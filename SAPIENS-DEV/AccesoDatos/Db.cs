using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPIENS_DEV.AccesoDatos
{
	public static class Db
	{
		static string cadena = "server=localhost;port=3306;database=gestor_proyectos;uid=root;pwd=;";

		public static MySqlConnection Conectar() { return new MySqlConnection(cadena); }

		// inicio de sesion

		public static int IdUsuario;
		public static string NombreUsuario;
		public static string Rol; // "coordinador", "docente" o "alumno"

		public static string Hash(string texto)
		{
			using (var sha = SHA256.Create())
			{
				byte[] b = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
				var sb = new StringBuilder();
				foreach (byte x in b) sb.Append(x.ToString("x2"));
				return sb.ToString();
			}
		}

		// Busca el correo en los 3 catálogos. Regresa el rol o null si no existe.
		public static string Login(string correo, string pass)
		{
			string h = Hash(pass);
			string[,] t = { { "coordinador", "id_coordinador" },
							{ "docente",     "id_docente"     },
							{ "alumno",      "id_alumno"      } };
			using (var cn = Conectar())
			{
				cn.Open();
				for (int i = 0; i < 3; i++)
				{
					var cmd = new MySqlCommand(
						"SELECT " + t[i, 1] + ", nombre FROM " + t[i, 0] +
						" WHERE correo=@c AND contrasena=@p", cn);
					cmd.Parameters.AddWithValue("@c", correo);
					cmd.Parameters.AddWithValue("@p", h);
					using (var r = cmd.ExecuteReader())
					{
						if (r.Read())
						{
							IdUsuario = r.GetInt32(0);
							NombreUsuario = r.GetString(1);
							Rol = t[i, 0];
							return Rol;
						}
					}
				}
			}
			return null;
		}

		// true si el correo ya está en cualquiera de los 3 catálogos
		public static bool CorreoExiste(string correo)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var cmd = new MySqlCommand(
					"SELECT (SELECT COUNT(*) FROM coordinador WHERE correo=@c) + " +
					"(SELECT COUNT(*) FROM docente WHERE correo=@c) + " +
					"(SELECT COUNT(*) FROM alumno WHERE correo=@c)", cn);
				cmd.Parameters.AddWithValue("@c", correo);
				return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
			}
		}

		public static void RegistrarCoordinador(string nom, string apP, string apM, string correo, string pass)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var cmd = new MySqlCommand(
					"INSERT INTO coordinador(nombre, apellido_paterno, apellido_materno, correo, contrasena) " +
					"VALUES(@n, @ap, @am, @c, @p)", cn);
				cmd.Parameters.AddWithValue("@n", nom);
				cmd.Parameters.AddWithValue("@ap", apP);
				cmd.Parameters.AddWithValue("@am", apM);
				cmd.Parameters.AddWithValue("@c", correo);
				cmd.Parameters.AddWithValue("@p", Hash(pass));
				cmd.ExecuteNonQuery();
			}
		}

		public static void RegistrarDocente(string nom, string apP, string apM, string correo,
											string pass, string depto, int idCoord)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var cmd = new MySqlCommand(
					"INSERT INTO docente(nombre, apellido_paterno, apellido_materno, correo, contrasena, departamento, id_coordinador) " +
					"VALUES(@n, @ap, @am, @c, @p, @d, @ic)", cn);
				cmd.Parameters.AddWithValue("@n", nom);
				cmd.Parameters.AddWithValue("@ap", apP);
				cmd.Parameters.AddWithValue("@am", apM);
				cmd.Parameters.AddWithValue("@c", correo);
				cmd.Parameters.AddWithValue("@p", Hash(pass));
				cmd.Parameters.AddWithValue("@d", depto);
				cmd.Parameters.AddWithValue("@ic", idCoord);
				cmd.ExecuteNonQuery();
			}
		}

		public static void RegistrarAlumno(string nom, string apP, string apM, string correo,
										   string pass, int matricula, string carrera, byte grado, string grupo)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var cmd = new MySqlCommand(
					"INSERT INTO alumno(nombre, apellido_paterno, apellido_materno, correo, contrasena, matricula, carrera, grado, grupo) " +
					"VALUES(@n, @ap, @am, @c, @p, @m, @ca, @g, @gr)", cn);
				cmd.Parameters.AddWithValue("@n", nom);
				cmd.Parameters.AddWithValue("@ap", apP);
				cmd.Parameters.AddWithValue("@am", apM);
				cmd.Parameters.AddWithValue("@c", correo);
				cmd.Parameters.AddWithValue("@p", Hash(pass));
				cmd.Parameters.AddWithValue("@m", matricula);
				cmd.Parameters.AddWithValue("@ca", carrera);
				cmd.Parameters.AddWithValue("@g", grado);
				cmd.Parameters.AddWithValue("@gr", grupo);
				cmd.ExecuteNonQuery();
			}
		}

		// Para llenar  Coordinador al que pertenece
		public static DataTable ObtenerCoordinadores()
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var da = new MySqlDataAdapter(
					"SELECT id_coordinador, CONCAT(nombre,' ',apellido_paterno,' ',apellido_materno) AS nombre_completo " +
					"FROM coordinador ORDER BY nombre", cn);
				var dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}
	}
}

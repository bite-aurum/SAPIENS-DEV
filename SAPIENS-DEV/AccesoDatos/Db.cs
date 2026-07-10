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
		// ================== HELPERS ==================
		static int Escalar(string sql, int idDocente)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var cmd = new MySqlCommand(sql, cn);
				cmd.Parameters.AddWithValue("@d", idDocente);
				return Convert.ToInt32(cmd.ExecuteScalar());
			}
		}

		static DataTable Tabla(string sql, int idDocente)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var da = new MySqlDataAdapter(sql, cn);
				da.SelectCommand.Parameters.AddWithValue("@d", idDocente);
				var dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}

		// ================== DASHBOARD ==================
		public static int ContarProyectos(int idDoc)
		{ return Escalar("SELECT COUNT(*) FROM proyecto WHERE id_docente=@d AND estado='activo'", idDoc); }

		public static int ContarTareas(int idDoc)
		{ return Escalar("SELECT COUNT(*) FROM tarea t JOIN proyecto p ON t.id_proyecto=p.id_proyecto WHERE p.id_docente=@d", idDoc); }

		public static int ContarEntregasPendientes(int idDoc)
		{ return Escalar("SELECT COUNT(*) FROM entrega e JOIN proyecto p ON e.id_proyecto=p.id_proyecto WHERE p.id_docente=@d AND e.estado='pendiente'", idDoc); }

		public static int ContarAlumnos(int idDoc)
		{ return Escalar("SELECT COUNT(DISTINCT ap.id_alumno) FROM alumno_proyecto ap JOIN proyecto p ON ap.id_proyecto=p.id_proyecto WHERE p.id_docente=@d", idDoc); }

		public static DataTable TareasRecientes(int idDoc)
		{
			return Tabla(
				"SELECT t.titulo AS Tarea, DATE_FORMAT(t.fecha_limite,'%d/%m/%Y') AS Vence, t.prioridad AS Prioridad " +
				"FROM tarea t JOIN proyecto p ON t.id_proyecto=p.id_proyecto " +
				"WHERE p.id_docente=@d ORDER BY t.fecha_limite LIMIT 6", idDoc);
		}

		public static DataTable ActividadReciente(int idDoc)
		{
			return Tabla(
				"SELECT CONCAT(a.nombre,' ',a.apellido_paterno,' entregó ',ar.nombre_archivo) AS actividad " +
				"FROM archivo ar JOIN alumno a ON ar.id_alumno=a.id_alumno " +
				"JOIN entrega e ON ar.id_entrega=e.id_entrega " +
				"JOIN proyecto p ON e.id_proyecto=p.id_proyecto " +
				"WHERE p.id_docente=@d ORDER BY ar.fecha_subida DESC LIMIT 5", idDoc);
		}

		// ================== PROYECTOS ==================
		public static DataTable ObtenerProyectos(int idDoc)
		{
			return Tabla(
				"SELECT p.id_proyecto, p.nombre, p.problematica, p.estado, p.fecha_inicio, p.fecha_fin, " +
				"(SELECT COUNT(DISTINCT ap.id_alumno) FROM alumno_proyecto ap WHERE ap.id_proyecto=p.id_proyecto) AS alumnos, " +
				"(SELECT COUNT(*) FROM tarea t WHERE t.id_proyecto=p.id_proyecto) AS tareas, " +
				"(SELECT COUNT(*) FROM entrega e WHERE e.id_proyecto=p.id_proyecto) AS entregas, " +
				"IFNULL((SELECT ROUND(SUM(s.estado='completada')*100/COUNT(*)) FROM subtarea s " +
				" JOIN tarea t2 ON s.id_tarea=t2.id_tarea WHERE t2.id_proyecto=p.id_proyecto),0) AS avance " +
				"FROM proyecto p WHERE p.id_docente=@d ORDER BY p.id_proyecto", idDoc);
		}

		public static int CrearProyecto(string nombre, string desc, string prob, string obj,
										DateTime inicio, DateTime fin, int idDoc)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var cmd = new MySqlCommand(
					"INSERT INTO proyecto(nombre, descripcion, problematica, objetivos, fecha_inicio, fecha_fin, estado, id_docente) " +
					"VALUES(@n, @de, @pr, @ob, @fi, @ff, 'activo', @d)", cn);
				cmd.Parameters.AddWithValue("@n", nombre);
				cmd.Parameters.AddWithValue("@de", desc);
				cmd.Parameters.AddWithValue("@pr", prob);
				cmd.Parameters.AddWithValue("@ob", obj);
				cmd.Parameters.AddWithValue("@fi", inicio.Date);
				cmd.Parameters.AddWithValue("@ff", fin.Date);
				cmd.Parameters.AddWithValue("@d", idDoc);
				cmd.ExecuteNonQuery();
				return (int)cmd.LastInsertedId;
			}
		}

		public static DataTable BuscarAlumno(string texto)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var da = new MySqlDataAdapter(
					"SELECT id_alumno, CONCAT(nombre,' ',apellido_paterno,' ',apellido_materno) AS nombre_completo, matricula " +
					"FROM alumno WHERE matricula LIKE @b OR CONCAT(nombre,' ',apellido_paterno) LIKE @b LIMIT 5", cn);
				da.SelectCommand.Parameters.AddWithValue("@b", "%" + texto + "%");
				var dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}

		public static void AsignarAlumno(int idProyecto, int idAlumno, string rol)
		{
			using (var cn = Conectar())
			{
				cn.Open();
				var cmd = new MySqlCommand(
					"INSERT INTO alumno_proyecto(id_alumno, id_proyecto, rol) VALUES(@a, @p, @r)", cn);
				cmd.Parameters.AddWithValue("@a", idAlumno);
				cmd.Parameters.AddWithValue("@p", idProyecto);
				cmd.Parameters.AddWithValue("@r", rol);
				cmd.ExecuteNonQuery();
			}
		}
	}
}

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

		// true si el correo ya está en cualquiera de los 3 
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

        // tareas
        public static DataTable ObtenerTareas(int idDoc)
        {
            return Tabla(
                "SELECT t.id_tarea, t.titulo, t.estado, t.prioridad, t.fecha_limite, " +
                "p.id_proyecto, p.nombre AS proyecto, p.fecha_inicio, " +
                "(SELECT COUNT(*) FROM subtarea s WHERE s.id_tarea=t.id_tarea) AS subtareas " +
                "FROM tarea t JOIN proyecto p ON t.id_proyecto=p.id_proyecto " +
                "WHERE p.id_docente=@d ORDER BY p.id_proyecto, t.fecha_limite", idDoc);
        }

        public static DataTable ProyectosCombo(int idDoc)
        {
            return Tabla(
                "SELECT p.id_proyecto, CONCAT('PROY-', YEAR(p.fecha_inicio), '-', LPAD(p.id_proyecto,3,'0'), ' — ', p.nombre) AS etiqueta " +
                "FROM proyecto p WHERE p.id_docente=@d ORDER BY p.id_proyecto", idDoc);
        }

        public static int CrearTarea(string titulo, string desc, string prioridad, DateTime limite, int idProyecto)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO tarea(titulo, descripcion, estado, prioridad, fecha_limite, id_proyecto) " +
                    "VALUES(@t, @de, 'pendiente', @pr, @fl, @p)", cn);
                cmd.Parameters.AddWithValue("@t", titulo);
                cmd.Parameters.AddWithValue("@de", desc);
                cmd.Parameters.AddWithValue("@pr", prioridad);
                cmd.Parameters.AddWithValue("@fl", limite.Date);
                cmd.Parameters.AddWithValue("@p", idProyecto);
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
        }

        public static void CrearSubtarea(string titulo, string desc, int idTarea)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO subtarea(titulo, descripcion, estado, id_tarea) VALUES(@t, @de, 'pendiente', @it)", cn);
                cmd.Parameters.AddWithValue("@t", titulo);
                cmd.Parameters.AddWithValue("@de", desc);
                cmd.Parameters.AddWithValue("@it", idTarea);
                cmd.ExecuteNonQuery();
            }
        }

        // entregas
        public static DataTable ObtenerEntregasDoc(int idDoc)
        {
            return Tabla(
                "SELECT e.id_entrega, e.titulo, e.fecha_limite, e.estado, p.id_proyecto, p.nombre AS proyecto, p.fecha_inicio " +
                "FROM entrega e JOIN proyecto p ON e.id_proyecto=p.id_proyecto " +
                "WHERE p.id_docente=@d ORDER BY p.id_proyecto, e.fecha_limite", idDoc);
        }

        public static int CrearEntrega(string titulo, string desc, DateTime fecha, int idProyecto)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO entrega(titulo, descripcion, fecha_limite, estado, id_proyecto) " +
                    "VALUES(@t, @de, @f, 'pendiente', @p)", cn);
                cmd.Parameters.AddWithValue("@t", titulo);
                cmd.Parameters.AddWithValue("@de", desc);
                cmd.Parameters.AddWithValue("@f", fecha.Date);
                cmd.Parameters.AddWithValue("@p", idProyecto);
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
        }

        // reportes
        public static DataTable ObtenerReportes(int idDoc)
        {
            return Tabla(
                "SELECT r.id_reporte, r.tipo, r.fecha, r.contenido, IFNULL(p.nombre,'Todos los proyectos') AS proyecto " +
                "FROM reporte r LEFT JOIN proyecto p ON r.id_proyecto=p.id_proyecto " +
                "WHERE r.id_docente=@d ORDER BY r.fecha DESC, r.id_reporte DESC", idDoc);
        }

        public static void CrearReporte(string tipo, string contenido, int idDoc, int idProyecto)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO reporte(tipo, contenido, id_docente, id_proyecto) VALUES(@t, @c, @d, @p)", cn);
                cmd.Parameters.AddWithValue("@t", tipo);
                cmd.Parameters.AddWithValue("@c", contenido);
                cmd.Parameters.AddWithValue("@d", idDoc);
                cmd.Parameters.AddWithValue("@p", idProyecto == 0 ? (object)DBNull.Value : idProyecto);
                cmd.ExecuteNonQuery();
            }
        }

        static DataTable TablaReporte(string sql, int idDoc, int idProyecto)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                if (idProyecto > 0) sql += " AND p.id_proyecto=@p";
                if (sql.Contains("GROUP__BY")) sql = sql.Replace("GROUP__BY", "GROUP BY");
                var da = new MySqlDataAdapter(sql, cn);
                da.SelectCommand.Parameters.AddWithValue("@d", idDoc);
                if (idProyecto > 0) da.SelectCommand.Parameters.AddWithValue("@p", idProyecto);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // idProyecto = 0 significa "todos mis proyectos"
        public static string GenerarContenido(string tipo, int idDoc, int idProyecto)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("REPORTE: " + tipo.ToUpper());
            sb.AppendLine("Docente: " + NombreUsuario + " · Fecha: " + DateTime.Today.ToString("dd/MM/yyyy"));
            sb.AppendLine(new string('-', 50));
            DataTable dt;

            if (tipo == "Avance por proyecto")
            {
                dt = TablaReporte(
                    "SELECT p.nombre, IFNULL((SELECT ROUND(SUM(s.estado='completada')*100/COUNT(*)) " +
                    "FROM subtarea s JOIN tarea t ON s.id_tarea=t.id_tarea WHERE t.id_proyecto=p.id_proyecto),0) AS avance " +
                    "FROM proyecto p WHERE p.id_docente=@d", idDoc, idProyecto);
                foreach (DataRow r in dt.Rows) sb.AppendLine("• " + r["nombre"] + ": " + r["avance"] + "% de avance");
            }
            else if (tipo == "Tareas completadas vs pendientes")
            {
                dt = TablaReporte(
                    "SELECT p.nombre, IFNULL(SUM(t.estado='completada'),0) AS comp, IFNULL(SUM(t.estado<>'completada'),0) AS pend " +
                    "FROM proyecto p LEFT JOIN tarea t ON t.id_proyecto=p.id_proyecto " +
                    "WHERE p.id_docente=@d GROUP__BY p.id_proyecto", idDoc, idProyecto);
                foreach (DataRow r in dt.Rows) sb.AppendLine("• " + r["nombre"] + ": " + r["comp"] + " completadas / " + r["pend"] + " pendientes");
            }
            else if (tipo == "Entregas a tiempo vs tardías")
            {
                dt = TablaReporte(
                    "SELECT p.nombre, IFNULL(SUM(e.estado='entregada'),0) AS ent, " +
                    "IFNULL(SUM(e.estado<>'entregada' AND e.fecha_limite<CURDATE()),0) AS tard, COUNT(e.id_entrega) AS tot " +
                    "FROM proyecto p LEFT JOIN entrega e ON e.id_proyecto=p.id_proyecto " +
                    "WHERE p.id_docente=@d GROUP__BY p.id_proyecto", idDoc, idProyecto);
                foreach (DataRow r in dt.Rows) sb.AppendLine("• " + r["nombre"] + ": " + r["ent"] + " entregadas · " + r["tard"] + " tardías · " + r["tot"] + " en total");
            }
            else // Subtareas por estado
            {
                dt = TablaReporte(
                    "SELECT s.estado, COUNT(*) AS n FROM subtarea s " +
                    "JOIN tarea t ON s.id_tarea=t.id_tarea JOIN proyecto p ON t.id_proyecto=p.id_proyecto " +
                    "WHERE p.id_docente=@d GROUP__BY s.estado", idDoc, idProyecto);
                foreach (DataRow r in dt.Rows) sb.AppendLine("• " + r["estado"] + ": " + r["n"] + " subtareas");
            }
            if (dt.Rows.Count == 0) sb.AppendLine("Sin datos para este reporte.");
            return sb.ToString();
        }

        public static DataTable AlumnosDeProyecto(int idProyecto)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var da = new MySqlDataAdapter(
                    "SELECT a.id_alumno, CONCAT(a.nombre,' ',a.apellido_paterno,' — ',a.matricula) AS etiqueta " +
                    "FROM alumno_proyecto ap JOIN alumno a ON ap.id_alumno=a.id_alumno " +
                    "WHERE ap.id_proyecto=@p ORDER BY a.nombre", cn);
                da.SelectCommand.Parameters.AddWithValue("@p", idProyecto);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void EnviarNotificacion(string mensaje, string tipo, int idAlumno)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO notificacion(mensaje, tipo, leida, id_alumno) VALUES(@m, @t, 0, @a)", cn);
                cmd.Parameters.AddWithValue("@m", mensaje);
                cmd.Parameters.AddWithValue("@t", tipo);
                cmd.Parameters.AddWithValue("@a", idAlumno);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable NotificacionesEnviadas(int idDoc)
        {
            return Tabla(
                "SELECT n.mensaje, n.tipo, n.fecha, CONCAT(a.nombre,' ',a.apellido_paterno) AS alumno " +
                "FROM notificacion n JOIN alumno a ON n.id_alumno=a.id_alumno " +
                "WHERE n.id_alumno IN (SELECT ap.id_alumno FROM alumno_proyecto ap " +
                " JOIN proyecto p ON ap.id_proyecto=p.id_proyecto WHERE p.id_docente=@d) " +
                "ORDER BY n.fecha DESC, n.id_notificacion DESC LIMIT 15", idDoc);
        }
        // Alumno
        static DataTable TablaId(string sql, int id)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var da = new MySqlDataAdapter(sql, cn);
                da.SelectCommand.Parameters.AddWithValue("@i", id);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataRow DatosAlumno(int idAl)
        { return TablaId("SELECT matricula, carrera, grado, grupo FROM alumno WHERE id_alumno=@i", idAl).Rows[0]; }

        public static int ContarProyectosAlumno(int idAl)
        { return Escalar("SELECT COUNT(*) FROM alumno_proyecto WHERE id_alumno=@d", idAl); }

        public static int TareasActivasAlumno(int idAl)
        {
            return Escalar(
                "SELECT COUNT(*) FROM tarea t JOIN alumno_proyecto ap ON t.id_proyecto=ap.id_proyecto " +
                "WHERE ap.id_alumno=@d AND t.estado<>'completada'", idAl);
        }

        public static int SubtareasPendientesAlumno(int idAl)
        {
            return Escalar(
                "SELECT COUNT(*) FROM subtarea s JOIN tarea t ON s.id_tarea=t.id_tarea " +
                "JOIN alumno_proyecto ap ON t.id_proyecto=ap.id_proyecto " +
                "WHERE ap.id_alumno=@d AND s.estado<>'completada'", idAl);
        }

        public static DateTime? ProximaEntregaAlumno(int idAl)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var cmd = new MySqlCommand(
                    "SELECT MIN(e.fecha_limite) FROM entrega e " +
                    "JOIN alumno_proyecto ap ON e.id_proyecto=ap.id_proyecto " +
                    "WHERE ap.id_alumno=@d AND e.estado='pendiente'", cn);
                cmd.Parameters.AddWithValue("@d", idAl);
                object r = cmd.ExecuteScalar();
                return r == DBNull.Value || r == null ? (DateTime?)null : Convert.ToDateTime(r);
            }
        }

        public static DataTable ProyectosDeAlumno(int idAl)
        {
            return Tabla(
                "SELECT p.id_proyecto, p.nombre, p.problematica, p.estado, p.fecha_inicio, p.fecha_fin, ap.rol, " +
                "CONCAT(d.nombre,' ',d.apellido_paterno) AS docente, " +
                "(SELECT COUNT(DISTINCT x.id_alumno) FROM alumno_proyecto x WHERE x.id_proyecto=p.id_proyecto) AS alumnos, " +
                "(SELECT COUNT(*) FROM tarea t WHERE t.id_proyecto=p.id_proyecto) AS tareas, " +
                "(SELECT COUNT(*) FROM entrega e WHERE e.id_proyecto=p.id_proyecto) AS entregas, " +
                "(SELECT COUNT(*) FROM subtarea s JOIN tarea t3 ON s.id_tarea=t3.id_tarea " +
                " WHERE t3.id_proyecto=p.id_proyecto AND s.estado<>'completada') AS sub_pend, " +
                "IFNULL((SELECT ROUND(SUM(s.estado='completada')*100/COUNT(*)) FROM subtarea s " +
                " JOIN tarea t2 ON s.id_tarea=t2.id_tarea WHERE t2.id_proyecto=p.id_proyecto),0) AS avance " +
                "FROM alumno_proyecto ap JOIN proyecto p ON ap.id_proyecto=p.id_proyecto " +
                "JOIN docente d ON p.id_docente=d.id_docente " +
                "WHERE ap.id_alumno=@d ORDER BY p.id_proyecto", idAl);
        }

        public static DataTable SubtareasRecientesAlumno(int idAl)
        {
            return Tabla(
                "SELECT s.titulo, t.prioridad, t.fecha_limite, p.nombre AS proyecto " +
                "FROM subtarea s JOIN tarea t ON s.id_tarea=t.id_tarea " +
                "JOIN proyecto p ON t.id_proyecto=p.id_proyecto " +
                "JOIN alumno_proyecto ap ON p.id_proyecto=ap.id_proyecto " +
                "WHERE ap.id_alumno=@d AND s.estado<>'completada' " +
                "ORDER BY t.fecha_limite LIMIT 3", idAl);
        }

        public static DataRow ProyectoDetalleAlumno(int idProyecto, int idAl)
        {
            using (var cn = Conectar())
            {
                cn.Open();
                var da = new MySqlDataAdapter(
                    "SELECT p.*, CONCAT(d.nombre,' ',d.apellido_paterno) AS docente, ap.rol, " +
                    "IFNULL((SELECT ROUND(SUM(s.estado='completada')*100/COUNT(*)) FROM subtarea s " +
                    " JOIN tarea t2 ON s.id_tarea=t2.id_tarea WHERE t2.id_proyecto=p.id_proyecto),0) AS avance " +
                    "FROM proyecto p JOIN docente d ON p.id_docente=d.id_docente " +
                    "JOIN alumno_proyecto ap ON ap.id_proyecto=p.id_proyecto AND ap.id_alumno=@a " +
                    "WHERE p.id_proyecto=@p", cn);
                da.SelectCommand.Parameters.AddWithValue("@a", idAl);
                da.SelectCommand.Parameters.AddWithValue("@p", idProyecto);
                var dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0];
            }
        }

        public static DataTable EquipoDeProyecto(int idProyecto)
        {
            return TablaId(
                "SELECT a.id_alumno, CONCAT(a.nombre,' ',a.apellido_paterno) AS nombre, a.matricula, ap.rol " +
                "FROM alumno_proyecto ap JOIN alumno a ON ap.id_alumno=a.id_alumno " +
                "WHERE ap.id_proyecto=@i ORDER BY ap.rol='líder' DESC, a.nombre", idProyecto);
        }

        public static DataTable EntregasDeProyecto(int idProyecto)
        {
            return TablaId(
                "SELECT id_entrega, titulo, fecha_limite, estado FROM entrega " +
                "WHERE id_proyecto=@i ORDER BY fecha_limite", idProyecto);
        }

        public static DataTable TareasDeProyecto(int idProyecto)
        {
            return TablaId(
                "SELECT id_tarea, titulo, estado, prioridad, fecha_limite FROM tarea " +
                "WHERE id_proyecto=@i ORDER BY fecha_limite", idProyecto);
        }
    }
}

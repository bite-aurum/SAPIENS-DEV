using SAPIENS_DEV.AccesoDatos;
using SAPIENS_DEV.PantallasDocente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPIENS_DEV.PantallasAlumno
{
	public partial class FrmDashboardAlumno : Form
	{
		FrmMenuAlumno menu;

		public FrmDashboardAlumno(FrmMenuAlumno m)
		{
			InitializeComponent();
			menu = m;
		}

		// Hace clickeable una tarjeta completa (incluye sus hijos)
		public static void Clickeable(Control c, EventHandler h)
		{
			c.Cursor = Cursors.Hand;
			c.Click += h;
			foreach (Control x in c.Controls) Clickeable(x, h);
		}

		private void FrmDashboardAlumno_Load(object sender, EventArgs e)
		{
			try
			{
				lblValProyectos.Text = Db.ContarProyectosAlumno(Db.IdUsuario).ToString();
				lblValTareas.Text = Db.TareasActivasAlumno(Db.IdUsuario).ToString();
				lblValSubtareas.Text = Db.SubtareasPendientesAlumno(Db.IdUsuario).ToString();
				DateTime? prox = Db.ProximaEntregaAlumno(Db.IdUsuario);
				lblValEntrega.Text = prox == null ? "—" : prox.Value.ToString("dd/MM/yyyy");

				// proyectos pequeñas clickeables
				flpProyectos.Controls.Clear();
				DataTable dp = Db.ProyectosDeAlumno(Db.IdUsuario);
				foreach (DataRow r in dp.Rows) flpProyectos.Controls.Add(MiniProyecto(r));
				if (dp.Rows.Count == 0)
					flpProyectos.Controls.Add(new Label
					{
						Text = "Aún no estás en ningún proyecto.",
						AutoSize = true,
						ForeColor = Color.FromArgb(107, 114, 128)
					});

				//Columna de la derecha  subtareas recientes + notificaciones 
				flpDerecha.Controls.Clear();
				DataTable ds = Db.SubtareasRecientesAlumno(Db.IdUsuario);
				foreach (DataRow r in ds.Rows) flpDerecha.Controls.Add(FilaSubtarea(r));
				if (ds.Rows.Count == 0)
					flpDerecha.Controls.Add(new Label
					{
						Text = "Sin subtareas pendientes.",
						AutoSize = true,
						ForeColor = Color.FromArgb(107, 114, 128)
					});

				flpDerecha.Controls.Add(new Label
				{
					Text = "Notificaciones",
					Font = new Font("Segoe UI", 11F, FontStyle.Bold),
					ForeColor = Color.FromArgb(31, 41, 55),
					AutoSize = true,
					Margin = new Padding(0, 14, 0, 6)
				});

				/*DataTable dn = Db.NotificacionesDeAlumno(Db.IdUsuario);
				int i = 0;
				foreach (DataRow r in dn.Rows) { if (i++ == 2) break; flpDerecha.Controls.Add(FilaNotif(r)); }
				if (dn.Rows.Count == 0)
					flpDerecha.Controls.Add(new Label
					{
						Text = "Sin notificaciones.",
						AutoSize = true,
						ForeColor = Color.FromArgb(107, 114, 128)
					});*/
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar el dashboard: " + ex.Message, "SAPIENS");
			}
		}

		Panel MiniProyecto(DataRow r)
		{
			int av = Convert.ToInt32(r["avance"]);
			int idProy = Convert.ToInt32(r["id_proyecto"]);
			string nombre = r["nombre"].ToString();
			string clave = "PROY-" + Convert.ToDateTime(r["fecha_inicio"]).Year + "-" + idProy.ToString("D3");
			int subPend = Convert.ToInt32(r["sub_pend"]);
			string estado = r["estado"].ToString();

			var card = new Panel { Size = new Size(440, 120), BackColor = Color.White, Margin = new Padding(0, 0, 0, 10) };
			card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
				Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

			card.Controls.Add(new Label
			{
				Text = nombre,
				Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
				ForeColor = Color.FromArgb(31, 41, 55),
				Location = new Point(16, 10),
				Size = new Size(310, 20),
				AutoEllipsis = true
			});
			card.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(estado),
				estado == "activo" ? new[] { Color.FromArgb(236, 253, 245), Color.FromArgb(16, 185, 129) }
								   : new[] { Color.FromArgb(255, 251, 235), Color.FromArgb(245, 158, 11) },
				new Point(340, 10), 85));
			card.Controls.Add(new Label
			{
				Text = clave + " · Prof. " + r["docente"],
				Font = new Font("Segoe UI", 7.5F),
				ForeColor = Color.FromArgb(107, 114, 128),
				Location = new Point(16, 32),
				Size = new Size(300, 14)
			});
			card.Controls.Add(new Label
			{
				Text = "Avance general",
				Font = new Font("Segoe UI", 7.5F),
				ForeColor = Color.FromArgb(107, 114, 128),
				Location = new Point(16, 54),
				AutoSize = true
			});
			var fondo = new Panel { BackColor = Color.FromArgb(229, 231, 235), Location = new Point(16, 72), Size = new Size(360, 8) };
			fondo.Controls.Add(new Panel { BackColor = Color.FromArgb(79, 70, 229), Location = new Point(0, 0), Size = new Size(360 * av / 100, 8) });
			card.Controls.Add(fondo);
			card.Controls.Add(new Label
			{
				Text = av + "%",
				Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
				ForeColor = Color.FromArgb(31, 41, 55),
				Location = new Point(385, 66),
				AutoSize = true
			});
			card.Controls.Add(new Label
			{
				Text = "Tareas: " + r["tareas"] + " · " + (subPend > 0 ? subPend + " subtareas pendientes" : "Sin subtareas pendientes"),
				Font = new Font("Segoe UI", 8F),
				ForeColor = subPend > 0 ? Color.FromArgb(245, 158, 11) : Color.FromArgb(16, 185, 129),
				Location = new Point(16, 92),
				Size = new Size(400, 16)
			});

			//Clickeable(card, (s, e) => menu.IrDetalleProyecto(idProy, nombre));
			return card;
		}

		Panel FilaSubtarea(DataRow r)
		{
			var card = new Panel { Size = new Size(440, 54), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
			card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
				Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
			card.Controls.Add(new Label
			{
				Text = r["titulo"].ToString(),
				Font = new Font("Segoe UI", 9F, FontStyle.Bold),
				ForeColor = Color.FromArgb(31, 41, 55),
				Location = new Point(16, 8),
				Size = new Size(320, 18),
				AutoEllipsis = true
			});
			card.Controls.Add(new Label
			{
				Text = r["proyecto"] + " · vence: " + Convert.ToDateTime(r["fecha_limite"]).ToString("dd/MM/yyyy"),
				Font = new Font("Segoe UI", 7.5F),
				ForeColor = Color.FromArgb(107, 114, 128),
				Location = new Point(16, 28),
				Size = new Size(320, 14)
			});
			card.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(r["prioridad"].ToString()),
				FrmTareasDocente.ColoresPrioridad(r["prioridad"].ToString()), new Point(360, 15), 65));
			return card;
		}

		Panel FilaNotif(DataRow r)
		{
			bool noLeida = Convert.ToInt32(r["leida"]) == 0;
			string tipo = r["tipo"].ToString();
			var card = new Panel { Size = new Size(440, 54), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
			card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
				Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
			if (noLeida)
				card.Controls.Add(new Label
				{
					Text = "■",
					ForeColor = Color.FromArgb(239, 68, 68),
					Font = new Font("Segoe UI", 7F),
					Location = new Point(6, 12),
					Size = new Size(12, 14)
				});
			string msg = r["mensaje"].ToString();
			if (msg.Length > 42) msg = msg.Substring(0, 42) + "...";
			card.Controls.Add(new Label
			{
				Text = msg,
				Font = new Font("Segoe UI", 9F, noLeida ? FontStyle.Bold : FontStyle.Regular),
				ForeColor = Color.FromArgb(31, 41, 55),
				Location = new Point(20, 8),
				Size = new Size(310, 18),
				AutoEllipsis = true
			});
			card.Controls.Add(new Label
			{
				Text = FrmTareasDocente.Capital(tipo) + " · " + Convert.ToDateTime(r["fecha"]).ToString("dd/MM/yyyy"),
				Font = new Font("Segoe UI", 7.5F),
				ForeColor = Color.FromArgb(107, 114, 128),
				Location = new Point(20, 28),
				Size = new Size(310, 14)
			});
			Color[] c;
			if (tipo == "alerta") c = new[] { Color.FromArgb(254, 226, 226), Color.FromArgb(239, 68, 68) };
			else if (tipo == "recordatorio") c = new[] { Color.FromArgb(255, 251, 235), Color.FromArgb(245, 158, 11) };
			else c = new[] { Color.FromArgb(236, 253, 245), Color.FromArgb(16, 185, 129) };
			card.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(tipo), c, new Point(340, 15), 90));
			return card;
		}

		//private void lnkVerProyectos_Click(object sender, EventArgs e) { menu.IrProyectos(); }
		//private void lnkVerTareas_Click(object sender, EventArgs e) { menu.IrTareas(); }

		private void pnlCard_Paint(object sender, PaintEventArgs e)
		{
			var p = (Panel)sender;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
				Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
		}
	}
}

using SAPIENS_DEV.AccesoDatos;
using SAPIENS_DEV.PantallasCoordinador;
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
	public partial class FrmMenuAlumno : Form
	{
		Form login;

		public FrmMenuAlumno(Form frmLogin)
		{
			InitializeComponent();
			login = frmLogin;
		}

		private void FrmMenuAlumno_Load(object sender, EventArgs e)
		{
			try
			{
				DataRow d = Db.DatosAlumno(Db.IdUsuario);
				lblEstadoIzq.Text = "   Rol: Alumno · " + Db.NombreUsuario + " · " + d["matricula"];
			}
			catch { lblEstadoIzq.Text = "   Rol: Alumno · " + Db.NombreUsuario; }
			lblAvatar.Text = FrmRendimientoCoord.Iniciales(Db.NombreUsuario);
			IrDashboard();
		}

		public void Navegar(Form pagina, string titulo, string subtitulo, Button boton)
		{
			lblTitulo.Text = titulo;
			lblSubtituloHdr.Text = subtitulo;
			if (boton != null) MarcarActivo(boton);
			pnlContenido.Controls.Clear();
			pagina.TopLevel = false;
			pagina.FormBorderStyle = FormBorderStyle.None;
			pagina.Dock = DockStyle.Fill;
			pnlContenido.Controls.Add(pagina);
			pagina.Show();
		}

		void MarcarActivo(Button b)
		{
			Button[] botones = { btnDashboard, btnProyectos, btnTareas, btnEntregas, btnNotificaciones };
			foreach (Button x in botones)
			{
				x.BackColor = Color.White;
				x.ForeColor = Color.FromArgb(107, 114, 128);
			}
			// btn activo alumno guía: fondo #F0F9FF, texto #3B82F6
			b.BackColor = Color.FromArgb(240, 249, 255);
			b.ForeColor = Color.FromArgb(59, 130, 246);
		}

		public void IrDashboard()
		{
			string sub = "Alumno";
			try
			{
				DataRow d = Db.DatosAlumno(Db.IdUsuario);
				sub = "Alumno · " + d["matricula"] + " · " + d["grado"] + "°" + d["grupo"];
			}
			catch { }
			string primerNombre = Db.NombreUsuario.Split(' ')[0];
			Navegar(new FrmDashboardAlumno(this), "Hola, " + Db.NombreUsuario, sub, btnDashboard);
		}

		//public void IrProyectos() { Navegar(new FrmProyectosAlumno(this), "Mis proyectos", "", btnProyectos); }
		//public void IrTareas() { Navegar(new FrmTareasAlumno(this), "Mis tareas", "", btnTareas); }
		//public void IrEntregas() { Navegar(new FrmEntregasAlumno(this), "Mis entregas", "", btnEntregas); }
		//public void IrNotificaciones() { Navegar(new FrmNotificacionesAlumno(this), "Notificaciones", "", btnNotificaciones); }

		//public void IrDetalleProyecto(int idProyecto, string nombre)
		//{ Navegar(new FrmDetalleProyectoAlumno(this, idProyecto), nombre, "", btnProyectos); }

		//public void IrDetalleTarea(int idTarea, string titulo)
		//{ Navegar(new FrmDetalleTareaAlumno(this, idTarea), titulo, "", btnTareas); }

		//public void IrDetalleEntrega(int idEntrega, string titulo)
		//{ Navegar(new FrmDetalleEntregaAlumno(this, idEntrega), titulo, "", btnEntregas); }

		private void btnDashboard_Click(object sender, EventArgs e) { IrDashboard(); }
		//private void btnProyectos_Click(object sender, EventArgs e) { IrProyectos(); }
		//private void btnTareas_Click(object sender, EventArgs e) { IrTareas(); }
		//private void btnEntregas_Click(object sender, EventArgs e) { IrEntregas(); }
		//private void btnNotificaciones_Click(object sender, EventArgs e) { IrNotificaciones(); }

		private void btnConfiguracion_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Cerrar sesión?", "SAPIENS", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{ login.Show(); Close(); }
		}

		private void pnlMenu_Paint(object sender, PaintEventArgs e)
		{
			using (var p = new Pen(Color.FromArgb(229, 231, 235)))
				e.Graphics.DrawLine(p, pnlMenu.Width - 1, 0, pnlMenu.Width - 1, pnlMenu.Height);
		}

		private void pnlHeader_Paint(object sender, PaintEventArgs e)
		{
			using (var p = new Pen(Color.FromArgb(229, 231, 235)))
				e.Graphics.DrawLine(p, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
		}
	}
}

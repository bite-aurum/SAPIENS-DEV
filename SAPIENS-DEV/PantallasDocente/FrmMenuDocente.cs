using SAPIENS_DEV.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPIENS_DEV.PantallasDocente
{
	public partial class FrmMenuDocente : Form
	{
		Form login;
		Button btnActivo;
		public FrmMenuDocente(Form frmLogin)
		{
			InitializeComponent();
			login = frmLogin;
		}
		private void FrmMenuDocente_Load(object sender, EventArgs e)
		{
			lblEstadoIzq.Text = "   Rol: Docente · " + Db.NombreUsuario;
			IrDashboard();
		}

		// pagina de control de contenido o barra lateral 
		public void Navegar(Form pagina, string titulo, Button boton)
		{
			lblTitulo.Text = titulo;
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
			Button[] botones = { btnDashboard, btnProyectos, btnTareas, btnEntregas, btnReportes, btnNotificaciones };
			foreach (Button x in botones)
			{
				x.BackColor = Color.White;
				x.ForeColor = Color.FromArgb(107, 114, 128);
			}
			b.BackColor = Color.FromArgb(240, 249, 255);   
			b.ForeColor = Color.FromArgb(79, 70, 229);
			btnActivo = b;
		}

		public void IrDashboard() { Navegar(new FrmDashboardDocente(this), "Bienvenido, " + Db.NombreUsuario, btnDashboard); }
		public void IrProyectos() { Navegar(new FrmProyectosDocente(this), "Mis proyectos", btnProyectos); }
		public void IrNuevoProyecto() { Navegar(new FrmNuevoProyecto(this), "Nuevo proyecto", btnProyectos); }

        public void IrTareas() { Navegar(new FrmTareasDocente(this), "Tareas", btnTareas); }
        //public void IrNuevaTarea() { Navegar(new FrmNuevaTarea(this), "Nueva tarea", btnTareas); }
        //public void IrEntregas() { Navegar(new FrmEntregasDocente(this), "Entregas", btnEntregas); }
        //public void IrNuevaEntrega() { Navegar(new FrmNuevaEntrega(this), "Nueva entrega", btnEntregas); }
        //public void IrReportes() { Navegar(new FrmReportesDocente(this), "Reportes", btnReportes); }
        //public void IrNotificaciones() { Navegar(new FrmNotificacionesDocente(this), "Notificaciones", btnNotificaciones); }

        private void btnDashboard_Click(object sender, EventArgs e) { IrDashboard(); }
		private void btnProyectos_Click(object sender, EventArgs e) { IrProyectos(); }
		private void btnTareas_Click(object sender, EventArgs e) { IrTareas(); }
		//private void btnEntregas_Click(object sender, EventArgs e) { IrEntregas(); }
		//private void btnReportes_Click(object sender, EventArgs e) { IrReportes(); }
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

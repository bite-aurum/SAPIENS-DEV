using SAPIENS_DEV.AccesoDatos;
using SAPIENS_DEV.Compartido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPIENS_DEV.PantallasCoordinador
{
    public partial class FrmMenuCoordinador : Form
    {
        Form login;

        public FrmMenuCoordinador(Form frmLogin)
        {
            InitializeComponent();
            login = frmLogin;

            // Iconos del menu gris, 24px,  El mismo color que tenia.
            Color gris = Color.FromArgb(107, 114, 128);
            Iconos.EnBoton(btnRendimiento, "grafica", gris);
            Iconos.EnBoton(btnDocentes, "personas", gris);
            Iconos.EnBoton(btnProyectos, "carpeta", gris);
            Iconos.EnBoton(btnConfiguracion, "engrane", gris);
        }
		public void CerrarSesion()
		{
			login.Show();
			Close();
		}

		private void FrmMenuCoordinador_Load(object sender, EventArgs e)
        {
            lblEstadoIzq.Text = "   Rol: Coordinador · " + Db.NombreUsuario;
            lblSubtitulo.Text = Db.NombreUsuario + " · COORD-" + Db.IdUsuario.ToString("D3");
            IrRendimiento();
        }

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
            Button[] botones = { btnRendimiento, btnDocentes, btnProyectos };
            foreach (Button x in botones)
            {
                x.BackColor = Color.White;
                x.ForeColor = Color.FromArgb(107, 114, 128);
            }
            // Ítem activo coordinador según guía: fondo #F0F9FF, texto #10B981
            b.BackColor = Color.FromArgb(240, 249, 255);
            b.ForeColor = Color.FromArgb(16, 185, 129);
        }

        public void IrRendimiento() { Navegar(new FrmRendimientoCoord(this), "Panel de coordinación", btnRendimiento); }
        public void IrDocentes() { Navegar(new FrmDocentesCoord(this), "Docentes", btnDocentes); }
        public void IrProyectos() { Navegar(new FrmProyectosCoord(this), "Todos los proyectos", btnProyectos); }

        private void btnRendimiento_Click(object sender, EventArgs e) { IrRendimiento(); }
        private void btnDocentes_Click(object sender, EventArgs e) { IrDocentes(); }
        private void btnProyectos_Click(object sender, EventArgs e) { IrProyectos(); }

		private void btnConfiguracion_Click(object sender, EventArgs e)
		{
			Navegar(new FrmConfiguracion(CerrarSesion), "Configuración", null);
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

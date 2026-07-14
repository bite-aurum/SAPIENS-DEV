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
	public partial class FrmNotificacionesDocente : Form
	{
		FrmMenuDocente menu;

		public FrmNotificacionesDocente(FrmMenuDocente m)
		{
			InitializeComponent();
			menu = m;
		}

		private void FrmNotificacionesDocente_Load(object sender, EventArgs e)
		{
			try
			{
				cmbProyecto.DataSource = Db.ProyectosCombo(Db.IdUsuario);
				cmbProyecto.DisplayMember = "etiqueta";
				cmbProyecto.ValueMember = "id_proyecto";
				cmbTipo.SelectedIndex = 0;
				txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
				CargarAlumnos();
				CargarEnviadas();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "SAPIENS"); }
		}

		void CargarAlumnos()
		{
			if (cmbProyecto.SelectedValue == null || !(cmbProyecto.SelectedValue is int)) return;
			cmbAlumno.DataSource = Db.AlumnosDeProyecto(Convert.ToInt32(cmbProyecto.SelectedValue));
			cmbAlumno.DisplayMember = "etiqueta";
			cmbAlumno.ValueMember = "id_alumno";
		}

		void CargarEnviadas()
		{
			lstEnviadas.Items.Clear();
			DataTable dt = Db.NotificacionesEnviadas(Db.IdUsuario);
			foreach (DataRow r in dt.Rows)
			{
				string msg = r["mensaje"].ToString();
				if (msg.Length > 45) msg = msg.Substring(0, 45) + "...";
				lstEnviadas.Items.Add("[" + r["tipo"] + "] " + r["alumno"] + " — " + msg +
					" (" + Convert.ToDateTime(r["fecha"]).ToString("dd/MM/yyyy") + ")");
			}
			if (dt.Rows.Count == 0) lstEnviadas.Items.Add("Sin notificaciones enviadas.");
		}

		private void cmbProyecto_SelectedIndexChanged(object sender, EventArgs e)
		{
			try { CargarAlumnos(); } catch { }
		}

		private void pnlCard_Paint(object sender, PaintEventArgs e)
		{
			var p = (Panel)sender;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
				System.Drawing.Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
		}

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			if (cmbAlumno.SelectedValue == null)
			{ MessageBox.Show("Selecciona un alumno destinatario.", "SAPIENS"); return; }
			if (txtMensaje.Text.Trim() == "")
			{ MessageBox.Show("Escribe el mensaje.", "SAPIENS"); return; }

			try
			{
				Db.EnviarNotificacion(txtMensaje.Text.Trim(), cmbTipo.Text.ToLower(),
					Convert.ToInt32(cmbAlumno.SelectedValue));
				MessageBox.Show("Notificación enviada.", "SAPIENS");
				txtMensaje.Clear();
				CargarEnviadas();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al enviar: " + ex.Message, "SAPIENS");
			}
		}
	}

}

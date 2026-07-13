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
	public partial class FrmNuevaEntrega : Form
	{
		FrmMenuDocente menu;

		public FrmNuevaEntrega(FrmMenuDocente m)
		{
			InitializeComponent();
			menu = m;
		}

		private void FrmNuevaEntrega_Load(object sender, EventArgs e)
		{
			try
			{
				cmbProyecto.DataSource = Db.ProyectosCombo(Db.IdUsuario);
				cmbProyecto.DisplayMember = "etiqueta";
				cmbProyecto.ValueMember = "id_proyecto";
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "SAPIENS"); }
			dtpFecha.Value = DateTime.Today.AddDays(14);
		}

		private void pnlCard_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, pnlDatos.ClientRectangle,
				System.Drawing.Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (cmbProyecto.SelectedValue == null)
			{ MessageBox.Show("Primero crea un proyecto.", "SAPIENS"); return; }
			if (txtTitulo.Text.Trim() == "" || txtDescripcion.Text.Trim() == "")
			{ MessageBox.Show("Llena título y descripción.", "SAPIENS"); return; }

			try
			{
				int idProy = Convert.ToInt32(cmbProyecto.SelectedValue);
				Db.CrearEntrega(txtTitulo.Text.Trim(), txtDescripcion.Text.Trim(), dtpFecha.Value, idProy);

				// Notificación automática a todo el equipo
				DataTable alumnos = Db.AlumnosDeProyecto(idProy);
				foreach (DataRow a in alumnos.Rows)
					Db.EnviarNotificacion("Nueva entrega programada: \"" + txtTitulo.Text.Trim() +
						"\". Fecha límite: " + dtpFecha.Value.ToString("dd/MM/yyyy") + ".",
						"entrega", Convert.ToInt32(a["id_alumno"]));

				MessageBox.Show("Entrega guardada. Se notificó a " + alumnos.Rows.Count + " alumno(s).", "SAPIENS");
				menu.IrEntregas();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar: " + ex.Message, "SAPIENS");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			//menu.IrEntregas();
		}
	}
}

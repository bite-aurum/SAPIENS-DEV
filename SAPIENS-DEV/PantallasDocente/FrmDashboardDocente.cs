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
	public partial class FrmDashboardDocente : Form
	{
		FrmMenuDocente menu;
		public FrmDashboardDocente(FrmMenuDocente m)
		{
			InitializeComponent();
			menu = m;
		}
		private void FrmDashboardDocente_Load(object sender, EventArgs e)
		{
			try
			{
				lblValProyectos.Text = Db.ContarProyectos(Db.IdUsuario).ToString();
				lblValTareas.Text = Db.ContarTareas(Db.IdUsuario).ToString();
				lblValEntregas.Text = Db.ContarEntregasPendientes(Db.IdUsuario).ToString();
				lblValAlumnos.Text = Db.ContarAlumnos(Db.IdUsuario).ToString();

				EstiloTabla(dgvTareas);
				dgvTareas.DataSource = Db.TareasRecientes(Db.IdUsuario);

				lstActividad.Items.Clear();
				DataTable act = Db.ActividadReciente(Db.IdUsuario);
				foreach (DataRow r in act.Rows) lstActividad.Items.Add("■  " + r["actividad"]);
				if (act.Rows.Count == 0) lstActividad.Items.Add("Sin actividad reciente.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar el dashboard: " + ex.Message, "SAPIENS");
			}
		}

		public static void EstiloTabla(DataGridView d)
		{
			d.BackgroundColor = Color.White;
			d.BorderStyle = BorderStyle.None;
			d.RowHeadersVisible = false;
			d.AllowUserToAddRows = false;
			d.ReadOnly = true;
			d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			d.EnableHeadersVisualStyles = false;
			d.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
			d.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
			d.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			d.ColumnHeadersHeight = 36;
			d.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
			d.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
			d.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 249, 255);
			d.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
			d.RowTemplate.Height = 36;
			d.GridColor = Color.FromArgb(229, 231, 235);
			d.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
		}

		private void pnlCard_Paint(object sender, PaintEventArgs e)
		{
			var p = (Panel)sender;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
				Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
		}
	}
}

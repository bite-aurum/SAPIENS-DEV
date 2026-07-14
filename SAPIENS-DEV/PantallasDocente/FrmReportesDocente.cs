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
    public partial class FrmReportesDocente : Form
    {
        FrmMenuDocente menu;
        string ultimoContenido = "";

        public FrmReportesDocente(FrmMenuDocente m)
        {
            InitializeComponent();
            menu = m;
        }

        private void FrmReportesDocente_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Db.ProyectosCombo(Db.IdUsuario);
                DataRow todos = dt.NewRow();
                todos["id_proyecto"] = 0;
                todos["etiqueta"] = "Todos mis proyectos";
                dt.Rows.InsertAt(todos, 0);
                cmbProyecto.DataSource = dt;
                cmbProyecto.DisplayMember = "etiqueta";
                cmbProyecto.ValueMember = "id_proyecto";
                cmbTipo.SelectedIndex = 0;
                txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
                CargarHistorial();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "SAPIENS"); }
        }

        void CargarHistorial()
        {
            lstHistorial.Items.Clear();
            DataTable dt = Db.ObtenerReportes(Db.IdUsuario);
            foreach (DataRow r in dt.Rows)
                lstHistorial.Items.Add("REP-" + Convert.ToInt32(r["id_reporte"]).ToString("D3") + " · " +
                    Convert.ToDateTime(r["fecha"]).ToString("dd/MM/yyyy") + " · " + r["tipo"] + " · " + r["proyecto"]);
            if (dt.Rows.Count == 0) lstHistorial.Items.Add("Sin reportes generados.");
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                System.Drawing.Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProy = Convert.ToInt32(cmbProyecto.SelectedValue);
                ultimoContenido = Db.GenerarContenido(cmbTipo.Text, Db.IdUsuario, idProy);
                Db.CrearReporte(cmbTipo.Text, ultimoContenido, Db.IdUsuario, idProy);

                lstPreview.Items.Clear();
                foreach (string linea in ultimoContenido.Split('\n'))
                    if (linea.Trim() != "") lstPreview.Items.Add(linea.TrimEnd('\r'));

                CargarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar: " + ex.Message, "SAPIENS");
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (ultimoContenido == "")
            { MessageBox.Show("Genera primero un reporte.", "SAPIENS"); return; }

            var sfd = new SaveFileDialog
            {
                Filter = "Archivo de texto|*.txt",
                FileName = "Reporte_" + DateTime.Today.ToString("yyyyMMdd") + ".txt"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //File.WriteAllText(sfd.FileName, ultimoContenido);
                MessageBox.Show("Reporte guardado.", "SAPIENS");
            }
        }
    }
}

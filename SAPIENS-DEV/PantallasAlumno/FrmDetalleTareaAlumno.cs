using SAPIENS_DEV.AccesoDatos;
using SAPIENS_DEV.PantallasDocente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPIENS_DEV.PantallasAlumno
{
    public partial class FrmDetalleTareaAlumno : Form
    {
        FrmMenuAlumno menu;
        int idTarea;
        string tituloTarea = "";
        string archivoRuta = "";

        class SubItem
        {
            public int Id; public string Titulo;
            public override string ToString() { return Titulo; }
        }

        public FrmDetalleTareaAlumno(FrmMenuAlumno m, int id)
        {
            InitializeComponent();
            menu = m;
            idTarea = id;
        }

        private void FrmDetalleTareaAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow t = Db.TareaDetalle(idTarea);
                tituloTarea = t["titulo"].ToString();
                DateTime fl = Convert.ToDateTime(t["fecha_limite"]);
                int dias = (fl.Date - DateTime.Today).Days;
                string clave = "PROY-" + Convert.ToDateTime(t["fecha_inicio"]).Year + "-" +
                               Convert.ToInt32(t["id_proyecto"]).ToString("D3");

                // Tarjeta de información 
                pnlInfo.Controls.Add(new Label
                {
                    Text = "Ta" + idTarea + " · " + clave + " · Vence: " + fl.ToString("dd/MM/yyyy"),
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    Location = new Point(20, 12),
                    Size = new Size(600, 18)
                });
                pnlInfo.Controls.Add(new Label
                {
                    Text = t["descripcion"] == DBNull.Value ? "Sin descripción." : t["descripcion"].ToString(),
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    Location = new Point(20, 34),
                    Size = new Size(900, 30),
                    AutoEllipsis = true
                });
                pnlInfo.Controls.Add(FrmTareasDocente.Chip(
                    FrmTareasDocente.Capital(t["prioridad"].ToString()) + (dias >= 0 ? " · " + dias + " días" : " · vencida"),
                    FrmTareasDocente.ColoresPrioridad(t["prioridad"].ToString()), new Point(700, 10), 110));
                pnlInfo.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(t["estado"].ToString()),
                    FrmTareasDocente.ColoresEstado(t["estado"].ToString()), new Point(820, 10), 110));

                // Subtareas del equipo 
                flpSub.Controls.Clear();
                cmbSubtarea.Items.Clear();
                DataTable subs = Db.SubtareasDeTarea(idTarea);
                int hechas = 0;
                foreach (DataRow s in subs.Rows)
                {
                    bool hecha = s["estado"].ToString() == "completada";
                    if (hecha) hechas++;
                    else cmbSubtarea.Items.Add(new SubItem
                    {
                        Id = Convert.ToInt32(s["id_subtarea"]),
                        Titulo = s["titulo"] + " — " + FrmTareasDocente.Capital(s["estado"].ToString())
                    });
                    flpSub.Controls.Add(FilaSubtarea(s));
                }
                if (cmbSubtarea.Items.Count > 0) cmbSubtarea.SelectedIndex = 0;

                lblProgreso.Text = "Progreso";
                lblProgresoVal.Text = hechas + "/" + subs.Rows.Count;
                int pct = subs.Rows.Count == 0 ? 0 : hechas * 100 / subs.Rows.Count;
                pnlBarraProg.Controls.Clear();
                pnlBarraProg.Controls.Add(new Panel
                {
                    BackColor = Color.FromArgb(245, 158, 11),
                    Location = new Point(0, 0),
                    Size = new Size(pnlBarraProg.Width * pct / 100, 8)
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tarea: " + ex.Message, "SAPIENS");
            }
        }

        Panel FilaSubtarea(DataRow s)
        {
            var fila = new Panel { Size = new Size(400, 46), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            fila.Paint += (x, e) => ControlPaint.DrawBorder(e.Graphics, fila.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
            fila.Controls.Add(new Label
            {
                Text = s["titulo"].ToString(),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(14, 12),
                Size = new Size(270, 20),
                AutoEllipsis = true
            });
            fila.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(s["estado"].ToString()),
                FrmTareasDocente.ColoresEstado(s["estado"].ToString()), new Point(290, 11), 100));
            return fila;
        }

        void SeleccionarArchivo(string ruta)
        {
            archivoRuta = ruta;
            lblArchivoSel.Text = "📄 " + Path.GetFileName(ruta);
            lblArchivoSel.ForeColor = Color.FromArgb(16, 185, 129);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Title = "Selecciona tu archivo",
                Filter = "Documentos|*.pdf;*.docx;*.doc;*.pptx;*.xlsx;*.png;*.jpg;*.sql;*.zip|Todos|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK) SeleccionarArchivo(ofd.FileName);
        }

        private void pnlDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void pnlDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (archivos.Length > 0) SeleccionarArchivo(archivos[0]);
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (cmbSubtarea.SelectedItem == null)
            { MessageBox.Show("No hay subtareas pendientes por completar.", "SAPIENS"); return; }
            if (archivoRuta == "")
            { MessageBox.Show("Selecciona o arrastra un archivo primero.", "SAPIENS"); return; }

            try
            {
                var sub = (SubItem)cmbSubtarea.SelectedItem;
                Db.CompletarSubtareaConArchivo(sub.Id, Db.IdUsuario,
                    Path.GetFileName(archivoRuta), archivoRuta,
                    Path.GetExtension(archivoRuta).TrimStart('.'));
                MessageBox.Show("Archivo subido. La subtarea se marcó como Completada.", "SAPIENS");
                menu.IrDetalleTarea(idTarea, tituloTarea); // recarga la pantalla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al subir: " + ex.Message, "SAPIENS");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e) { menu.IrTareas(); }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }

        // Zona punteada para arrastrar archivos
        private void pnlDrop_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(209, 213, 219)) { DashStyle = DashStyle.Dash })
                e.Graphics.DrawRectangle(pen, 0, 0, pnlDrop.Width - 1, pnlDrop.Height - 1);
        }
    }
}

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
    public partial class FrmTareasAlumno : Form
    {
        FrmMenuAlumno menu;

        public FrmTareasAlumno(FrmMenuAlumno m)
        {
            InitializeComponent();
            menu = m;
        }

        private void FrmTareasAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                flpTareas.Controls.Clear();
                DataTable dt = Db.TareasDeAlumno(Db.IdUsuario);
                int proyActual = -1;
                foreach (DataRow r in dt.Rows)
                {
                    int idP = Convert.ToInt32(r["id_proyecto"]);
                    if (idP != proyActual)
                    {
                        proyActual = idP;
                        string clave = "PROY-" + Convert.ToDateTime(r["fecha_inicio"]).Year + "-" + idP.ToString("D3");
                        flpTareas.Controls.Add(new Label
                        {
                            Text = clave + " — " + r["proyecto"].ToString().ToUpper(),
                            Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                            ForeColor = Color.FromArgb(107, 114, 128),
                            AutoSize = true,
                            Margin = new Padding(0, 14, 0, 6)
                        });
                    }
                    flpTareas.Controls.Add(CrearTarjeta(r));
                }
                if (dt.Rows.Count == 0)
                    flpTareas.Controls.Add(new Label
                    {
                        Text = "No tienes tareas asignadas todavía.",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128),
                        Font = new Font("Segoe UI", 10F)
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tareas: " + ex.Message, "SAPIENS");
            }
        }

        Panel CrearTarjeta(DataRow r)
        {
            int idTarea = Convert.ToInt32(r["id_tarea"]);
            string titulo = r["titulo"].ToString();
            DateTime fl = Convert.ToDateTime(r["fecha_limite"]);
            int dias = (fl.Date - DateTime.Today).Days;

            var card = new Panel { Size = new Size(920, 64), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

            card.Controls.Add(new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(20, 10),
                Size = new Size(560, 22)
            });
            card.Controls.Add(new Label
            {
                Text = "Ta" + idTarea + " · " + r["subtareas"] + " subtareas del equipo · vence: " + fl.ToString("dd/MM/yyyy"),
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(20, 34),
                Size = new Size(560, 18)
            });

            card.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(r["prioridad"].ToString()),
                FrmTareasDocente.ColoresPrioridad(r["prioridad"].ToString()), new Point(600, 20), 60));
            card.Controls.Add(new Label
            {
                Text = dias >= 0 ? "· " + dias + " días" : "· vencida",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(665, 24),
                Size = new Size(65, 16)
            });
            card.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(r["estado"].ToString()),
                FrmTareasDocente.ColoresEstado(r["estado"].ToString()), new Point(740, 20), 130));

            FrmDashboardAlumno.Clickeable(card, (s, e) => menu.IrDetalleTarea(idTarea, titulo));
            return card;
        }
    }
}

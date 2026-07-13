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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAPIENS_DEV.PantallasDocente
{
    public partial class FrmTareasDocente : Form
    {
        FrmMenuDocente menu;
        public FrmTareasDocente(FrmMenuDocente m)
        {
            InitializeComponent();
            menu= m;
        }

        private void FrmTareasDocente_Load(object sender, EventArgs e)
        {
            try
            {
                flpTareas.Controls.Clear();
                DataTable dt = Db.ObtenerTareas(Db.IdUsuario);
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
                        Text = "Aún no hay tareas. Crea la primera con «+ Nueva tarea».",
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
            var card = new Panel { Size = new Size(920, 64), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

            DateTime fl = Convert.ToDateTime(r["fecha_limite"]);
            int dias = (fl.Date - DateTime.Today).Days;

            card.Controls.Add(new Label
            {
                Text = r["titulo"].ToString(),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(20, 10),
                Size = new Size(600, 22)
            });
            card.Controls.Add(new Label
            {
                Text = "T" + r["id_tarea"] + " · " + r["subtareas"] + " subtareas · vence: " + fl.ToString("dd/MM/yyyy") +
                       (dias >= 0 ? " · faltan " + dias + " días" : " · vencida hace " + (-dias) + " días"),
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(20, 34),
                Size = new Size(600, 18)
            });

            card.Controls.Add(Chip(Capital(r["prioridad"].ToString()), ColoresPrioridad(r["prioridad"].ToString()), new Point(690, 20), 70));
            card.Controls.Add(Chip(Capital(r["estado"].ToString()), ColoresEstado(r["estado"].ToString()), new Point(770, 20), 130));
            return card;
        }

        public static string Capital(string s)
        { return s.Length == 0 ? s : char.ToUpper(s[0]) + s.Substring(1); }

        // Colores de estado 
        public static Color[] ColoresPrioridad(string p)
        {
            if (p == "alta") return new[] { Color.FromArgb(254, 226, 226), Color.FromArgb(239, 68, 68) };
            if (p == "media") return new[] { Color.FromArgb(255, 251, 235), Color.FromArgb(245, 158, 11) };
            return new[] { Color.FromArgb(236, 253, 245), Color.FromArgb(16, 185, 129) };
        }

        public static Color[] ColoresEstado(string e)
        {
            if (e == "completada" || e == "entregada") return new[] { Color.FromArgb(236, 253, 245), Color.FromArgb(16, 185, 129) };
            if (e == "en progreso" || e == "en revisión") return new[] { Color.FromArgb(255, 251, 235), Color.FromArgb(245, 158, 11) };
            return new[] { Color.FromArgb(243, 244, 246), Color.FromArgb(107, 114, 128) };
        }

        public static Label Chip(string texto, Color[] colores, Point pos, int ancho)
        {
            return new Label
            {
                Text = texto,
                BackColor = colores[0],
                ForeColor = colores[1],
                Font = new Font("Segoe UI", 8F),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = pos,
                Size = new Size(ancho, 24)
            };
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            //menu.IrNuevaTarea();
        }
    }
}

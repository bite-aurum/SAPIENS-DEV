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

namespace SAPIENS_DEV.PantallasCoordinador
{
    public partial class FrmDocentesCoord : Form
    {
        FrmMenuCoordinador menu;
        static Color[] coloresAvatar = {
            Color.FromArgb(79, 70, 229), Color.FromArgb(245, 158, 11),
            Color.FromArgb(107, 114, 128), Color.FromArgb(153, 27, 27) };

        public FrmDocentesCoord(FrmMenuCoordinador m)
        {
            InitializeComponent();
            menu = m;
        }

        private void FrmDocentesCoord_Load(object sender, EventArgs e)
        {
            try
            {
                flpDocentes.Controls.Clear();
                DataTable dt = Db.RendimientoDocentes(Db.IdUsuario);
                int i = 0;
                foreach (DataRow r in dt.Rows) flpDocentes.Controls.Add(CrearTarjeta(r, i++));
                if (dt.Rows.Count == 0)
                    flpDocentes.Controls.Add(new Label
                    {
                        Text = "Sin docentes registrados. Se registran desde la pantalla de registro con tu clave de coordinador.",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128),
                        Font = new Font("Segoe UI", 9F)
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar docentes: " + ex.Message, "SAPIENS");
            }
        }

        Panel CrearTarjeta(DataRow r, int i)
        {
            int pct = Convert.ToInt32(r["pct"]);
            string clave = "DOC-" + Convert.ToInt32(r["id_docente"]).ToString("D3");

            var card = new Panel { Size = new Size(640, 78), BackColor = Color.White, Margin = new Padding(0, 0, 0, 10) };
            card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

            card.Controls.Add(new Label
            {
                Text = FrmRendimientoCoord.Iniciales(r["docente"].ToString()),
                BackColor = coloresAvatar[i % 4],
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(16, 20),
                Size = new Size(38, 38),
                TextAlign = ContentAlignment.MiddleCenter
            });
            card.Controls.Add(new Label
            {
                Text = r["docente"].ToString(),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(66, 10),
                Size = new Size(340, 20)
            });
            card.Controls.Add(new Label
            {
                Text = clave + " · " + r["correo"],
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(66, 31),
                Size = new Size(340, 16)
            });
            card.Controls.Add(new Label
            {
                Text = "📁 " + r["proyectos"] + " proyectos    👥 " + r["alumnos"] + " alumnos",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(66, 50),
                Size = new Size(340, 16)
            });
            card.Controls.Add(new Label
            {
                Text = pct + "%",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = FrmRendimientoCoord.ColorPct(pct),
                Location = new Point(500, 15),
                Size = new Size(120, 28),
                TextAlign = ContentAlignment.MiddleRight
            });
            card.Controls.Add(new Label
            {
                Text = "entregas a tiempo",
                Font = new Font("Segoe UI", 7F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(500, 45),
                Size = new Size(120, 14),
                TextAlign = ContentAlignment.MiddleRight
            });
            return card;
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }
    }
}

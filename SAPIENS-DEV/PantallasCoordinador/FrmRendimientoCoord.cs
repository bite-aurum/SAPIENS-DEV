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
    public partial class FrmRendimientoCoord : Form
    {
        FrmMenuCoordinador menu;
        static Color[] coloresAvatar = {
            Color.FromArgb(79, 70, 229), Color.FromArgb(245, 158, 11),
            Color.FromArgb(107, 114, 128), Color.FromArgb(153, 27, 27) };

        public FrmRendimientoCoord(FrmMenuCoordinador m)
        {
            InitializeComponent();
            menu = m;

            // Iconos de las tarjetas, con el mismo color que tenia.
            Color verde = Color.FromArgb(16, 185, 129);
            Iconos.EnLabel(lblIcoProyectos, "carpeta", verde);
            Iconos.EnLabel(lblIcoDocentes, "personas", verde);
            Iconos.EnLabel(lblIcoEntregas, "check", verde);
            Iconos.EnLabel(lblIcoRetraso, "advertencia", Color.FromArgb(245, 158, 11));
        }

        private void FrmRendimientoCoord_Load(object sender, EventArgs e)
        {
            try
            {
                lblValProyectos.Text = Db.ContarProyectosCoord(Db.IdUsuario).ToString();
                lblValDocentes.Text = Db.ContarDocentesCoord(Db.IdUsuario).ToString();
                lblValEntregas.Text = Db.EntregasATiempoCoord(Db.IdUsuario) + "%";
                lblValRetraso.Text = Db.ProyectosConRetraso(Db.IdUsuario).ToString();

                // Rendimiento por docente
                flpDocentes.Controls.Clear();
                DataTable dt = Db.RendimientoDocentes(Db.IdUsuario);
                int i = 0;
                foreach (DataRow r in dt.Rows) flpDocentes.Controls.Add(TarjetaDocente(r, i++));
                if (dt.Rows.Count == 0)
                    flpDocentes.Controls.Add(new Label
                    {
                        Text = "Sin docentes registrados.",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128)
                    });

                // Avance por proyecto
                flpProyectos.Controls.Clear();
                DataTable dp = Db.ProyectosDeCoordinador(Db.IdUsuario);
                foreach (DataRow r in dp.Rows) flpProyectos.Controls.Add(TarjetaProyecto(r));
                if (dp.Rows.Count == 0)
                    flpProyectos.Controls.Add(new Label
                    {
                        Text = "Sin proyectos registrados.",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128)
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el panel: " + ex.Message, "SAPIENS");
            }
        }

        // % coloreado: verde éxito ≥80, ámbar advertencia ≥70, rojo error <70 (colores de la guía)
        public static Color ColorPct(int pct)
        {
            if (pct >= 80) return Color.FromArgb(16, 185, 129);
            if (pct >= 70) return Color.FromArgb(245, 158, 11);
            return Color.FromArgb(239, 68, 68);
        }

        public static Color ColorAvance(int av)
        {
            if (av >= 60) return Color.FromArgb(16, 185, 129);
            if (av >= 30) return Color.FromArgb(245, 158, 11);
            return Color.FromArgb(239, 68, 68);
        }

        public static string Iniciales(string nombre)
        {
            string[] p = nombre.Split(' ');
            return (p[0].Substring(0, 1) + (p.Length > 1 ? p[1].Substring(0, 1) : "")).ToUpper();
        }

        Panel TarjetaDocente(DataRow r, int i)
        {
            int pct = Convert.ToInt32(r["pct"]);
            var card = new Panel { Size = new Size(405, 64), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

            card.Controls.Add(new Label
            {
                Text = Iniciales(r["docente"].ToString()),
                BackColor = coloresAvatar[i % 4],
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Location = new Point(14, 15),
                Size = new Size(34, 34),
                TextAlign = ContentAlignment.MiddleCenter
            });
            card.Controls.Add(new Label
            {
                Text = r["docente"].ToString(),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(58, 12),
                Size = new Size(230, 20)
            });
            card.Controls.Add(new Label
            {
                Text = r["proyectos"] + " proyectos · " + r["alumnos"] + " alumnos",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(58, 33),
                Size = new Size(230, 16)
            });
            card.Controls.Add(new Label
            {
                Text = pct + "%",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = ColorPct(pct),
                Location = new Point(300, 10),
                Size = new Size(95, 26),
                TextAlign = ContentAlignment.MiddleRight
            });
            card.Controls.Add(new Label
            {
                Text = "entregas a tiempo",
                Font = new Font("Segoe UI", 7F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(300, 38),
                Size = new Size(95, 14),
                TextAlign = ContentAlignment.MiddleRight
            });
            return card;
        }

        Panel TarjetaProyecto(DataRow r)
        {
            int av = Convert.ToInt32(r["avance"]);
            string clave = "PROY-" + Convert.ToDateTime(r["fecha_inicio"]).Year + "-" +
                           Convert.ToInt32(r["id_proyecto"]).ToString("D3");
            var card = new Panel { Size = new Size(405, 70), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

            card.Controls.Add(new Label
            {
                Text = r["nombre"].ToString(),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(14, 8),
                Size = new Size(300, 20),
                AutoEllipsis = true
            });
            card.Controls.Add(new Label
            {
                Text = clave + " · Prof. " + r["docente"],
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(14, 28),
                Size = new Size(300, 15)
            });
            card.Controls.Add(new Label
            {
                Text = av + "%",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(330, 8),
                Size = new Size(60, 20),
                TextAlign = ContentAlignment.MiddleRight
            });
            var fondo = new Panel { BackColor = Color.FromArgb(229, 231, 235), Location = new Point(14, 50), Size = new Size(375, 8) };
            fondo.Controls.Add(new Panel { BackColor = ColorAvance(av), Location = new Point(0, 0), Size = new Size(375 * av / 100, 8) });
            card.Controls.Add(fondo);
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

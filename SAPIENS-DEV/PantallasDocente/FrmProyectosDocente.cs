using SAPIENS_DEV.Compartido;
﻿using SAPIENS_DEV.AccesoDatos;
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
    public partial class FrmProyectosDocente : Form
    {
        FrmMenuDocente menu;
        public FrmProyectosDocente(FrmMenuDocente m)
        {
            InitializeComponent();
            menu = m;
        }
        private void FrmProyectosDocente_Load(object sender, EventArgs e)
        {
            try
            {
                flpProyectos.Controls.Clear();
                DataTable dt = Db.ObtenerProyectos(Db.IdUsuario);
                foreach (DataRow r in dt.Rows) flpProyectos.Controls.Add(CrearTarjeta(r));
                if (dt.Rows.Count == 0)
                    flpProyectos.Controls.Add(new Label
                    {
                        Text = "Aún no tienes proyectos. Crea el primero con el botón «+ Nuevo proyecto».",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128),
                        Font = new Font("Segoe UI", 10F),
                        Margin = new Padding(10)
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message, "SAPIENS");
            }
        }

        Panel CrearTarjeta(DataRow r)
        {
            int avance = Convert.ToInt32(r["avance"]);
            DateTime fi = Convert.ToDateTime(r["fecha_inicio"]);
            string clave = "PROY-" + fi.Year + "-" + Convert.ToInt32(r["id_proyecto"]).ToString("D3");

            var card = new Panel { Size = new Size(920, 150), BackColor = Color.White, Margin = new Padding(0, 0, 0, 16) };
            card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

            card.Controls.Add(new Label
            {
                Text = r["nombre"].ToString(),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(20, 14),
                Size = new Size(700, 24)
            });

            string ff = r["fecha_fin"] == DBNull.Value ? "—" : Convert.ToDateTime(r["fecha_fin"]).ToString("dd/MM/yyyy");
            card.Controls.Add(new Label
            {
                Text = clave + " · Fecha inicio: " + fi.ToString("dd/MM/yyyy") + " · Fin estimado: " + ff,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(20, 40),
                Size = new Size(700, 18)
            });

            card.Controls.Add(new Label
            {
                Text = "Problemática: " + (r["problematica"] == DBNull.Value ? "—" : r["problematica"].ToString()),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(20, 60),
                Size = new Size(860, 18),
                AutoEllipsis = true
            });

            // chips
            string[] iconosChip = { "personas", "check", "enviar" };
            string[] textosChip = { r["alumnos"] + " alumnos", r["tareas"] + " tareas", r["entregas"] + " entregas" };
            int cx = 20;
            for (int i = 0; i < textosChip.Length; i++)
            {
                var chip = new Label
                {
                    Text = textosChip[i],
                    Font = new Font("Segoe UI", 8F),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    BackColor = Color.White,
                    Location = new Point(cx, 84),
                    Size = new Size(95, 22),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Iconos.EnLabelConTexto(chip, iconosChip[i], Color.FromArgb(107, 114, 128), 16);
                chip.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, chip.ClientRectangle,
                    Color.FromArgb(209, 213, 219), ButtonBorderStyle.Solid);
                card.Controls.Add(chip);
                cx += 105;
            }

            // estado 
            string estado = r["estado"].ToString();
            var lblEstado = new Label
            {
                Text = estado,
                Font = new Font("Segoe UI", 8F),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(810, 14),
                Size = new Size(90, 22),
                BackColor = estado == "activo" ? Color.FromArgb(236, 253, 245) : Color.FromArgb(255, 251, 235),
                ForeColor = estado == "activo" ? Color.FromArgb(16, 185, 129) : Color.FromArgb(245, 158, 11)
            };
            card.Controls.Add(lblEstado);

            // barra de avance
            card.Controls.Add(new Label
            {
                Text = "Avance general",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(20, 116),
                AutoSize = true
            });
            var barraFondo = new Panel { BackColor = Color.FromArgb(229, 231, 235), Location = new Point(120, 121), Size = new Size(700, 8) };
            barraFondo.Controls.Add(new Panel { BackColor = Color.FromArgb(79, 70, 229), Location = new Point(0, 0), Size = new Size(700 * avance / 100, 8) });
            card.Controls.Add(barraFondo);
            card.Controls.Add(new Label
            {
                Text = avance + "%",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(835, 112),
                AutoSize = true
            });

            return card;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            menu.IrNuevoProyecto();
        }
    }
}

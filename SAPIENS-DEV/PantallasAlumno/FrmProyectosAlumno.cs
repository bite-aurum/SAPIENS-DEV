using SAPIENS_DEV.Compartido;
﻿using SAPIENS_DEV.AccesoDatos;
using SAPIENS_DEV.PantallasCoordinador;
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
    public partial class FrmProyectosAlumno : Form
    {
        FrmMenuAlumno menu;

        public FrmProyectosAlumno(FrmMenuAlumno m)
        {
            InitializeComponent();
            menu = m;
        }

        private void FrmProyectosAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                flpProyectos.Controls.Clear();
                DataTable dt = Db.ProyectosDeAlumno(Db.IdUsuario);
                foreach (DataRow r in dt.Rows) flpProyectos.Controls.Add(CrearTarjeta(r));
                if (dt.Rows.Count == 0)
                    flpProyectos.Controls.Add(new Label
                    {
                        Text = "Aún no estás asignado a ningún proyecto.",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128),
                        Font = new Font("Segoe UI", 10F)
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message, "SAPIENS");
            }
        }

        Panel CrearTarjeta(DataRow r)
        {
            int av = Convert.ToInt32(r["avance"]);
            int idProy = Convert.ToInt32(r["id_proyecto"]);
            string nombre = r["nombre"].ToString();
            DateTime fi = Convert.ToDateTime(r["fecha_inicio"]);
            string clave = "PROY-" + fi.Year + "-" + idProy.ToString("D3");
            string estado = r["estado"].ToString();

            var card = new Panel { Size = new Size(920, 150), BackColor = Color.White, Margin = new Padding(0, 0, 0, 12) };
            card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

            card.Controls.Add(new Label
            {
                Text = nombre,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(20, 14),
                Size = new Size(680, 24)
            });
            card.Controls.Add(new Label
            {
                Text = clave + " · Prof. " + r["docente"] + " · Rol: " + FrmTareasDocente.Capital(r["rol"].ToString()),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(20, 40),
                Size = new Size(680, 18)
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

            card.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(estado),
                estado == "activo" ? new[] { Color.FromArgb(236, 253, 245), Color.FromArgb(16, 185, 129) }
                                   : new[] { Color.FromArgb(255, 251, 235), Color.FromArgb(245, 158, 11) },
                new Point(810, 14), 90));

            string[] iconosChip = { "personas", "check", "enviar" };
            string[] textosChip = { r["alumnos"] + " integrantes", r["tareas"] + " tareas", r["entregas"] + " entregas" };
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
                    Size = new Size(105, 22),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Iconos.EnLabelConTexto(chip, iconosChip[i], Color.FromArgb(107, 114, 128), 16);
                chip.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, chip.ClientRectangle,
                    Color.FromArgb(209, 213, 219), ButtonBorderStyle.Solid);
                card.Controls.Add(chip);
                cx += 115;
            }

            card.Controls.Add(new Label
            {
                Text = "Avance general",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(20, 116),
                AutoSize = true
            });
            var fondo = new Panel { BackColor = Color.FromArgb(229, 231, 235), Location = new Point(120, 121), Size = new Size(700, 8) };
            fondo.Controls.Add(new Panel
            {
                BackColor = FrmRendimientoCoord.ColorAvance(av),
                Location = new Point(0, 0),
                Size = new Size(700 * av / 100, 8)
            });
            card.Controls.Add(fondo);
            card.Controls.Add(new Label
            {
                Text = av + "%",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(835, 112),
                AutoSize = true
            });

            FrmDashboardAlumno.Clickeable(card, (s, e) => menu.IrDetalleProyecto(idProy, nombre));
            return card;
        }
    }
}

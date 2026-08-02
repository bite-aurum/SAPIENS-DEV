using SAPIENS_DEV.Compartido;
﻿using SAPIENS_DEV.AccesoDatos;
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
    public partial class FrmNotificacionesAlumno : Form
    {
        FrmMenuAlumno menu;

        public FrmNotificacionesAlumno(FrmMenuAlumno m)
        {
            InitializeComponent();
            menu = m;

            // Icono del botn, con el mismo color que tenia.
            Iconos.EnBotonTexto(btnMarcarTodas, "check", Color.FromArgb(31, 41, 55));
        }

        private void FrmNotificacionesAlumno_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        void Cargar()
        {
            try
            {
                flpNotifs.Controls.Clear();
                DataTable dt = Db.NotificacionesDeAlumno(Db.IdUsuario);
                int noLeidas = 0;
                foreach (DataRow r in dt.Rows) if (Convert.ToInt32(r["leida"]) == 0) noLeidas++;

                if (noLeidas > 0)
                {
                    flpNotifs.Controls.Add(Seccion("NO LEÍDAS (" + noLeidas + ")"));
                    foreach (DataRow r in dt.Rows)
                        if (Convert.ToInt32(r["leida"]) == 0) flpNotifs.Controls.Add(CrearTarjeta(r));
                }
                if (dt.Rows.Count - noLeidas > 0)
                {
                    flpNotifs.Controls.Add(Seccion("LEÍDAS"));
                    foreach (DataRow r in dt.Rows)
                        if (Convert.ToInt32(r["leida"]) == 1) flpNotifs.Controls.Add(CrearTarjeta(r));
                }
                if (dt.Rows.Count == 0)
                    flpNotifs.Controls.Add(new Label
                    {
                        Text = "No tienes notificaciones.",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128),
                        Font = new Font("Segoe UI", 10F)
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar notificaciones: " + ex.Message, "SAPIENS");
            }
        }

        Label Seccion(string texto)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(107, 114, 128),
                AutoSize = true,
                Margin = new Padding(0, 14, 0, 6)
            };
        }

        Panel CrearTarjeta(DataRow r)
        {
            string tipo = r["tipo"].ToString();
            bool noLeida = Convert.ToInt32(r["leida"]) == 0;

            var card = new Panel { Size = new Size(920, 58), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

            card.Controls.Add(new Label
            {
                Text = noLeida ? "■" : "□",
                ForeColor = noLeida ? Color.FromArgb(239, 68, 68) : Color.FromArgb(209, 213, 219),
                Font = new Font("Segoe UI", 8F),
                Location = new Point(14, 20),
                Size = new Size(16, 16)
            });

            string icoNombre = tipo == "alerta" ? "advertencia" : tipo == "recordatorio" ? "reloj" : "info";
            Color icoColor = tipo == "alerta" ? Color.FromArgb(239, 68, 68)
                           : tipo == "recordatorio" ? Color.FromArgb(245, 158, 11)
                           : Color.FromArgb(16, 185, 129);
            var lblIco = new Label
            {
                Location = new Point(36, 16),
                Size = new Size(26, 24)
            };
            Iconos.EnLabel(lblIco, icoNombre, icoColor, 24);
            card.Controls.Add(lblIco);

            card.Controls.Add(new Label
            {
                Text = r["mensaje"].ToString(),
                Font = new Font("Segoe UI", 9F, noLeida ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(70, 8),
                Size = new Size(680, 20),
                AutoEllipsis = true
            });
            card.Controls.Add(new Label
            {
                Text = FrmTareasDocente.Capital(tipo) + " · " + Convert.ToDateTime(r["fecha"]).ToString("dd/MM/yyyy"),
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(70, 32),
                Size = new Size(400, 14)
            });

            Color[] c;
            if (tipo == "alerta") c = new[] { Color.FromArgb(254, 226, 226), Color.FromArgb(239, 68, 68) };
            else if (tipo == "recordatorio") c = new[] { Color.FromArgb(255, 251, 235), Color.FromArgb(245, 158, 11) };
            else c = new[] { Color.FromArgb(236, 253, 245), Color.FromArgb(16, 185, 129) };
            card.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(tipo), c, new Point(790, 17), 110));
            return card;
        }

        private void btnMarcarTodas_Click(object sender, EventArgs e)
        {
            try
            {
                Db.MarcarNotificacionesLeidas(Db.IdUsuario);
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SAPIENS");
            }
        }
    }
}

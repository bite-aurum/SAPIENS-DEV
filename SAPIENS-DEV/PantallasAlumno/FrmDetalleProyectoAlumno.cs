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
    public partial class FrmDetalleProyectoAlumno : Form
    {
        FrmMenuAlumno menu;
        int idProyecto;
        static Color[] coloresAvatar = {
            Color.FromArgb(59, 130, 246), Color.FromArgb(124, 58, 237),
            Color.FromArgb(245, 158, 11), Color.FromArgb(107, 114, 128) };

        public FrmDetalleProyectoAlumno(FrmMenuAlumno m, int idProy)
        {
            InitializeComponent();
            menu = m;
            idProyecto = idProy;

            // Icono del botón, con el mismo color qe tejia .
            Iconos.EnBotonTexto(btnVolver, "flecha-izquierda", Color.FromArgb(31, 41, 55));
        }

        private void FrmDetalleProyectoAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow r = Db.ProyectoDetalleAlumno(idProyecto, Db.IdUsuario);
                int av = Convert.ToInt32(r["avance"]);
                DateTime fi = Convert.ToDateTime(r["fecha_inicio"]);
                string clave = "PROY-" + fi.Year + "-" + idProyecto.ToString("D3");
                string ff = r["fecha_fin"] == DBNull.Value ? "—" : Convert.ToDateTime(r["fecha_fin"]).ToString("dd/MM/yyyy");

                // ---- Tarjeta de información ----
                pnlInfo.Controls.Add(new Label
                {
                    Text = clave + " · Prof. " + r["docente"] + " · Inicio: " + fi.ToString("dd/MM/yyyy") + " · Fin estimado: " + ff,
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    Location = new Point(20, 14),
                    Size = new Size(750, 18)
                });
                string estado = r["estado"].ToString();
                pnlInfo.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(estado),
                    estado == "activo" ? new[] { Color.FromArgb(236, 253, 245), Color.FromArgb(16, 185, 129) }
                                       : new[] { Color.FromArgb(255, 251, 235), Color.FromArgb(245, 158, 11) },
                    new Point(840, 12), 90));
                pnlInfo.Controls.Add(new Label
                {
                    Text = "Problemática: " + (r["problematica"] == DBNull.Value ? "—" : r["problematica"]),
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    Location = new Point(20, 38),
                    Size = new Size(900, 18),
                    AutoEllipsis = true
                });
                pnlInfo.Controls.Add(new Label
                {
                    Text = "Objetivos: " + (r["objetivos"] == DBNull.Value ? "—" : r["objetivos"]),
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    Location = new Point(20, 58),
                    Size = new Size(900, 18),
                    AutoEllipsis = true
                });
                pnlInfo.Controls.Add(new Label
                {
                    Text = "Avance general",
                    Font = new Font("Segoe UI", 8F),
                    ForeColor = Color.FromArgb(107, 114, 128),
                    Location = new Point(20, 88),
                    AutoSize = true
                });
                var fondo = new Panel { BackColor = Color.FromArgb(229, 231, 235), Location = new Point(120, 93), Size = new Size(720, 8) };
                fondo.Controls.Add(new Panel
                {
                    BackColor = FrmRendimientoCoord.ColorAvance(av),
                    Location = new Point(0, 0),
                    Size = new Size(720 * av / 100, 8)
                });
                pnlInfo.Controls.Add(fondo);
                pnlInfo.Controls.Add(new Label
                {
                    Text = av + "%",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    Location = new Point(855, 84),
                    AutoSize = true
                });

                // ---- Equipo ----
                flpEquipo.Controls.Clear();
                DataTable eq = Db.EquipoDeProyecto(idProyecto);
                int i = 0;
                foreach (DataRow a in eq.Rows) flpEquipo.Controls.Add(FilaIntegrante(a, i++));

                // ---- Entregas ----
                flpEntregas.Controls.Clear();
                DataTable en = Db.EntregasDeProyecto(idProyecto);
                foreach (DataRow x in en.Rows) flpEntregas.Controls.Add(FilaEntrega(x));
                if (en.Rows.Count == 0)
                    flpEntregas.Controls.Add(new Label
                    {
                        Text = "Sin entregas.",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128)
                    });

                // ---- Tareas ----
                flpTareas.Controls.Clear();
                DataTable ta = Db.TareasDeProyecto(idProyecto);
                foreach (DataRow x in ta.Rows) flpTareas.Controls.Add(FilaTarea(x));
                if (ta.Rows.Count == 0)
                    flpTareas.Controls.Add(new Label
                    {
                        Text = "Sin tareas.",
                        AutoSize = true,
                        ForeColor = Color.FromArgb(107, 114, 128)
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el proyecto: " + ex.Message, "SAPIENS");
            }
        }

        Panel FilaIntegrante(DataRow a, int i)
        {
            bool soyYo = Convert.ToInt32(a["id_alumno"]) == Db.IdUsuario;
            bool lider = a["rol"].ToString().ToLower().Contains("líder") || a["rol"].ToString().ToLower().Contains("lider");
            var fila = new Panel { Size = new Size(420, 54), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            fila.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, fila.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
            fila.Controls.Add(new Label
            {
                Text = FrmRendimientoCoord.Iniciales(a["nombre"].ToString()),
                BackColor = coloresAvatar[i % 4],
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Location = new Point(12, 11),
                Size = new Size(32, 32),
                TextAlign = ContentAlignment.MiddleCenter
            });
            fila.Controls.Add(new Label
            {
                Text = a["nombre"] + (soyYo ? " - Tú" : ""),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(54, 8),
                Size = new Size(250, 18)
            });
            fila.Controls.Add(new Label
            {
                Text = a["matricula"].ToString(),
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(54, 28),
                Size = new Size(200, 14)
            });
            fila.Controls.Add(FrmTareasDocente.Chip(lider ? "Líder" : "Miembro",
                lider ? new[] { Color.FromArgb(255, 251, 235), Color.FromArgb(245, 158, 11) }
                      : new[] { Color.FromArgb(240, 249, 255), Color.FromArgb(59, 130, 246) },
                new Point(330, 15), 75));
            return fila;
        }

        Panel FilaEntrega(DataRow x)
        {
            string estado = x["estado"].ToString();
            DateTime f = Convert.ToDateTime(x["fecha_limite"]);
            bool tardia = estado == "pendiente" && f.Date < DateTime.Today;
            var fila = new Panel { Size = new Size(430, 50), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            fila.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, fila.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
            fila.Controls.Add(new Label
            {
                Text = x["titulo"].ToString(),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(14, 6),
                Size = new Size(290, 18),
                AutoEllipsis = true
            });
            fila.Controls.Add(new Label
            {
                Text = "ENT-" + Convert.ToInt32(x["id_entrega"]).ToString("D3") + " · " + f.ToString("dd/MM/yyyy"),
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(14, 26),
                Size = new Size(250, 14)
            });
            Color[] c = tardia
                ? new[] { Color.FromArgb(254, 226, 226), Color.FromArgb(239, 68, 68) }
                : FrmTareasDocente.ColoresEstado(estado);
            fila.Controls.Add(FrmTareasDocente.Chip(tardia ? "Tardía" : FrmTareasDocente.Capital(estado), c, new Point(320, 13), 95));
            int id = Convert.ToInt32(x["id_entrega"]);
            string titulo = x["titulo"].ToString();
           // FrmDashboardAlumno.Clickeable(fila, (s, e) => menu.IrDetalleEntrega(id, titulo));
            return fila;
        }

        Panel FilaTarea(DataRow x)
        {
            var fila = new Panel { Size = new Size(430, 50), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
            fila.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, fila.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
            fila.Controls.Add(new Label
            {
                Text = x["titulo"].ToString(),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(31, 41, 55),
                Location = new Point(14, 6),
                Size = new Size(290, 18),
                AutoEllipsis = true
            });
            fila.Controls.Add(new Label
            {
                Text = "Ta" + x["id_tarea"] + " · vence: " + Convert.ToDateTime(x["fecha_limite"]).ToString("dd/MM/yyyy"),
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.FromArgb(107, 114, 128),
                Location = new Point(14, 26),
                Size = new Size(250, 14)
            });
            fila.Controls.Add(FrmTareasDocente.Chip(FrmTareasDocente.Capital(x["estado"].ToString()),
                FrmTareasDocente.ColoresEstado(x["estado"].ToString()), new Point(320, 13), 95));
            int id = Convert.ToInt32(x["id_tarea"]);
            string titulo = x["titulo"].ToString();
           // FrmDashboardAlumno.Clickeable(fila, (s, e) => menu.IrDetalleTarea(id, titulo));
            return fila;
        }

        private void btnVolver_Click(object sender, EventArgs e) { menu.IrProyectos(); }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }
    }
}

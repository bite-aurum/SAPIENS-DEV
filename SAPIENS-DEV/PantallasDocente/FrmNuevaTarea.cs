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
    public partial class FrmNuevaTarea : Form
    {
        FrmMenuDocente menu;
        string prioridadActual = "media";

        class SubItem
        {
            public string Titulo; public string Desc;
            public override string ToString() { return Titulo; }
        }
        List<SubItem> subtareas = new List<SubItem>();

        public FrmNuevaTarea(FrmMenuDocente m)
        {
            InitializeComponent();
            menu = m;

            // Iconos de los botones, con el mismo color que tenía su emoji.
            Iconos.EnBotonTexto(btnQuitarSub, "basura", Color.FromArgb(239, 68, 68));
            Iconos.EnBotonTexto(btnCancelar, "equis", Color.FromArgb(31, 41, 55));
            Iconos.EnBotonTexto(btnGuardar, "guardar", Color.White);
        }

        private void FrmNuevaTarea_Load(object sender, EventArgs e)
        {
            try
            {
                cmbProyecto.DataSource = Db.ProyectosCombo(Db.IdUsuario);
                cmbProyecto.DisplayMember = "etiqueta";
                cmbProyecto.ValueMember = "id_proyecto";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "SAPIENS"); }
            dtpLimite.Value = DateTime.Today.AddDays(7);
            CalcularPrioridad();
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }

        private void dtpLimite_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrioridad();
        }

        void CalcularPrioridad()
        {
            int dias = (dtpLimite.Value.Date - DateTime.Today).Days;
            prioridadActual = dias <= 3 ? "alta" : dias <= 7 ? "media" : "baja";
            Color[] c = FrmTareasDocente.ColoresPrioridad(prioridadActual);
            lblPrioridadVal.Text = FrmTareasDocente.Capital(prioridadActual);
            lblPrioridadVal.BackColor = c[0];
            lblPrioridadVal.ForeColor = c[1];
            lblHintPrioridad.Text = "Faltan " + dias + " días · calculada automáticamente";
        }

        private void btnAgregarSub_Click(object sender, EventArgs e)
        {
            if (txtSubNombre.Text.Trim() == "")
            { MessageBox.Show("Escribe el nombre de la subtarea.", "SAPIENS"); return; }
            var s = new SubItem { Titulo = txtSubNombre.Text.Trim(), Desc = txtSubDesc.Text.Trim() };
            subtareas.Add(s);
            lstSub.Items.Add(s);
            lblSubAgregadas.Text = "Subtareas agregadas (" + subtareas.Count + ")";
            txtSubNombre.Clear(); txtSubDesc.Clear();
        }

        private void btnQuitarSub_Click(object sender, EventArgs e)
        {
            if (lstSub.SelectedIndex < 0) return;
            subtareas.RemoveAt(lstSub.SelectedIndex);
            lstSub.Items.RemoveAt(lstSub.SelectedIndex);
            lblSubAgregadas.Text = "Subtareas agregadas (" + subtareas.Count + ")";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbProyecto.SelectedValue == null)
            { MessageBox.Show("Primero crea un proyecto.", "SAPIENS"); return; }
            if (txtNombre.Text.Trim() == "")
            { MessageBox.Show("Escribe el nombre de la tarea.", "SAPIENS"); return; }

            try
            {
                int id = Db.CrearTarea(txtNombre.Text.Trim(), txtDescripcion.Text.Trim(),
                    prioridadActual, dtpLimite.Value, Convert.ToInt32(cmbProyecto.SelectedValue));
                foreach (SubItem s in subtareas) Db.CrearSubtarea(s.Titulo, s.Desc, id);
                MessageBox.Show("Tarea guardada correctamente.", "SAPIENS");
                menu.IrTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "SAPIENS");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menu.IrTareas();
        }
    }
}

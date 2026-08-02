namespace SAPIENS_DEV.PantallasDocente
{
    partial class FrmNuevaTarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FrmNuevaTarea";
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblSecDatos = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.lblHintProy = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblPrioridadVal = new System.Windows.Forms.Label();
            this.lblHintPrioridad = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblHintEstado = new System.Windows.Forms.Label();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.lblSecSub = new System.Windows.Forms.Label();
            this.lblSubNombre = new System.Windows.Forms.Label();
            this.txtSubNombre = new System.Windows.Forms.TextBox();
            this.lblSubDesc = new System.Windows.Forms.Label();
            this.txtSubDesc = new System.Windows.Forms.TextBox();
            this.btnAgregarSub = new System.Windows.Forms.Button();
            this.lblHintSub = new System.Windows.Forms.Label();
            this.lblSubAgregadas = new System.Windows.Forms.Label();
            this.lstSub = new System.Windows.Forms.ListBox();
            this.btnQuitarSub = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.pnlSub.SuspendLayout();
            this.SuspendLayout();
            // pnlDatos
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.Location = new System.Drawing.Point(24, 24);
            this.pnlDatos.Size = new System.Drawing.Size(700, 400);
            this.pnlDatos.Controls.Add(this.lblSecDatos);
            this.pnlDatos.Controls.Add(this.lblProyecto);
            this.pnlDatos.Controls.Add(this.cmbProyecto);
            this.pnlDatos.Controls.Add(this.lblHintProy);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblDescripcion);
            this.pnlDatos.Controls.Add(this.txtDescripcion);
            this.pnlDatos.Controls.Add(this.lblLimite);
            this.pnlDatos.Controls.Add(this.dtpLimite);
            this.pnlDatos.Controls.Add(this.lblPrioridad);
            this.pnlDatos.Controls.Add(this.lblPrioridadVal);
            this.pnlDatos.Controls.Add(this.lblHintPrioridad);
            this.pnlDatos.Controls.Add(this.lblEstado);
            this.pnlDatos.Controls.Add(this.txtEstado);
            this.pnlDatos.Controls.Add(this.lblHintEstado);
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecDatos
            this.lblSecDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecDatos.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecDatos.Location = new System.Drawing.Point(30, 18);
            this.lblSecDatos.Size = new System.Drawing.Size(300, 20);
            this.lblSecDatos.Text = "DATOS DE LA TAREA";
            // lblProyecto
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblProyecto.Location = new System.Drawing.Point(30, 50);
            this.lblProyecto.Text = "Proyecto *";
            // cmbProyecto
            this.cmbProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyecto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProyecto.Location = new System.Drawing.Point(30, 70);
            this.cmbProyecto.Size = new System.Drawing.Size(640, 25);
            // lblHintProy
            this.lblHintProy.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHintProy.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHintProy.Location = new System.Drawing.Point(30, 98);
            this.lblHintProy.Size = new System.Drawing.Size(400, 15);
            this.lblHintProy.Text = "La tarea quedará vinculada a este proyecto y a todo su equipo";
            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblNombre.Location = new System.Drawing.Point(30, 122);
            this.lblNombre.Text = "Nombre de la tarea *";
            // txtNombre
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(30, 142);
            this.txtNombre.Size = new System.Drawing.Size(640, 25);
            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDescripcion.Location = new System.Drawing.Point(30, 177);
            this.lblDescripcion.Text = "Descripción";
            // txtDescripcion
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(30, 197);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Size = new System.Drawing.Size(640, 50);
            // lblLimite
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLimite.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblLimite.Location = new System.Drawing.Point(30, 260);
            this.lblLimite.Text = "Fecha límite *";
            // dtpLimite
            this.dtpLimite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLimite.Location = new System.Drawing.Point(30, 280);
            this.dtpLimite.Size = new System.Drawing.Size(200, 25);
            this.dtpLimite.ValueChanged += new System.EventHandler(this.dtpLimite_ValueChanged);
            // lblPrioridad
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrioridad.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPrioridad.Location = new System.Drawing.Point(260, 260);
            this.lblPrioridad.Text = "Prioridad";
            // lblPrioridadVal
            this.lblPrioridadVal.BackColor = System.Drawing.Color.FromArgb(255, 251, 235);
            this.lblPrioridadVal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPrioridadVal.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblPrioridadVal.Location = new System.Drawing.Point(260, 282);
            this.lblPrioridadVal.Size = new System.Drawing.Size(70, 22);
            this.lblPrioridadVal.Text = "Media";
            this.lblPrioridadVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblHintPrioridad
            this.lblHintPrioridad.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHintPrioridad.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHintPrioridad.Location = new System.Drawing.Point(340, 285);
            this.lblHintPrioridad.Size = new System.Drawing.Size(300, 15);
            this.lblHintPrioridad.Text = "calculada automáticamente";
            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblEstado.Location = new System.Drawing.Point(30, 318);
            this.lblEstado.Text = "Estado";
            // txtEstado
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEstado.Location = new System.Drawing.Point(30, 338);
            this.txtEstado.Size = new System.Drawing.Size(200, 25);
            this.txtEstado.Text = "Pendiente";
            // lblHintEstado
            this.lblHintEstado.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHintEstado.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHintEstado.Location = new System.Drawing.Point(30, 366);
            this.lblHintEstado.Size = new System.Drawing.Size(300, 15);
            this.lblHintEstado.Text = "Se asigna automáticamente al crear";
            // pnlSub
            this.pnlSub.BackColor = System.Drawing.Color.White;
            this.pnlSub.Location = new System.Drawing.Point(24, 440);
            this.pnlSub.Size = new System.Drawing.Size(700, 260);
            this.pnlSub.Controls.Add(this.lblSecSub);
            this.pnlSub.Controls.Add(this.lblSubNombre);
            this.pnlSub.Controls.Add(this.txtSubNombre);
            this.pnlSub.Controls.Add(this.lblSubDesc);
            this.pnlSub.Controls.Add(this.txtSubDesc);
            this.pnlSub.Controls.Add(this.btnAgregarSub);
            this.pnlSub.Controls.Add(this.lblHintSub);
            this.pnlSub.Controls.Add(this.lblSubAgregadas);
            this.pnlSub.Controls.Add(this.lstSub);
            this.pnlSub.Controls.Add(this.btnQuitarSub);
            this.pnlSub.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecSub
            this.lblSecSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecSub.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecSub.Location = new System.Drawing.Point(30, 18);
            this.lblSecSub.Size = new System.Drawing.Size(300, 20);
            this.lblSecSub.Text = "SUBTAREAS DEL EQUIPO";
            // lblSubNombre
            this.lblSubNombre.AutoSize = true;
            this.lblSubNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubNombre.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSubNombre.Location = new System.Drawing.Point(30, 50);
            this.lblSubNombre.Text = "Nombre *";
            // txtSubNombre
            this.txtSubNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSubNombre.Location = new System.Drawing.Point(30, 70);
            this.txtSubNombre.Size = new System.Drawing.Size(280, 25);
            // lblSubDesc
            this.lblSubDesc.AutoSize = true;
            this.lblSubDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubDesc.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSubDesc.Location = new System.Drawing.Point(30, 105);
            this.lblSubDesc.Text = "Descripción";
            // txtSubDesc
            this.txtSubDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSubDesc.Location = new System.Drawing.Point(30, 125);
            this.txtSubDesc.Size = new System.Drawing.Size(280, 25);
            // btnAgregarSub
            this.btnAgregarSub.BackColor = System.Drawing.Color.White;
            this.btnAgregarSub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnAgregarSub.FlatAppearance.BorderSize = 2;
            this.btnAgregarSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarSub.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnAgregarSub.Location = new System.Drawing.Point(30, 168);
            this.btnAgregarSub.Size = new System.Drawing.Size(280, 32);
            this.btnAgregarSub.Text = "+  Agregar subtarea";
            this.btnAgregarSub.UseVisualStyleBackColor = false;
            this.btnAgregarSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSub.Click += new System.EventHandler(this.btnAgregarSub_Click);
            // lblHintSub
            this.lblHintSub.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHintSub.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHintSub.Location = new System.Drawing.Point(30, 205);
            this.lblHintSub.Size = new System.Drawing.Size(290, 15);
            this.lblHintSub.Text = "Cualquier alumno del equipo puede completarla";
            // lblSubAgregadas
            this.lblSubAgregadas.AutoSize = true;
            this.lblSubAgregadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubAgregadas.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSubAgregadas.Location = new System.Drawing.Point(340, 50);
            this.lblSubAgregadas.Text = "Subtareas agregadas (0)";
            // lstSub
            this.lstSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstSub.ItemHeight = 22;
            this.lstSub.Location = new System.Drawing.Point(340, 70);
            this.lstSub.Size = new System.Drawing.Size(330, 130);
            // btnQuitarSub
            this.btnQuitarSub.BackColor = System.Drawing.Color.White;
            this.btnQuitarSub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnQuitarSub.FlatAppearance.BorderSize = 1;
            this.btnQuitarSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnQuitarSub.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnQuitarSub.Location = new System.Drawing.Point(340, 210);
            this.btnQuitarSub.Size = new System.Drawing.Size(330, 28);
            this.btnQuitarSub.Text = "Quitar seleccionada";
            this.btnQuitarSub.UseVisualStyleBackColor = false;
            this.btnQuitarSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarSub.Click += new System.EventHandler(this.btnQuitarSub_Click);
            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnCancelar.FlatAppearance.BorderSize = 1;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnCancelar.Location = new System.Drawing.Point(24, 720);
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(544, 720);
            this.btnGuardar.Size = new System.Drawing.Size(180, 40);
            this.btnGuardar.Text = "Guardar tarea";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // FrmNuevaTarea
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlSub);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmNuevaTarea_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblSecDatos;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Label lblHintProy;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.DateTimePicker dtpLimite;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblPrioridadVal;
        private System.Windows.Forms.Label lblHintPrioridad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblHintEstado;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.Label lblSecSub;
        private System.Windows.Forms.Label lblSubNombre;
        private System.Windows.Forms.TextBox txtSubNombre;
        private System.Windows.Forms.Label lblSubDesc;
        private System.Windows.Forms.TextBox txtSubDesc;
        private System.Windows.Forms.Button btnAgregarSub;
        private System.Windows.Forms.Label lblHintSub;
        private System.Windows.Forms.Label lblSubAgregadas;
        private System.Windows.Forms.ListBox lstSub;
        private System.Windows.Forms.Button btnQuitarSub;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        #endregion
    }
}
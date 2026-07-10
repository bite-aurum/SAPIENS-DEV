namespace SAPIENS_DEV.PantallasDocente
{
    partial class FrmNuevoProyecto
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
            this.Text = "FrmNuevoProyecto";

            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblSecDatos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblProblematica = new System.Windows.Forms.Label();
            this.txtProblematica = new System.Windows.Forms.TextBox();
            this.lblObjetivos = new System.Windows.Forms.Label();
            this.txtObjetivos = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblHintEstado = new System.Windows.Forms.Label();
            this.pnlAlumnos = new System.Windows.Forms.Panel();
            this.lblSecAlumnos = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnBuscarAgregar = new System.Windows.Forms.Button();
            this.lblHintBuscar = new System.Windows.Forms.Label();
            this.lblAgregados = new System.Windows.Forms.Label();
            this.lstAgregados = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.pnlAlumnos.SuspendLayout();
            this.SuspendLayout();
            // pnlDatos
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.Location = new System.Drawing.Point(24, 24);
            this.pnlDatos.Size = new System.Drawing.Size(700, 470);
            this.pnlDatos.Controls.Add(this.lblSecDatos);
            this.pnlDatos.Controls.Add(this.lblTitulo);
            this.pnlDatos.Controls.Add(this.txtTitulo);
            this.pnlDatos.Controls.Add(this.lblDescripcion);
            this.pnlDatos.Controls.Add(this.txtDescripcion);
            this.pnlDatos.Controls.Add(this.lblProblematica);
            this.pnlDatos.Controls.Add(this.txtProblematica);
            this.pnlDatos.Controls.Add(this.lblObjetivos);
            this.pnlDatos.Controls.Add(this.txtObjetivos);
            this.pnlDatos.Controls.Add(this.lblInicio);
            this.pnlDatos.Controls.Add(this.dtpInicio);
            this.pnlDatos.Controls.Add(this.lblFin);
            this.pnlDatos.Controls.Add(this.dtpFin);
            this.pnlDatos.Controls.Add(this.lblEstado);
            this.pnlDatos.Controls.Add(this.txtEstado);
            this.pnlDatos.Controls.Add(this.lblHintEstado);
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecDatos
            this.lblSecDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecDatos.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecDatos.Location = new System.Drawing.Point(30, 18);
            this.lblSecDatos.Size = new System.Drawing.Size(300, 20);
            this.lblSecDatos.Text = "DATOS DEL PROYECTO";
            // lblTitulo (campo requerido con * rojo según guía)
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitulo.Location = new System.Drawing.Point(30, 50);
            this.lblTitulo.Text = "Título *";
            // txtTitulo
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitulo.Location = new System.Drawing.Point(30, 70);
            this.txtTitulo.Size = new System.Drawing.Size(640, 25);
            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDescripcion.Location = new System.Drawing.Point(30, 105);
            this.lblDescripcion.Text = "Descripción *";
            // txtDescripcion
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(30, 125);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Size = new System.Drawing.Size(640, 50);
            // lblProblematica
            this.lblProblematica.AutoSize = true;
            this.lblProblematica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProblematica.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblProblematica.Location = new System.Drawing.Point(30, 185);
            this.lblProblematica.Text = "Problemática *";
            // txtProblematica
            this.txtProblematica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProblematica.Location = new System.Drawing.Point(30, 205);
            this.txtProblematica.Multiline = true;
            this.txtProblematica.Size = new System.Drawing.Size(640, 50);
            // lblObjetivos
            this.lblObjetivos.AutoSize = true;
            this.lblObjetivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblObjetivos.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblObjetivos.Location = new System.Drawing.Point(30, 265);
            this.lblObjetivos.Text = "Objetivos";
            // txtObjetivos
            this.txtObjetivos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObjetivos.Location = new System.Drawing.Point(30, 285);
            this.txtObjetivos.Multiline = true;
            this.txtObjetivos.Size = new System.Drawing.Size(640, 50);
            // lblInicio
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblInicio.Location = new System.Drawing.Point(30, 345);
            this.lblInicio.Text = "Fecha de inicio *";
            // dtpInicio
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(30, 365);
            this.dtpInicio.Size = new System.Drawing.Size(200, 25);
            // lblFin
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFin.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblFin.Location = new System.Drawing.Point(260, 345);
            this.lblFin.Text = "Fecha fin estimada";
            // dtpFin
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(260, 365);
            this.dtpFin.Size = new System.Drawing.Size(200, 25);
            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblEstado.Location = new System.Drawing.Point(30, 400);
            this.lblEstado.Text = "Estado";
            // txtEstado (disabled según guía: fondo #F3F4F6)
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEstado.Location = new System.Drawing.Point(30, 420);
            this.txtEstado.Size = new System.Drawing.Size(200, 25);
            this.txtEstado.Text = "Activo";
            // lblHintEstado
            this.lblHintEstado.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHintEstado.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHintEstado.Location = new System.Drawing.Point(30, 448);
            this.lblHintEstado.Size = new System.Drawing.Size(300, 15);
            this.lblHintEstado.Text = "Se asigna automáticamente al crear";
            // pnlAlumnos
            this.pnlAlumnos.BackColor = System.Drawing.Color.White;
            this.pnlAlumnos.Location = new System.Drawing.Point(24, 510);
            this.pnlAlumnos.Size = new System.Drawing.Size(700, 230);
            this.pnlAlumnos.Controls.Add(this.lblSecAlumnos);
            this.pnlAlumnos.Controls.Add(this.lblBuscar);
            this.pnlAlumnos.Controls.Add(this.txtBuscar);
            this.pnlAlumnos.Controls.Add(this.lblRol);
            this.pnlAlumnos.Controls.Add(this.cmbRol);
            this.pnlAlumnos.Controls.Add(this.btnBuscarAgregar);
            this.pnlAlumnos.Controls.Add(this.lblHintBuscar);
            this.pnlAlumnos.Controls.Add(this.lblAgregados);
            this.pnlAlumnos.Controls.Add(this.lstAgregados);
            this.pnlAlumnos.Controls.Add(this.btnQuitar);
            this.pnlAlumnos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecAlumnos
            this.lblSecAlumnos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecAlumnos.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecAlumnos.Location = new System.Drawing.Point(30, 18);
            this.lblSecAlumnos.Size = new System.Drawing.Size(300, 20);
            this.lblSecAlumnos.Text = "ASIGNAR ALUMNOS";
            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblBuscar.Location = new System.Drawing.Point(30, 50);
            this.lblBuscar.Text = "Buscar alumno";
            // txtBuscar
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(30, 70);
            this.txtBuscar.Size = new System.Drawing.Size(180, 25);
            // lblRol
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblRol.Location = new System.Drawing.Point(30, 105);
            this.lblRol.Text = "Rol en el proyecto";
            // cmbRol
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.Items.AddRange(new object[] { "Participante", "Líder" });
            this.cmbRol.Location = new System.Drawing.Point(30, 125);
            this.cmbRol.Size = new System.Drawing.Size(180, 25);
            // btnBuscarAgregar
            this.btnBuscarAgregar.BackColor = System.Drawing.Color.White;
            this.btnBuscarAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnBuscarAgregar.FlatAppearance.BorderSize = 2;
            this.btnBuscarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarAgregar.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnBuscarAgregar.Location = new System.Drawing.Point(30, 165);
            this.btnBuscarAgregar.Size = new System.Drawing.Size(180, 32);
            this.btnBuscarAgregar.Text = "🔍  Buscar y agregar";
            this.btnBuscarAgregar.UseVisualStyleBackColor = false;
            this.btnBuscarAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAgregar.Click += new System.EventHandler(this.btnBuscarAgregar_Click);
            // lblHintBuscar
            this.lblHintBuscar.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHintBuscar.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHintBuscar.Location = new System.Drawing.Point(30, 200);
            this.lblHintBuscar.Size = new System.Drawing.Size(200, 15);
            this.lblHintBuscar.Text = "Busca por matrícula o nombre";
            // lblAgregados
            this.lblAgregados.AutoSize = true;
            this.lblAgregados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAgregados.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblAgregados.Location = new System.Drawing.Point(300, 50);
            this.lblAgregados.Text = "Alumnos agregados (0)";
            // lstAgregados
            this.lstAgregados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAgregados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstAgregados.ItemHeight = 22;
            this.lstAgregados.Location = new System.Drawing.Point(300, 70);
            this.lstAgregados.Size = new System.Drawing.Size(370, 110);
            // btnQuitar
            this.btnQuitar.BackColor = System.Drawing.Color.White;
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnQuitar.FlatAppearance.BorderSize = 1;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnQuitar.Location = new System.Drawing.Point(300, 188);
            this.btnQuitar.Size = new System.Drawing.Size(370, 28);
            this.btnQuitar.Text = "🗑  Quitar seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnCancelar.FlatAppearance.BorderSize = 1;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnCancelar.Location = new System.Drawing.Point(24, 760);
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.Text = "✕  Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // btnGuardar (botón primario)
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(544, 760);
            this.btnGuardar.Size = new System.Drawing.Size(180, 40);
            this.btnGuardar.Text = "💾  Guardar proyecto";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // FrmNuevoProyecto
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlAlumnos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmNuevoProyecto_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlAlumnos.ResumeLayout(false);
            this.pnlAlumnos.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblSecDatos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblProblematica;
        private System.Windows.Forms.TextBox txtProblematica;
        private System.Windows.Forms.Label lblObjetivos;
        private System.Windows.Forms.TextBox txtObjetivos;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblHintEstado;
        private System.Windows.Forms.Panel pnlAlumnos;
        private System.Windows.Forms.Label lblSecAlumnos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnBuscarAgregar;
        private System.Windows.Forms.Label lblHintBuscar;
        private System.Windows.Forms.Label lblAgregados;
        private System.Windows.Forms.ListBox lstAgregados;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;

        #endregion
    }
}
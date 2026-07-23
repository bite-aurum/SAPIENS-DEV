namespace SAPIENS_DEV.PantallasDocente
{
	partial class FrmNotificacionesDocente
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
			this.Text = "FrmNotificacionesDocente";
			this.pnlEnviadas = new System.Windows.Forms.Panel();
			this.lblSecEnv = new System.Windows.Forms.Label();
			this.lstEnviadas = new System.Windows.Forms.ListBox();
			this.pnlEnviar = new System.Windows.Forms.Panel();
			this.lblSecForm = new System.Windows.Forms.Label();
			this.lblProyecto = new System.Windows.Forms.Label();
			this.cmbProyecto = new System.Windows.Forms.ComboBox();
			this.lblHintProy = new System.Windows.Forms.Label();
			this.lblAlumno = new System.Windows.Forms.Label();
			this.cmbAlumno = new System.Windows.Forms.ComboBox();
			this.lblTipo = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.lblFecha = new System.Windows.Forms.Label();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.lblHintFecha = new System.Windows.Forms.Label();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.pnlEnviadas.SuspendLayout();
			this.pnlEnviar.SuspendLayout();
			this.SuspendLayout();
			// pnlEnviadas
			this.pnlEnviadas.BackColor = System.Drawing.Color.White;
			this.pnlEnviadas.Location = new System.Drawing.Point(24, 24);
			this.pnlEnviadas.Size = new System.Drawing.Size(440, 586);
			this.pnlEnviadas.Controls.Add(this.lblSecEnv);
			this.pnlEnviadas.Controls.Add(this.lstEnviadas);
			this.pnlEnviadas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSecEnv
			this.lblSecEnv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSecEnv.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSecEnv.Location = new System.Drawing.Point(30, 18);
			this.lblSecEnv.Size = new System.Drawing.Size(300, 20);
			this.lblSecEnv.Text = "ENVIADAS";
			// lstEnviadas
			this.lstEnviadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstEnviadas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.lstEnviadas.ItemHeight = 24;
			this.lstEnviadas.Location = new System.Drawing.Point(30, 45);
			this.lstEnviadas.Size = new System.Drawing.Size(380, 520);
			// pnlEnviar
			this.pnlEnviar.BackColor = System.Drawing.Color.White;
			this.pnlEnviar.Location = new System.Drawing.Point(490, 24);
			this.pnlEnviar.Size = new System.Drawing.Size(485, 586);
			this.pnlEnviar.Controls.Add(this.lblSecForm);
			this.pnlEnviar.Controls.Add(this.lblProyecto);
			this.pnlEnviar.Controls.Add(this.cmbProyecto);
			this.pnlEnviar.Controls.Add(this.lblHintProy);
			this.pnlEnviar.Controls.Add(this.lblAlumno);
			this.pnlEnviar.Controls.Add(this.cmbAlumno);
			this.pnlEnviar.Controls.Add(this.lblTipo);
			this.pnlEnviar.Controls.Add(this.cmbTipo);
			this.pnlEnviar.Controls.Add(this.lblMensaje);
			this.pnlEnviar.Controls.Add(this.txtMensaje);
			this.pnlEnviar.Controls.Add(this.lblFecha);
			this.pnlEnviar.Controls.Add(this.txtFecha);
			this.pnlEnviar.Controls.Add(this.lblHintFecha);
			this.pnlEnviar.Controls.Add(this.btnEnviar);
			this.pnlEnviar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSecForm
			this.lblSecForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSecForm.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSecForm.Location = new System.Drawing.Point(30, 18);
			this.lblSecForm.Size = new System.Drawing.Size(300, 20);
			this.lblSecForm.Text = "ENVIAR NOTIFICACIÓN";
			// lblProyecto
			this.lblProyecto.AutoSize = true;
			this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblProyecto.Location = new System.Drawing.Point(30, 48);
			this.lblProyecto.Text = "Proyecto";
			// cmbProyecto
			this.cmbProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProyecto.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbProyecto.Location = new System.Drawing.Point(30, 68);
			this.cmbProyecto.Size = new System.Drawing.Size(420, 25);
			this.cmbProyecto.SelectedIndexChanged += new System.EventHandler(this.cmbProyecto_SelectedIndexChanged);
			// lblHintProy
			this.lblHintProy.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
			this.lblHintProy.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblHintProy.Location = new System.Drawing.Point(30, 96);
			this.lblHintProy.Size = new System.Drawing.Size(420, 15);
			this.lblHintProy.Text = "Los alumnos disponibles son del proyecto seleccionado";
			// lblAlumno
			this.lblAlumno.AutoSize = true;
			this.lblAlumno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblAlumno.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblAlumno.Location = new System.Drawing.Point(30, 122);
			this.lblAlumno.Text = "Alumno destinatario *";
			// cmbAlumno
			this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAlumno.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbAlumno.Location = new System.Drawing.Point(30, 142);
			this.cmbAlumno.Size = new System.Drawing.Size(420, 25);
			// lblTipo
			this.lblTipo.AutoSize = true;
			this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblTipo.Location = new System.Drawing.Point(30, 180);
			this.lblTipo.Text = "Tipo *";
			// cmbTipo
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbTipo.Items.AddRange(new object[] { "Alerta", "Recordatorio", "Informativa" });
			this.cmbTipo.Location = new System.Drawing.Point(30, 200);
			this.cmbTipo.Size = new System.Drawing.Size(420, 25);
			// lblMensaje
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblMensaje.Location = new System.Drawing.Point(30, 238);
			this.lblMensaje.Text = "Mensaje *";
			// txtMensaje
			this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtMensaje.Location = new System.Drawing.Point(30, 258);
			this.txtMensaje.Multiline = true;
			this.txtMensaje.Size = new System.Drawing.Size(420, 90);
			// lblFecha
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblFecha.Location = new System.Drawing.Point(30, 365);
			this.lblFecha.Text = "Fecha de envío";
			// txtFecha
			this.txtFecha.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
			this.txtFecha.Enabled = false;
			this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtFecha.Location = new System.Drawing.Point(30, 385);
			this.txtFecha.Size = new System.Drawing.Size(420, 25);
			// lblHintFecha
			this.lblHintFecha.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
			this.lblHintFecha.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblHintFecha.Location = new System.Drawing.Point(30, 413);
			this.lblHintFecha.Size = new System.Drawing.Size(420, 15);
			this.lblHintFecha.Text = "Se envía automáticamente al guardar";
			// btnEnviar
			this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnEnviar.FlatAppearance.BorderSize = 0;
			this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnEnviar.ForeColor = System.Drawing.Color.White;
			this.btnEnviar.Location = new System.Drawing.Point(30, 445);
			this.btnEnviar.Size = new System.Drawing.Size(420, 40);
			this.btnEnviar.Text = "📨  Enviar notificación";
			this.btnEnviar.UseVisualStyleBackColor = false;
			this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// FrmNotificacionesDocente
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
			this.ClientSize = new System.Drawing.Size(1000, 630);
			this.Controls.Add(this.pnlEnviadas);
			this.Controls.Add(this.pnlEnviar);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Load += new System.EventHandler(this.FrmNotificacionesDocente_Load);
			this.pnlEnviadas.ResumeLayout(false);
			this.pnlEnviar.ResumeLayout(false);
			this.pnlEnviar.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel pnlEnviadas;
		private System.Windows.Forms.Label lblSecEnv;
		private System.Windows.Forms.ListBox lstEnviadas;
		private System.Windows.Forms.Panel pnlEnviar;
		private System.Windows.Forms.Label lblSecForm;
		private System.Windows.Forms.Label lblProyecto;
		private System.Windows.Forms.ComboBox cmbProyecto;
		private System.Windows.Forms.Label lblHintProy;
		private System.Windows.Forms.Label lblAlumno;
		private System.Windows.Forms.ComboBox cmbAlumno;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label lblMensaje;
		private System.Windows.Forms.TextBox txtMensaje;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label lblHintFecha;
		private System.Windows.Forms.Button btnEnviar;

		#endregion
	}
}
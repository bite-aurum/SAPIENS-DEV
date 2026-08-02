namespace SAPIENS_DEV.PantallasDocente
{
	partial class FrmNuevaEntrega
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
			this.Text = "FrmNuevaEntrega";
			this.pnlDatos = new System.Windows.Forms.Panel();
			this.lblSec = new System.Windows.Forms.Label();
			this.lblProyecto = new System.Windows.Forms.Label();
			this.cmbProyecto = new System.Windows.Forms.ComboBox();
			this.lblHintProy = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.lblFecha = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.lblEstado = new System.Windows.Forms.Label();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.lblHintFecha = new System.Windows.Forms.Label();
			this.lblHintEstado = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.pnlDatos.SuspendLayout();
			this.SuspendLayout();
			// pnlDatos
			this.pnlDatos.BackColor = System.Drawing.Color.White;
			this.pnlDatos.Location = new System.Drawing.Point(24, 24);
			this.pnlDatos.Size = new System.Drawing.Size(700, 380);
			this.pnlDatos.Controls.Add(this.lblSec);
			this.pnlDatos.Controls.Add(this.lblProyecto);
			this.pnlDatos.Controls.Add(this.cmbProyecto);
			this.pnlDatos.Controls.Add(this.lblHintProy);
			this.pnlDatos.Controls.Add(this.lblTitulo);
			this.pnlDatos.Controls.Add(this.txtTitulo);
			this.pnlDatos.Controls.Add(this.lblDescripcion);
			this.pnlDatos.Controls.Add(this.txtDescripcion);
			this.pnlDatos.Controls.Add(this.lblFecha);
			this.pnlDatos.Controls.Add(this.dtpFecha);
			this.pnlDatos.Controls.Add(this.lblEstado);
			this.pnlDatos.Controls.Add(this.txtEstado);
			this.pnlDatos.Controls.Add(this.lblHintFecha);
			this.pnlDatos.Controls.Add(this.lblHintEstado);
			this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSec
			this.lblSec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSec.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSec.Location = new System.Drawing.Point(30, 18);
			this.lblSec.Size = new System.Drawing.Size(300, 20);
			this.lblSec.Text = "DATOS DE LA ENTREGA";
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
			this.lblHintProy.Text = "La entrega aplica para todo el equipo del proyecto";
			// lblTitulo
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblTitulo.Location = new System.Drawing.Point(30, 122);
			this.lblTitulo.Text = "Título de la entrega *";
			// txtTitulo
			this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtTitulo.Location = new System.Drawing.Point(30, 142);
			this.txtTitulo.Size = new System.Drawing.Size(640, 25);
			// lblDescripcion
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblDescripcion.Location = new System.Drawing.Point(30, 177);
			this.lblDescripcion.Text = "Descripción *";
			// txtDescripcion
			this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtDescripcion.Location = new System.Drawing.Point(30, 197);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Size = new System.Drawing.Size(640, 55);
			// lblFecha
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblFecha.Location = new System.Drawing.Point(30, 268);
			this.lblFecha.Text = "Fecha programada *";
			// dtpFecha
			this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(30, 288);
			this.dtpFecha.Size = new System.Drawing.Size(200, 25);
			// lblEstado
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblEstado.Location = new System.Drawing.Point(260, 268);
			this.lblEstado.Text = "Estado";
			// txtEstado
			this.txtEstado.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
			this.txtEstado.Enabled = false;
			this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtEstado.Location = new System.Drawing.Point(260, 288);
			this.txtEstado.Size = new System.Drawing.Size(200, 25);
			this.txtEstado.Text = "Pendiente";
			// lblHintFecha
			this.lblHintFecha.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
			this.lblHintFecha.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblHintFecha.Location = new System.Drawing.Point(30, 318);
			this.lblHintFecha.Size = new System.Drawing.Size(220, 15);
			this.lblHintFecha.Text = "Todo el equipo recibirá notificación automática";
			// lblHintEstado
			this.lblHintEstado.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
			this.lblHintEstado.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblHintEstado.Location = new System.Drawing.Point(260, 318);
			this.lblHintEstado.Size = new System.Drawing.Size(220, 15);
			this.lblHintEstado.Text = "Se asigna automáticamente al crear";
			// btnCancelar
			this.btnCancelar.BackColor = System.Drawing.Color.White;
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
			this.btnCancelar.FlatAppearance.BorderSize = 1;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.btnCancelar.Location = new System.Drawing.Point(24, 424);
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
			this.btnGuardar.Location = new System.Drawing.Point(544, 424);
			this.btnGuardar.Size = new System.Drawing.Size(180, 40);
			this.btnGuardar.Text = "Guardar entrega";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// FrmNuevaEntrega
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
			this.ClientSize = new System.Drawing.Size(1000, 630);
			this.Controls.Add(this.pnlDatos);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Load += new System.EventHandler(this.FrmNuevaEntrega_Load);
			this.pnlDatos.ResumeLayout(false);
			this.pnlDatos.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel pnlDatos;
		private System.Windows.Forms.Label lblSec;
		private System.Windows.Forms.Label lblProyecto;
		private System.Windows.Forms.ComboBox cmbProyecto;
		private System.Windows.Forms.Label lblHintProy;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Label lblHintFecha;
		private System.Windows.Forms.Label lblHintEstado;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;

		#endregion
	}
}
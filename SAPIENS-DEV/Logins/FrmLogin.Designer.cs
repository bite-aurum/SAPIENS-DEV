namespace SAPIENS_DEV.Logins
{
	partial class FrmLogin
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
			this.Text = "FrmLogin";
			this.pnlCard = new System.Windows.Forms.Panel();
			this.lblLogo = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.lblPass = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.lblSinCuenta = new System.Windows.Forms.Label();
			this.btnRegistrarse = new System.Windows.Forms.Button();
			this.pnlCard.SuspendLayout();
			this.SuspendLayout();
			// pnlCard
			this.pnlCard.BackColor = System.Drawing.Color.White;
			this.pnlCard.Location = new System.Drawing.Point(230, 180);
			this.pnlCard.Size = new System.Drawing.Size(440, 360);
			this.pnlCard.Controls.Add(this.lblLogo);
			this.pnlCard.Controls.Add(this.lblSubtitulo);
			this.pnlCard.Controls.Add(this.lblCorreo);
			this.pnlCard.Controls.Add(this.txtCorreo);
			this.pnlCard.Controls.Add(this.lblPass);
			this.pnlCard.Controls.Add(this.txtPass);
			this.pnlCard.Controls.Add(this.btnIngresar);
			this.pnlCard.Controls.Add(this.lblSinCuenta);
			this.pnlCard.Controls.Add(this.btnRegistrarse);
			this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblLogo
			this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.lblLogo.Location = new System.Drawing.Point(0, 25);
			this.lblLogo.Size = new System.Drawing.Size(440, 40);
			this.lblLogo.Text = "SAPIENS";
			this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// lblSubtitulo
			this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSubtitulo.Location = new System.Drawing.Point(0, 65);
			this.lblSubtitulo.Size = new System.Drawing.Size(440, 20);
			this.lblSubtitulo.Text = "Sistema de Gestión de Proyectos Académicos · UTHH";
			this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// lblCorreo
			this.lblCorreo.AutoSize = true;
			this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblCorreo.Location = new System.Drawing.Point(30, 100);
			this.lblCorreo.Text = "Correo electrónico";
			// txtCorreo
			this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCorreo.Location = new System.Drawing.Point(30, 120);
			this.txtCorreo.Size = new System.Drawing.Size(380, 25);
			// lblPass
			this.lblPass.AutoSize = true;
			this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPass.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblPass.Location = new System.Drawing.Point(30, 160);
			this.lblPass.Text = "Contraseña";
			// txtPass
			this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPass.Location = new System.Drawing.Point(30, 180);
			this.txtPass.Size = new System.Drawing.Size(380, 25);
			this.txtPass.UseSystemPasswordChar = true;
			// btnIngresar (botón primario: fondo índigo #4F46E5, texto blanco, alto 40)
			this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnIngresar.ForeColor = System.Drawing.Color.White;
			this.btnIngresar.Location = new System.Drawing.Point(30, 225);
			this.btnIngresar.Size = new System.Drawing.Size(380, 40);
			this.btnIngresar.Text = "Iniciar sesión";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// lblSinCuenta
			this.lblSinCuenta.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblSinCuenta.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSinCuenta.Location = new System.Drawing.Point(0, 275);
			this.lblSinCuenta.Size = new System.Drawing.Size(440, 18);
			this.lblSinCuenta.Text = "¿No tienes cuenta?";
			this.lblSinCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// btnRegistrarse (botón secundario: borde 2px índigo, fondo blanco)
			this.btnRegistrarse.BackColor = System.Drawing.Color.White;
			this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnRegistrarse.FlatAppearance.BorderSize = 2;
			this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarse.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnRegistrarse.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnRegistrarse.Location = new System.Drawing.Point(30, 300);
			this.btnRegistrarse.Size = new System.Drawing.Size(380, 40);
			this.btnRegistrarse.Text = "Registrarse";
			this.btnRegistrarse.UseVisualStyleBackColor = false;
			this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
			// FrmLogin
			this.AcceptButton = this.btnIngresar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
			this.ClientSize = new System.Drawing.Size(900, 720);
			this.Controls.Add(this.pnlCard);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SAPIENS — Iniciar sesión";
			this.pnlCard.ResumeLayout(false);
			this.pnlCard.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel pnlCard;
		private System.Windows.Forms.Label lblLogo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Label lblSinCuenta;
		private System.Windows.Forms.Button btnRegistrarse;
		#endregion
	}
}
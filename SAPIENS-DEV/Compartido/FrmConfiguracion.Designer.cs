namespace SAPIENS_DEV.Compartido
{
	partial class FrmConfiguracion
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
			this.Text = "FrmConfiguracion";
			this.pnlPerfil = new System.Windows.Forms.Panel();
			this.lblSecPerfil = new System.Windows.Forms.Label();
			this.lblAvatar = new System.Windows.Forms.Label();
			this.lblNombreCompleto = new System.Windows.Forms.Label();
			this.lblClaveRol = new System.Windows.Forms.Label();
			this.lblExtra = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblApellidos = new System.Windows.Forms.Label();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.pnlPass = new System.Windows.Forms.Panel();
			this.lblSecPass = new System.Windows.Forms.Label();
			this.lblPassActual = new System.Windows.Forms.Label();
			this.txtPassActual = new System.Windows.Forms.TextBox();
			this.btnOjo1 = new System.Windows.Forms.Button();
			this.lblPassNueva = new System.Windows.Forms.Label();
			this.txtPassNueva = new System.Windows.Forms.TextBox();
			this.btnOjo2 = new System.Windows.Forms.Button();
			this.lblPassConfirmar = new System.Windows.Forms.Label();
			this.txtPassConfirmar = new System.Windows.Forms.TextBox();
			this.btnOjo3 = new System.Windows.Forms.Button();
			this.btnActualizarPass = new System.Windows.Forms.Button();
			this.pnlPref = new System.Windows.Forms.Panel();
			this.lblSecPref = new System.Windows.Forms.Label();
			this.chkTema = new System.Windows.Forms.CheckBox();
			this.lblHintTema = new System.Windows.Forms.Label();
			this.chkNotifs = new System.Windows.Forms.CheckBox();
			this.lblHintNotifs = new System.Windows.Forms.Label();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.pnlPerfil.SuspendLayout();
			this.pnlPass.SuspendLayout();
			this.pnlPref.SuspendLayout();
			this.SuspendLayout();
			// pnlPerfil
			this.pnlPerfil.BackColor = System.Drawing.Color.White;
			this.pnlPerfil.Location = new System.Drawing.Point(24, 24);
			this.pnlPerfil.Size = new System.Drawing.Size(700, 260);
			this.pnlPerfil.Controls.Add(this.lblSecPerfil);
			this.pnlPerfil.Controls.Add(this.lblAvatar);
			this.pnlPerfil.Controls.Add(this.lblNombreCompleto);
			this.pnlPerfil.Controls.Add(this.lblClaveRol);
			this.pnlPerfil.Controls.Add(this.lblExtra);
			this.pnlPerfil.Controls.Add(this.lblNombre);
			this.pnlPerfil.Controls.Add(this.txtNombre);
			this.pnlPerfil.Controls.Add(this.lblApellidos);
			this.pnlPerfil.Controls.Add(this.txtApellidos);
			this.pnlPerfil.Controls.Add(this.lblCorreo);
			this.pnlPerfil.Controls.Add(this.txtCorreo);
			this.pnlPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSecPerfil
			this.lblSecPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSecPerfil.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSecPerfil.Location = new System.Drawing.Point(30, 18);
			this.lblSecPerfil.Size = new System.Drawing.Size(300, 20);
			this.lblSecPerfil.Text = "PERFIL";
			// lblAvatar
			this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
			this.lblAvatar.ForeColor = System.Drawing.Color.White;
			this.lblAvatar.Location = new System.Drawing.Point(30, 50);
			this.lblAvatar.Size = new System.Drawing.Size(48, 48);
			this.lblAvatar.Text = "US";
			this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// lblNombreCompleto
			this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblNombreCompleto.Location = new System.Drawing.Point(90, 50);
			this.lblNombreCompleto.Size = new System.Drawing.Size(500, 22);
			this.lblNombreCompleto.Text = "Nombre Apellido";
			// lblClaveRol
			this.lblClaveRol.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblClaveRol.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblClaveRol.Location = new System.Drawing.Point(91, 72);
			this.lblClaveRol.Size = new System.Drawing.Size(400, 15);
			this.lblClaveRol.Text = "";
			// lblExtra
			this.lblExtra.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblExtra.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblExtra.Location = new System.Drawing.Point(91, 88);
			this.lblExtra.Size = new System.Drawing.Size(500, 15);
			this.lblExtra.Text = "";
			// lblNombre
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblNombre.Location = new System.Drawing.Point(30, 120);
			this.lblNombre.Text = "Nombre";
			// txtNombre
			this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtNombre.Location = new System.Drawing.Point(30, 140);
			this.txtNombre.Size = new System.Drawing.Size(310, 25);
			// lblApellidos
			this.lblApellidos.AutoSize = true;
			this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblApellidos.Location = new System.Drawing.Point(360, 120);
			this.lblApellidos.Text = "Apellidos";
			// txtApellidos
			this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtApellidos.Location = new System.Drawing.Point(360, 140);
			this.txtApellidos.Size = new System.Drawing.Size(310, 25);
			// lblCorreo
			this.lblCorreo.AutoSize = true;
			this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblCorreo.Location = new System.Drawing.Point(30, 178);
			this.lblCorreo.Text = "Correo electrónico";
			// txtCorreo
			this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCorreo.Location = new System.Drawing.Point(30, 198);
			this.txtCorreo.Size = new System.Drawing.Size(640, 25);
			// pnlPass
			this.pnlPass.BackColor = System.Drawing.Color.White;
			this.pnlPass.Location = new System.Drawing.Point(24, 298);
			this.pnlPass.Size = new System.Drawing.Size(700, 215);
			this.pnlPass.Controls.Add(this.lblSecPass);
			this.pnlPass.Controls.Add(this.lblPassActual);
			this.pnlPass.Controls.Add(this.txtPassActual);
			this.pnlPass.Controls.Add(this.btnOjo1);
			this.pnlPass.Controls.Add(this.lblPassNueva);
			this.pnlPass.Controls.Add(this.txtPassNueva);
			this.pnlPass.Controls.Add(this.btnOjo2);
			this.pnlPass.Controls.Add(this.lblPassConfirmar);
			this.pnlPass.Controls.Add(this.txtPassConfirmar);
			this.pnlPass.Controls.Add(this.btnOjo3);
			this.pnlPass.Controls.Add(this.btnActualizarPass);
			this.pnlPass.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSecPass
			this.lblSecPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSecPass.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSecPass.Location = new System.Drawing.Point(30, 18);
			this.lblSecPass.Size = new System.Drawing.Size(300, 20);
			this.lblSecPass.Text = "CAMBIAR CONTRASEÑA";
			// lblPassActual
			this.lblPassActual.AutoSize = true;
			this.lblPassActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPassActual.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblPassActual.Location = new System.Drawing.Point(30, 46);
			this.lblPassActual.Text = "Contraseña actual";
			// txtPassActual
			this.txtPassActual.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPassActual.Location = new System.Drawing.Point(30, 66);
			this.txtPassActual.Size = new System.Drawing.Size(600, 25);
			this.txtPassActual.UseSystemPasswordChar = true;
			// btnOjo1
			this.btnOjo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOjo1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
			this.btnOjo1.FlatAppearance.BorderSize = 1;
			this.btnOjo1.Location = new System.Drawing.Point(636, 66);
			this.btnOjo1.Size = new System.Drawing.Size(34, 25);
			this.btnOjo1.Text = "👁";
			this.btnOjo1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOjo1.Click += new System.EventHandler(this.btnOjo1_Click);
			// lblPassNueva
			this.lblPassNueva.AutoSize = true;
			this.lblPassNueva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPassNueva.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblPassNueva.Location = new System.Drawing.Point(30, 104);
			this.lblPassNueva.Text = "Nueva contraseña";
			// txtPassNueva
			this.txtPassNueva.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPassNueva.Location = new System.Drawing.Point(30, 124);
			this.txtPassNueva.Size = new System.Drawing.Size(270, 25);
			this.txtPassNueva.UseSystemPasswordChar = true;
			// btnOjo2
			this.btnOjo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOjo2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
			this.btnOjo2.FlatAppearance.BorderSize = 1;
			this.btnOjo2.Location = new System.Drawing.Point(306, 124);
			this.btnOjo2.Size = new System.Drawing.Size(34, 25);
			this.btnOjo2.Text = "👁";
			this.btnOjo2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOjo2.Click += new System.EventHandler(this.btnOjo2_Click);
			// lblPassConfirmar
			this.lblPassConfirmar.AutoSize = true;
			this.lblPassConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblPassConfirmar.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblPassConfirmar.Location = new System.Drawing.Point(370, 104);
			this.lblPassConfirmar.Text = "Confirmar contraseña";
			// txtPassConfirmar
			this.txtPassConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPassConfirmar.Location = new System.Drawing.Point(370, 124);
			this.txtPassConfirmar.Size = new System.Drawing.Size(260, 25);
			this.txtPassConfirmar.UseSystemPasswordChar = true;
			// btnOjo3
			this.btnOjo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOjo3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
			this.btnOjo3.FlatAppearance.BorderSize = 1;
			this.btnOjo3.Location = new System.Drawing.Point(636, 124);
			this.btnOjo3.Size = new System.Drawing.Size(34, 25);
			this.btnOjo3.Text = "👁";
			this.btnOjo3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOjo3.Click += new System.EventHandler(this.btnOjo3_Click);
			// btnActualizarPass (secundario)
			this.btnActualizarPass.BackColor = System.Drawing.Color.White;
			this.btnActualizarPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnActualizarPass.FlatAppearance.BorderSize = 1;
			this.btnActualizarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizarPass.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.btnActualizarPass.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnActualizarPass.Location = new System.Drawing.Point(30, 165);
			this.btnActualizarPass.Size = new System.Drawing.Size(180, 32);
			this.btnActualizarPass.Text = "🔒  Actualizar contraseña";
			this.btnActualizarPass.UseVisualStyleBackColor = false;
			this.btnActualizarPass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizarPass.Click += new System.EventHandler(this.btnActualizarPass_Click);
			// pnlPref
			this.pnlPref.BackColor = System.Drawing.Color.White;
			this.pnlPref.Location = new System.Drawing.Point(24, 527);
			this.pnlPref.Size = new System.Drawing.Size(700, 140);
			this.pnlPref.Controls.Add(this.lblSecPref);
			this.pnlPref.Controls.Add(this.chkTema);
			this.pnlPref.Controls.Add(this.lblHintTema);
			this.pnlPref.Controls.Add(this.chkNotifs);
			this.pnlPref.Controls.Add(this.lblHintNotifs);
			this.pnlPref.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSecPref
			this.lblSecPref.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSecPref.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSecPref.Location = new System.Drawing.Point(30, 18);
			this.lblSecPref.Size = new System.Drawing.Size(300, 20);
			this.lblSecPref.Text = "PREFERENCIAS";
			// chkTema
			this.chkTema.AutoSize = true;
			this.chkTema.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.chkTema.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.chkTema.Location = new System.Drawing.Point(30, 48);
			this.chkTema.Text = "Tema oscuro";
			this.chkTema.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkTema.CheckedChanged += new System.EventHandler(this.chkTema_CheckedChanged);
			// lblHintTema
			this.lblHintTema.Font = new System.Drawing.Font("Segoe UI", 7.5F);
			this.lblHintTema.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblHintTema.Location = new System.Drawing.Point(48, 70);
			this.lblHintTema.Size = new System.Drawing.Size(300, 15);
			this.lblHintTema.Text = "Cambia la apariencia del sistema";
			// chkNotifs
			this.chkNotifs.AutoSize = true;
			this.chkNotifs.Checked = true;
			this.chkNotifs.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.chkNotifs.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.chkNotifs.Location = new System.Drawing.Point(30, 95);
			this.chkNotifs.Text = "Notificaciones del sistema";
			this.chkNotifs.Cursor = System.Windows.Forms.Cursors.Hand;
			// lblHintNotifs
			this.lblHintNotifs.Font = new System.Drawing.Font("Segoe UI", 7.5F);
			this.lblHintNotifs.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblHintNotifs.Location = new System.Drawing.Point(48, 117);
			this.lblHintNotifs.Size = new System.Drawing.Size(300, 15);
			this.lblHintNotifs.Text = "Recibir alertas y recordatorios";
			// btnCerrarSesion (borde rojo error según guía)
			this.btnCerrarSesion.BackColor = System.Drawing.Color.White;
			this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
			this.btnCerrarSesion.FlatAppearance.BorderSize = 1;
			this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
			this.btnCerrarSesion.Location = new System.Drawing.Point(24, 685);
			this.btnCerrarSesion.Size = new System.Drawing.Size(150, 40);
			this.btnCerrarSesion.Text = "⇥  Cerrar sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// btnGuardar (primario)
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnGuardar.ForeColor = System.Drawing.Color.White;
			this.btnGuardar.Location = new System.Drawing.Point(554, 685);
			this.btnGuardar.Size = new System.Drawing.Size(170, 40);
			this.btnGuardar.Text = "💾  Guardar cambios";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// FrmConfiguracion
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
			this.ClientSize = new System.Drawing.Size(1000, 630);
			this.Controls.Add(this.pnlPerfil);
			this.Controls.Add(this.pnlPass);
			this.Controls.Add(this.pnlPref);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnGuardar);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
			this.pnlPerfil.ResumeLayout(false);
			this.pnlPerfil.PerformLayout();
			this.pnlPass.ResumeLayout(false);
			this.pnlPass.PerformLayout();
			this.pnlPref.ResumeLayout(false);
			this.pnlPref.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel pnlPerfil;
		private System.Windows.Forms.Label lblSecPerfil;
		private System.Windows.Forms.Label lblAvatar;
		private System.Windows.Forms.Label lblNombreCompleto;
		private System.Windows.Forms.Label lblClaveRol;
		private System.Windows.Forms.Label lblExtra;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblApellidos;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Panel pnlPass;
		private System.Windows.Forms.Label lblSecPass;
		private System.Windows.Forms.Label lblPassActual;
		private System.Windows.Forms.TextBox txtPassActual;
		private System.Windows.Forms.Button btnOjo1;
		private System.Windows.Forms.Label lblPassNueva;
		private System.Windows.Forms.TextBox txtPassNueva;
		private System.Windows.Forms.Button btnOjo2;
		private System.Windows.Forms.Label lblPassConfirmar;
		private System.Windows.Forms.TextBox txtPassConfirmar;
		private System.Windows.Forms.Button btnOjo3;
		private System.Windows.Forms.Button btnActualizarPass;
		private System.Windows.Forms.Panel pnlPref;
		private System.Windows.Forms.Label lblSecPref;
		private System.Windows.Forms.CheckBox chkTema;
		private System.Windows.Forms.Label lblHintTema;
		private System.Windows.Forms.CheckBox chkNotifs;
		private System.Windows.Forms.Label lblHintNotifs;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Button btnGuardar;

		#endregion
	}
}
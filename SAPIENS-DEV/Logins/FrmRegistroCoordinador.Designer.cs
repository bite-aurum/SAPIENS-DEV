namespace SAPIENS_DEV.Logins
{
    partial class FrmRegistroCoordinador
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
            this.Text = "FrmRegistroCoordinador";
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lnkVolver = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBadge = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // pnlCard
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(230, 175);
            this.pnlCard.Size = new System.Drawing.Size(440, 370);
            this.pnlCard.Controls.Add(this.lnkVolver);
            this.pnlCard.Controls.Add(this.lblTitulo);
            this.pnlCard.Controls.Add(this.lblBadge);
            this.pnlCard.Controls.Add(this.lblNombre);
            this.pnlCard.Controls.Add(this.txtNombre);
            this.pnlCard.Controls.Add(this.lblApellidos);
            this.pnlCard.Controls.Add(this.txtApellidos);
            this.pnlCard.Controls.Add(this.lblCorreo);
            this.pnlCard.Controls.Add(this.txtCorreo);
            this.pnlCard.Controls.Add(this.lblPass);
            this.pnlCard.Controls.Add(this.txtPass);
            this.pnlCard.Controls.Add(this.lblConfirmar);
            this.pnlCard.Controls.Add(this.txtConfirmar);
            this.pnlCard.Controls.Add(this.btnCrear);
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lnkVolver
            this.lnkVolver.AutoSize = true;
            this.lnkVolver.LinkColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lnkVolver.Location = new System.Drawing.Point(30, 20);
            this.lnkVolver.Text = "← Volver";
            this.lnkVolver.Click += new System.EventHandler(this.lnkVolver_Click);
            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblTitulo.Location = new System.Drawing.Point(0, 45);
            this.lblTitulo.Size = new System.Drawing.Size(440, 30);
            this.lblTitulo.Text = "Registro de coordinador";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblBadge (rol Coordinador: texto #10B981, fondo #ECFDF5)
            this.lblBadge.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.lblBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBadge.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblBadge.Location = new System.Drawing.Point(145, 78);
            this.lblBadge.Size = new System.Drawing.Size(150, 20);
            this.lblBadge.Text = "🛡 Coordinador académico";
            this.lblBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblNombre.Location = new System.Drawing.Point(30, 115);
            this.lblNombre.Text = "Nombre";
            // txtNombre
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(30, 135);
            this.txtNombre.Size = new System.Drawing.Size(185, 25);
            // lblApellidos
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblApellidos.Location = new System.Drawing.Point(225, 115);
            this.lblApellidos.Text = "Apellidos";
            // txtApellidos
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellidos.Location = new System.Drawing.Point(225, 135);
            this.txtApellidos.Size = new System.Drawing.Size(185, 25);
            // lblCorreo
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblCorreo.Location = new System.Drawing.Point(30, 175);
            this.lblCorreo.Text = "Correo electrónico";
            // txtCorreo
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreo.Location = new System.Drawing.Point(30, 195);
            this.txtCorreo.Size = new System.Drawing.Size(380, 25);
            // lblPass
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPass.Location = new System.Drawing.Point(30, 235);
            this.lblPass.Text = "Contraseña";
            // txtPass
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPass.Location = new System.Drawing.Point(30, 255);
            this.txtPass.Size = new System.Drawing.Size(185, 25);
            this.txtPass.UseSystemPasswordChar = true;
            // lblConfirmar
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblConfirmar.Location = new System.Drawing.Point(225, 235);
            this.lblConfirmar.Text = "Confirmar contraseña";
            // txtConfirmar
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmar.Location = new System.Drawing.Point(225, 255);
            this.txtConfirmar.Size = new System.Drawing.Size(185, 25);
            this.txtConfirmar.UseSystemPasswordChar = true;
            // btnCrear
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(30, 305);
            this.btnCrear.Size = new System.Drawing.Size(380, 40);
            this.btnCrear.Text = "Crear cuenta";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // FrmRegistroCoordinador
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAPIENS — Registro de coordinador";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.LinkLabel lnkVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBadge;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnCrear;
        #endregion
    }
}
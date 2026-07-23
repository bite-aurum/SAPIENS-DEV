namespace SAPIENS_DEV.PantallasCoordinador
{
    partial class FrmMenuCoordinador
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
            this.Text = "FrmMenuCoordinador";
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.lblEstadoIzq = new System.Windows.Forms.Label();
            this.lblEstadoDer = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblLogoIcono = new System.Windows.Forms.Label();
            this.lblLogoTexto = new System.Windows.Forms.Label();
            this.btnRendimiento = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlEstado.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // pnlEstado
            this.pnlEstado.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.pnlEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEstado.Height = 24;
            this.pnlEstado.Controls.Add(this.lblEstadoIzq);
            this.pnlEstado.Controls.Add(this.lblEstadoDer);
            // lblEstadoIzq
            this.lblEstadoIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEstadoIzq.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstadoIzq.ForeColor = System.Drawing.Color.White;
            this.lblEstadoIzq.Width = 400;
            this.lblEstadoIzq.Text = "   Rol: Coordinador";
            this.lblEstadoIzq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // lblEstadoDer
            this.lblEstadoDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEstadoDer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstadoDer.ForeColor = System.Drawing.Color.White;
            this.lblEstadoDer.Width = 200;
            this.lblEstadoDer.Text = "v1.0.0   ";
            this.lblEstadoDer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // pnlMenu
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Width = 220;
            this.pnlMenu.Controls.Add(this.lblLogoIcono);
            this.pnlMenu.Controls.Add(this.lblLogoTexto);
            this.pnlMenu.Controls.Add(this.btnRendimiento);
            this.pnlMenu.Controls.Add(this.btnDocentes);
            this.pnlMenu.Controls.Add(this.btnProyectos);
            this.pnlMenu.Controls.Add(this.btnConfiguracion);
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // lblLogoIcono
            this.lblLogoIcono.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblLogoIcono.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogoIcono.ForeColor = System.Drawing.Color.White;
            this.lblLogoIcono.Location = new System.Drawing.Point(16, 16);
            this.lblLogoIcono.Size = new System.Drawing.Size(32, 32);
            this.lblLogoIcono.Text = "S";
            this.lblLogoIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblLogoTexto
            this.lblLogoTexto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogoTexto.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblLogoTexto.Location = new System.Drawing.Point(56, 18);
            this.lblLogoTexto.Size = new System.Drawing.Size(150, 28);
            this.lblLogoTexto.Text = "SAPIENS";
            // btnRendimiento
            this.btnRendimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRendimiento.FlatAppearance.BorderSize = 0;
            this.btnRendimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRendimiento.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnRendimiento.Location = new System.Drawing.Point(0, 70);
            this.btnRendimiento.Size = new System.Drawing.Size(220, 48);
            this.btnRendimiento.Text = "   📊  Rendimiento";
            this.btnRendimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRendimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRendimiento.Click += new System.EventHandler(this.btnRendimiento_Click);
            // btnDocentes
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDocentes.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnDocentes.Location = new System.Drawing.Point(0, 118);
            this.btnDocentes.Size = new System.Drawing.Size(220, 48);
            this.btnDocentes.Text = "   👥  Docentes";
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // btnProyectos
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProyectos.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnProyectos.Location = new System.Drawing.Point(0, 166);
            this.btnProyectos.Size = new System.Drawing.Size(220, 48);
            this.btnProyectos.Text = "   📁  Proyectos";
            this.btnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // btnConfiguracion
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfiguracion.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnConfiguracion.Height = 48;
            this.btnConfiguracion.Text = "   ⚙  Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblAvatar);
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitulo.Location = new System.Drawing.Point(24, 10);
            this.lblTitulo.Size = new System.Drawing.Size(700, 28);
            this.lblTitulo.Text = "Panel de coordinación";
            // lblSubtitulo
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 38);
            this.lblSubtitulo.Size = new System.Drawing.Size(500, 18);
            this.lblSubtitulo.Text = "";
            // lblAvatar (identificador de rol coordinador: verde #10B981)
            this.lblAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvatar.ForeColor = System.Drawing.Color.White;
            this.lblAvatar.Location = new System.Drawing.Point(944, 16);
            this.lblAvatar.Size = new System.Drawing.Size(32, 32);
            this.lblAvatar.Text = "CO";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // pnlContenido
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            // FrmMenuCoordinador
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 720);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlEstado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAPIENS";
            this.Load += new System.EventHandler(this.FrmMenuCoordinador_Load);
            this.pnlEstado.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Label lblEstadoIzq;
        private System.Windows.Forms.Label lblEstadoDer;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblLogoIcono;
        private System.Windows.Forms.Label lblLogoTexto;
        private System.Windows.Forms.Button btnRendimiento;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Panel pnlContenido;

        #endregion
    }
}
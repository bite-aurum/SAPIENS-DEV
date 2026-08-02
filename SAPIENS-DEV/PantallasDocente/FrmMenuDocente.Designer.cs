namespace SAPIENS_DEV.PantallasDocente
{
	partial class FrmMenuDocente
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
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.lblEstadoIzq = new System.Windows.Forms.Label();
            this.lblEstadoDer = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblLogoIcono = new System.Windows.Forms.Label();
            this.lblLogoTexto = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnEntregas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlEstado.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.pnlEstado.Controls.Add(this.lblEstadoIzq);
            this.pnlEstado.Controls.Add(this.lblEstadoDer);
            this.pnlEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEstado.Location = new System.Drawing.Point(0, 696);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(1220, 24);
            this.pnlEstado.TabIndex = 3;
            // 
            // lblEstadoIzq
            // 
            this.lblEstadoIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEstadoIzq.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstadoIzq.ForeColor = System.Drawing.Color.White;
            this.lblEstadoIzq.Location = new System.Drawing.Point(0, 0);
            this.lblEstadoIzq.Name = "lblEstadoIzq";
            this.lblEstadoIzq.Size = new System.Drawing.Size(400, 24);
            this.lblEstadoIzq.TabIndex = 0;
            this.lblEstadoIzq.Text = "   Rol: Docente";
            this.lblEstadoIzq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstadoDer
            // 
            this.lblEstadoDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEstadoDer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstadoDer.ForeColor = System.Drawing.Color.White;
            this.lblEstadoDer.Location = new System.Drawing.Point(1020, 0);
            this.lblEstadoDer.Name = "lblEstadoDer";
            this.lblEstadoDer.Size = new System.Drawing.Size(200, 24);
            this.lblEstadoDer.TabIndex = 1;
            this.lblEstadoDer.Text = "Conectado · v1.0.0   ";
            this.lblEstadoDer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.lblLogoIcono);
            this.pnlMenu.Controls.Add(this.lblLogoTexto);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnProyectos);
            this.pnlMenu.Controls.Add(this.btnTareas);
            this.pnlMenu.Controls.Add(this.btnEntregas);
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.btnNotificaciones);
            this.pnlMenu.Controls.Add(this.btnConfiguracion);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 696);
            this.pnlMenu.TabIndex = 2;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // lblLogoIcono
            // 
            this.lblLogoIcono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblLogoIcono.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogoIcono.ForeColor = System.Drawing.Color.White;
            this.lblLogoIcono.Location = new System.Drawing.Point(16, 16);
            this.lblLogoIcono.Name = "lblLogoIcono";
            this.lblLogoIcono.Size = new System.Drawing.Size(32, 32);
            this.lblLogoIcono.TabIndex = 0;
            this.lblLogoIcono.Text = "S";
            this.lblLogoIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogoTexto
            // 
            this.lblLogoTexto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogoTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblLogoTexto.Location = new System.Drawing.Point(56, 18);
            this.lblLogoTexto.Name = "lblLogoTexto";
            this.lblLogoTexto.Size = new System.Drawing.Size(150, 28);
            this.lblLogoTexto.TabIndex = 1;
            this.lblLogoTexto.Text = "SAPIENS";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 70);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 48);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProyectos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnProyectos.Location = new System.Drawing.Point(0, 118);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(220, 48);
            this.btnProyectos.TabIndex = 3;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnTareas.Location = new System.Drawing.Point(0, 166);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(220, 48);
            this.btnTareas.TabIndex = 4;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnEntregas
            // 
            this.btnEntregas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntregas.FlatAppearance.BorderSize = 0;
            this.btnEntregas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEntregas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnEntregas.Location = new System.Drawing.Point(0, 214);
            this.btnEntregas.Name = "btnEntregas";
            this.btnEntregas.Size = new System.Drawing.Size(220, 48);
            this.btnEntregas.TabIndex = 5;
            this.btnEntregas.Text = "Entregas";
            this.btnEntregas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntregas.Click += new System.EventHandler(this.btnEntregas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnReportes.Location = new System.Drawing.Point(0, 262);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(220, 48);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNotificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnNotificaciones.Location = new System.Drawing.Point(0, 310);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(220, 48);
            this.btnNotificaciones.TabIndex = 7;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConfiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 648);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(220, 48);
            this.btnConfiguracion.TabIndex = 8;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 64);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitulo.Location = new System.Drawing.Point(24, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Dashboard";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(220, 64);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1000, 632);
            this.pnlContenido.TabIndex = 0;
            //this.pnlContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenido_Paint);
            // 
            // FrmMenuDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 720);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlEstado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmMenuDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAPIENS — Sistema de Gestión de Proyectos Académicos";
            this.Load += new System.EventHandler(this.FrmMenuDocente_Load);
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
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnProyectos;
		private System.Windows.Forms.Button btnTareas;
		private System.Windows.Forms.Button btnEntregas;
		private System.Windows.Forms.Button btnReportes;
		private System.Windows.Forms.Button btnNotificaciones;
		private System.Windows.Forms.Button btnConfiguracion;
		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel pnlContenido;
		#endregion
	}
}
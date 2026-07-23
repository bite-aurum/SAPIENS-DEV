namespace SAPIENS_DEV.PantallasAlumno
{
	partial class FrmDetalleEntregaAlumno
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
			this.Text = "FrmDetalleEntregaAlumno";
			this.btnVolver = new System.Windows.Forms.Button();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.pnlSubir = new System.Windows.Forms.Panel();
			this.lblSecSubir = new System.Windows.Forms.Label();
			this.pnlDrop = new System.Windows.Forms.Panel();
			this.lblDropIco = new System.Windows.Forms.Label();
			this.lblDrop1 = new System.Windows.Forms.Label();
			this.lblDrop2 = new System.Windows.Forms.Label();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.lblArchivoSel = new System.Windows.Forms.Label();
			this.lblNota = new System.Windows.Forms.Label();
			this.btnSubir = new System.Windows.Forms.Button();
			this.pnlArchivos = new System.Windows.Forms.Panel();
			this.lblSecArchivos = new System.Windows.Forms.Label();
			this.flpArchivos = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlInfoEnt = new System.Windows.Forms.Panel();
			this.lblSecInfoEnt = new System.Windows.Forms.Label();
			this.flpInfoEnt = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlSubir.SuspendLayout();
			this.pnlDrop.SuspendLayout();
			this.pnlArchivos.SuspendLayout();
			this.pnlInfoEnt.SuspendLayout();
			this.SuspendLayout();
			// btnVolver
			this.btnVolver.BackColor = System.Drawing.Color.White;
			this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
			this.btnVolver.FlatAppearance.BorderSize = 1;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.btnVolver.Location = new System.Drawing.Point(24, 16);
			this.btnVolver.Size = new System.Drawing.Size(90, 30);
			this.btnVolver.Text = "←  Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// pnlInfo
			this.pnlInfo.BackColor = System.Drawing.Color.White;
			this.pnlInfo.Location = new System.Drawing.Point(24, 56);
			this.pnlInfo.Size = new System.Drawing.Size(950, 85);
			this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// pnlSubir
			this.pnlSubir.BackColor = System.Drawing.Color.White;
			this.pnlSubir.Location = new System.Drawing.Point(24, 155);
			this.pnlSubir.Size = new System.Drawing.Size(465, 420);
			this.pnlSubir.Controls.Add(this.lblSecSubir);
			this.pnlSubir.Controls.Add(this.pnlDrop);
			this.pnlSubir.Controls.Add(this.lblArchivoSel);
			this.pnlSubir.Controls.Add(this.lblNota);
			this.pnlSubir.Controls.Add(this.btnSubir);
			this.pnlSubir.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSecSubir
			this.lblSecSubir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSecSubir.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSecSubir.Location = new System.Drawing.Point(20, 16);
			this.lblSecSubir.Size = new System.Drawing.Size(300, 20);
			this.lblSecSubir.Text = "SUBIR ARCHIVO";
			// pnlDrop
			this.pnlDrop.AllowDrop = true;
			this.pnlDrop.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
			this.pnlDrop.Location = new System.Drawing.Point(20, 45);
			this.pnlDrop.Size = new System.Drawing.Size(425, 190);
			this.pnlDrop.Controls.Add(this.lblDropIco);
			this.pnlDrop.Controls.Add(this.lblDrop1);
			this.pnlDrop.Controls.Add(this.lblDrop2);
			this.pnlDrop.Controls.Add(this.btnSeleccionar);
			this.pnlDrop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrop_Paint);
			this.pnlDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDrop_DragEnter);
			this.pnlDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDrop_DragDrop);
			// lblDropIco
			this.lblDropIco.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.lblDropIco.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
			this.lblDropIco.Location = new System.Drawing.Point(0, 25);
			this.lblDropIco.Size = new System.Drawing.Size(425, 30);
			this.lblDropIco.Text = "⇪";
			this.lblDropIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// lblDrop1
			this.lblDrop1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblDrop1.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblDrop1.Location = new System.Drawing.Point(0, 62);
			this.lblDrop1.Size = new System.Drawing.Size(425, 18);
			this.lblDrop1.Text = "Arrastra tu archivo aquí";
			this.lblDrop1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// lblDrop2
			this.lblDrop2.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblDrop2.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblDrop2.Location = new System.Drawing.Point(0, 82);
			this.lblDrop2.Size = new System.Drawing.Size(425, 16);
			this.lblDrop2.Text = "o selecciona desde tu equipo";
			this.lblDrop2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// btnSeleccionar
			this.btnSeleccionar.BackColor = System.Drawing.Color.White;
			this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnSeleccionar.FlatAppearance.BorderSize = 1;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.btnSeleccionar.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnSeleccionar.Location = new System.Drawing.Point(132, 115);
			this.btnSeleccionar.Size = new System.Drawing.Size(160, 30);
			this.btnSeleccionar.Text = "⇪  Seleccionar archivo";
			this.btnSeleccionar.UseVisualStyleBackColor = false;
			this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// lblArchivoSel
			this.lblArchivoSel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
			this.lblArchivoSel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblArchivoSel.Location = new System.Drawing.Point(20, 245);
			this.lblArchivoSel.Size = new System.Drawing.Size(425, 18);
			this.lblArchivoSel.Text = "Ningún archivo seleccionado";
			// lblNota
			this.lblNota.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
			this.lblNota.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblNota.Location = new System.Drawing.Point(20, 268);
			this.lblNota.Size = new System.Drawing.Size(425, 30);
			this.lblNota.Text = "ⓘ Al subir el archivo la entrega se marcará como Entregada automáticamente y el docente podrá verla.";
			// btnSubir
			this.btnSubir.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnSubir.FlatAppearance.BorderSize = 0;
			this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSubir.ForeColor = System.Drawing.Color.White;
			this.btnSubir.Location = new System.Drawing.Point(20, 310);
			this.btnSubir.Size = new System.Drawing.Size(425, 40);
			this.btnSubir.Text = "⇪  Subir archivo";
			this.btnSubir.UseVisualStyleBackColor = false;
			this.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
			// pnlArchivos
			this.pnlArchivos.BackColor = System.Drawing.Color.White;
			this.pnlArchivos.Location = new System.Drawing.Point(510, 155);
			this.pnlArchivos.Size = new System.Drawing.Size(464, 160);
			this.pnlArchivos.Controls.Add(this.lblSecArchivos);
			this.pnlArchivos.Controls.Add(this.flpArchivos);
			this.pnlArchivos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSecArchivos
			this.lblSecArchivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSecArchivos.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSecArchivos.Location = new System.Drawing.Point(20, 16);
			this.lblSecArchivos.Size = new System.Drawing.Size(300, 20);
			this.lblSecArchivos.Text = "ARCHIVOS SUBIDOS";
			// flpArchivos
			this.flpArchivos.AutoScroll = true;
			this.flpArchivos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpArchivos.WrapContents = false;
			this.flpArchivos.Location = new System.Drawing.Point(20, 45);
			this.flpArchivos.Size = new System.Drawing.Size(425, 100);
			// pnlInfoEnt
			this.pnlInfoEnt.BackColor = System.Drawing.Color.White;
			this.pnlInfoEnt.Location = new System.Drawing.Point(510, 328);
			this.pnlInfoEnt.Size = new System.Drawing.Size(464, 247);
			this.pnlInfoEnt.Controls.Add(this.lblSecInfoEnt);
			this.pnlInfoEnt.Controls.Add(this.flpInfoEnt);
			this.pnlInfoEnt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			// lblSecInfoEnt
			this.lblSecInfoEnt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.lblSecInfoEnt.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblSecInfoEnt.Location = new System.Drawing.Point(20, 16);
			this.lblSecInfoEnt.Size = new System.Drawing.Size(300, 20);
			this.lblSecInfoEnt.Text = "INFO DE LA ENTREGA";
			// flpInfoEnt
			this.flpInfoEnt.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpInfoEnt.WrapContents = false;
			this.flpInfoEnt.Location = new System.Drawing.Point(20, 45);
			this.flpInfoEnt.Size = new System.Drawing.Size(425, 185);
			// FrmDetalleEntregaAlumno
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
			this.ClientSize = new System.Drawing.Size(1000, 630);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.pnlSubir);
			this.Controls.Add(this.pnlArchivos);
			this.Controls.Add(this.pnlInfoEnt);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Load += new System.EventHandler(this.FrmDetalleEntregaAlumno_Load);
			this.pnlSubir.ResumeLayout(false);
			this.pnlDrop.ResumeLayout(false);
			this.pnlArchivos.ResumeLayout(false);
			this.pnlInfoEnt.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Panel pnlSubir;
		private System.Windows.Forms.Label lblSecSubir;
		private System.Windows.Forms.Panel pnlDrop;
		private System.Windows.Forms.Label lblDropIco;
		private System.Windows.Forms.Label lblDrop1;
		private System.Windows.Forms.Label lblDrop2;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Label lblArchivoSel;
		private System.Windows.Forms.Label lblNota;
		private System.Windows.Forms.Button btnSubir;
		private System.Windows.Forms.Panel pnlArchivos;
		private System.Windows.Forms.Label lblSecArchivos;
		private System.Windows.Forms.FlowLayoutPanel flpArchivos;
		private System.Windows.Forms.Panel pnlInfoEnt;
		private System.Windows.Forms.Label lblSecInfoEnt;
		private System.Windows.Forms.FlowLayoutPanel flpInfoEnt;


		#endregion
	}
}
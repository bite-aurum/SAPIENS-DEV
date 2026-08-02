namespace SAPIENS_DEV.PantallasDocente
{
	partial class FrmDashboardDocente
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
			this.Text = "FrmDashboardDocente";
			this.pnlCard1 = new System.Windows.Forms.Panel();
			this.lblTitProyectos = new System.Windows.Forms.Label();
			this.lblValProyectos = new System.Windows.Forms.Label();
			this.lblIcoProyectos = new System.Windows.Forms.Label();
			this.pnlCard2 = new System.Windows.Forms.Panel();
			this.lblTitTareas = new System.Windows.Forms.Label();
			this.lblValTareas = new System.Windows.Forms.Label();
			this.lblIcoTareas = new System.Windows.Forms.Label();
			this.pnlCard3 = new System.Windows.Forms.Panel();
			this.lblTitEntregas = new System.Windows.Forms.Label();
			this.lblValEntregas = new System.Windows.Forms.Label();
			this.lblIcoEntregas = new System.Windows.Forms.Label();
			this.pnlCard4 = new System.Windows.Forms.Panel();
			this.lblTitAlumnos = new System.Windows.Forms.Label();
			this.lblValAlumnos = new System.Windows.Forms.Label();
			this.lblIcoAlumnos = new System.Windows.Forms.Label();
			this.lblTareasRec = new System.Windows.Forms.Label();
			this.dgvTareas = new System.Windows.Forms.DataGridView();
			this.lblActividad = new System.Windows.Forms.Label();
			this.lstActividad = new System.Windows.Forms.ListBox();
			this.pnlCard1.SuspendLayout();
			this.pnlCard2.SuspendLayout();
			this.pnlCard3.SuspendLayout();
			this.pnlCard4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
			this.SuspendLayout();
			// pnlCard1 — Proyectos activos
			this.pnlCard1.BackColor = System.Drawing.Color.White;
			this.pnlCard1.Location = new System.Drawing.Point(24, 24);
			this.pnlCard1.Size = new System.Drawing.Size(225, 90);
			this.pnlCard1.Controls.Add(this.lblTitProyectos);
			this.pnlCard1.Controls.Add(this.lblValProyectos);
			this.pnlCard1.Controls.Add(this.lblIcoProyectos);
			this.pnlCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			this.lblTitProyectos.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblTitProyectos.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblTitProyectos.Location = new System.Drawing.Point(16, 14);
			this.lblTitProyectos.Size = new System.Drawing.Size(150, 18);
			this.lblTitProyectos.Text = "Proyectos activos";
			this.lblValProyectos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblValProyectos.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblValProyectos.Location = new System.Drawing.Point(14, 36);
			this.lblValProyectos.Size = new System.Drawing.Size(120, 40);
			this.lblValProyectos.Text = "0";
			this.lblIcoProyectos.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.lblIcoProyectos.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.lblIcoProyectos.Location = new System.Drawing.Point(175, 30);
			this.lblIcoProyectos.Size = new System.Drawing.Size(36, 32);
			this.lblIcoProyectos.Text = "";
			// pnlCard2 — Tareas asignadas
			this.pnlCard2.BackColor = System.Drawing.Color.White;
			this.pnlCard2.Location = new System.Drawing.Point(264, 24);
			this.pnlCard2.Size = new System.Drawing.Size(225, 90);
			this.pnlCard2.Controls.Add(this.lblTitTareas);
			this.pnlCard2.Controls.Add(this.lblValTareas);
			this.pnlCard2.Controls.Add(this.lblIcoTareas);
			this.pnlCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			this.lblTitTareas.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblTitTareas.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblTitTareas.Location = new System.Drawing.Point(16, 14);
			this.lblTitTareas.Size = new System.Drawing.Size(150, 18);
			this.lblTitTareas.Text = "Tareas asignadas";
			this.lblValTareas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblValTareas.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblValTareas.Location = new System.Drawing.Point(14, 36);
			this.lblValTareas.Size = new System.Drawing.Size(120, 40);
			this.lblValTareas.Text = "0";
			this.lblIcoTareas.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.lblIcoTareas.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.lblIcoTareas.Location = new System.Drawing.Point(175, 30);
			this.lblIcoTareas.Size = new System.Drawing.Size(36, 32);
			this.lblIcoTareas.Text = "";
			// pnlCard3 — Entregas pendientes
			this.pnlCard3.BackColor = System.Drawing.Color.White;
			this.pnlCard3.Location = new System.Drawing.Point(504, 24);
			this.pnlCard3.Size = new System.Drawing.Size(225, 90);
			this.pnlCard3.Controls.Add(this.lblTitEntregas);
			this.pnlCard3.Controls.Add(this.lblValEntregas);
			this.pnlCard3.Controls.Add(this.lblIcoEntregas);
			this.pnlCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			this.lblTitEntregas.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblTitEntregas.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblTitEntregas.Location = new System.Drawing.Point(16, 14);
			this.lblTitEntregas.Size = new System.Drawing.Size(150, 18);
			this.lblTitEntregas.Text = "Entregas pendientes";
			this.lblValEntregas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblValEntregas.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblValEntregas.Location = new System.Drawing.Point(14, 36);
			this.lblValEntregas.Size = new System.Drawing.Size(120, 40);
			this.lblValEntregas.Text = "0";
			this.lblIcoEntregas.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.lblIcoEntregas.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
			this.lblIcoEntregas.Location = new System.Drawing.Point(175, 30);
			this.lblIcoEntregas.Size = new System.Drawing.Size(36, 32);
			this.lblIcoEntregas.Text = "";
			// pnlCard4 — Alumnos activos
			this.pnlCard4.BackColor = System.Drawing.Color.White;
			this.pnlCard4.Location = new System.Drawing.Point(744, 24);
			this.pnlCard4.Size = new System.Drawing.Size(225, 90);
			this.pnlCard4.Controls.Add(this.lblTitAlumnos);
			this.pnlCard4.Controls.Add(this.lblValAlumnos);
			this.pnlCard4.Controls.Add(this.lblIcoAlumnos);
			this.pnlCard4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			this.lblTitAlumnos.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblTitAlumnos.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblTitAlumnos.Location = new System.Drawing.Point(16, 14);
			this.lblTitAlumnos.Size = new System.Drawing.Size(150, 18);
			this.lblTitAlumnos.Text = "Alumnos activos";
			this.lblValAlumnos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblValAlumnos.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblValAlumnos.Location = new System.Drawing.Point(14, 36);
			this.lblValAlumnos.Size = new System.Drawing.Size(120, 40);
			this.lblValAlumnos.Text = "0";
			this.lblIcoAlumnos.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.lblIcoAlumnos.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
			this.lblIcoAlumnos.Location = new System.Drawing.Point(175, 30);
			this.lblIcoAlumnos.Size = new System.Drawing.Size(36, 32);
			this.lblIcoAlumnos.Text = "";
			// lblTareasRec
			this.lblTareasRec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblTareasRec.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblTareasRec.Location = new System.Drawing.Point(24, 134);
			this.lblTareasRec.Size = new System.Drawing.Size(300, 24);
			this.lblTareasRec.Text = "Tareas recientes";
			// dgvTareas
			this.dgvTareas.Location = new System.Drawing.Point(24, 162);
			this.dgvTareas.Size = new System.Drawing.Size(465, 300);
			// lblActividad
			this.lblActividad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblActividad.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblActividad.Location = new System.Drawing.Point(504, 134);
			this.lblActividad.Size = new System.Drawing.Size(300, 24);
			this.lblActividad.Text = "Actividad reciente";
			// lstActividad
			this.lstActividad.BackColor = System.Drawing.Color.White;
			this.lstActividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstActividad.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lstActividad.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lstActividad.ItemHeight = 28;
			this.lstActividad.Location = new System.Drawing.Point(504, 162);
			this.lstActividad.Size = new System.Drawing.Size(465, 300);
			// FrmDashboardDocente
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
			this.ClientSize = new System.Drawing.Size(1000, 630);
			this.Controls.Add(this.pnlCard1);
			this.Controls.Add(this.pnlCard2);
			this.Controls.Add(this.pnlCard3);
			this.Controls.Add(this.pnlCard4);
			this.Controls.Add(this.lblTareasRec);
			this.Controls.Add(this.dgvTareas);
			this.Controls.Add(this.lblActividad);
			this.Controls.Add(this.lstActividad);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Load += new System.EventHandler(this.FrmDashboardDocente_Load);
			this.pnlCard1.ResumeLayout(false);
			this.pnlCard2.ResumeLayout(false);
			this.pnlCard3.ResumeLayout(false);
			this.pnlCard4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel pnlCard1;
		private System.Windows.Forms.Label lblTitProyectos;
		private System.Windows.Forms.Label lblValProyectos;
		private System.Windows.Forms.Label lblIcoProyectos;
		private System.Windows.Forms.Panel pnlCard2;
		private System.Windows.Forms.Label lblTitTareas;
		private System.Windows.Forms.Label lblValTareas;
		private System.Windows.Forms.Label lblIcoTareas;
		private System.Windows.Forms.Panel pnlCard3;
		private System.Windows.Forms.Label lblTitEntregas;
		private System.Windows.Forms.Label lblValEntregas;
		private System.Windows.Forms.Label lblIcoEntregas;
		private System.Windows.Forms.Panel pnlCard4;
		private System.Windows.Forms.Label lblTitAlumnos;
		private System.Windows.Forms.Label lblValAlumnos;
		private System.Windows.Forms.Label lblIcoAlumnos;
		private System.Windows.Forms.Label lblTareasRec;
		private System.Windows.Forms.DataGridView dgvTareas;
		private System.Windows.Forms.Label lblActividad;
		private System.Windows.Forms.ListBox lstActividad;
		#endregion
	}
}
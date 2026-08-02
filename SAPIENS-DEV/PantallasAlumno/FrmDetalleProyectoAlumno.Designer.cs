namespace SAPIENS_DEV.PantallasAlumno
{
	partial class FrmDetalleProyectoAlumno
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
			this.Text = "FrmDetalleProyectoAlumno";
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlEquipo = new System.Windows.Forms.Panel();
            this.lblSecEquipo = new System.Windows.Forms.Label();
            this.flpEquipo = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEntregas = new System.Windows.Forms.Panel();
            this.lblSecEntregas = new System.Windows.Forms.Label();
            this.flpEntregas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTareas = new System.Windows.Forms.Panel();
            this.lblSecTareas = new System.Windows.Forms.Label();
            this.flpTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEquipo.SuspendLayout();
            this.pnlEntregas.SuspendLayout();
            this.pnlTareas.SuspendLayout();
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
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // pnlInfo
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(24, 56);
            this.pnlInfo.Size = new System.Drawing.Size(950, 115);
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // pnlEquipo
            this.pnlEquipo.BackColor = System.Drawing.Color.White;
            this.pnlEquipo.Location = new System.Drawing.Point(24, 185);
            this.pnlEquipo.Size = new System.Drawing.Size(470, 425);
            this.pnlEquipo.Controls.Add(this.lblSecEquipo);
            this.pnlEquipo.Controls.Add(this.flpEquipo);
            this.pnlEquipo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecEquipo
            this.lblSecEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecEquipo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecEquipo.Location = new System.Drawing.Point(20, 16);
            this.lblSecEquipo.Size = new System.Drawing.Size(300, 20);
            this.lblSecEquipo.Text = "EQUIPO";
            // flpEquipo
            this.flpEquipo.AutoScroll = true;
            this.flpEquipo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEquipo.WrapContents = false;
            this.flpEquipo.Location = new System.Drawing.Point(20, 45);
            this.flpEquipo.Size = new System.Drawing.Size(430, 365);
            // pnlEntregas
            this.pnlEntregas.BackColor = System.Drawing.Color.White;
            this.pnlEntregas.Location = new System.Drawing.Point(510, 185);
            this.pnlEntregas.Size = new System.Drawing.Size(464, 175);
            this.pnlEntregas.Controls.Add(this.lblSecEntregas);
            this.pnlEntregas.Controls.Add(this.flpEntregas);
            this.pnlEntregas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecEntregas
            this.lblSecEntregas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecEntregas.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecEntregas.Location = new System.Drawing.Point(20, 16);
            this.lblSecEntregas.Size = new System.Drawing.Size(300, 20);
            this.lblSecEntregas.Text = "ENTREGAS";
            // flpEntregas
            this.flpEntregas.AutoScroll = true;
            this.flpEntregas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEntregas.WrapContents = false;
            this.flpEntregas.Location = new System.Drawing.Point(20, 45);
            this.flpEntregas.Size = new System.Drawing.Size(430, 115);
            // pnlTareas
            this.pnlTareas.BackColor = System.Drawing.Color.White;
            this.pnlTareas.Location = new System.Drawing.Point(510, 372);
            this.pnlTareas.Size = new System.Drawing.Size(464, 238);
            this.pnlTareas.Controls.Add(this.lblSecTareas);
            this.pnlTareas.Controls.Add(this.flpTareas);
            this.pnlTareas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecTareas
            this.lblSecTareas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecTareas.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecTareas.Location = new System.Drawing.Point(20, 16);
            this.lblSecTareas.Size = new System.Drawing.Size(300, 20);
            this.lblSecTareas.Text = "TAREAS";
            // flpTareas
            this.flpTareas.AutoScroll = true;
            this.flpTareas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTareas.WrapContents = false;
            this.flpTareas.Location = new System.Drawing.Point(20, 45);
            this.flpTareas.Size = new System.Drawing.Size(430, 178);
            // FrmDetalleProyectoAlumno
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlEquipo);
            this.Controls.Add(this.pnlEntregas);
            this.Controls.Add(this.pnlTareas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmDetalleProyectoAlumno_Load);
            this.pnlEquipo.ResumeLayout(false);
            this.pnlEntregas.ResumeLayout(false);
            this.pnlTareas.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlEquipo;
        private System.Windows.Forms.Label lblSecEquipo;
        private System.Windows.Forms.FlowLayoutPanel flpEquipo;
        private System.Windows.Forms.Panel pnlEntregas;
        private System.Windows.Forms.Label lblSecEntregas;
        private System.Windows.Forms.FlowLayoutPanel flpEntregas;
        private System.Windows.Forms.Panel pnlTareas;
        private System.Windows.Forms.Label lblSecTareas;
        private System.Windows.Forms.FlowLayoutPanel flpTareas;

        #endregion
    }
}
namespace SAPIENS_DEV.PantallasAlumno
{
	partial class FrmDashboardAlumno
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
			this.Text = "FrmDashboardAlumno";
			this.pnlCard1 = new System.Windows.Forms.Panel();
			this.lblTit1 = new System.Windows.Forms.Label();
			this.lblValProyectos = new System.Windows.Forms.Label();
			this.lblIco1 = new System.Windows.Forms.Label();
			this.pnlCard2 = new System.Windows.Forms.Panel();
			this.lblTit2 = new System.Windows.Forms.Label();
			this.lblValTareas = new System.Windows.Forms.Label();
			this.lblIco2 = new System.Windows.Forms.Label();
			this.pnlCard3 = new System.Windows.Forms.Panel();
			this.lblTit3 = new System.Windows.Forms.Label();
			this.lblValSubtareas = new System.Windows.Forms.Label();
			this.lblIco3 = new System.Windows.Forms.Label();
			this.pnlCard4 = new System.Windows.Forms.Panel();
			this.lblTit4 = new System.Windows.Forms.Label();
			this.lblValEntrega = new System.Windows.Forms.Label();
			this.lblIco4 = new System.Windows.Forms.Label();
			this.lblMisProy = new System.Windows.Forms.Label();
			this.lnkVerProyectos = new System.Windows.Forms.LinkLabel();
			this.flpProyectos = new System.Windows.Forms.FlowLayoutPanel();
			this.lblSubRec = new System.Windows.Forms.Label();
			this.lnkVerTareas = new System.Windows.Forms.LinkLabel();
			this.flpDerecha = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlCard1.SuspendLayout();
			this.pnlCard2.SuspendLayout();
			this.pnlCard3.SuspendLayout();
			this.pnlCard4.SuspendLayout();
			this.SuspendLayout();
			// pnlCard1 — Mis proyectos
			this.pnlCard1.BackColor = System.Drawing.Color.White;
			this.pnlCard1.Location = new System.Drawing.Point(24, 24);
			this.pnlCard1.Size = new System.Drawing.Size(225, 90);
			this.pnlCard1.Controls.Add(this.lblTit1);
			this.pnlCard1.Controls.Add(this.lblValProyectos);
			this.pnlCard1.Controls.Add(this.lblIco1);
			this.pnlCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			this.lblTit1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblTit1.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblTit1.Location = new System.Drawing.Point(16, 14);
			this.lblTit1.Size = new System.Drawing.Size(160, 18);
			this.lblTit1.Text = "Mis proyectos";
			this.lblValProyectos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblValProyectos.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblValProyectos.Location = new System.Drawing.Point(14, 36);
			this.lblValProyectos.Size = new System.Drawing.Size(120, 40);
			this.lblValProyectos.Text = "0";
			this.lblIco1.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.lblIco1.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.lblIco1.Location = new System.Drawing.Point(175, 30);
			this.lblIco1.Size = new System.Drawing.Size(36, 32);
			this.lblIco1.Text = "📁";
			// pnlCard2 — Tareas activas
			this.pnlCard2.BackColor = System.Drawing.Color.White;
			this.pnlCard2.Location = new System.Drawing.Point(264, 24);
			this.pnlCard2.Size = new System.Drawing.Size(225, 90);
			this.pnlCard2.Controls.Add(this.lblTit2);
			this.pnlCard2.Controls.Add(this.lblValTareas);
			this.pnlCard2.Controls.Add(this.lblIco2);
			this.pnlCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			this.lblTit2.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblTit2.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblTit2.Location = new System.Drawing.Point(16, 14);
			this.lblTit2.Size = new System.Drawing.Size(160, 18);
			this.lblTit2.Text = "Tareas activas";
			this.lblValTareas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblValTareas.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblValTareas.Location = new System.Drawing.Point(14, 36);
			this.lblValTareas.Size = new System.Drawing.Size(120, 40);
			this.lblValTareas.Text = "0";
			this.lblIco2.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.lblIco2.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.lblIco2.Location = new System.Drawing.Point(175, 30);
			this.lblIco2.Size = new System.Drawing.Size(36, 32);
			this.lblIco2.Text = "✅";
			// pnlCard3 — Subtareas pendientes
			this.pnlCard3.BackColor = System.Drawing.Color.White;
			this.pnlCard3.Location = new System.Drawing.Point(504, 24);
			this.pnlCard3.Size = new System.Drawing.Size(225, 90);
			this.pnlCard3.Controls.Add(this.lblTit3);
			this.pnlCard3.Controls.Add(this.lblValSubtareas);
			this.pnlCard3.Controls.Add(this.lblIco3);
			this.pnlCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			this.lblTit3.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblTit3.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblTit3.Location = new System.Drawing.Point(16, 14);
			this.lblTit3.Size = new System.Drawing.Size(160, 18);
			this.lblTit3.Text = "Subtareas pendientes";
			this.lblValSubtareas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblValSubtareas.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblValSubtareas.Location = new System.Drawing.Point(14, 36);
			this.lblValSubtareas.Size = new System.Drawing.Size(120, 40);
			this.lblValSubtareas.Text = "0";
			this.lblIco3.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.lblIco3.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
			this.lblIco3.Location = new System.Drawing.Point(175, 30);
			this.lblIco3.Size = new System.Drawing.Size(36, 32);
			this.lblIco3.Text = "📋";
			// pnlCard4 — Próxima entrega
			this.pnlCard4.BackColor = System.Drawing.Color.White;
			this.pnlCard4.Location = new System.Drawing.Point(744, 24);
			this.pnlCard4.Size = new System.Drawing.Size(225, 90);
			this.pnlCard4.Controls.Add(this.lblTit4);
			this.pnlCard4.Controls.Add(this.lblValEntrega);
			this.pnlCard4.Controls.Add(this.lblIco4);
			this.pnlCard4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
			this.lblTit4.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lblTit4.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
			this.lblTit4.Location = new System.Drawing.Point(16, 14);
			this.lblTit4.Size = new System.Drawing.Size(160, 18);
			this.lblTit4.Text = "Próxima entrega";
			this.lblValEntrega.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblValEntrega.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblValEntrega.Location = new System.Drawing.Point(14, 40);
			this.lblValEntrega.Size = new System.Drawing.Size(155, 32);
			this.lblValEntrega.Text = "—";
			this.lblIco4.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.lblIco4.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.lblIco4.Location = new System.Drawing.Point(175, 30);
			this.lblIco4.Size = new System.Drawing.Size(36, 32);
			this.lblIco4.Text = "📅";
			// lblMisProy
			this.lblMisProy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblMisProy.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblMisProy.Location = new System.Drawing.Point(24, 134);
			this.lblMisProy.Size = new System.Drawing.Size(200, 24);
			this.lblMisProy.Text = "Mis proyectos";
			// lnkVerProyectos
			this.lnkVerProyectos.LinkColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.lnkVerProyectos.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lnkVerProyectos.Location = new System.Drawing.Point(400, 140);
			this.lnkVerProyectos.Size = new System.Drawing.Size(90, 18);
			this.lnkVerProyectos.Text = "Ver todos";
			this.lnkVerProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//this.lnkVerProyectos.Click += new System.EventHandler(this.lnkVerProyectos_Click);
			// flpProyectos
			this.flpProyectos.AutoScroll = true;
			this.flpProyectos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpProyectos.WrapContents = false;
			this.flpProyectos.Location = new System.Drawing.Point(24, 162);
			this.flpProyectos.Size = new System.Drawing.Size(466, 448);
			// lblSubRec
			this.lblSubRec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblSubRec.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
			this.lblSubRec.Location = new System.Drawing.Point(504, 134);
			this.lblSubRec.Size = new System.Drawing.Size(220, 24);
			this.lblSubRec.Text = "Subtareas recientes";
			// lnkVerTareas
			this.lnkVerTareas.LinkColor = System.Drawing.Color.FromArgb(59, 130, 246);
			this.lnkVerTareas.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lnkVerTareas.Location = new System.Drawing.Point(880, 140);
			this.lnkVerTareas.Size = new System.Drawing.Size(90, 18);
			this.lnkVerTareas.Text = "Ver todas";
			this.lnkVerTareas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//this.lnkVerTareas.Click += new System.EventHandler(this.lnkVerTareas_Click);
			// flpDerecha
			this.flpDerecha.AutoScroll = true;
			this.flpDerecha.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpDerecha.WrapContents = false;
			this.flpDerecha.Location = new System.Drawing.Point(504, 162);
			this.flpDerecha.Size = new System.Drawing.Size(466, 448);
			// FrmDashboardAlumno
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
			this.ClientSize = new System.Drawing.Size(1000, 630);
			this.Controls.Add(this.pnlCard1);
			this.Controls.Add(this.pnlCard2);
			this.Controls.Add(this.pnlCard3);
			this.Controls.Add(this.pnlCard4);
			this.Controls.Add(this.lblMisProy);
			this.Controls.Add(this.lnkVerProyectos);
			this.Controls.Add(this.flpProyectos);
			this.Controls.Add(this.lblSubRec);
			this.Controls.Add(this.lnkVerTareas);
			this.Controls.Add(this.flpDerecha);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Load += new System.EventHandler(this.FrmDashboardAlumno_Load);
			this.pnlCard1.ResumeLayout(false);
			this.pnlCard2.ResumeLayout(false);
			this.pnlCard3.ResumeLayout(false);
			this.pnlCard4.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Panel pnlCard1;
		private System.Windows.Forms.Label lblTit1;
		private System.Windows.Forms.Label lblValProyectos;
		private System.Windows.Forms.Label lblIco1;
		private System.Windows.Forms.Panel pnlCard2;
		private System.Windows.Forms.Label lblTit2;
		private System.Windows.Forms.Label lblValTareas;
		private System.Windows.Forms.Label lblIco2;
		private System.Windows.Forms.Panel pnlCard3;
		private System.Windows.Forms.Label lblTit3;
		private System.Windows.Forms.Label lblValSubtareas;
		private System.Windows.Forms.Label lblIco3;
		private System.Windows.Forms.Panel pnlCard4;
		private System.Windows.Forms.Label lblTit4;
		private System.Windows.Forms.Label lblValEntrega;
		private System.Windows.Forms.Label lblIco4;
		private System.Windows.Forms.Label lblMisProy;
		private System.Windows.Forms.LinkLabel lnkVerProyectos;
		private System.Windows.Forms.FlowLayoutPanel flpProyectos;
		private System.Windows.Forms.Label lblSubRec;
		private System.Windows.Forms.LinkLabel lnkVerTareas;
		private System.Windows.Forms.FlowLayoutPanel flpDerecha;

		#endregion
	}
}
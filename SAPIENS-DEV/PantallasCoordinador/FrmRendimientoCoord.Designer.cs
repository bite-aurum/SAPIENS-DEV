namespace SAPIENS_DEV.PantallasCoordinador
{
    partial class FrmRendimientoCoord
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
            this.Text = "FrmRendimientoCoord";
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblTitProyectos = new System.Windows.Forms.Label();
            this.lblValProyectos = new System.Windows.Forms.Label();
            this.lblIcoProyectos = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblTitDocentes = new System.Windows.Forms.Label();
            this.lblValDocentes = new System.Windows.Forms.Label();
            this.lblIcoDocentes = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblTitEntregas = new System.Windows.Forms.Label();
            this.lblValEntregas = new System.Windows.Forms.Label();
            this.lblIcoEntregas = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblTitRetraso = new System.Windows.Forms.Label();
            this.lblValRetraso = new System.Windows.Forms.Label();
            this.lblIcoRetraso = new System.Windows.Forms.Label();
            this.pnlDocentes = new System.Windows.Forms.Panel();
            this.lblSecDocentes = new System.Windows.Forms.Label();
            this.flpDocentes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProyectos = new System.Windows.Forms.Panel();
            this.lblSecProyectos = new System.Windows.Forms.Label();
            this.flpProyectos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlDocentes.SuspendLayout();
            this.pnlProyectos.SuspendLayout();
            this.SuspendLayout();
            // pnlCard1 — Total proyectos
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
            this.lblTitProyectos.Text = "Total proyectos";
            this.lblValProyectos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblValProyectos.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValProyectos.Location = new System.Drawing.Point(14, 36);
            this.lblValProyectos.Size = new System.Drawing.Size(120, 40);
            this.lblValProyectos.Text = "0";
            this.lblIcoProyectos.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblIcoProyectos.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblIcoProyectos.Location = new System.Drawing.Point(175, 30);
            this.lblIcoProyectos.Size = new System.Drawing.Size(36, 32);
            this.lblIcoProyectos.Text = "";
            // pnlCard2 — Docentes activos
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Location = new System.Drawing.Point(264, 24);
            this.pnlCard2.Size = new System.Drawing.Size(225, 90);
            this.pnlCard2.Controls.Add(this.lblTitDocentes);
            this.pnlCard2.Controls.Add(this.lblValDocentes);
            this.pnlCard2.Controls.Add(this.lblIcoDocentes);
            this.pnlCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            this.lblTitDocentes.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTitDocentes.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTitDocentes.Location = new System.Drawing.Point(16, 14);
            this.lblTitDocentes.Size = new System.Drawing.Size(150, 18);
            this.lblTitDocentes.Text = "Docentes activos";
            this.lblValDocentes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblValDocentes.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValDocentes.Location = new System.Drawing.Point(14, 36);
            this.lblValDocentes.Size = new System.Drawing.Size(120, 40);
            this.lblValDocentes.Text = "0";
            this.lblIcoDocentes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblIcoDocentes.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblIcoDocentes.Location = new System.Drawing.Point(175, 30);
            this.lblIcoDocentes.Size = new System.Drawing.Size(36, 32);
            this.lblIcoDocentes.Text = "";
            // pnlCard3 — Entregas a tiempo
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
            this.lblTitEntregas.Text = "Entregas a tiempo";
            this.lblValEntregas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblValEntregas.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValEntregas.Location = new System.Drawing.Point(14, 36);
            this.lblValEntregas.Size = new System.Drawing.Size(120, 40);
            this.lblValEntregas.Text = "0%";
            this.lblIcoEntregas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblIcoEntregas.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblIcoEntregas.Location = new System.Drawing.Point(175, 30);
            this.lblIcoEntregas.Size = new System.Drawing.Size(36, 32);
            this.lblIcoEntregas.Text = "";
            // pnlCard4 — Proyectos con retraso
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.Location = new System.Drawing.Point(744, 24);
            this.pnlCard4.Size = new System.Drawing.Size(225, 90);
            this.pnlCard4.Controls.Add(this.lblTitRetraso);
            this.pnlCard4.Controls.Add(this.lblValRetraso);
            this.pnlCard4.Controls.Add(this.lblIcoRetraso);
            this.pnlCard4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            this.lblTitRetraso.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTitRetraso.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTitRetraso.Location = new System.Drawing.Point(16, 14);
            this.lblTitRetraso.Size = new System.Drawing.Size(150, 18);
            this.lblTitRetraso.Text = "Proyectos con retraso";
            this.lblValRetraso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblValRetraso.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValRetraso.Location = new System.Drawing.Point(14, 36);
            this.lblValRetraso.Size = new System.Drawing.Size(120, 40);
            this.lblValRetraso.Text = "0";
            this.lblIcoRetraso.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblIcoRetraso.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblIcoRetraso.Location = new System.Drawing.Point(175, 30);
            this.lblIcoRetraso.Size = new System.Drawing.Size(36, 32);
            this.lblIcoRetraso.Text = "";
            // pnlDocentes
            this.pnlDocentes.BackColor = System.Drawing.Color.White;
            this.pnlDocentes.Location = new System.Drawing.Point(24, 134);
            this.pnlDocentes.Size = new System.Drawing.Size(465, 476);
            this.pnlDocentes.Controls.Add(this.lblSecDocentes);
            this.pnlDocentes.Controls.Add(this.flpDocentes);
            this.pnlDocentes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecDocentes
            this.lblSecDocentes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecDocentes.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecDocentes.Location = new System.Drawing.Point(20, 16);
            this.lblSecDocentes.Size = new System.Drawing.Size(300, 20);
            this.lblSecDocentes.Text = "RENDIMIENTO POR DOCENTE";
            // flpDocentes
            this.flpDocentes.AutoScroll = true;
            this.flpDocentes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDocentes.WrapContents = false;
            this.flpDocentes.Location = new System.Drawing.Point(20, 45);
            this.flpDocentes.Size = new System.Drawing.Size(425, 415);
            // pnlProyectos
            this.pnlProyectos.BackColor = System.Drawing.Color.White;
            this.pnlProyectos.Location = new System.Drawing.Point(510, 134);
            this.pnlProyectos.Size = new System.Drawing.Size(465, 476);
            this.pnlProyectos.Controls.Add(this.lblSecProyectos);
            this.pnlProyectos.Controls.Add(this.flpProyectos);
            this.pnlProyectos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecProyectos
            this.lblSecProyectos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecProyectos.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecProyectos.Location = new System.Drawing.Point(20, 16);
            this.lblSecProyectos.Size = new System.Drawing.Size(300, 20);
            this.lblSecProyectos.Text = "AVANCE POR PROYECTO";
            // flpProyectos
            this.flpProyectos.AutoScroll = true;
            this.flpProyectos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProyectos.WrapContents = false;
            this.flpProyectos.Location = new System.Drawing.Point(20, 45);
            this.flpProyectos.Size = new System.Drawing.Size(425, 415);
            // FrmRendimientoCoord
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlCard1);
            this.Controls.Add(this.pnlCard2);
            this.Controls.Add(this.pnlCard3);
            this.Controls.Add(this.pnlCard4);
            this.Controls.Add(this.pnlDocentes);
            this.Controls.Add(this.pnlProyectos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmRendimientoCoord_Load);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard4.ResumeLayout(false);
            this.pnlDocentes.ResumeLayout(false);
            this.pnlProyectos.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblTitProyectos;
        private System.Windows.Forms.Label lblValProyectos;
        private System.Windows.Forms.Label lblIcoProyectos;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblTitDocentes;
        private System.Windows.Forms.Label lblValDocentes;
        private System.Windows.Forms.Label lblIcoDocentes;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblTitEntregas;
        private System.Windows.Forms.Label lblValEntregas;
        private System.Windows.Forms.Label lblIcoEntregas;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblTitRetraso;
        private System.Windows.Forms.Label lblValRetraso;
        private System.Windows.Forms.Label lblIcoRetraso;
        private System.Windows.Forms.Panel pnlDocentes;
        private System.Windows.Forms.Label lblSecDocentes;
        private System.Windows.Forms.FlowLayoutPanel flpDocentes;
        private System.Windows.Forms.Panel pnlProyectos;
        private System.Windows.Forms.Label lblSecProyectos;
        private System.Windows.Forms.FlowLayoutPanel flpProyectos;

        #endregion
    }
}
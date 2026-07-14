namespace SAPIENS_DEV.PantallasCoordinador
{
    partial class FrmDocentesCoord
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
            this.Text = "FrmDocentesCoord";
            this.pnlLista = new System.Windows.Forms.Panel();
            this.lblSec = new System.Windows.Forms.Label();
            this.flpDocentes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLista.SuspendLayout();
            this.SuspendLayout();
            // pnlLista
            this.pnlLista.BackColor = System.Drawing.Color.White;
            this.pnlLista.Location = new System.Drawing.Point(24, 24);
            this.pnlLista.Size = new System.Drawing.Size(700, 586);
            this.pnlLista.Controls.Add(this.lblSec);
            this.pnlLista.Controls.Add(this.flpDocentes);
            this.pnlLista.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSec
            this.lblSec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSec.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSec.Location = new System.Drawing.Point(20, 16);
            this.lblSec.Size = new System.Drawing.Size(300, 20);
            this.lblSec.Text = "DOCENTES REGISTRADOS";
            // flpDocentes
            this.flpDocentes.AutoScroll = true;
            this.flpDocentes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDocentes.WrapContents = false;
            this.flpDocentes.Location = new System.Drawing.Point(20, 45);
            this.flpDocentes.Size = new System.Drawing.Size(660, 525);
            // FrmDocentesCoord
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlLista);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmDocentesCoord_Load);
            this.pnlLista.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.FlowLayoutPanel flpDocentes;

        #endregion
    }
}
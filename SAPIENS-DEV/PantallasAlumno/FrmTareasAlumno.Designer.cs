namespace SAPIENS_DEV.PantallasAlumno
{
    partial class FrmTareasAlumno
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
            this.Text = "FrmTareasAlumno";
            this.flpTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // flpTareas
            this.flpTareas.AutoScroll = true;
            this.flpTareas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTareas.WrapContents = false;
            this.flpTareas.Location = new System.Drawing.Point(24, 24);
            this.flpTareas.Size = new System.Drawing.Size(950, 586);
            // FrmTareasAlumno
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.flpTareas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmTareasAlumno_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FlowLayoutPanel flpTareas;

        #endregion
    }
}
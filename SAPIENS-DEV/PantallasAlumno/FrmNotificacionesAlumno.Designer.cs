namespace SAPIENS_DEV.PantallasAlumno
{
    partial class FrmNotificacionesAlumno
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
            this.Text = "FrmNotificacionesAlumno";
            this.btnMarcarTodas = new System.Windows.Forms.Button();
            this.flpNotifs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // btnMarcarTodas
            this.btnMarcarTodas.BackColor = System.Drawing.Color.White;
            this.btnMarcarTodas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnMarcarTodas.FlatAppearance.BorderSize = 1;
            this.btnMarcarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarTodas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnMarcarTodas.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnMarcarTodas.Location = new System.Drawing.Point(764, 16);
            this.btnMarcarTodas.Size = new System.Drawing.Size(200, 32);
            this.btnMarcarTodas.Text = "Marcar todas como leídas";
            this.btnMarcarTodas.UseVisualStyleBackColor = false;
            this.btnMarcarTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcarTodas.Click += new System.EventHandler(this.btnMarcarTodas_Click);
            // flpNotifs
            this.flpNotifs.AutoScroll = true;
            this.flpNotifs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNotifs.WrapContents = false;
            this.flpNotifs.Location = new System.Drawing.Point(24, 60);
            this.flpNotifs.Size = new System.Drawing.Size(950, 550);
            // FrmNotificacionesAlumno
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.btnMarcarTodas);
            this.Controls.Add(this.flpNotifs);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmNotificacionesAlumno_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnMarcarTodas;
        private System.Windows.Forms.FlowLayoutPanel flpNotifs;

        #endregion
    }
}
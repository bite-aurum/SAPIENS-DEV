namespace SAPIENS_DEV.PantallasDocente
{
    partial class FrmProyectosDocente
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
            this.Text = "FrmProyectosDocente";

            this.btnNuevo = new System.Windows.Forms.Button();
            this.flpProyectos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // btnNuevo (botón secundario según guía)
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnNuevo.FlatAppearance.BorderSize = 2;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnNuevo.Location = new System.Drawing.Point(784, 16);
            this.btnNuevo.Size = new System.Drawing.Size(180, 40);
            this.btnNuevo.Text = "+  Nuevo proyecto";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // flpProyectos
            this.flpProyectos.AutoScroll = true;
            this.flpProyectos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpProyectos.WrapContents = false;
            this.flpProyectos.Location = new System.Drawing.Point(24, 70);
            this.flpProyectos.Size = new System.Drawing.Size(950, 540);
            // FrmProyectosDocente
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.flpProyectos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmProyectosDocente_Load);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.FlowLayoutPanel flpProyectos;
        #endregion
    }
}
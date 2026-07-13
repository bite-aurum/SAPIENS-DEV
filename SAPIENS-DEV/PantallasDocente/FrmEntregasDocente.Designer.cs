namespace SAPIENS_DEV.PantallasDocente
{
	partial class FrmEntregasDocente
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
			this.Text = "FrmEntregasDocente";
			this.btnNueva = new System.Windows.Forms.Button();
			this.flpEntregas = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// btnNueva (botón secundario según guía)
			this.btnNueva.BackColor = System.Drawing.Color.White;
			this.btnNueva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnNueva.FlatAppearance.BorderSize = 2;
			this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNueva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnNueva.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
			this.btnNueva.Location = new System.Drawing.Point(784, 16);
			this.btnNueva.Size = new System.Drawing.Size(180, 40);
			this.btnNueva.Text = "+  Nueva entrega";
			this.btnNueva.UseVisualStyleBackColor = false;
			this.btnNueva.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
			// flpEntregas
			this.flpEntregas.AutoScroll = true;
			this.flpEntregas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpEntregas.WrapContents = false;
			this.flpEntregas.Location = new System.Drawing.Point(24, 70);
			this.flpEntregas.Size = new System.Drawing.Size(950, 540);
			// FrmEntregasDocente
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
			this.ClientSize = new System.Drawing.Size(1000, 630);
			this.Controls.Add(this.btnNueva);
			this.Controls.Add(this.flpEntregas);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Load += new System.EventHandler(this.FrmEntregasDocente_Load);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnNueva;
		private System.Windows.Forms.FlowLayoutPanel flpEntregas;

		#endregion
	}
}
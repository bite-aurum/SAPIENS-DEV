namespace SAPIENS_DEV.PantallasDocente
{
    partial class FrmReportesDocente
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
            this.Text = "FrmReportesDocente";
            this.pnlGenerar = new System.Windows.Forms.Panel();
            this.lblSecGen = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.lblSecPrev = new System.Windows.Forms.Label();
            this.lstPreview = new System.Windows.Forms.ListBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.pnlHistorial = new System.Windows.Forms.Panel();
            this.lblSecHist = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.pnlGenerar.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            this.pnlHistorial.SuspendLayout();
            this.SuspendLayout();
            // pnlGenerar
            this.pnlGenerar.BackColor = System.Drawing.Color.White;
            this.pnlGenerar.Location = new System.Drawing.Point(24, 24);
            this.pnlGenerar.Size = new System.Drawing.Size(440, 290);
            this.pnlGenerar.Controls.Add(this.lblSecGen);
            this.pnlGenerar.Controls.Add(this.lblTipo);
            this.pnlGenerar.Controls.Add(this.cmbTipo);
            this.pnlGenerar.Controls.Add(this.lblProyecto);
            this.pnlGenerar.Controls.Add(this.cmbProyecto);
            this.pnlGenerar.Controls.Add(this.lblFecha);
            this.pnlGenerar.Controls.Add(this.txtFecha);
            this.pnlGenerar.Controls.Add(this.btnGenerar);
            this.pnlGenerar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecGen
            this.lblSecGen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecGen.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecGen.Location = new System.Drawing.Point(30, 18);
            this.lblSecGen.Size = new System.Drawing.Size(300, 20);
            this.lblSecGen.Text = "GENERAR NUEVO REPORTE";
            // lblTipo
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTipo.Location = new System.Drawing.Point(30, 48);
            this.lblTipo.Text = "Tipo de reporte";
            // cmbTipo
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipo.Items.AddRange(new object[] {
                "Avance por proyecto",
                "Tareas completadas vs pendientes",
                "Entregas a tiempo vs tardías",
                "Subtareas por estado" });
            this.cmbTipo.Location = new System.Drawing.Point(30, 68);
            this.cmbTipo.Size = new System.Drawing.Size(380, 25);
            // lblProyecto
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProyecto.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblProyecto.Location = new System.Drawing.Point(30, 105);
            this.lblProyecto.Text = "Proyecto";
            // cmbProyecto
            this.cmbProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyecto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProyecto.Location = new System.Drawing.Point(30, 125);
            this.cmbProyecto.Size = new System.Drawing.Size(380, 25);
            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblFecha.Location = new System.Drawing.Point(30, 162);
            this.lblFecha.Text = "Fecha de generación";
            // txtFecha
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFecha.Location = new System.Drawing.Point(30, 182);
            this.txtFecha.Size = new System.Drawing.Size(380, 25);
            // btnGenerar
            this.btnGenerar.BackColor = System.Drawing.Color.White;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnGenerar.FlatAppearance.BorderSize = 2;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnGenerar.Location = new System.Drawing.Point(30, 225);
            this.btnGenerar.Size = new System.Drawing.Size(380, 40);
            this.btnGenerar.Text = "📊  Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // pnlPreview
            this.pnlPreview.BackColor = System.Drawing.Color.White;
            this.pnlPreview.Location = new System.Drawing.Point(24, 330);
            this.pnlPreview.Size = new System.Drawing.Size(440, 280);
            this.pnlPreview.Controls.Add(this.lblSecPrev);
            this.pnlPreview.Controls.Add(this.lstPreview);
            this.pnlPreview.Controls.Add(this.btnDescargar);
            this.pnlPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecPrev
            this.lblSecPrev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecPrev.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecPrev.Location = new System.Drawing.Point(30, 18);
            this.lblSecPrev.Size = new System.Drawing.Size(300, 20);
            this.lblSecPrev.Text = "VISTA PREVIA";
            // lstPreview
            this.lstPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPreview.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstPreview.ItemHeight = 20;
            this.lstPreview.Location = new System.Drawing.Point(30, 45);
            this.lstPreview.Size = new System.Drawing.Size(380, 160);
            // btnDescargar
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Location = new System.Drawing.Point(30, 220);
            this.btnDescargar.Size = new System.Drawing.Size(380, 40);
            this.btnDescargar.Text = "⬇  Descargar reporte";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // pnlHistorial
            this.pnlHistorial.BackColor = System.Drawing.Color.White;
            this.pnlHistorial.Location = new System.Drawing.Point(490, 24);
            this.pnlHistorial.Size = new System.Drawing.Size(485, 586);
            this.pnlHistorial.Controls.Add(this.lblSecHist);
            this.pnlHistorial.Controls.Add(this.lstHistorial);
            this.pnlHistorial.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecHist
            this.lblSecHist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecHist.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecHist.Location = new System.Drawing.Point(30, 18);
            this.lblSecHist.Size = new System.Drawing.Size(300, 20);
            this.lblSecHist.Text = "HISTORIAL DE REPORTES";
            // lstHistorial
            this.lstHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHistorial.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstHistorial.ItemHeight = 24;
            this.lstHistorial.Location = new System.Drawing.Point(30, 45);
            this.lstHistorial.Size = new System.Drawing.Size(425, 520);
            // FrmReportesDocente
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlGenerar);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.pnlHistorial);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmReportesDocente_Load);
            this.pnlGenerar.ResumeLayout(false);
            this.pnlGenerar.PerformLayout();
            this.pnlPreview.ResumeLayout(false);
            this.pnlHistorial.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlGenerar;
        private System.Windows.Forms.Label lblSecGen;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label lblSecPrev;
        private System.Windows.Forms.ListBox lstPreview;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Panel pnlHistorial;
        private System.Windows.Forms.Label lblSecHist;
        private System.Windows.Forms.ListBox lstHistorial;

        #endregion
    }
}
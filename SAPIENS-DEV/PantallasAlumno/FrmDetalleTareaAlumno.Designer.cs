namespace SAPIENS_DEV.PantallasAlumno
{
    partial class FrmDetalleTareaAlumno
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
            this.Text = "FrmDetalleTareaAlumno";
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.lblSecSub = new System.Windows.Forms.Label();
            this.flpSub = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.pnlBarraProg = new System.Windows.Forms.Panel();
            this.lblProgresoVal = new System.Windows.Forms.Label();
            this.pnlSubir = new System.Windows.Forms.Panel();
            this.lblSecSubir = new System.Windows.Forms.Label();
            this.lblSubtarea = new System.Windows.Forms.Label();
            this.cmbSubtarea = new System.Windows.Forms.ComboBox();
            this.lblHintCombo = new System.Windows.Forms.Label();
            this.pnlDrop = new System.Windows.Forms.Panel();
            this.lblDropIco = new System.Windows.Forms.Label();
            this.lblDrop1 = new System.Windows.Forms.Label();
            this.lblDrop2 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblArchivoSel = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.pnlSub.SuspendLayout();
            this.pnlSubir.SuspendLayout();
            this.pnlDrop.SuspendLayout();
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
            this.pnlInfo.Size = new System.Drawing.Size(950, 75);
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // pnlSub
            this.pnlSub.BackColor = System.Drawing.Color.White;
            this.pnlSub.Location = new System.Drawing.Point(24, 145);
            this.pnlSub.Size = new System.Drawing.Size(465, 465);
            this.pnlSub.Controls.Add(this.lblSecSub);
            this.pnlSub.Controls.Add(this.flpSub);
            this.pnlSub.Controls.Add(this.lblProgreso);
            this.pnlSub.Controls.Add(this.pnlBarraProg);
            this.pnlSub.Controls.Add(this.lblProgresoVal);
            this.pnlSub.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecSub
            this.lblSecSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecSub.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecSub.Location = new System.Drawing.Point(20, 16);
            this.lblSecSub.Size = new System.Drawing.Size(300, 20);
            this.lblSecSub.Text = "SUBTAREAS DEL EQUIPO";
            // flpSub
            this.flpSub.AutoScroll = true;
            this.flpSub.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSub.WrapContents = false;
            this.flpSub.Location = new System.Drawing.Point(20, 45);
            this.flpSub.Size = new System.Drawing.Size(425, 350);
            // lblProgreso
            this.lblProgreso.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProgreso.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblProgreso.Location = new System.Drawing.Point(20, 410);
            this.lblProgreso.Size = new System.Drawing.Size(70, 16);
            this.lblProgreso.Text = "Progreso";
            // pnlBarraProg
            this.pnlBarraProg.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.pnlBarraProg.Location = new System.Drawing.Point(95, 414);
            this.pnlBarraProg.Size = new System.Drawing.Size(300, 8);
            // lblProgresoVal
            this.lblProgresoVal.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProgresoVal.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblProgresoVal.Location = new System.Drawing.Point(405, 408);
            this.lblProgresoVal.Size = new System.Drawing.Size(50, 18);
            this.lblProgresoVal.Text = "0/0";
            // pnlSubir
            this.pnlSubir.BackColor = System.Drawing.Color.White;
            this.pnlSubir.Location = new System.Drawing.Point(510, 145);
            this.pnlSubir.Size = new System.Drawing.Size(464, 465);
            this.pnlSubir.Controls.Add(this.lblSecSubir);
            this.pnlSubir.Controls.Add(this.lblSubtarea);
            this.pnlSubir.Controls.Add(this.cmbSubtarea);
            this.pnlSubir.Controls.Add(this.lblHintCombo);
            this.pnlSubir.Controls.Add(this.pnlDrop);
            this.pnlSubir.Controls.Add(this.lblArchivoSel);
            this.pnlSubir.Controls.Add(this.lblNota);
            this.pnlSubir.Controls.Add(this.btnSubir);
            this.pnlSubir.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblSecSubir
            this.lblSecSubir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecSubir.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSecSubir.Location = new System.Drawing.Point(20, 16);
            this.lblSecSubir.Size = new System.Drawing.Size(300, 20);
            this.lblSecSubir.Text = "SUBIR ARCHIVO A SUBTAREA";
            // lblSubtarea
            this.lblSubtarea.AutoSize = true;
            this.lblSubtarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubtarea.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSubtarea.Location = new System.Drawing.Point(20, 46);
            this.lblSubtarea.Text = "Subtarea";
            // cmbSubtarea
            this.cmbSubtarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubtarea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSubtarea.Location = new System.Drawing.Point(20, 66);
            this.cmbSubtarea.Size = new System.Drawing.Size(424, 25);
            // lblHintCombo
            this.lblHintCombo.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblHintCombo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHintCombo.Location = new System.Drawing.Point(20, 94);
            this.lblHintCombo.Size = new System.Drawing.Size(300, 15);
            this.lblHintCombo.Text = "Solo subtareas sin completar";
            // pnlDrop (zona punteada)
            this.pnlDrop.AllowDrop = true;
            this.pnlDrop.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlDrop.Location = new System.Drawing.Point(20, 120);
            this.pnlDrop.Size = new System.Drawing.Size(424, 160);
            this.pnlDrop.Controls.Add(this.lblDropIco);
            this.pnlDrop.Controls.Add(this.lblDrop1);
            this.pnlDrop.Controls.Add(this.lblDrop2);
            this.pnlDrop.Controls.Add(this.btnSeleccionar);
            this.pnlDrop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrop_Paint);
            this.pnlDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDrop_DragEnter);
            this.pnlDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDrop_DragDrop);
            // lblDropIco
            this.lblDropIco.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblDropIco.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblDropIco.Location = new System.Drawing.Point(0, 18);
            this.lblDropIco.Size = new System.Drawing.Size(424, 30);
            this.lblDropIco.Text = "";
            this.lblDropIco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblDrop1
            this.lblDrop1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDrop1.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDrop1.Location = new System.Drawing.Point(0, 52);
            this.lblDrop1.Size = new System.Drawing.Size(424, 18);
            this.lblDrop1.Text = "Arrastra tu archivo aquí";
            this.lblDrop1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblDrop2
            this.lblDrop2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDrop2.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDrop2.Location = new System.Drawing.Point(0, 72);
            this.lblDrop2.Size = new System.Drawing.Size(424, 16);
            this.lblDrop2.Text = "o selecciona desde tu equipo";
            this.lblDrop2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnSeleccionar
            this.btnSeleccionar.BackColor = System.Drawing.Color.White;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnSeleccionar.FlatAppearance.BorderSize = 1;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnSeleccionar.Location = new System.Drawing.Point(132, 100);
            this.btnSeleccionar.Size = new System.Drawing.Size(160, 30);
            this.btnSeleccionar.Text = "Seleccionar archivo";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // lblArchivoSel
            this.lblArchivoSel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblArchivoSel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblArchivoSel.Location = new System.Drawing.Point(20, 288);
            this.lblArchivoSel.Size = new System.Drawing.Size(424, 18);
            this.lblArchivoSel.Text = "Ningún archivo seleccionado";
            // lblNota
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNota.Location = new System.Drawing.Point(20, 310);
            this.lblNota.Size = new System.Drawing.Size(424, 30);
            this.lblNota.Text = "Al subir el archivo la subtarea se marcará como Completada automáticamente y el avance de la tarea se actualizará.";
            // btnSubir
            this.btnSubir.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Location = new System.Drawing.Point(20, 350);
            this.btnSubir.Size = new System.Drawing.Size(424, 40);
            this.btnSubir.Text = "Subir archivo";
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // FrmDetalleTareaAlumno
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlSub);
            this.Controls.Add(this.pnlSubir);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmDetalleTareaAlumno_Load);
            this.pnlSub.ResumeLayout(false);
            this.pnlSubir.ResumeLayout(false);
            this.pnlSubir.PerformLayout();
            this.pnlDrop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.Label lblSecSub;
        private System.Windows.Forms.FlowLayoutPanel flpSub;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Panel pnlBarraProg;
        private System.Windows.Forms.Label lblProgresoVal;
        private System.Windows.Forms.Panel pnlSubir;
        private System.Windows.Forms.Label lblSecSubir;
        private System.Windows.Forms.Label lblSubtarea;
        private System.Windows.Forms.ComboBox cmbSubtarea;
        private System.Windows.Forms.Label lblHintCombo;
        private System.Windows.Forms.Panel pnlDrop;
        private System.Windows.Forms.Label lblDropIco;
        private System.Windows.Forms.Label lblDrop1;
        private System.Windows.Forms.Label lblDrop2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblArchivoSel;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnSubir;

        #endregion
    }
}
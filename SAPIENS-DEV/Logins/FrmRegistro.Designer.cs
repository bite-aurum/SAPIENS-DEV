namespace SAPIENS_DEV.Logins
{
    partial class FrmRegistro
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
            this.Text = "FrmRegistro";
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlAlumno = new System.Windows.Forms.Panel();
            this.lblAluIcono = new System.Windows.Forms.Label();
            this.lblAluTitulo = new System.Windows.Forms.Label();
            this.lblAluDesc = new System.Windows.Forms.Label();
            this.pnlDocente = new System.Windows.Forms.Panel();
            this.lblDocIcono = new System.Windows.Forms.Label();
            this.lblDocTitulo = new System.Windows.Forms.Label();
            this.lblDocDesc = new System.Windows.Forms.Label();
            this.pnlCoordinador = new System.Windows.Forms.Panel();
            this.lblCooIcono = new System.Windows.Forms.Label();
            this.lblCooTitulo = new System.Windows.Forms.Label();
            this.lblCooDesc = new System.Windows.Forms.Label();
            this.lnkVolver = new System.Windows.Forms.LinkLabel();
            this.pnlCard.SuspendLayout();
            this.pnlAlumno.SuspendLayout();
            this.pnlDocente.SuspendLayout();
            this.pnlCoordinador.SuspendLayout();
            this.SuspendLayout();
            // pnlCard
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(230, 195);
            this.pnlCard.Size = new System.Drawing.Size(440, 330);
            this.pnlCard.Controls.Add(this.lblLogo);
            this.pnlCard.Controls.Add(this.lblSubtitulo);
            this.pnlCard.Controls.Add(this.pnlAlumno);
            this.pnlCard.Controls.Add(this.pnlDocente);
            this.pnlCard.Controls.Add(this.pnlCoordinador);
            this.pnlCard.Controls.Add(this.lnkVolver);
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // lblLogo
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblLogo.Location = new System.Drawing.Point(0, 25);
            this.lblLogo.Size = new System.Drawing.Size(440, 40);
            this.lblLogo.Text = "SAPIENS";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblSubtitulo
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 68);
            this.lblSubtitulo.Size = new System.Drawing.Size(440, 20);
            this.lblSubtitulo.Text = "Selecciona cómo quieres registrarte";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // pnlAlumno (rol Alumno: azul cielo #3B82F6)
            this.pnlAlumno.BackColor = System.Drawing.Color.White;
            this.pnlAlumno.Location = new System.Drawing.Point(30, 105);
            this.pnlAlumno.Size = new System.Drawing.Size(120, 130);
            this.pnlAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAlumno.Controls.Add(this.lblAluIcono);
            this.pnlAlumno.Controls.Add(this.lblAluTitulo);
            this.pnlAlumno.Controls.Add(this.lblAluDesc);
            this.pnlAlumno.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRol_Paint);
            this.pnlAlumno.Click += new System.EventHandler(this.Alumno_Click);
            // lblAluIcono
            this.lblAluIcono.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAluIcono.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblAluIcono.Location = new System.Drawing.Point(0, 12);
            this.lblAluIcono.Size = new System.Drawing.Size(120, 30);
            this.lblAluIcono.Text = "🎓";
            this.lblAluIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAluIcono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAluIcono.Click += new System.EventHandler(this.Alumno_Click);
            // lblAluTitulo
            this.lblAluTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAluTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblAluTitulo.Location = new System.Drawing.Point(0, 48);
            this.lblAluTitulo.Size = new System.Drawing.Size(120, 22);
            this.lblAluTitulo.Text = "Alumno";
            this.lblAluTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAluTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAluTitulo.Click += new System.EventHandler(this.Alumno_Click);
            // lblAluDesc
            this.lblAluDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAluDesc.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblAluDesc.Location = new System.Drawing.Point(5, 72);
            this.lblAluDesc.Size = new System.Drawing.Size(110, 45);
            this.lblAluDesc.Text = "Registro con matrícula";
            this.lblAluDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAluDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAluDesc.Click += new System.EventHandler(this.Alumno_Click);
            // pnlDocente (rol Docente: púrpura #7C3AED)
            this.pnlDocente.BackColor = System.Drawing.Color.White;
            this.pnlDocente.Location = new System.Drawing.Point(160, 105);
            this.pnlDocente.Size = new System.Drawing.Size(120, 130);
            this.pnlDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDocente.Controls.Add(this.lblDocIcono);
            this.pnlDocente.Controls.Add(this.lblDocTitulo);
            this.pnlDocente.Controls.Add(this.lblDocDesc);
            this.pnlDocente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRol_Paint);
            this.pnlDocente.Click += new System.EventHandler(this.Docente_Click);
            // lblDocIcono
            this.lblDocIcono.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDocIcono.ForeColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.lblDocIcono.Location = new System.Drawing.Point(0, 12);
            this.lblDocIcono.Size = new System.Drawing.Size(120, 30);
            this.lblDocIcono.Text = "💼";
            this.lblDocIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDocIcono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDocIcono.Click += new System.EventHandler(this.Docente_Click);
            // lblDocTitulo
            this.lblDocTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDocTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDocTitulo.Location = new System.Drawing.Point(0, 48);
            this.lblDocTitulo.Size = new System.Drawing.Size(120, 22);
            this.lblDocTitulo.Text = "Docente";
            this.lblDocTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDocTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDocTitulo.Click += new System.EventHandler(this.Docente_Click);
            // lblDocDesc
            this.lblDocDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDocDesc.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDocDesc.Location = new System.Drawing.Point(5, 72);
            this.lblDocDesc.Size = new System.Drawing.Size(110, 45);
            this.lblDocDesc.Text = "Registro con correo institucional";
            this.lblDocDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDocDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDocDesc.Click += new System.EventHandler(this.Docente_Click);
            // pnlCoordinador (rol Coordinador: verde esmeralda #10B981)
            this.pnlCoordinador.BackColor = System.Drawing.Color.White;
            this.pnlCoordinador.Location = new System.Drawing.Point(290, 105);
            this.pnlCoordinador.Size = new System.Drawing.Size(120, 130);
            this.pnlCoordinador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCoordinador.Controls.Add(this.lblCooIcono);
            this.pnlCoordinador.Controls.Add(this.lblCooTitulo);
            this.pnlCoordinador.Controls.Add(this.lblCooDesc);
            this.pnlCoordinador.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRol_Paint);
            this.pnlCoordinador.Click += new System.EventHandler(this.Coordinador_Click);
            // lblCooIcono
            this.lblCooIcono.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblCooIcono.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblCooIcono.Location = new System.Drawing.Point(0, 12);
            this.lblCooIcono.Size = new System.Drawing.Size(120, 30);
            this.lblCooIcono.Text = "🛡";
            this.lblCooIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCooIcono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCooIcono.Click += new System.EventHandler(this.Coordinador_Click);
            // lblCooTitulo
            this.lblCooTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCooTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblCooTitulo.Location = new System.Drawing.Point(0, 48);
            this.lblCooTitulo.Size = new System.Drawing.Size(120, 22);
            this.lblCooTitulo.Text = "Coordinador";
            this.lblCooTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCooTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCooTitulo.Click += new System.EventHandler(this.Coordinador_Click);
            // lblCooDesc
            this.lblCooDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCooDesc.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCooDesc.Location = new System.Drawing.Point(5, 72);
            this.lblCooDesc.Size = new System.Drawing.Size(110, 45);
            this.lblCooDesc.Text = "Registro institucional";
            this.lblCooDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCooDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCooDesc.Click += new System.EventHandler(this.Coordinador_Click);
            // lnkVolver
            this.lnkVolver.LinkColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lnkVolver.Location = new System.Drawing.Point(0, 260);
            this.lnkVolver.Size = new System.Drawing.Size(440, 20);
            this.lnkVolver.Text = "← Volver al login";
            this.lnkVolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkVolver.Click += new System.EventHandler(this.lnkVolver_Click);
            // FrmRegistro
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAPIENS — Registro";
            this.pnlCard.ResumeLayout(false);
            this.pnlAlumno.ResumeLayout(false);
            this.pnlDocente.ResumeLayout(false);
            this.pnlCoordinador.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAlumno;
        private System.Windows.Forms.Label lblAluIcono;
        private System.Windows.Forms.Label lblAluTitulo;
        private System.Windows.Forms.Label lblAluDesc;
        private System.Windows.Forms.Panel pnlDocente;
        private System.Windows.Forms.Label lblDocIcono;
        private System.Windows.Forms.Label lblDocTitulo;
        private System.Windows.Forms.Label lblDocDesc;
        private System.Windows.Forms.Panel pnlCoordinador;
        private System.Windows.Forms.Label lblCooIcono;
        private System.Windows.Forms.Label lblCooTitulo;
        private System.Windows.Forms.Label lblCooDesc;
        private System.Windows.Forms.LinkLabel lnkVolver;


        #endregion
    }
}
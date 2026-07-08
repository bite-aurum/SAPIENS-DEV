using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPIENS_DEV.Logins
{
    public partial class FrmRegistro : Form
    {
        Form login;
        public FrmRegistro(Form frmlogin)
        {
            InitializeComponent();
            login = frmlogin;
        }
        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlCard.ClientRectangle,
                System.Drawing.Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }

        private void pnlRol_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                System.Drawing.Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }

        private void Alumno_Click(object sender, EventArgs e)
        {
           new FrmRegistroAlumno(login).Show();
            Close();
        }

        private void Docente_Click(object sender, EventArgs e)
        {
            new FrmRegistroDocente(login).Show();
            Close();
        }

        private void Coordinador_Click(object sender, EventArgs e)
        {
            new FrmRegistroCoordinador(login).Show();
            Close();
        }

        private void lnkVolver_Click(object sender, EventArgs e)
        {
            login.Show();
            Close();
        }
    }
}

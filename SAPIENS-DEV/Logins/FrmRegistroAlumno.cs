using SAPIENS_DEV.AccesoDatos;
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
    public partial class FrmRegistroAlumno : Form
    {
        Form login;
        public FrmRegistroAlumno(Form frmlogin)
        {
            InitializeComponent();
            login = frmlogin;
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlCard.ClientRectangle,
                System.Drawing.Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }

        private void lnkVolver_Click(object sender, EventArgs e)
        {
            new FrmRegistro(login).Show();
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtApellidos.Text.Trim() == "" ||
                txtMatricula.Text.Trim() == "" || txtCorreo.Text.Trim() == "" ||
                txtCarrera.Text.Trim() == "" || cmbGrado.SelectedIndex < 0 ||
                cmbGrupo.SelectedIndex < 0 || txtPass.Text == "")
            { MessageBox.Show("Llena todos los campos.", "SAPIENS"); return; }

            int matricula;
            if (!int.TryParse(txtMatricula.Text.Trim(), out matricula))
            { MessageBox.Show("La matrícula debe ser numérica.", "SAPIENS"); return; }

            if (txtPass.Text != txtConfirmar.Text)
            { MessageBox.Show("Las contraseñas no coinciden.", "SAPIENS"); return; }

            string[] ap = txtApellidos.Text.Trim().Split(new[] { ' ' }, 2);
            string apPat = ap[0], apMat = ap.Length > 1 ? ap[1] : "";

            try
            {
                if (Db.CorreoExiste(txtCorreo.Text.Trim()))
                { MessageBox.Show("Ese correo ya está registrado.", "SAPIENS"); return; }

                Db.RegistrarAlumno(txtNombre.Text.Trim(), apPat, apMat, txtCorreo.Text.Trim(),
                    txtPass.Text, matricula, txtCarrera.Text.Trim(),
                    byte.Parse(cmbGrado.Text), cmbGrupo.Text);

                MessageBox.Show("Cuenta creada correctamente.", "SAPIENS");
                login.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "SAPIENS");
            }
        }
    }
}

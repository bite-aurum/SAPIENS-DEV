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
    public partial class FrmRegistroDocente : Form
    {
        Form login;
        public FrmRegistroDocente(Form frmlogin)
        {
            InitializeComponent();
            login = frmlogin;
        }

        private void FrmRegistroDocente_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Db.ObtenerCoordinadores();
                cmbCoordinador.DataSource = dt;
                cmbCoordinador.DisplayMember = "nombre_completo";
                cmbCoordinador.ValueMember = "id_coordinador";
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Aún no hay coordinadores registrados. Registra primero un coordinador.", "SAPIENS");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "SAPIENS");
            }
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
                txtCorreo.Text.Trim() == "" || cmbDepartamento.Text.Trim() == "" || txtPass.Text == "")
            { MessageBox.Show("Llena todos los campos.", "SAPIENS"); return; }

            if (cmbCoordinador.SelectedValue == null)
            { MessageBox.Show("Selecciona el coordinador al que perteneces.", "SAPIENS"); return; }

            if (txtPass.Text != txtConfirmar.Text)
            { MessageBox.Show("Las contraseñas no coinciden.", "SAPIENS"); return; }

            string[] ap = txtApellidos.Text.Trim().Split(new[] { ' ' }, 2);
            string apPat = ap[0], apMat = ap.Length > 1 ? ap[1] : "";

            try
            {
                if (Db.CorreoExiste(txtCorreo.Text.Trim()))
                { MessageBox.Show("Ese correo ya está registrado.", "SAPIENS"); return; }

                Db.RegistrarDocente(txtNombre.Text.Trim(), apPat, apMat, txtCorreo.Text.Trim(),
                    txtPass.Text, cmbDepartamento.Text.Trim(),
                    Convert.ToInt32(cmbCoordinador.SelectedValue));

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

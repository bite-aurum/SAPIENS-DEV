using SAPIENS_DEV.Compartido;
﻿using SAPIENS_DEV.AccesoDatos;
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
    public partial class FrmRegistroCoordinador : Form
    {
        Form login;
        public FrmRegistroCoordinador(Form frmlogin)
        {
            InitializeComponent();
            login = frmlogin;
            Iconos.EnLabelConTexto(lblBadge, "escudo", Color.FromArgb(16, 185, 129));
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
                txtCorreo.Text.Trim() == "" || txtPass.Text == "")
            { MessageBox.Show("Llena todos los campos.", "SAPIENS"); return; }

            if (txtPass.Text != txtConfirmar.Text)
            { MessageBox.Show("Las contraseñas no coinciden.", "SAPIENS"); return; }

            string[] ap = txtApellidos.Text.Trim().Split(new[] { ' ' }, 2);
            string apPat = ap[0], apMat = ap.Length > 1 ? ap[1] : "";

            try
            {
                if (Db.CorreoExiste(txtCorreo.Text.Trim()))
                { MessageBox.Show("Ese correo ya está registrado.", "SAPIENS"); return; }

                Db.RegistrarCoordinador(txtNombre.Text.Trim(), apPat, apMat,
                    txtCorreo.Text.Trim(), txtPass.Text);

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

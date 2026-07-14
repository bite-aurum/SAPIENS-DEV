using SAPIENS_DEV.AccesoDatos;
using SAPIENS_DEV.PantallasCoordinador;
using SAPIENS_DEV.PantallasDocente;
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
	public partial class FrmLogin : Form
	{
        
        public FrmLogin()
		{
			InitializeComponent();
		}
		private void pnlCard_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, pnlCard.ClientRectangle,
				System.Drawing.Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			if (txtCorreo.Text.Trim() == "" || txtPass.Text == "")
			{ MessageBox.Show("Escribe tu correo y contraseña.", "SAPIENS"); return; }

			try
			{
				string rol = Db.Login(txtCorreo.Text.Trim(), txtPass.Text);
				if (rol == "docente") { new FrmMenuDocente(this).Show(); Hide(); }
				else MessageBox.Show("Bienvenido " + Db.NombreUsuario + " (" + rol + ") — menú en construcción.", "SAPIENS");
                if (rol == "docente") { new FrmMenuDocente(this).Show(); Hide(); }
                else if (rol == "coordinador") { new FrmMenuCoordinador(this).Show(); Hide(); }
                else MessageBox.Show("Bienvenido " + Db.NombreUsuario + " (" + rol + ") — menú en construcción.", "SAPIENS");
                // abrir el formulario segun el rol
            }
			catch (Exception ex)
			{
				MessageBox.Show("Error de conexión: " + ex.Message, "SAPIENS");
			}
		}

		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			new FrmRegistro(this).Show();
			Hide();
		}
	}
}

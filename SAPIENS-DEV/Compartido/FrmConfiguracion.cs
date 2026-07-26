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

namespace SAPIENS_DEV.Compartido
{
	public partial class FrmConfiguracion : Form
	{
		Action cerrarSesion;
		string correoOriginal = "";

		public FrmConfiguracion(Action accionCerrarSesion)
		{
			InitializeComponent();
			cerrarSesion = accionCerrarSesion;

			chkNotifs.Checked = Accesibilidad.Activada;
			chkTextoGrande.Checked = Accesibilidad.TextoGrande;
		}

		private void chkNotifs_CheckedChanged(object sender, EventArgs e)
		{
			Accesibilidad.Activada = chkNotifs.Checked;
			if (chkNotifs.Checked)
				Accesibilidad.Decir("Accesibilidad activada");
		}

		// Enciende o apaga el texto grande de toda la app.
		private void chkTextoGrande_CheckedChanged(object sender, EventArgs e)
		{
			Accesibilidad.TextoGrande = chkTextoGrande.Checked;
		}

		private void FrmConfiguracion_Load(object sender, EventArgs e)
		{
			try
			{
				DataRow p = Db.PerfilUsuario();
				string nombreCompleto = p["nombre"] + " " + p["apellido_paterno"] + " " + p["apellido_materno"];

				// Avatar y clave 
				Color colorRol; string prefijo; string extra = "";
				if (Db.Rol == "coordinador") { colorRol = Color.FromArgb(16, 185, 129); prefijo = "COORD-"; }
				else if (Db.Rol == "docente")
				{
					colorRol = Color.FromArgb(124, 58, 237); prefijo = "DOC-";
					extra = "Departamento de " + p["departamento"];
				}
				else
				{
					colorRol = Color.FromArgb(59, 130, 246); prefijo = "ALU-";
					extra = p["carrera"] + " · " + p["grado"] + "°" + p["grupo"];
				}

				lblAvatar.BackColor = colorRol;
				lblAvatar.Text = FrmRendimientoCoord.Iniciales(nombreCompleto);
				lblNombreCompleto.Text = nombreCompleto;
				lblClaveRol.Text = prefijo + Db.IdUsuario.ToString("D3") + " · " + FrmTareasDocente.Capital(Db.Rol);
				lblExtra.Text = extra;

				txtNombre.Text = p["nombre"].ToString();
				txtApellidos.Text = (p["apellido_paterno"] + " " + p["apellido_materno"]).Trim();
				txtCorreo.Text = p["correo"].ToString();
				correoOriginal = p["correo"].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar el perfil: " + ex.Message, "SAPIENS");
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text.Trim() == "" || txtApellidos.Text.Trim() == "" || txtCorreo.Text.Trim() == "")
			{ MessageBox.Show("Llena nombre, apellidos y correo.", "SAPIENS"); return; }

			try
			{
				string correo = txtCorreo.Text.Trim();
				if (correo != correoOriginal && Db.CorreoExiste(correo))
				{ MessageBox.Show("Ese correo ya está registrado por otro usuario.", "SAPIENS"); return; }

				string[] ap = txtApellidos.Text.Trim().Split(new[] { ' ' }, 2);
				Db.ActualizarPerfil(txtNombre.Text.Trim(), ap[0], ap.Length > 1 ? ap[1] : "", correo);
				correoOriginal = correo;
				MessageBox.Show("Perfil actualizado correctamente.", "SAPIENS");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar: " + ex.Message, "SAPIENS");
			}
		}

		private void btnActualizarPass_Click(object sender, EventArgs e)
		{
			if (txtPassActual.Text == "" || txtPassNueva.Text == "")
			{ MessageBox.Show("Llena la contraseña actual y la nueva.", "SAPIENS"); return; }
			if (txtPassNueva.Text != txtPassConfirmar.Text)
			{ MessageBox.Show("Las contraseñas nuevas no coinciden.", "SAPIENS"); return; }
			if (txtPassNueva.Text.Length < 8)
			{ MessageBox.Show("La nueva contraseña debe tener al menos 8 caracteres.", "SAPIENS"); return; }

			try
			{
				if (!Db.CambiarContrasena(txtPassActual.Text, txtPassNueva.Text))
				{ MessageBox.Show("La contraseña actual es incorrecta.", "SAPIENS"); return; }

				MessageBox.Show("Contraseña actualizada correctamente.", "SAPIENS");
				txtPassActual.Clear(); txtPassNueva.Clear(); txtPassConfirmar.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "SAPIENS");
			}
		}

		// Botones mostrar/ocultar contraseña
		private void btnOjo1_Click(object sender, EventArgs e)
		{ txtPassActual.UseSystemPasswordChar = !txtPassActual.UseSystemPasswordChar; }
		private void btnOjo2_Click(object sender, EventArgs e)
		{ txtPassNueva.UseSystemPasswordChar = !txtPassNueva.UseSystemPasswordChar; }
		private void btnOjo3_Click(object sender, EventArgs e)
		{ txtPassConfirmar.UseSystemPasswordChar = !txtPassConfirmar.UseSystemPasswordChar; }

		private void chkTema_CheckedChanged(object sender, EventArgs e)
		{
			if (chkTema.Checked)
			{
				MessageBox.Show("El tema no esta dispo .", "SAPIENS");
				chkTema.Checked = false;
			}
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Seguro que quieres cerrar sesión?", "SAPIENS",
				MessageBoxButtons.YesNo) == DialogResult.Yes)
				cerrarSesion();
		}

		private void pnlCard_Paint(object sender, PaintEventArgs e)
		{
			var p = (Panel)sender;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
				Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
		}
	}
}

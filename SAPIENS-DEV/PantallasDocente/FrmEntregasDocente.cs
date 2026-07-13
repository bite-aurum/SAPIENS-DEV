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

namespace SAPIENS_DEV.PantallasDocente
{
	public partial class FrmEntregasDocente : Form
	{
		FrmMenuDocente menu;

		public FrmEntregasDocente(FrmMenuDocente m)
		{
			InitializeComponent();
			menu = m;
		}

		private void FrmEntregasDocente_Load(object sender, EventArgs e)
		{
			try
			{
				flpEntregas.Controls.Clear();
				DataTable dt = Db.ObtenerEntregasDoc(Db.IdUsuario);
				int proyActual = -1;
				foreach (DataRow r in dt.Rows)
				{
					int idP = Convert.ToInt32(r["id_proyecto"]);
					if (idP != proyActual)
					{
						proyActual = idP;
						string clave = "PROY-" + Convert.ToDateTime(r["fecha_inicio"]).Year + "-" + idP.ToString("D3");
						flpEntregas.Controls.Add(new Label
						{
							Text = clave + " — " + r["proyecto"].ToString().ToUpper(),
							Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
							ForeColor = Color.FromArgb(107, 114, 128),
							AutoSize = true,
							Margin = new Padding(0, 14, 0, 6)
						});
					}
					flpEntregas.Controls.Add(CrearTarjeta(r));
				}
				if (dt.Rows.Count == 0)
					flpEntregas.Controls.Add(new Label
					{
						Text = "Aún no hay entregas programadas.",
						AutoSize = true,
						ForeColor = Color.FromArgb(107, 114, 128),
						Font = new Font("Segoe UI", 10F)
					});
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar entregas: " + ex.Message, "SAPIENS");
			}
		}

		Panel CrearTarjeta(DataRow r)
		{
			var card = new Panel { Size = new Size(920, 58), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
			card.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
				Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);

			DateTime fl = Convert.ToDateTime(r["fecha_limite"]);
			string estado = r["estado"].ToString();
			bool tardia = estado == "pendiente" && fl.Date < DateTime.Today;

			card.Controls.Add(new Label
			{
				Text = r["titulo"].ToString(),
				Font = new Font("Segoe UI", 10F, FontStyle.Bold),
				ForeColor = Color.FromArgb(31, 41, 55),
				Location = new Point(20, 8),
				Size = new Size(640, 22)
			});
			card.Controls.Add(new Label
			{
				Text = "ENT-" + Convert.ToInt32(r["id_entrega"]).ToString("D3") + " · Programada: " + fl.ToString("dd/MM/yyyy") + " · Equipo completo",
				Font = new Font("Segoe UI", 8F),
				ForeColor = Color.FromArgb(107, 114, 128),
				Location = new Point(20, 30),
				Size = new Size(640, 18)
			});

			Color[] c = tardia
				? new[] { Color.FromArgb(254, 226, 226), Color.FromArgb(239, 68, 68) }
				: FrmTareasDocente.ColoresEstado(estado);
			card.Controls.Add(FrmTareasDocente.Chip(
				tardia ? "Tardía" : FrmTareasDocente.Capital(estado), c, new Point(780, 17), 120));
			return card;
		}

		private void btnNueva_Click(object sender, EventArgs e)
		{
			menu.IrNuevaEntrega();
		}
	}
}

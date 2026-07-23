using SAPIENS_DEV.AccesoDatos;
using SAPIENS_DEV.PantallasDocente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPIENS_DEV.PantallasAlumno
{
	public partial class FrmDetalleEntregaAlumno : Form
	{
		FrmMenuAlumno menu;
		int idEntrega;
		string tituloEntrega = "";
		string archivoRuta = "";

		public FrmDetalleEntregaAlumno(FrmMenuAlumno m, int id)
		{
			InitializeComponent();
			menu = m;
			idEntrega = id;
		}

		private void FrmDetalleEntregaAlumno_Load(object sender, EventArgs e)
		{
			try
			{
				DataRow r = Db.EntregaDetalle(idEntrega);
				tituloEntrega = r["titulo"].ToString();
				DateTime fl = Convert.ToDateTime(r["fecha_limite"]);
				string clave = "PROY-" + Convert.ToDateTime(r["fecha_inicio"]).Year + "-" +
							   Convert.ToInt32(r["id_proyecto"]).ToString("D3");
				string estado = r["estado"].ToString();
				bool tardia = estado == "pendiente" && fl.Date < DateTime.Today;

				// ---- Tarjeta de información ----
				pnlInfo.Controls.Add(new Label
				{
					Text = "ENT-" + idEntrega.ToString("D3") + " · " + clave + " · Prof. " + r["docente"],
					Font = new Font("Segoe UI", 8.5F),
					ForeColor = Color.FromArgb(107, 114, 128),
					Location = new Point(20, 12),
					Size = new Size(700, 18)
				});
				pnlInfo.Controls.Add(new Label
				{
					Text = "Fecha programada: " + fl.ToString("dd/MM/yyyy"),
					Font = new Font("Segoe UI", 8.5F),
					ForeColor = Color.FromArgb(107, 114, 128),
					Location = new Point(20, 32),
					Size = new Size(700, 18)
				});
				pnlInfo.Controls.Add(new Label
				{
					Text = "Descripción: " + (r["descripcion"] == DBNull.Value ? "—" : r["descripcion"]),
					Font = new Font("Segoe UI", 8.5F),
					ForeColor = Color.FromArgb(31, 41, 55),
					Location = new Point(20, 54),
					Size = new Size(900, 18),
					AutoEllipsis = true
				});
				Color[] c = tardia
					? new[] { Color.FromArgb(254, 226, 226), Color.FromArgb(239, 68, 68) }
					: FrmTareasDocente.ColoresEstado(estado);
				pnlInfo.Controls.Add(FrmTareasDocente.Chip(
					tardia ? "Tardía" : FrmTareasDocente.Capital(estado), c, new Point(840, 10), 90));

				CargarArchivos();

				// ---- Info de la entrega ----
				flpInfoEnt.Controls.Clear();
				flpInfoEnt.Controls.Add(FilaInfo("Clave", "ENT-" + idEntrega.ToString("D3"), Color.FromArgb(31, 41, 55)));
				flpInfoEnt.Controls.Add(FilaInfo("Proyecto", clave, Color.FromArgb(31, 41, 55)));
				flpInfoEnt.Controls.Add(FilaInfo("Fecha programada", fl.ToString("dd/MM/yyyy"), Color.FromArgb(59, 130, 246)));
				flpInfoEnt.Controls.Add(FilaInfo("Estado actual", tardia ? "Tardía" : FrmTareasDocente.Capital(estado),
					tardia ? Color.FromArgb(239, 68, 68) : (estado == "entregada" ? Color.FromArgb(16, 185, 129) : Color.FromArgb(245, 158, 11))));
				flpInfoEnt.Controls.Add(FilaInfo("Docente", "Prof. " + r["docente"], Color.FromArgb(31, 41, 55)));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar la entrega: " + ex.Message, "SAPIENS");
			}
		}

		void CargarArchivos()
		{
			flpArchivos.Controls.Clear();
			DataTable ar = Db.ArchivosDeEntrega(idEntrega);
			foreach (DataRow x in ar.Rows)
				flpArchivos.Controls.Add(new Label
				{
					Text = "📄 " + x["nombre_archivo"] + "  ·  " + x["alumno"] + "  ·  " +
						   Convert.ToDateTime(x["fecha_subida"]).ToString("dd/MM/yyyy"),
					Font = new Font("Segoe UI", 8.5F),
					ForeColor = Color.FromArgb(31, 41, 55),
					AutoSize = true,
					Margin = new Padding(0, 0, 0, 8)
				});
			if (ar.Rows.Count == 0)
				flpArchivos.Controls.Add(new Label
				{
					Text = "🗎  Sin archivos aún",
					Font = new Font("Segoe UI", 9F),
					ForeColor = Color.FromArgb(107, 114, 128),
					AutoSize = true
				});
		}

		Panel FilaInfo(string etiqueta, string valor, Color colorValor)
		{
			var fila = new Panel { Size = new Size(410, 28), BackColor = Color.White, Margin = new Padding(0) };
			fila.Controls.Add(new Label
			{
				Text = etiqueta,
				Font = new Font("Segoe UI", 8.5F),
				ForeColor = Color.FromArgb(107, 114, 128),
				Location = new Point(0, 5),
				Size = new Size(160, 18)
			});
			fila.Controls.Add(new Label
			{
				Text = valor,
				Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
				ForeColor = colorValor,
				Location = new Point(160, 5),
				Size = new Size(250, 18),
				TextAlign = ContentAlignment.MiddleRight
			});
			fila.Paint += (s, e) => {
				using (var p = new Pen(Color.FromArgb(229, 231, 235)))
					e.Graphics.DrawLine(p, 0, fila.Height - 1, fila.Width, fila.Height - 1);
			};
			return fila;
		}

		void SeleccionarArchivo(string ruta)
		{
			archivoRuta = ruta;
			lblArchivoSel.Text = "📄 " + Path.GetFileName(ruta);
			lblArchivoSel.ForeColor = Color.FromArgb(16, 185, 129);
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog
			{
				Title = "Selecciona el archivo de tu entrega",
				Filter = "Documentos|*.pdf;*.docx;*.doc;*.pptx;*.xlsx;*.png;*.jpg;*.sql;*.zip|Todos|*.*"
			};
			if (ofd.ShowDialog() == DialogResult.OK) SeleccionarArchivo(ofd.FileName);
		}

		private void pnlDrop_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

		private void pnlDrop_DragDrop(object sender, DragEventArgs e)
		{
			string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (archivos.Length > 0) SeleccionarArchivo(archivos[0]);
		}

		private void btnSubir_Click(object sender, EventArgs e)
		{
			if (archivoRuta == "")
			{ MessageBox.Show("Selecciona o arrastra un archivo primero.", "SAPIENS"); return; }

			try
			{
				Db.SubirArchivoEntrega(Path.GetFileName(archivoRuta), archivoRuta,
					Path.GetExtension(archivoRuta).TrimStart('.'), idEntrega, Db.IdUsuario);
				MessageBox.Show("Archivo subido. La entrega se marcó como Entregada.", "SAPIENS");
				menu.IrDetalleEntrega(idEntrega, tituloEntrega); // recarga
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al subir: " + ex.Message, "SAPIENS");
			}
		}

		private void btnVolver_Click(object sender, EventArgs e) { menu.IrEntregas(); }

		private void pnlCard_Paint(object sender, PaintEventArgs e)
		{
			var p = (Panel)sender;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
				Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
		}

		private void pnlDrop_Paint(object sender, PaintEventArgs e)
		{
			using (var pen = new Pen(Color.FromArgb(209, 213, 219)) { DashStyle = DashStyle.Dash })
				e.Graphics.DrawRectangle(pen, 0, 0, pnlDrop.Width - 1, pnlDrop.Height - 1);
		}
	}
}

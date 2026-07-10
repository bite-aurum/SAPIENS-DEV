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
    public partial class FrmNuevoProyecto : Form
    {
        FrmMenuDocente menu;

        class AlumnoItem
        {
            public int Id; public string Texto; public string Rol;
            public override string ToString() { return Texto + "  ·  " + Rol; }
        }
        List<AlumnoItem> agregados = new List<AlumnoItem>();

        public FrmNuevoProyecto(FrmMenuDocente m)
        {
            InitializeComponent();
            menu = m;
        }

        private void FrmNuevoProyecto_Load(object sender, EventArgs e)
        {
            cmbRol.SelectedIndex = 0;
            dtpFin.Value = DateTime.Today.AddMonths(2);
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                System.Drawing.Color.FromArgb(229, 231, 235), ButtonBorderStyle.Solid);
        }

        private void btnBuscarAgregar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            { MessageBox.Show("Escribe una matrícula o nombre.", "SAPIENS"); return; }

            try
            {
                DataTable dt = Db.BuscarAlumno(txtBuscar.Text.Trim());
                if (dt.Rows.Count == 0)
                { MessageBox.Show("No se encontró ningún alumno.", "SAPIENS"); return; }

                DataRow r = dt.Rows[0];
                int id = Convert.ToInt32(r["id_alumno"]);
                foreach (AlumnoItem a in agregados)
                    if (a.Id == id) { MessageBox.Show("Ese alumno ya está agregado.", "SAPIENS"); return; }

                var item = new AlumnoItem
                {
                    Id = id,
                    Texto = r["nombre_completo"] + " (" + r["matricula"] + ")",
                    Rol = cmbRol.Text
                };
                agregados.Add(item);
                lstAgregados.Items.Add(item);
                lblAgregados.Text = "Alumnos agregados (" + agregados.Count + ")";
                txtBuscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "SAPIENS");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstAgregados.SelectedIndex < 0) return;
            agregados.RemoveAt(lstAgregados.SelectedIndex);
            lstAgregados.Items.RemoveAt(lstAgregados.SelectedIndex);
            lblAgregados.Text = "Alumnos agregados (" + agregados.Count + ")";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || txtProblematica.Text.Trim() == "")
            { MessageBox.Show("Llena título, descripción y problemática.", "SAPIENS"); return; }

            if (dtpFin.Value.Date <= dtpInicio.Value.Date)
            { MessageBox.Show("La fecha fin debe ser posterior a la fecha de inicio.", "SAPIENS"); return; }

            try
            {
                int id = Db.CrearProyecto(txtTitulo.Text.Trim(), txtDescripcion.Text.Trim(),
                    txtProblematica.Text.Trim(), txtObjetivos.Text.Trim(),
                    dtpInicio.Value, dtpFin.Value, Db.IdUsuario);

                foreach (AlumnoItem a in agregados)
                    Db.AsignarAlumno(id, a.Id, a.Rol.ToLower());

                MessageBox.Show("Proyecto guardado correctamente.", "SAPIENS");
                menu.IrProyectos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "SAPIENS");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menu.IrProyectos();
        }
    }
}

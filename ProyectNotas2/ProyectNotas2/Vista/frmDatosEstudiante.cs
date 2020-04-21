using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectNotas2.Model;

namespace ProyectNotas2.Vista
{
    public partial class frmDatosEstudiante : Form
    {
        public frmDatosEstudiante()
        {
            InitializeComponent();
        }

        estudiante Est = new estudiante();

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                Est.nombre_estudiante = txtNombreEstudiante.Text;
                Est.apellido = txtApellido.Text;
                Est.usuario = txtUsuario.Text;
                Est.contrasena = txtContrasena.Text;

                db.estudiante.Add(Est);
                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                var tb_Estudiante = db.estudiante;
                foreach (var iterarEstudiante in tb_Estudiante)
                {
                    dgvEstudiante.Rows.Add(iterarEstudiante.id_estudiante, iterarEstudiante.nombre_estudiante, iterarEstudiante.apellido, iterarEstudiante.usuario, iterarEstudiante.contrasena);
                }
            }
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                string Id = dgvEstudiante.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                Est = db.estudiante.Where(VerificarId => VerificarId.id_estudiante == IdC).First();
                Est.nombre_estudiante = txtNombreEstudiante.Text;
                Est.apellido = txtApellido.Text;
                Est.usuario = txtUsuario.Text;
                Est.contrasena = txtContrasena.Text;
                db.Entry(Est).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

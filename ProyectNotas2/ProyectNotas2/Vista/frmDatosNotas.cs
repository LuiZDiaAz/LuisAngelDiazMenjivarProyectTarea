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
    public partial class frmDatosNotas : Form
    {
        public frmDatosNotas()
        {
            InitializeComponent();
        }

        nota Not = new nota();

        void cargardatos()
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                var jointablas = from tbAlumno in db.estudiante
                                 from tbmateria in db.materia
                                 from tbnota in db.nota
                                 where tbAlumno.id_estudiante == tbnota.id_estudante && tbmateria.id_materia == tbnota.id_materia

                                 select new
                                 {
                                     Id = tbnota.id_nota,
                                     Id_Alumno = tbAlumno.id_estudiante,
                                     Nombre_Alumno = tbAlumno.nombre_estudiante + "" + tbAlumno.apellido,
                                     Id_Materia = tbmateria.id_materia,
                                     Materia = tbmateria.nombre_materia,
                                     Nota = tbnota.notas
                                 };
                dgvNota.DataSource = jointablas.ToList();
                dgvNota.Columns[1].Visible = false;
                dgvNota.Columns[3].Visible = false;

            }
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                Not.id_nota = int.Parse(txtIdnota.Text);
                Not.id_estudante = int.Parse(txtIdestudiante.Text);
                Not.id_materia = int.Parse(txtIdnota.Text);
                Not.notas = Convert.ToDouble(txtNota.Text);

                db.nota.Add(Not);
                db.SaveChanges();
            }
            cargardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                string Id = dgvNota.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                Not = db.nota.Where(VerificarId => VerificarId.id_nota == IdC).First();
                Not.id_estudante = int.Parse(txtIdestudiante.Text);
                Not.id_materia = int.Parse(txtIdmateria.Text);
                Not.notas = Convert.ToDouble(txtNota.Text);
                db.Entry(Not).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            cargardatos();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                String Id = dgvNota.CurrentRow.Cells[0].Value.ToString();

                Not = db.nota.Find(int.Parse(Id));
                db.nota.Remove(Not);
                db.SaveChanges();
            }
            cargardatos();
        }

        private void frmDatosNotas_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}

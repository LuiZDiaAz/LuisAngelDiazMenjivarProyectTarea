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
    public partial class frmDatosMateria : Form
    {
        public frmDatosMateria()
        {
            InitializeComponent();
        }

        materia Mate = new materia();

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                Mate.id_materia = int.Parse(txtIdmateria.Text);
                Mate.nombre_materia = txtNombremateria.Text;

                db.materia.Add(Mate);
                db.SaveChanges();
            }
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                string Id = dgvMateria.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                Mate = db.materia.Where(VerificarId => VerificarId.id_materia == IdC).First();
                Mate.nombre_materia = txtNombremateria.Text;
                db.Entry(Mate).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void bttnCargar_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                var tb_Materia = db.materia;
                foreach (var iterarMateria in tb_Materia)
                {
                    dgvMateria.Rows.Add(iterarMateria.id_materia, iterarMateria.nombre_materia);
                }
            }
        }
    }
}

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
using ProyectNotas2.Vista;

namespace ProyectNotas2
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void bttnIniciarSesion_Click(object sender, EventArgs e)
        {
            using (NotasEstudiantesEntities1 db = new NotasEstudiantesEntities1())
            {
                var lista = from Usuario in db.estudiante
                            where Usuario.usuario == txtUsuario.Text
                            && Usuario.contrasena == txtContrasena.Text
                            select Usuario;

                if (lista.Count() > 0)
                {
                    MessageBox.Show("Bienvenido");
                    frmMennu f = new frmMennu();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Informacion Incorrecta");
                }
            }
        }
    }
}

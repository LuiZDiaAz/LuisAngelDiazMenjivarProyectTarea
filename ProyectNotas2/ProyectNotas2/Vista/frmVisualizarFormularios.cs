using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectNotas2.Vista
{
    public partial class frmVisualizarFormularios : Form
    {
        public frmVisualizarFormularios()
        {
            InitializeComponent();
        }

        private void bttnCargarFormularios_Click(object sender, EventArgs e)
        {
            frmDatosEstudiante Not = new frmDatosEstudiante();
            Not.MdiParent = this;
            Not.Show();

            frmDatosMateria Mate = new frmDatosMateria();
            Mate.MdiParent = this;
            Mate.Show();

            frmDatosNotas Est = new frmDatosNotas();
            Est.MdiParent = this;
            Est.Show();
        }
    }
}

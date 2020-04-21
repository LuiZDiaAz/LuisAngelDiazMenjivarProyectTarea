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
    public partial class frmMennu : Form
    {
        public frmMennu()
        {
            InitializeComponent();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEstudiante f = new frmDatosEstudiante();
            f.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDatosMateria f = new frmDatosMateria();
            f.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmDatosNotas f = new frmDatosNotas();
            f.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmVisualizarFormularios f = new frmVisualizarFormularios();
            f.Show();
        }
    }
}

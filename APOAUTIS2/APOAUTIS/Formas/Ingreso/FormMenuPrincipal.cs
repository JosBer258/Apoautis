using APOAUTIS.Formas.Alumnos;
using APOAUTIS.Formas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Ingreso
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricula mat = new FrmMatricula();
            mat.ShowDialog();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mydbDataSet.alumnos' Puede moverla o quitarla según sea necesario.
         

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaAlumnos alumnos = new FormaAlumnos();
            alumnos.ShowDialog();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario User = new FormUsuario();
            User.ShowDialog();
        }
    }
}

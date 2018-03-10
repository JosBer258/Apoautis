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

        private void entrevistaDePadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void estudioSocioeconomicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void evaluacionPsicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEvalPsic evalPsic = new FormaEvalPsic();
            evalPsic.ShowDialog();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEntPadres entPadres = new FormaEntPadres();
            entPadres.ShowDialog();
        }

        private void vistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaEntrevistaPadres vistaEntPadres = new VistaEntrevistaPadres();
            vistaEntPadres.ShowDialog();
        }

        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormaEstSocEco estSocioEco = new FormaEstSocEco();
            estSocioEco.ShowDialog();
        }

        private void vistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VistaEstSoc vistaEsSc = new VistaEstSoc();
            vistaEsSc.ShowDialog();
        }

        private void ingreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricula mat = new FrmMatricula();
            mat.ShowDialog();
        }

        private void vistaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VistaMatricula vistaMat = new VistaMatricula();
            vistaMat.ShowDialog();
        }
    }
}

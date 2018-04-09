using APOAUTIS.Clases;
using APOAUTIS.Formas.Alumnos;
using APOAUTIS.Formas.Entrevista_Padres;
using APOAUTIS.Formas.Matricula;
using APOAUTIS.Formas.Responsables;
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
        private static int state;

        public int State { get {  return state; }
            set { state = value; }
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

           
            if (State != 3)
            {
                usuariosToolStripMenuItem.Visible = false;
            }
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

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorialMatriculas Hist = new FormHistorialMatriculas();
            Hist.ShowDialog();
        }

        private void ingresosGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresoGastos Ing = new FormIngresoGastos();
            Ing.ShowDialog();
        }

        private void montoMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMontoMatricula Mon = new FormMontoMatricula();
            Mon.ShowDialog();
        }

        private void responsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoResponsable Resp = new FormMantenimientoResponsable();
            Resp.ShowDialog();
        }

        private void pruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rangoDeMensualidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRangoMensualidad Mens = new FormRangoMensualidad();
            Mens.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

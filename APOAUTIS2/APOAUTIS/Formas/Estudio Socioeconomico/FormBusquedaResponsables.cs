using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Estudio_Socioeconomico
{
    public partial class FormBusquedaResponsables : Form
    {
        Clases.C_Validaciones Cl_Valid = new Clases.C_Validaciones();
        public string Accion;


        public FormBusquedaResponsables()
        {
            InitializeComponent();
        }

        private void Bttn_Cancelar_responsables_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btm_buscar_responsable_Click(object sender, EventArgs e)
        {
            DGV_responsables.DataSource = Clases.C_EstudioSocioMetodos.BuscarS(Txt_FiltroResponsable.Text);

        }

        public static Clases.C_responsablesMadre madreSeleccionado { get; set; }
        public static Clases.C_DatosGenerales AlumnoSeleccionado { get; set; }
        public static Clases.C_responsablePadre padreSeleccionado { get; set; }
        public static Clases.C_ResponsablesOtro otrorespSeleccionado { get; set; }
        public static Clases.C_InformacionFamilia Infofamilia { get; set; }
        public static Clases.C_LugaresRecreacion Recreacion { get; set; }
        public static Clases.C_HistorialMedico Medico { get; set; }
        public static Clases.C_InformacionVivienda vivienda{ get; set; }
        public static Clases.C_EstudioSocioEc socio { get; set; }




        private void btm_Aceptar_responsables_Click(object sender, EventArgs e)
        {


            if (DGV_responsables.SelectedRows.Count == 1)
            {
                double cod = Convert.ToDouble(DGV_responsables.CurrentRow.Cells[0].Value);

                AlumnoSeleccionado = Clases.C_EstudioSocioMetodos.ObtenerDatosGenerales(cod);
                madreSeleccionado = Clases.C_EstudioSocioMetodos.ObtenerMadre(cod);
                padreSeleccionado = Clases.C_EstudioSocioMetodos.ObtenerPadre(cod);
                otrorespSeleccionado = Clases.C_EstudioSocioMetodos.ObtenerOtroResp(cod);
                Infofamilia = Clases.C_EstudioSocioMetodos.ObtenerInfofamilia(cod);
                Recreacion = Clases.C_EstudioSocioMetodos.ObtenerRecreacion(cod);
                Medico = Clases.C_EstudioSocioMetodos.ObtenerHistorialMedico(cod);
                vivienda = Clases.C_EstudioSocioMetodos.ObtenerInfoVivienda(cod);
                socio = Clases.C_EstudioSocioMetodos.ObtenerEstudioSE(cod);


                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void DGV_responsables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBusquedaResponsables_Load(object sender, EventArgs e)
        {

        }
    }
    }


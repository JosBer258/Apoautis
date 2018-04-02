using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APOAUTIS.Clases;
using APOAUTIS.Formas.Estudio_Socioeconomico;
using MySql.Data.MySqlClient;

namespace APOAUTIS.Formas.Estudio_Socioeconomico
{
    public partial class FromBusquedaAlumno : Form
    {
        public FromBusquedaAlumno()
        {
            InitializeComponent();
        }



        private void Bttn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_FiltroAlumno_TextChanged(object sender, EventArgs e)
        {


        }

        

        private void btm_buscar_Click(object sender, EventArgs e)
        {
            DGV_Show.DataSource = Clases.C_EstudioSocioMetodos.Buscar(Txt_FiltroAlumno.Text);
        }
   
        public static C_DatosGenerales AlumnoSeleccionado { get;  set; }

        private void btm_Aceptar_Click(object sender, EventArgs e)
        {
            
                if (DGV_Show.SelectedRows.Count == 1)
                {
                    double cod = Convert.ToDouble(DGV_Show.CurrentRow.Cells[0].Value);
                AlumnoSeleccionado = C_EstudioSocioMetodos.ObtenerDatosGenerales(cod);

                    this.Close();
                }
                else
                    MessageBox.Show("debe de seleccionar una fila");
            }
    }
}

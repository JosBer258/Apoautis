using APOAUTIS.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Alumnos
{
    public partial class FormaAlumnos : Form
    {
        C_Alumnos alumno = new C_Alumnos();

        public FormaAlumnos()
        {
            InitializeComponent();
        }

        private void FormaAlumnos_Load(object sender, EventArgs e)
        {
            alumno.Fun_Show(Pest1_Dgv_BsqAlm);
            Pest1_Radio_Alumno.Checked = true;
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Pest1_Txt_BusquedaPorNombre_TextChanged(object sender, EventArgs e)
        {
            if(Pest1_Txt_BusquedaPorNombre.Text == string.Empty)
            {
                alumno.Fun_Show(Pest1_Dgv_BsqAlm);
            }
            else
            {
                alumno.BusquedaCargarDatosNombre(Pest1_Dgv_BsqAlm, Pest1_Txt_BusquedaPorNombre.Text);
            }
            
        }

        private void Pest1_Txt_ID_TextChanged(object sender, EventArgs e)
        {
            if (Pest1_Txt_ID.Text == string.Empty)
            {
                alumno.Fun_Show(Pest1_Dgv_BsqAlm);
            }
            else
            {
                alumno.BusquedaCargarDatosIdentidad(Pest1_Dgv_BsqAlm, Pest1_Txt_ID.Text);
            }

        }

        private void Pest1_Radio_Alumno_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Alumno.Checked == true)
            {
                Pest1_Txt_BusquedaPorNombre.Enabled=true;
                Pest1_Txt_ID.Enabled = false;
                Pest1_Txt_ID.Clear();
            }
            else
            {
                Pest1_Txt_BusquedaPorNombre.Enabled = false;
                Pest1_Txt_ID.Enabled = true;
                Pest1_Txt_BusquedaPorNombre.Clear();
            }
        }

        private void Pest1_Dgv_BsqAlm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            a = Pest1_Dgv_BsqAlm.CurrentCell.ColumnIndex.ToString();
            if (Convert.ToInt16(a) == 1 || Convert.ToInt16(a) == 0 || Convert.ToInt16(a) == 7)
            {

                if (Convert.ToInt16(a) == 0)
                {

                   
                    alumno.CodAlumno11 = Convert.ToInt32(Pest1_Dgv_BsqAlm.CurrentCell.Value.ToString());
                    alumno.FillAlumnosPest2Por(2);
                    
                    

                }
                else
                 if (Convert.ToInt16(a) == 1)
                {
                    alumno.NomAlumno11 = Pest1_Dgv_BsqAlm.CurrentCell.Value.ToString();
                    alumno.FillAlumnosPest2Por(1);

                }
                else
                 if (Convert.ToInt16(a) == 7)
                {
                    alumno.IdAlum11 = Pest1_Dgv_BsqAlm.CurrentCell.Value.ToString();
                    alumno.FillAlumnosPest2Por(3);

                }
                Pest2_Pest1_Txt_Codigo.Text = Convert.ToString(alumno.CodAlumno11);
                Pest2_Pest1_Txt_NombComp.Text = Convert.ToString(alumno.NomAlumno11);
                Pest2_Pest1_Txt_LugarNacimiento.Text = Convert.ToString(alumno.LugarNaciAlum11);
                Pest2_Pest1_Txt_FechaNacimiento.Text = Convert.ToString(alumno.FechaNaciAlum11);
                Pest2_Pest1_Txt_Edad.Text = Convert.ToString(alumno.EdadAlum11);
                Pest2_Pest1_Txt_EdadCronologica.Text = Convert.ToString(alumno.EdadCronologica11);
                Pest2_Pest1_Txt_InstiProcedencia.Text = Convert.ToString(alumno.InstProceAlumno11);
                Pest2_Pest1_Txt_TelefonoFijo.Text = Convert.ToString(alumno.TelFijoAlum11);
                Pest2_Pest1_Txt_Sexo.Text = Convert.ToString(alumno.SexoAlum11);
                Pest2_Pest1_Txt_Identidad.Text = Convert.ToString(alumno.IdAlum11);
                Pest2_Pest1_Txt_Celular.Text = Convert.ToString(alumno.CelAlumno11);
                Pest2_Pest1_Txt_Escolaridad.Text = Convert.ToString(alumno.EscolaridadAlum11);
                Pest2_Pest1_Txt_Direccion.Text = Convert.ToString(alumno.DireccionAlum11);
                Pest2_Pest1_Txt_Instituto.Text = Convert.ToString(alumno.InstDondeEstaIncluido11);
                alumno.MostrarAcontecimientos(Pest2_Pest2_DGV_AconMed);
                alumno.llenarDatosHistoriaMedico();

                Pest2_Pest2_Txt_Medicamentos.Text = Convert.ToString(alumno.UsoMedicamentos1);
                Pest2_Pest2_Txt_Alergias.Text = Convert.ToString(alumno.ExistenciaAlergias1);
                Pest2_Pest2_Txt_GastaMedic.Text = Convert.ToString(alumno.GastosMEdicos1);
                Pest2_Pest2_Txt_EnferPadSuFam.Text = Convert.ToString(alumno.EnfermedadesPadeciFamilia1);
                Pest2_Pest2_Txt_LugRecAtencMedica.Text = Convert.ToString(alumno.LugaresAtencionMedica1);

                MessageBox.Show("Listo");
               
            }
        }
    }
}

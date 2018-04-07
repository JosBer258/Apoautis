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
        C_Responsables resp = new C_Responsables();
        C_Validaciones val = new C_Validaciones();

        private bool Vacios(GroupBox groupBox1)
        {

            int s = 0;

            var boxesx = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxesx)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, "Please fill the required field");
                    s++;
                }
                else
                {
                    errorProvider1.SetError(box, "");
                }

            }
            if (s > 0)
                return false;
            else
            {

                return true;
            }

        }
        private void validacionMenu(GroupBox groupBox1)
        {
            var blankContextMenu = new ContextMenuStrip();
            var boxe1 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxe1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

        }
        public FormaAlumnos()
        {
            InitializeComponent();
        }

        private void FormaAlumnos_Load(object sender, EventArgs e)
        {
            alumno.Fun_Show(Pest1_Dgv_BsqAlm);
            Pest1_Radio_Alumno.Checked = true;
            alumno.GenerarEstado(Pest2_Pest1_Cmb_Estado);
            alumno.VerificarYear();
            validacionMenu(Pest2_Pest3_Grupo_Encargados);
            validacionMenu(Pest2_Pest1_GrupoGeneral);
            Pest2_Pest3_Cmb_Trabaja.SelectedIndex = 0;


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
                    alumno.Fun_Show(Pest1_Dgv_BsqAlm);



                }
                else
                 if (Convert.ToInt16(a) == 1)
                {
                    alumno.NomAlumno11 = Pest1_Dgv_BsqAlm.CurrentCell.Value.ToString();
                    alumno.FillAlumnosPest2Por(1);
                    alumno.Fun_Show(Pest1_Dgv_BsqAlm);
                }
                else
                 if (Convert.ToInt16(a) == 7)
                {
                    alumno.IdAlum11 = Pest1_Dgv_BsqAlm.CurrentCell.Value.ToString();
                    alumno.FillAlumnosPest2Por(3);
                    alumno.Fun_Show(Pest1_Dgv_BsqAlm);
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
               
                resp.Fill_DGV_Resp_Por_Alumno(Pest2_Pest3_DGV_MuestraEncargados, alumno.CodAlumno11);
                Pest2_Pest3_Txt_Codigo.Text= Convert.ToString(resp.ObtenerUltimoCodigoResponsable());
                MessageBox.Show("Listo");
               
            }
        }

        private void Pest2_Pest3_Bttn_Aceptar_Click(object sender, EventArgs e)
        {
           

            if (alumno.CodAlumno11 > 0)
            {
                if (Vacios(Pest2_Pest3_Grupo_Encargados) == true)
                {
                    string srt;
                    if (Pest2_Pest3_Cmb_Trabaja.SelectedIndex == 1)
                    {
                        srt = "No,No Trabaja";
                    }
                    else
                    {
                        srt = Convert.ToString(Pest2_Pest3_Cmb_Trabaja.SelectedItem) + ", " + Pest2_Pest3_Txt_LugarTrabajo.Text;
                    }

                     
                    resp.CodResp = Convert.ToInt32(Pest2_Pest3_Txt_Codigo.Text);
                    resp.NomResp = Pest2_Pest3_Txt_Completo.Text;
                    resp.IdResp = Convert.ToInt32(Pest2_Pest3_Txt_ID.Text);
                    resp.DomResp = Pest2_Pest3_Txt_Domicilio.Text;
                    resp.ProfResp = Pest2_Pest3_Txt_ProfecionUOficio.Text;
                    resp.LugTrab = srt;
                    resp.TelCasResp = Pest2_Pest3_Txt_TelefonoCasa.Text;
                    resp.TelCelResp = Pest2_Pest3_Txt_TelefonoCelular.Text;
                    resp.TelTrabResp = Pest2_Pest3_Txt_TelefonoTrabajo.Text;
                    resp.CorrResp = Pest2_Pest3_Txt_EdadAnos.Text;
                    if (resp.VerificarDuplicidadNombreID() == true)
                    {
                        resp.insertResponsable();
                        resp.insertResponsableAlumno(alumno.CodAlumno11, Convert.ToInt32(Pest2_Pest3_Txt_Codigo.Text));
                        MessageBox.Show("Ingresado Exitosamente");
                        resp.Fill_DGV_Resp_Por_Alumno(Pest2_Pest3_DGV_MuestraEncargados, alumno.CodAlumno11);
                        Pest2_Pest3_Txt_Codigo.Text = Convert.ToString(resp.ObtenerUltimoCodigoResponsable());
                    }
                    else
                    {
                        MessageBox.Show("Existe duplicidad tanto en el nombre o en la identidad");
                    }

                    
                }
            }
            else
            {
                MessageBox.Show("No existe un alumno seleccionado, por favor vuelva a la " +
                    "pantalla de busqueda de alumno y seleccione uno", "Warning");
            }
           
           
           

        }

        private void Pest1_Txt_BusquedaPorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest1_Txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest2_Pest3_Txt_Completo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest2_Pest3_Txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest2_Pest3_Txt_Domicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, Pest2_Pest3_Txt_Domicilio);
        }

        private void Pest2_Pest3_Txt_ProfecionUOficio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest2_Pest3_Txt_EdadAnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarCorreoIngreso(sender, e, Pest2_Pest3_Txt_EdadAnos);
        }

        private void Pest2_Pest3_Txt_LugarTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, Pest2_Pest3_Txt_LugarTrabajo);
        }

        private void Pest2_Pest3_Txt_TelefonoCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest2_Pest3_Txt_TelefonoCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest2_Pest3_Txt_TelefonoTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest2_Pest1_Bttn_Aceptar_Click(object sender, EventArgs e)
        {

            if (alumno.CodAlumno11 > 0)
            {
                if (Vacios(Pest2_Pest1_GrupoGeneral) == true)
                {
                    
                    alumno.updateAlumnos(Pest2_Pest1_Txt_Sexo.Text, Pest2_Pest1_Txt_Direccion.Text,
                        Pest2_Pest1_Txt_TelefonoFijo.Text, Pest2_Pest1_Txt_Celular.Text, Pest2_Pest1_Txt_Escolaridad.Text
                        , Pest2_Pest1_Txt_InstiProcedencia.Text, Pest2_Pest1_Txt_Instituto.Text,
                        alumno.CodAlumno11);
                    MessageBox.Show("Ingresado Exitosamente");
                    alumno.Fun_Show(Pest1_Dgv_BsqAlm);

                }
            }
            else
            {
                MessageBox.Show("No existe un alumno seleccionado, por favor vuelva a la " +
                    "pantalla de busqueda de alumno y seleccione uno", "Warning");
            }


        }

        private void Pest2_Pest1_Txt_Sexo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Pest2_Pest1_Txt_Sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
            val.ValidarGeneroSingleChar(sender, e);
        }

        private void Pest2_Pest1_Txt_Escolaridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest2_Pest1_Txt_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest2_Pest1_Txt_TelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest2_Pest1_Txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, Pest2_Pest1_Txt_Direccion);
        }

        private void Pest2_Pest1_Txt_Instituto_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest2_Pest1_Txt_InstiProcedencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

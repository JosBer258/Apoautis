﻿using APOAUTIS.Clases;
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

        private static string rutaArchivo;
        private static string nomArchivo;

        public static string RutaArchivo
        {
            get
            {
                return rutaArchivo;
            }

            set
            {
                rutaArchivo = value;
            }
        }

        public static string NomArchivo
        {
            get
            {
                return nomArchivo;
            }

            set
            {
                nomArchivo = value;
            }
        }


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

        private void limpiarErrorproviders(GroupBox groupBox1)
        {

            

            var boxesx = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxesx)
            {
               
                    errorProvider1.SetError(box, "");
                
        
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

        private void limpieza(GroupBox groupBox1)
        {
            
            var boxe1 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxe1)
            {
                box.Text = string.Empty;

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
            alumno.VerificarYear();
            validacionMenu(Pest2_Pest3_Grupo_Encargados);
            validacionMenu(Pest2_Pest1_GrupoGeneral);
            Pest2_Pest3_Cmb_Trabaja.SelectedIndex = -1;
            Pest2_Pest1_Cmb_RecEvaluacion.SelectedIndex = -1;

            Pest1_Txt_CantidadAlumnosSeleccionados.Text = Convert.ToString(Pest1_Dgv_BsqAlm.Rows.Count);
            comboBox1.SelectedIndex = 0;


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
            Pest1_Txt_CantidadAlumnosSeleccionados.Text = Convert.ToString(Pest1_Dgv_BsqAlm.Rows.Count);
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
            Pest1_Txt_CantidadAlumnosSeleccionados.Text = Convert.ToString(Pest1_Dgv_BsqAlm.Rows.Count);
        }

        private void Pest1_Radio_Alumno_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_Alumno.Checked == true)
            {
                Pest1_Txt_BusquedaPorNombre.Enabled=true;
                Pest1_Txt_ID.Enabled = false;
                Pest1_Txt_ID.Clear();
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = -1;
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
                alumno.GenerarEstado(Pest2_Pest1_Cmb_Estado, 2);
                Pest2_Pest1_Cmb_Estado.SelectedValue = alumno.EstadoAlumno;
                Pest2_Pest1_Txt_TelefonoEmergencia.Text = alumno.EmergTelefono1;
                textBox1Pest2_Pest1_Txt_lugarEmergencia.Text = alumno.EmergLugar1;
                alumno.MostrarAcontecimientos(Pest2_Pest2_DGV_AconMed);
                alumno.llenarDatosHistoriaMedico();
                alumno.GenerarEstado(Pest2_Pest3_Cmb_Estado, 3);
                alumno.GenerarJornada(Pest2_Pest1_Cmb_Jornada);
                resp.GenerarEstado(Pest2_Pest3_Cmb_TipoResponsable);
                Pest2_Pest3_Cmb_Trabaja.SelectedIndex = 0;
                alumno.llenarDatosMatricula(Convert.ToInt32(Pest2_Pest1_Txt_Codigo.Text));
                if (alumno.CodMatricula <= 0)
                {
                    Pest2_Pest1_GrupoMatricula.Enabled = false;
                    limpieza(Pest2_Pest1_GrupoMatricula);
                    Pest2_Pest1_Cmb_Jornada.DataSource = null;
                    Pest2_Pest1_Cmb_RecEvaluacion.SelectedIndex = -1;


                }
                else
                {
                    Pest2_Pest1_GrupoMatricula.Enabled = true;
                    Pest2_Pest1_Cmb_Jornada.SelectedValue = alumno.Jornada;
                    Pest2_Pest1_Cmb_RecEvaluacion.SelectedItem = alumno.RecibioEvalu.ToUpper();
                    Pest2_Pest1_Txt_FechaIngreso.Text = alumno.FechaIngreso;
                    Pest2_Pest1_Txt_Observaciones.Text = alumno.Observaciones;
                    Pest2_Pest1_Txt_AIngreso.Text = alumno.AnioIngreso;
                }
              

                Pest2_Pest2_Txt_Medicamentos.Text = Convert.ToString(alumno.UsoMedicamentos1);
                Pest2_Pest2_Txt_Alergias.Text = Convert.ToString(alumno.ExistenciaAlergias1);
                Pest2_Pest2_Txt_GastaMedic.Text = Convert.ToString(alumno.GastosMEdicos1);
                Pest2_Pest2_Txt_EnferPadSuFam.Text = Convert.ToString(alumno.EnfermedadesPadeciFamilia1);
                Pest2_Pest2_Txt_LugRecAtencMedica.Text = Convert.ToString(alumno.LugaresAtencionMedica1);
               
                resp.Fill_DGV_Resp_Por_Alumno(Pest2_Pest3_DGV_MuestraEncargados, alumno.CodAlumno11);
                Pest2_Pest3_Txt_Codigo.Text= Convert.ToString(resp.ObtenerUltimoCodigoResponsable());
                Vacios(Pest2_Pest1_GrupoGeneral);
                limpieza(Pest1_Grupo_OpcionesBusqueda);
                MessageBox.Show("Listo");
                
               
            }
        }

        private void Pest2_Pest3_Bttn_Aceptar_Click(object sender, EventArgs e)
        {
           

            if (Pest2_Pest1_Txt_Codigo.Text != string.Empty)
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
                    resp.IdResp = Pest2_Pest3_Txt_ID.Text;
                    resp.DomResp = Pest2_Pest3_Txt_Domicilio.Text;
                    resp.ProfResp = Pest2_Pest3_Txt_ProfecionUOficio.Text;
                    resp.LugTrab = srt;
                    resp.TelCasResp = Pest2_Pest3_Txt_TelefonoCasa.Text;
                    resp.TelCelResp = Pest2_Pest3_Txt_TelefonoCelular.Text;
                    resp.TelTrabResp = Pest2_Pest3_Txt_TelefonoTrabajo.Text;
                    resp.CorrResp = Pest2_Pest3_Txt_EdadAnos.Text;
                    resp.EstResp = Convert.ToInt32(Pest2_Pest3_Cmb_Estado.SelectedValue);

                    if (resp.VerificarDuplicidadNombreID() == true)
                    {
                        resp.insertResponsable();
                        resp.insertResponsableAlumno(Convert.ToInt32(Pest2_Pest1_Txt_Codigo.Text), Convert.ToInt32(Pest2_Pest3_Txt_Codigo.Text), 
                            Convert.ToInt32(Pest2_Pest3_Cmb_TipoResponsable.SelectedValue));
                        MessageBox.Show("Ingresado Exitosamente");
                        limpieza(Pest2_Pest3_Grupo_Encargados);
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

            if (Pest2_Pest1_Txt_Codigo.Text!=string.Empty)
            {
                Vacios(Pest2_Pest1_GrupoGeneral);
              
                    if (Vacios(Pest2_Pest1_GrupoGeneral) == true)
                    {



                      
                       
                            if (alumno.CodMatricula <= 0)
                            {
                                alumno.updateAlumnos(Pest2_Pest1_Txt_NombComp.Text, Pest2_Pest1_Txt_Sexo.Text, Pest2_Pest1_Txt_Identidad.Text, Pest2_Pest1_Txt_Direccion.Text,
                          Pest2_Pest1_Txt_TelefonoFijo.Text, Pest2_Pest1_Txt_Celular.Text, Pest2_Pest1_Txt_Escolaridad.Text
                          , Pest2_Pest1_Txt_InstiProcedencia.Text, Pest2_Pest1_Txt_Instituto.Text,
                           Convert.ToInt32(Pest2_Pest1_Cmb_Estado.SelectedValue),
                           textBox1Pest2_Pest1_Txt_lugarEmergencia.Text,
                           Pest2_Pest1_Txt_TelefonoEmergencia.Text, alumno.CodAlumno11);
                            MessageBox.Show("Ingresado Exitosamente");
                            alumno.Fun_Show(Pest1_Dgv_BsqAlm);
                        }
                            else if(Pest2_Pest1_GrupoMatricula.Enabled == true && Vacios(Pest2_Pest1_GrupoMatricula) == true &&
                                alumno.CodMatricula > 0)
                            {
                                alumno.updateMatricula(Convert.ToInt32(Pest2_Pest1_Cmb_Jornada.SelectedValue),
                                Pest2_Pest1_Cmb_RecEvaluacion.SelectedItem.ToString(), Pest2_Pest1_Txt_Observaciones.Text
                                , alumno.CodAlumno11, alumno.CodMatricula);

                            alumno.updateAlumnos(Pest2_Pest1_Txt_NombComp.Text, Pest2_Pest1_Txt_Sexo.Text, Pest2_Pest1_Txt_Identidad.Text, Pest2_Pest1_Txt_Direccion.Text,
                          Pest2_Pest1_Txt_TelefonoFijo.Text, Pest2_Pest1_Txt_Celular.Text, Pest2_Pest1_Txt_Escolaridad.Text
                          , Pest2_Pest1_Txt_InstiProcedencia.Text, Pest2_Pest1_Txt_Instituto.Text,
                           Convert.ToInt32(Pest2_Pest1_Cmb_Estado.SelectedValue),
                           textBox1Pest2_Pest1_Txt_lugarEmergencia.Text,
                           Pest2_Pest1_Txt_TelefonoEmergencia.Text, alumno.CodAlumno11);
                            errorProvider1.SetError(Pest2_Pest1_GrupoMatricula, "");
                            MessageBox.Show("Ingresado Exitosamente");
                            alumno.Fun_Show(Pest1_Dgv_BsqAlm);
                        }
                        else if (Pest2_Pest1_GrupoMatricula.Enabled == true && Vacios(Pest2_Pest1_GrupoMatricula) == false &&
                            alumno.CodMatricula > 0)
                        {
                            errorProvider1.SetError(Pest2_Pest1_GrupoMatricula, "Por Favor, LLene los campos restantes");
                        }



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

        private void Pest2_Pest3_Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            if( Pest2_Pest1_Txt_Codigo.Text!=string.Empty)
            {
                limpieza(Pest2_Pest3_Grupo_Encargados);
                Pest2_Pest3_Txt_Codigo.Text = Convert.ToString(resp.ObtenerUltimoCodigoResponsable());
            }
            else
            {
                limpieza(Pest2_Pest3_Grupo_Encargados);
                Pest2_Pest3_DGV_MuestraEncargados.DataSource = null;
                Pest2_Pest3_Cmb_Estado.DataSource = null;
                Pest2_Pest3_Cmb_TipoResponsable.DataSource = null;
                Pest2_Pest3_Cmb_Trabaja.SelectedIndex = -1;
                Pest2_Pest1_Cmb_Jornada.DataSource=null;
                Pest2_Pest1_Cmb_RecEvaluacion.SelectedIndex = -1;
            }
        }

        private void Pest2_Pest1_Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            limpieza(Pest2_Pest1_GrupoGeneral);
            limpieza(Pest2_Pest1_GrupoMatricula);

            limpiarErrorproviders(Pest2_Pest1_GrupoGeneral);
            limpiarErrorproviders(Pest2_Pest1_GrupoMatricula);
            limpiarErrorproviders(Pest2_Pest3_Grupo_Encargados);

        }

        private void Pest2_Pest1_Txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Pest1_Txt_Codigo.Text == string.Empty)
            {
                Pest2_Pest3_DGV_MuestraEncargados.DataSource = null;
                Pest2_Pest2_DGV_AconMed.DataSource=null;
                Pest2_Pest3_Cmb_Estado.DataSource = null;
                Pest2_Pest1_Cmb_Estado.DataSource = null;
                Pest2_Pest3_Cmb_TipoResponsable.DataSource = null;
                Pest2_Pest3_Cmb_Trabaja.SelectedIndex = -1;
                limpieza(Pest2_Pest2_Grupo_Historial);
                limpieza(Pest2_Pest3_Grupo_Encargados);
                Pest2_Pest1_Cmb_Jornada.DataSource = null;
                Pest2_Pest1_Cmb_RecEvaluacion.SelectedIndex = -1;
            }
        }

        private void textBox1Pest2_Pest1_Txt_lugarEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios_Direccion(sender, e, textBox1Pest2_Pest1_Txt_lugarEmergencia);
        }

        private void Pest2_Pest1_Txt_TelefonoEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void Pest2_Pest1_Cmb_RecEvaluacion_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Pest2_Pest3_Cmb_Trabaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest2_Pest3_Cmb_Trabaja.SelectedIndex == 1)
            {
                Pest2_Pest3_Txt_LugarTrabajo.Enabled = false;
                Pest2_Pest3_Txt_LugarTrabajo.Text = "No trabaja";
                Pest2_Pest3_Txt_TelefonoTrabajo.Text = "No trabaja";
                Pest2_Pest3_Txt_TelefonoTrabajo.Enabled = false;

            }
            else
            {
                Pest2_Pest3_Txt_TelefonoTrabajo.Clear();
                Pest2_Pest3_Txt_TelefonoTrabajo.Enabled = true;
                Pest2_Pest3_Txt_LugarTrabajo.Enabled = true;
                Pest2_Pest3_Txt_LugarTrabajo.Clear();
            }
        }

        private void Pest2_Pest1_Txt_Observaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest2_Pest3_Grupo_Encargados_Enter(object sender, EventArgs e)
        {

        }

        private void Pest1_Radio_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest1_Radio_ID.Checked == true)
            {
                Pest1_Txt_BusquedaPorNombre.Enabled = false;
                Pest1_Txt_ID.Enabled = true;
                Pest1_Txt_BusquedaPorNombre.Clear();
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = -1;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Pest1_Txt_BusquedaPorNombre.Enabled = false;
                Pest1_Txt_BusquedaPorNombre.Clear();
                comboBox1.Enabled = true;
                comboBox1.SelectedIndex = -1;
                Pest1_Txt_ID.Enabled = false;
                Pest1_Txt_ID.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                alumno.Fun_Show(Pest1_Dgv_BsqAlm);
            }
            else
            {
                alumno.BusquedaCargarDatosGenero(Pest1_Dgv_BsqAlm, comboBox1.SelectedItem.ToString());
            }
            Pest1_Txt_CantidadAlumnosSeleccionados.Text = Convert.ToString(Pest1_Dgv_BsqAlm.Rows.Count);
        }

        private void Pest1_Dgv_BsqAlm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_SelecionarRuta selectNombre = new Form_SelecionarRuta();

            if (string.IsNullOrEmpty(Pest2_Pest1_Txt_Codigo.Text))
            {
                
            }else
            {
                alumno.VerificarYear();
                alumno.VerificarYearImpresion();
                selectNombre.numericUpDown1.Value = alumno.Var_ImpreionAños;
                selectNombre.numericUpDown2.Value = alumno.Var_ImpresionMeses;

                selectNombre.NombrePersona.Text = Pest2_Pest1_Txt_NombComp.Text;
                selectNombre.NombrePersona.ReadOnly = true;

                if (Pest2_Pest1_Txt_Sexo.Text.ToUpper() == "M")
                {
                    selectNombre.comboBox1.SelectedIndex = 0;
                }else
                {
                    selectNombre.comboBox1.SelectedIndex = 1;
                }
            }

            try
            {
                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                RutaArchivo = Convert.ToString(dialog.SelectedPath);

                if (RutaArchivo != "")
                {
                    
                    selectNombre.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error");
            }
        }
    }
}

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
using APOAUTIS.Formas.Manuales;

namespace APOAUTIS
{
    public partial class FormaEntPadres : Form
    {
        C_EntrePadres Padres = new C_EntrePadres();

        public FormaEntPadres()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void FormaEntPadres_Load(object sender, EventArgs e)
        {
            Padres.Fun_mostrar_alumno(dtgalumnos);
        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_Amnesis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_Desarrollo_Motriz;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_DesarrolloSocial;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_AcontecimientoMedico;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_VidaDiaria;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_VidaDiaria2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_RelacionesConFamilia;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_RasgosIdentificables;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_RasgosIdentificables2;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_DatosGenerales;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_ComoReacciona;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormaEstSocEco Est = new FormaEstSocEco();
            Est.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Padres.Fun_buscar_alumno(dtgalumnos, textBox1.Text);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button15_Click(object sender, EventArgs e)
        {
                //datos generales
                Padres.Referido_por = txtreferido.Text;
                Padres.Lugar = txtlugar.Text;
                Padres.Fecha = txtfecha.Text;
                Padres.fun_datosgenerales(txtalgo_mencionar.Text);
               
                //funcion anamnesis
                Padres.Tipo_fam = txttipofamilia.Text;
                Padres.Peso_nacer = txtpesonacer.Text;
                Padres.Dura_gestion = txtduraciongestacion.Text;
                Padres.Datos_rele_prenatales = txtdatosprenatales.Text;
                Padres.Datos_rele_perinatales = txtdatosperinatales.Text;
                Padres.Datos_rele_posnatales = txtdatospostnatales.Text;
                Padres.fun_anamnesis();
                
                //funcion desarrollo motriz
                Padres.Control_cuello = txtcontrolcuello.Text;
                Padres.Se_sento = txtse_sento.Text;
                Padres.Gateo = txtgateo.Text;
                Padres.Camino = txtcamino.Text;
                Padres.Corrio = txtcorrio.Text;
                Padres.Salta = txtsaltar.Text;
                Padres.Antece_trans_fami = txttranstornofamilia.Text;
                Padres.Mov_pecul_cuerpo = txtmovim_peculiares.Text;
                Padres.fun_desa_motris();
                
                //funcion de desarrollo social y lenguaje
                Padres.Acepta_busca_interac = txtbuscainter.Text;
                Padres.Parti_actividades = txtactivi_grupo.Text;
                Padres.Edad_son_gut = txtsonido_gutu.Text;
                Padres.Edad_son_voc = txtsonido_voca.Text;
                Padres.Edad_son_sila = txtsonido_sil.Text;
                Padres.Edad_son_pal = txtdecir_palabra.Text + ' ' + txtcuales_palabras.Text;
                Padres.Propicia_conver = txtprop_conversa.Text;
                Padres.Muestra_inter_tema = txtinteres_tema.Text;
                Padres.Habla_tercera_pers = txthabla_terpersona.Text;
                Padres.Dice_oracion_comple = txtoraci_completas.Text;
                Padres.Repite_palabra_escu = txtrepetir_palabras.Text;
                
               Padres.fun_desalenguaje();
               
                //funcion de acontecimiento academico
                Padres.Integrado_kinder = cmbintegrado_kinder.Text + ' ' + txtcual.Text;
                Padres.Desde_cuando = txtdesde_cuando.Text;
                Padres.Manifiesta_comportamiento_escuela = txtmanifiesta_escuela.Text;
                Padres.Deseenvuelve_escuela = txtdesenvuelve_escuela.Text;
            string Com = txtdescriba_doa.Text + "Porque: " + txtda_normal_porque.Text;
                Padres.fun_aconte_academicos(txtinteres_particular.Text,Com );
                
                //funcion de vida diaria
                Padres.Duerme_solo = txtduemesolo.Text;
                Padres.Hora_acuesta = txthora_acuesta.Text;
                Padres.Hora_levanta = txthora_levanta.Text;
                Padres.Duerme_sin_interruncion = txtduerme_toda_noche.Text;
                Padres.Duerme_objeto_especial = txtduerme_objetoespe.Text;
                Padres.Comida_favorita = txtcomida_favorita.Text;
                Padres.Comida_no_guste = txtcomida_no_gusta.Text;
                Padres.Come_solo = txtcome_solo.Text;
                Padres.Utiliza_cubierto = txtcubierto.Text;
                Padres.Edad_come_solo = txtedad_come_solo.Text;
                Padres.Come_no_comestible = txtcome_no_comestible.Text;
                Padres.Agrada_banarse = txtagrada_banarse.Text;
                Padres.Coopera_banarse = txtcoopera_banarse.Text;
                Padres.Bana = cmbbana_solo.Text + ' ' + txtbana_solo.Text;
                Padres.Cambia_solo = cmbcabia_solo.Text;
                Padres.Coopera_cambiarse = txtcoopera_cambiar.Text;
                Padres.Ropa_preferida = txtropa_preferida.Text;
                Padres.Controla_sfinter = txtcontrola_esfinter.Text;
                Padres.Muestra_signos_defecando = txtmuestra_signos.Text;
                Padres.Conocer_panal_sucio = cmbconocer_panal_sucio.Text + ' ' + txtconocer_panal_sucio.Text;
                Padres.Edad_controla_esfinter = txtedad_controla_esfinter.Text;
                Padres.Uso_inodoro = txtuso_inodoro.Text;
                Padres.Limpia_solo = cmblimpia_solo.Text;
                Padres.Coopera_limpiarse = txtcoopera_limpiarse.Text;
                Padres.fun_vida(textBox2.Text);
                
                //relacion de familiar
                Padres.Apego_faniliar = txtapego_miebro.Text + ' ' + txtapego_miembro2.Text;
                Padres.Relacion_padres = txtrela_padres.Text + ' ' + txtrela_padres2.Text;
                Padres.Relacion_hermanos = txtrela_hermanos.Text + ' ' + txtrela_hermano2.Text;
                Padres.Comportamiento = txtcomportamiento.Text + ' ' + txtcomportamiento2.Text;
                Padres.fun_relacion_familiar();
                
                //reaccion
                Padres.Corte_pelo = txtcorte_cabello.Text;
                Padres.Corte_unas = txtcorte_unas.Text;
                Padres.Limpieza_oidos = txtlimpieza_oidos.Text;
                Padres.Cepilla_dientes = txtcepillo_dientes.Text;
                Padres.Personas_adultas = txtpersonas_adultos.Text;
                Padres.Cambios_hogar = txtreaccion.Text;
                Padres.fun_reaccion();
               
                //rasgos identificable
                Padres.Interes_particular_juguete = txtinteres_particular.Text;
                Padres.Describadia_normal = txtdescriba_doa.Text + ' ' + txtda_normal_porque.Text;
                Padres.Algo_mencionar = txtalgo_mencionar.Text;
                
                //rasgos identificables 2
                if (chemuestra_movimientos.Checked == true)
                {
                    Padres.Movimientos_estereotipados = "si";

                }
                else
                {
                    Padres.Movimientos_estereotipados = "no";
                }
                if (chealinea_objetos.Checked == true)
                {
                    Padres.Alinea_objetos = "si";

                }
                else
                {
                    Padres.Alinea_objetos = "no";
                }
                if (checambios_temperamento.Checked == true)
                {
                    Padres.Cambio_temperamento = "si";

                }
                else
                {
                    Padres.Cambio_temperamento = "no";
                }
                if (checamina_puntilla.Checked == true)
                {
                    Padres.Camina_puntilla = "si";

                }
                else
                {
                    Padres.Camina_puntilla = "no";
                }
                if (cheatiende_nombre.Checked == true)
                {
                    Padres.Atiende_cuando_llama = "si";

                }
                else
                {
                    Padres.Atiende_cuando_llama = "no";
                }
                if (chesigue_instrucciones.Checked == true)
                {
                    Padres.Instrucciones_verbales = "si";

                }
                else
                {
                    Padres.Instrucciones_verbales = "no";
                }
                if (chemuestra_escolalia.Checked == true)
                {
                    Padres.Muestra_esvolalia = "si";

                }
                else
                {
                    Padres.Muestra_esvolalia = "no";
                }
                if (chehabla_solo.Checked == true)
                {
                    Padres.Habla_solo = "si";

                }
                else
                {
                    Padres.Habla_solo = "no";
                }
                if (chemuestra_voz_peculiar.Checked == true)
                {
                    Padres.Voz_peculear = "si";

                }
                else
                {
                    Padres.Voz_peculear = "no";
                }
                if (cheuso_lenguaje.Checked == true)
                {
                    Padres.Funcional_lenguaje = "si";

                }
                else
                {
                    Padres.Funcional_lenguaje = "no";
                }
                if (chegusta_ver_girar.Checked == true)
                {
                    Padres.Gusta_girar_objetos = "si";

                }
                else
                {
                    Padres.Gusta_girar_objetos = "no";
                }
                if (chetemor_situaciones.Checked == true)
                {
                    Padres.Temor_situaciones = "si";

                }
                else
                {
                    Padres.Temor_situaciones = "no";
                }
                if (chepetrones_mirada_estranos.Checked == true)
                {
                    Padres.Miradas_extranas = "si";

                }
                else
                {
                    Padres.Miradas_extranas = "no";
                }
                if (chemirada_vacio.Checked == true)
                {
                    Padres.Mirada_al_vacio = "si";

                }
                else
                {
                    Padres.Mirada_al_vacio = "no";
                }
                Padres.fun_rasgos_identificables_2();
                MessageBox.Show("se registro el alumno:" + Padres.NomAlumno + " seleccionado", "");
            
           
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Padres.Cuando = txtcuando.Text;
            Padres.Donde = txtdonde.Text;
            Padres.Diag_tratamiento = txtdiag_tratamiento.Text;
            Padres.fun_aconte_medicos();
            Padres.Fun_Show(dtg_medicos);
        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void cmbbana_solo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            //Padres.Fun_buscar_alumno(dtgalumnos);
        }

       

        private void dtgalumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
            //agarra el id de la celda seleccionada
            DataGridViewRow row = dtgalumnos.Rows[e.RowIndex];

            Padres.CodAlumno = Convert.ToInt32(row.Cells["Codigo de Alumno"].Value);
            Padres.NomAlumno = Convert.ToString(row.Cells["Nombre de Alumno"].Value);
            
            
            txtfecha_nacimiento.Text = Convert.ToString(row.Cells["fecha de nacimiento"].Value);
            txtedadcronologica.Text = Convert.ToString(row.Cells["edad cronologica"].Value);
            txtescolaridad.Text = Convert.ToString(row.Cells["escolaridad del alumno"].Value);
            txtdireccion.Text = Convert.ToString(row.Cells["direccion del alumno"].Value);
            txttelefono.Text= Convert.ToString(row.Cells["telefono fijo"].Value);

            MessageBox.Show("Alumno: " + Padres.NomAlumno + " seleccionado","");

        }

        private void dtgalumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pest_DatosGenerales_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            FormManual Manual = new FormManual();
            Manual.ShowDialog();
        }
    }
}

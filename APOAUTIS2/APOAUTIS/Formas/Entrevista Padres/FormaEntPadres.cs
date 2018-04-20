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
        C_Validaciones Val = new C_Validaciones();

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
            Fun_ClicDerecho();
            var blankContextMenu = new ContextMenuStrip();

           
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
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
          
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

            if (Padres.Fun_ValidarSIYaExisteEntrevista(Padres.CodAlumno) == true)
            {
                MessageBox.Show("El alumno ya tiene registrado una entrevista de padres previamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Padres.Fun_VerificarYear((int)Convert.ToDouble(row.Cells["Codigo de Alumno"].Value));
            txtedadcronologica.Text= Padres.V_EdadCronologica;

            txtfecha_nacimiento.Text = Convert.ToString(row.Cells["fecha de nacimiento"].Value);
            txtedadcronologica.Text = Convert.ToString(row.Cells["edad cronologica"].Value);
            txtescolaridad.Text = Convert.ToString(row.Cells["escolaridad del alumno"].Value);
            txtdireccion.Text = Convert.ToString(row.Cells["direccion del alumno"].Value);
            txttelefono.Text= Convert.ToString(row.Cells["telefono fijo"].Value);

            txtresponsable.Text=Padres.Fun_ExtraerResponsables((int)Convert.ToDouble(row.Cells["Codigo de Alumno"].Value));

            MessageBox.Show("Alumno: " + Padres.NomAlumno + " seleccionado", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Pest_Amnesis_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (Fun_RetornarSiEtaVacio() == true)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Existen campos vacios...¿Desea continuar?", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.No)
                {
                    return;
                }
            }


            if (string.IsNullOrEmpty(txtfecha_nacimiento.Text))
            {
                MessageBox.Show("No existen alumnos selecionado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Fun_EstablecerSiEstaVacio();

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
            Padres.fun_aconte_academicos(txtinteres_particular.Text, Com);

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
            MessageBox.Show("se registro el alumno:" + Padres.NomAlumno + " seleccionado", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Fun_Limpiar();

        }


        private void Fun_ClicDerecho()
        {

            var blankContextMenu = new ContextMenuStrip();

            var boxes = Grupo_comoreaciona.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes1 = Grupo_Social.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes2 = Grupo_Motriz.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxes3 = Grupo_DatosIdentificables.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            
            


        var boxes4 = Grupo_VidaDiaria.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes5 = Grupo_AcontAcademicos.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes6 = Grupo_Lenguaje.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes7 = Grupo_DatosGenerales.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes8 = Grupo_Busqueda.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes9 = Grupo_Anamnesis.Controls.OfType<TextBox>();
            foreach (var box in boxes9)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

          
        }

        public void Fun_Limpiar()
        {
            var boxes = Grupo_comoreaciona.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.Clear();

            }

            var boxes1 = Grupo_Social.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.Clear();

            }

            var boxes2 = Grupo_Motriz.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                box.Clear();

            }


            var boxes3 = Grupo_DatosIdentificables.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                box.Clear();

            }


            var boxes4 = Grupo_VidaDiaria.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                box.Clear();

            }

            var boxes5 = Grupo_AcontAcademicos.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.Clear();

            }

            var boxes6 = Grupo_Lenguaje.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                box.Clear();

            }

            var boxes7 = Grupo_DatosGenerales.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.Clear();

            }

            var boxes8 = Grupo_Busqueda.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.Clear();

            }

            var boxes9 = Grupo_Anamnesis.Controls.OfType<TextBox>();
            foreach (var box in boxes9)
            {
                box.Clear();

            }
        }

        public bool Fun_RetornarSiEtaVacio()
        {
            bool Resp = false;

            var boxes = Grupo_comoreaciona.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }

            var boxes1 = Grupo_Social.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }

            var boxes2 = Grupo_Motriz.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }


            var boxes3 = Grupo_DatosIdentificables.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }


            var boxes4 = Grupo_VidaDiaria.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }

            var boxes5 = Grupo_AcontAcademicos.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }

            var boxes6 = Grupo_Lenguaje.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }

            var boxes7 = Grupo_DatosGenerales.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }

            var boxes8 = Grupo_Busqueda.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }

            var boxes9 = Grupo_Anamnesis.Controls.OfType<TextBox>();
            foreach (var box in boxes9)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }

            }
            return Resp;

        }

        public void Fun_EstablecerSiEstaVacio()
        {
            var boxes = Grupo_comoreaciona.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }

            var boxes1 = Grupo_Social.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }

            var boxes2 = Grupo_Motriz.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }


            var boxes3 = Grupo_DatosIdentificables.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }


            var boxes4 = Grupo_VidaDiaria.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }

            var boxes5 = Grupo_AcontAcademicos.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }

            var boxes6 = Grupo_Lenguaje.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }

            var boxes7 = Grupo_DatosGenerales.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }

            var boxes8 = Grupo_Busqueda.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }

            var boxes9 = Grupo_Anamnesis.Controls.OfType<TextBox>();
            foreach (var box in boxes9)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "-";
                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, textBox1);
            // Val.ValirLetrasYEspacios_Direccion(sender, e, );
        }

        private void txtreferido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtreferido);
        }

        private void txtlugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtlugar);
        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtfecha);
        }

        private void txttipofamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txttipofamilia);
        }

        private void txtpesonacer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtpesonacer);
        }

        private void txtduraciongestacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtduraciongestacion);
        }

        private void txtdatosprenatales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdatosprenatales);
        }

        private void txtdatosperinatales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdatosperinatales);
        }

        private void txtdatospostnatales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdatospostnatales);
        }

        private void txtcontrolcuello_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcontrolcuello);
        }

        private void txtcamino_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcamino);
        }

        private void txtse_sento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtse_sento);
        }

        private void txtcorrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcorrio);
        }
    
        private void txtgateo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtgateo);
        }

        private void txtsaltar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtsaltar);
        }

        private void txttranstornofamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txttranstornofamilia);
        }

        private void txtmovim_peculiares_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtmovim_peculiares);
        }

        private void txtbuscainter_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtbuscainter);
        }

        private void txtactivi_grupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtactivi_grupo);
        }

        private void txtsonido_gutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtsonido_gutu);
        }

        private void txtsonido_voca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtsonido_voca);
        }

        private void txtsonido_sil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtsonido_sil);
        }

        private void txtdecir_palabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdecir_palabra);
        }

        private void txtcuales_palabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcuales_palabras);
        }

        private void txtprop_conversa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtprop_conversa);
        }

        private void txtinteres_tema_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtinteres_tema);
        }

        private void txthabla_terpersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txthabla_terpersona);
        }

        private void txtoraci_completas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtoraci_completas);
        }

        private void txtrepetir_palabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtrepetir_palabras);
        }

        private void txtcual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcual);
        }

        private void txtdesde_cuando_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdesde_cuando);
        }

        private void txtmanifiesta_escuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtmanifiesta_escuela);
        }

        private void txtdesenvuelve_escuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdesenvuelve_escuela);
        }

        private void txtcuando_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcuando);
        }

        private void txtdonde_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdonde);
        }

        private void txtdiag_tratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdiag_tratamiento);
        }

        private void txtinteres_particular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtinteres_particular);
        }

        private void txtdescriba_doa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtdescriba_doa);
        }

        private void txtda_normal_porque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtda_normal_porque);
        }

        private void txtalgo_mencionar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtalgo_mencionar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, textBox2);

        }

        private void txtcoopera_limpiarse_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcoopera_limpiarse);
        }

        private void txtuso_inodoro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtuso_inodoro);
        }

        private void txtedad_controla_esfinter_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtedad_controla_esfinter);
        }

        private void txtconocer_panal_sucio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtconocer_panal_sucio);
        }

        private void txtmuestra_signos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtmuestra_signos);
        }

        private void txtcontrola_esfinter_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcontrola_esfinter);
        }

        private void txtropa_preferida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtropa_preferida);
        }

        private void txtcoopera_cambiar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcoopera_cambiar);
        }

        private void txtbana_solo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtbana_solo);
        }

        private void txtcoopera_banarse_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcoopera_banarse);
        }

        private void txtagrada_banarse_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtagrada_banarse);
        }

        private void txtcome_no_comestible_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcome_no_comestible);
        }

        private void txtedad_come_solo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtedad_come_solo);
        }

        private void txtcome_solo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcome_solo);

        }

        private void txtcubierto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcubierto);
        }

        private void txtcomida_no_gusta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcomida_no_gusta);
        }

        private void txtcomida_favorita_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtcomida_favorita);
        }

        private void txtduerme_objetoespe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtduerme_objetoespe);
        }

        private void txtduerme_toda_noche_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtduerme_toda_noche);
        }

        private void txthora_levanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txthora_levanta);
        }

        private void txthora_acuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txthora_acuesta);
        }

        private void txtduemesolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtduemesolo);
        }
    }
}

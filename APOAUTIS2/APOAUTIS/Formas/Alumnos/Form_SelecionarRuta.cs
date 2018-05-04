using APOAUTIS.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Alumnos
{
    public partial class Form_SelecionarRuta : Form
    {

        C_Alumnos cEval = new C_Alumnos();
        C_Validaciones Eval = new C_Validaciones();
        FormaAlumnos fEval = new FormaAlumnos();


        string Nombre_Persona, Mensaje, edadCronologica, Fecha;

        public Form_SelecionarRuta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreArchivo.Text = "";
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Mensaje = "";
            if (string.IsNullOrEmpty(NombrePersona.Text))
            {
                MessageBox.Show("Debe escribir el nombre de la persona", "Mensaje de error");
                return;
            }

            Nombre_Persona = NombrePersona.Text;

            if (comboBox1.SelectedIndex==0)
            {
                if (Convert.ToDouble(numericUpDown1.Value) <= 12)
                {
                    Mensaje = " el niño ";
                }
                else
                if (Convert.ToDouble(numericUpDown1.Value) >12 && Convert.ToDouble(numericUpDown1.Value) <=18)
                {
                    Mensaje = " el joven ";
                }
                else
                if (Convert.ToDouble(numericUpDown1.Value) > 18 && Convert.ToDouble(numericUpDown1.Value) <= 35)
                {
                    Mensaje = " el caballero ";
                }
                else
                {
                    Mensaje = " el señor ";
                }
                

            }
            else
            {
                if (Convert.ToDouble(numericUpDown1.Value) <= 12)
                {
                    Mensaje = " la niña ";
                }
                else
               if (Convert.ToDouble(numericUpDown1.Value) > 12 && Convert.ToDouble(numericUpDown1.Value) <= 18)
                {
                    Mensaje = " la joven ";
                }
                else
               if (Convert.ToDouble(numericUpDown1.Value) > 18 && Convert.ToDouble(numericUpDown1.Value) <= 35)
                {
                    Mensaje = " la señorita ";
                }
                else
                {
                    Mensaje = " la señora ";
                }
            }

            edadCronologica = numericUpDown1.Value.ToString() + " años, " + numericUpDown2.Value.ToString() + " meses";

            Fecha = ExtraerFecha();

 
            string nombreArchivo = txtNombreArchivo.Text;
            string ruta = FormaAlumnos.RutaArchivo;

            if (string.IsNullOrEmpty(txtNombreArchivo.Text))
            {
                MessageBox.Show("Debe escribir un nombre para el archivo", "Mensaje de error");
            }
            else
            {
                txtNombreArchivo.Text = "";
                this.Hide();


                cEval.Mensaje_Identificador = Mensaje;
                cEval.Edadcronologica = edadCronologica;
                cEval.Fechaimpresion = Fecha;
        
        cEval.ExportDataTableToPdf(ruta + @"\" + nombreArchivo + ".pdf", "Constancia", Nombre_Persona, Mensaje, edadCronologica, Fecha);
                System.Diagnostics.Process.Start(ruta + @"\" + nombreArchivo + ".pdf");
            }


        }

        private void NombrePersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            Eval.ValidarNombres_SoloLetras(sender,e);
        }

        private void txtNombreArchivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Eval.ValidarNombres_LetrasYNumeros(sender, e);
        }

        private void Form_SelecionarRuta_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            txtNombreArchivo.ContextMenuStrip = blankContextMenu;
            NombrePersona.ContextMenuStrip = blankContextMenu;

            comboBox1.SelectedIndex = 0;
        }


        public string ExtraerFecha()
        {
            string Fecha="";

            string Dia= dateTimePicker1.Value.Day.ToString();
            string Mes="";
            string MesNumero = dateTimePicker1.Value.Month.ToString();
            string Annio = dateTimePicker1.Value.Year.ToString();

            int Num = dateTimePicker1.Value.Month;

            if (Num == 1)
            {
                Mes = "Enero";
            }
            else
                 if (Num == 2)
            {
                Mes = "Febrero";
            }
            else
                 if (Num == 3)
            {
                Mes = "Marzo";
            }
            else
                 if (Num == 4)
            {
                Mes = "Abril";
            }
            else
                 if (Num == 5)
            {
                Mes = "Mayo";
            }
            else
                 if (Num == 6)
            {
                Mes = "Junio";
            }
            else
                 if (Num == 7)
            {
                Mes = "Julio";
            }
            else
                 if (Num == 8)
            {
                Mes = "Agosto";
            }
            else
                 if (Num == 9)
            {
                Mes = "Septiembre";
            }
            else
                 if (Num == 10)
            {
                Mes = "Octubre";
            }
            else
                 if (Num == 11)
            {
                Mes = "Noviembre";
            }
            else
                 if (Num == 12)
            {
                Mes = "Diciembre";
            }


            if (Convert.ToInt32( Dia)==1)
            {
                Fecha = " al " + Dia + "dia del mes de " + Mes + "del año " + Annio;
            }
            else
            {
                Fecha = " a los " +  Dia +" dias del mes de " + Mes + " del año " + Annio;
            }
            
            return Fecha;
        }
    }
}

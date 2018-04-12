using APOAUTIS.Clases;
using APOAUTIS.Formas.Alumnos;
using APOAUTIS.Formas.Manuales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Matricula
{
    public partial class FormIngresoGastos : Form
    {
        C_Validaciones Cl_Validaciones = new C_Validaciones();
        FormGlobalShowAlum F_ShowAlum = new FormGlobalShowAlum();
        C_IngGast Cl_Gastos = new C_IngGast();

        int Var_codigoAlumno = 0;

        public FormIngresoGastos()
        {
            InitializeComponent();
        }


        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pest_Ingresos_Click(object sender, EventArgs e)
        {

        }

        private void FormIngresoGastos_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();

            var Grupo_Ing = Grupo_Ingreso.Controls.OfType<TextBox>();
            foreach (var box in Grupo_Ing)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            var Grupo_Gast = Grupo_Gasto.Controls.OfType<TextBox>();
            foreach (var box in Grupo_Gast)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


        }

        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {

            var Grupo_Ing = Grupo_Ingreso.Controls.OfType<TextBox>();
            foreach (var box in Grupo_Ing)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    box.Text = "0";
                }
            }

            var Grupo_Gast = Grupo_Gasto.Controls.OfType<TextBox>();
            foreach (var box in Grupo_Gast)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    box.Text = "0";
                }
            }

            if (string.IsNullOrWhiteSpace(Txt_OpcionBusqueda.Text))
            {
                errorProvider1.SetError(Txt_OpcionBusqueda, "Porfavor, selecione un alumno");
                return;
            }
            else
            {
                errorProvider1.SetError(Txt_OpcionBusqueda, "");
            }
            try
            {
                Fun_IngresarCambios();
                Fun_Limpiar();
            }catch(System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Fun_ValidarEspaciosVacios()
        {

        }

        private void GrupoIngr_Txt_Abuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoIngr_Txt_Abuela);
        }

        private void GrupoIngr_Txt_Padre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoIngr_Txt_Padre);
        }

        private void GrupoIngr_Txt_Madre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoIngr_Txt_Madre);
        }

        private void GrupoIngr_Txt_Hijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoIngr_Txt_Hijos);
        }

        private void GrupoIngr_Txt_Otros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoIngr_Txt_Otros);
        }

        private void GrupoIngr_Txt_Pension_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoIngr_Txt_Pension);
        }

        private void GrupoGasto_Txt_Transporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Transporte);
        }

        private void GrupoGasto_Txt_Salud_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Salud);
        }

        private void GrupoGasto_Txt_Educacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Educacion);
        }

        private void GrupoGasto_Txt_Vestimenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Vestimenta);
        }

        private void GrupoGasto_Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Telefono);
        }

        private void GrupoGasto_Txt_Alimentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Alimentos);
        }

        private void GrupoGasto_Txt_Combustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Combustible);
        }

        private void GrupoGasto_Txt_EnergiaElectrica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_EnergiaElectrica);
        }

        private void GrupoGasto_Txt_AguaPotable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_AguaPotable);
        }

        private void GrupoGasto_Txt_Vivienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Vivienda);
        }

        private void GrupoGasto_Txt_Otros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Validaciones.NumerosDecimales(sender, e, GrupoGasto_Txt_Otros);
        }

        private void GrupoIngr_Txt_Abuela_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularIngresos();

        }

        private void Fun_CalcularIngresos()
        {
            float Var_Monto = 0;
            float Var_Total = 0;


            var Grupo_Ing = Grupo_Ingreso.Controls.OfType<TextBox>();
            foreach (var box in Grupo_Ing)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    Var_Monto = 0;
                } else
                {
                    Var_Monto = (float)Convert.ToDouble(box.Text);
                }
                Var_Total = Var_Total + Var_Monto;
            }

            GrupoIngr_Txt_Total.Text = Convert.ToString(Var_Total);
        }

        private void GrupoIngr_Txt_Padre_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularIngresos();
        }

        private void GrupoIngr_Txt_Madre_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularIngresos();
        }

        private void GrupoIngr_Txt_Otros_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularIngresos();
        }

        private void GrupoIngr_Txt_Pension_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularIngresos();
        }

        private void GrupoIngr_Txt_Hijos_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularIngresos();
        }

        private void Fun_CalcularGastos()
        {
            float Var_Monto = 0;
            float Var_Total = 0;


            var Grupo_Gast = Grupo_Gasto.Controls.OfType<TextBox>();
            foreach (var box in Grupo_Gast)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    Var_Monto = 0;
                }
                else
                {
                    Var_Monto = (float)Convert.ToDouble(box.Text);
                }
                Var_Total = Var_Total + Var_Monto;
            }

            GrupoGasto_Total.Text = Convert.ToString(Var_Total);
        }

        private void GrupoGasto_Txt_Transporte_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_Salud_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_Educacion_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_Vestimenta_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_Alimentos_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_EnergiaElectrica_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_AguaPotable_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_Vivienda_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_Otros_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void GrupoGasto_Txt_Combustible_TextChanged(object sender, EventArgs e)
        {
            Fun_CalcularGastos();
        }

        private void Grupo_Gasto_Enter(object sender, EventArgs e)
        {

        }

        private void Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            Fun_Limpiar();
        }

        private void Fun_Limpiar()
        {

            Txt_OpcionBusqueda.Clear();
            Var_codigoAlumno = 0;

            var Grupo_Gast = Grupo_Gasto.Controls.OfType<TextBox>();
            foreach (var box in Grupo_Gast)
            {
                
                    box.Text = string.Empty;
                

            }

            var Grupo_Ing = Grupo_Ingreso.Controls.OfType<TextBox>();
            foreach (var box in Grupo_Ing)
            {
                
                    box.Text = string.Empty;
               
            }

            GrupoIngr_Txt_Total.Text = "0";
            GrupoGasto_Total.Text = "0";
        }

        private void Bttn_Buscar_Click(object sender, EventArgs e)
        {
            AddOwnedForm(F_ShowAlum);
            F_ShowAlum.Accion = "Gastos";
            F_ShowAlum.ShowDialog();
        }
        public void Fun_CargarDatos(int Var_Codigo, string Var_Nombre)
        {

            Cl_Gastos.Var_cod_alum = Var_Codigo;
            Cl_Gastos.Var_nom_alum = Var_Nombre;

            Txt_OpcionBusqueda.Text = Var_Nombre;
            Var_codigoAlumno = Var_Codigo;

            Cl_Gastos.Fun_ExtracionDatos();
            GrupoIngr_Txt_Abuela.Text = Convert.ToString(Cl_Gastos.Var_ing_abuela);
            GrupoIngr_Txt_Padre.Text = Convert.ToString(Cl_Gastos.Var_ing_pad);
            GrupoIngr_Txt_Madre.Text = Convert.ToString(Cl_Gastos.Var_ing_madre);
            GrupoIngr_Txt_Otros.Text = Convert.ToString(Cl_Gastos.Var_ing_otro);
            GrupoIngr_Txt_Pension.Text = Convert.ToString(Cl_Gastos.Var_ing_pens);
            GrupoIngr_Txt_Hijos.Text = Convert.ToString(Cl_Gastos.Var_ing_hijo);
            GrupoIngr_Txt_Total.Text = Convert.ToString(Cl_Gastos.Var_ing_total);
            GrupoGasto_Txt_Transporte.Text = Convert.ToString(Cl_Gastos.Var_gast_trans);
            GrupoGasto_Txt_Salud.Text = Convert.ToString(Cl_Gastos.Var_gast_salud);
            GrupoGasto_Txt_Educacion.Text = Convert.ToString(Cl_Gastos.Var_gast_educac);
            GrupoGasto_Txt_Vestimenta.Text = Convert.ToString(Cl_Gastos.Var_gast_vest);
            GrupoGasto_Txt_Telefono.Text = Convert.ToString(Cl_Gastos.Var_gast_telef);
            GrupoGasto_Txt_Alimentos.Text = Convert.ToString(Cl_Gastos.Var_gast_alim);
            GrupoGasto_Txt_EnergiaElectrica.Text = Convert.ToString(Cl_Gastos.Var_gast_energ);
            GrupoGasto_Txt_AguaPotable.Text = Convert.ToString(Cl_Gastos.Var_gast_agua);
            GrupoGasto_Txt_Vivienda.Text = Convert.ToString(Cl_Gastos.Var_gast_vivien);
            GrupoGasto_Txt_Otros.Text = Convert.ToString(Cl_Gastos.Var_gast_otros);
            GrupoGasto_Txt_Combustible.Text = Convert.ToString(Cl_Gastos.Var_gast_comb);
            GrupoGasto_Total.Text = Convert.ToString(Cl_Gastos.Var_gast_total);
        }

        public void Fun_IngresarCambios()
        {

            Cl_Gastos.Var_ing_abuela= (float)Convert.ToDouble(GrupoIngr_Txt_Abuela.Text);
            Cl_Gastos.Var_ing_pad = (float)Convert.ToDouble(GrupoIngr_Txt_Padre.Text);
            Cl_Gastos.Var_ing_madre = (float)Convert.ToDouble(GrupoIngr_Txt_Madre.Text);
            Cl_Gastos.Var_ing_otro = (float)Convert.ToDouble(GrupoIngr_Txt_Otros.Text);
            Cl_Gastos.Var_ing_pens = (float)Convert.ToDouble(GrupoIngr_Txt_Pension.Text);
            Cl_Gastos.Var_ing_hijo = (float)Convert.ToDouble(GrupoIngr_Txt_Hijos.Text);
            Cl_Gastos.Var_ing_total = (float)Convert.ToDouble(GrupoIngr_Txt_Total.Text);
            Cl_Gastos.Var_gast_trans = (float)Convert.ToDouble(GrupoGasto_Txt_Transporte.Text);
            Cl_Gastos.Var_gast_salud = (float)Convert.ToDouble(GrupoGasto_Txt_Salud.Text);
            Cl_Gastos.Var_gast_educac = (float)Convert.ToDouble(GrupoGasto_Txt_Educacion.Text);
            Cl_Gastos.Var_gast_vest = (float)Convert.ToDouble(GrupoGasto_Txt_Vestimenta.Text);
            Cl_Gastos.Var_gast_telef = (float)Convert.ToDouble(GrupoGasto_Txt_Telefono.Text);
            Cl_Gastos.Var_gast_alim = (float)Convert.ToDouble(GrupoGasto_Txt_Alimentos.Text);
            Cl_Gastos.Var_gast_energ = (float)Convert.ToDouble(GrupoGasto_Txt_EnergiaElectrica.Text);
            Cl_Gastos.Var_gast_agua = (float)Convert.ToDouble(GrupoGasto_Txt_AguaPotable.Text);
            Cl_Gastos.Var_gast_vivien = (float)Convert.ToDouble(GrupoGasto_Txt_Vivienda.Text);
            Cl_Gastos.Var_gast_otros = (float)Convert.ToDouble(GrupoGasto_Txt_Otros.Text);
            Cl_Gastos.Var_gast_comb = (float)Convert.ToDouble(GrupoGasto_Txt_Combustible.Text);
            Cl_Gastos.Var_gast_total = (float)Convert.ToDouble(GrupoGasto_Total.Text);

            Cl_Gastos.Fun_ActualizarDatos();
        }

        private void Bttn_Ayuda_Click(object sender, EventArgs e)
        {
            FormManual Manual = new FormManual();
            Manual.ShowDialog();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_IngGast: Conexion
    {
        private int var_cod_alum;
        private string var_nom_alum;


        private float var_ing_abuela;
        private float var_ing_pad;
        private float var_ing_madre;
        private float var_ing_otro;
        private float var_ing_pens;
        private float var_ing_hijo;
        private float var_ing_total;
        private float var_gast_trans;
        private float var_gast_salud;
        private float var_gast_educac;
        private float var_gast_vest;
        private float var_gast_telef;
        private float var_gast_alim;
        private float var_gast_energ;
        private float var_gast_agua;
        private float var_gast_vivien;
        private float var_gast_otros;
        private float var_gast_comb;
        private float var_gast_total;


        public int Var_cod_alum
        {
            get
            {
                return var_cod_alum;
            }

            set
            {
                var_cod_alum = value;
            }
        }

        public string Var_nom_alum
        {
            get
            {
                return var_nom_alum;
            }

            set
            {
                var_nom_alum = value;
            }
        }

        public float Var_ing_abuela
        {
            get
            {
                return var_ing_abuela;
            }

            set
            {
                var_ing_abuela = value;
            }
        }

        public float Var_ing_pad
        {
            get
            {
                return var_ing_pad;
            }

            set
            {
                var_ing_pad = value;
            }
        }

        public float Var_ing_madre
        {
            get
            {
                return var_ing_madre;
            }

            set
            {
                var_ing_madre = value;
            }
        }

        public float Var_ing_otro
        {
            get
            {
                return var_ing_otro;
            }

            set
            {
                var_ing_otro = value;
            }
        }

        public float Var_ing_pens
        {
            get
            {
                return var_ing_pens;
            }

            set
            {
                var_ing_pens = value;
            }
        }

        public float Var_ing_hijo
        {
            get
            {
                return var_ing_hijo;
            }

            set
            {
                var_ing_hijo = value;
            }
        }

        public float Var_ing_total
        {
            get
            {
                return var_ing_total;
            }

            set
            {
                var_ing_total = value;
            }
        }

        public float Var_gast_trans
        {
            get
            {
                return var_gast_trans;
            }

            set
            {
                var_gast_trans = value;
            }
        }

        public float Var_gast_salud
        {
            get
            {
                return var_gast_salud;
            }

            set
            {
                var_gast_salud = value;
            }
        }

        public float Var_gast_educac
        {
            get
            {
                return var_gast_educac;
            }

            set
            {
                var_gast_educac = value;
            }
        }

        public float Var_gast_vest
        {
            get
            {
                return var_gast_vest;
            }

            set
            {
                var_gast_vest = value;
            }
        }

        public float Var_gast_telef
        {
            get
            {
                return var_gast_telef;
            }

            set
            {
                var_gast_telef = value;
            }
        }

        public float Var_gast_alim
        {
            get
            {
                return var_gast_alim;
            }

            set
            {
                var_gast_alim = value;
            }
        }

        public float Var_gast_energ
        {
            get
            {
                return var_gast_energ;
            }

            set
            {
                var_gast_energ = value;
            }
        }

        public float Var_gast_agua
        {
            get
            {
                return var_gast_agua;
            }

            set
            {
                var_gast_agua = value;
            }
        }

        public float Var_gast_vivien
        {
            get
            {
                return var_gast_vivien;
            }

            set
            {
                var_gast_vivien = value;
            }
        }

        public float Var_gast_otros
        {
            get
            {
                return var_gast_otros;
            }

            set
            {
                var_gast_otros = value;
            }
        }

        public float Var_gast_comb
        {
            get
            {
                return var_gast_comb;
            }

            set
            {
                var_gast_comb = value;
            }
        }

        public float Var_gast_total
        {
            get
            {
                return var_gast_total;
            }

            set
            {
                var_gast_total = value;
            }
        }

        public void Fun_ExtracionDatos()
        {

            this.sql = string.Format("select * from informacionfamilia where Alumnos_CodAlumno = '{0}'", Var_cod_alum);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_gast_otros = (float)Convert.ToDouble(Reg["OtrosGastos"].ToString());
                Var_gast_comb = (float)Convert.ToDouble(Reg["GastoGaso"].ToString());
                Var_gast_total = (float)Convert.ToDouble(Reg["TotalGastos"].ToString());
                Var_gast_trans = (float)Convert.ToDouble(Reg["GastoTransp"].ToString());
                Var_gast_salud = (float)Convert.ToDouble(Reg["GastoSalub"].ToString());
                Var_gast_educac = (float)Convert.ToDouble(Reg["GastoEduca"].ToString());
                Var_gast_vest = (float)Convert.ToDouble(Reg["GastoRopa"].ToString());
                Var_gast_telef = (float)Convert.ToDouble(Reg["GastoTel"].ToString());
                Var_gast_alim = (float)Convert.ToDouble(Reg["GastoComida"].ToString());
                Var_gast_energ = (float)Convert.ToDouble(Reg["GastoEnergiaElec"].ToString());
                Var_gast_agua = (float)Convert.ToDouble(Reg["GastoAgua"].ToString());
                Var_gast_vivien = (float)Convert.ToDouble(Reg["GastoVivienda"].ToString());
                Var_ing_abuela = (float)Convert.ToDouble(Reg["IngresoAbuela"].ToString());
                Var_ing_pad = (float)Convert.ToDouble(Reg["IngresoPadre"].ToString());
                Var_ing_madre = (float)Convert.ToDouble(Reg["IngresoMadre"].ToString());
                Var_ing_otro = (float)Convert.ToDouble(Reg["OtrosIngresos"].ToString());
                Var_ing_pens = (float)Convert.ToDouble(Reg["Pension"].ToString());
                Var_ing_hijo = (float)Convert.ToDouble(Reg["IngresoHijo"].ToString());
                Var_ing_total = (float)Convert.ToDouble(Reg["TotalMensLemp"].ToString());

            }
            this.cnx.Close();

        }

        public void Fun_ActualizarDatos()
        {
            this.sql = string.Format(" update informacionfamilia set IngresoAbuela = '{0}', IngresoMadre = '{1}', IngresoPadre = '{2}', IngresoHijo = '{3}', Pension = '{4}', OtrosIngresos = '{5}', TotalMensLemp = '{6}', GastoEnergiaElec = '{7}', GastoAgua = '{8}', GastoTel = '{9}', GastoComida = '{10}', GastoTransp = '{11}', GastoSalub = '{12}', GastoEduca = '{13}', GastoGaso = '{14}', GastoRopa = '{15}', GastoVivienda = '{16}', OtrosGastos = '{17}', TotalGastos = '{18}' where Alumnos_CodAlumno = '{19}'",
                Var_ing_abuela, Var_ing_madre, Var_ing_pad, Var_ing_hijo, Var_ing_pens, Var_ing_otro, Var_ing_total,
                Var_gast_energ, Var_gast_agua, Var_gast_telef, Var_gast_alim, Var_gast_trans, Var_gast_salud, Var_gast_educac, Var_gast_comb, Var_gast_vest
                , Var_gast_vivien, Var_gast_otros, Var_gast_total, Var_cod_alum);

            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();
            if (Reg > 0)
            {
                MessageBox.Show("Los datos se ingresaron correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ocurrio un error en el ingreso\nPor favor contacte con su supervisor", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.cnx.Close();
        }
    }
}

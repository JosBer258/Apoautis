using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_MontoMens : Conexion
    {
        private string var_nom_alumno;
        private string var_resp_nombres;
        private string var_total_ingresos;
        private float var_mensualidad;
        private int var_cod_nom;
        private int var_cod_matricula;

        private string var_filtro_nom_cliente;

        public string Var_nom_alumno
        {
            get
            {
                return var_nom_alumno;
            }

            set
            {
                var_nom_alumno = value;
            }
        }

        public string Var_resp_nombres
        {
            get
            {
                return var_resp_nombres;
            }

            set
            {
                var_resp_nombres = value;
            }
        }

        public string Var_total_ingresos
        {
            get
            {
                return var_total_ingresos;
            }

            set
            {
                var_total_ingresos = value;
            }
        }

        public float Var_mensualidad
        {
            get
            {
                return var_mensualidad;
            }

            set
            {
                var_mensualidad = value;
            }
        }

        public string Var_filtro_nom_cliente
        {
            get
            {
                return var_filtro_nom_cliente;
            }

            set
            {
                var_filtro_nom_cliente = value;
            }
        }

        public int Var_cod_nom
        {
            get
            {
                return var_cod_nom;
            }

            set
            {
                var_cod_nom = value;
            }
        }

        public int Var_cod_matricula
        {
            get
            {
                return var_cod_matricula;
            }

            set
            {
                var_cod_matricula = value;
            }
        }

        public void Fun_ExtraerResponsables()
        {
            Var_resp_nombres = "";
            int ContadorFil=1;

            this.sql = string.Format("select C.NomComRes as 'Responsable' from alumnos as A inner join alumnos_responsables as B on A.CodAlumno = B.CodAlumno inner join responsables as C on B.CodResp = C.CodResp where A.CodAlumno = '{0}'", Var_cod_nom);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            while (Reg.Read())
            {
                if (ContadorFil > 1) { 
                    Var_resp_nombres = Var_resp_nombres + " y " + Reg["Responsable"].ToString();
                }else
                {
                    Var_resp_nombres = Reg["Responsable"].ToString();
                }

                ContadorFil++;
            }

            cnx.Close();
        }

        public void Fun_ExtraerTotalMen()
        {
            this.sql = string.Format("select TotalMensLemp from informacionfamilia where Alumnos_CodAlumno = '{0}';", Var_cod_nom);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_total_ingresos = Reg["TotalMensLemp"].ToString();
            }
            this.cnx.Close();
        }


        public void Fun_CalcularMensualidad()
        {
            double Var_Total;
            Var_Total = (Double)Convert.ToDecimal(Var_total_ingresos);

            this.sql = string.Format("select cargorangoinic, cargvalmensul from cuota  where  '{0}' > cargorangoinic order by CAST(cargorangoinic as DECIMAL(10, 2)) desc limit 1;", Var_Total);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_mensualidad = (float) Convert.ToDouble(Reg["cargvalmensul"].ToString());
            }
            this.cnx.Close();

        }

        public void Fun_ExtraerMatri()
        {
            this.sql = string.Format("select A.CodMatricula as 'Codi_Matr' from matricula as A where A.Alumnos_CodAlumno='{0}' order by A.CodMatricula desc limit 1; ", Var_cod_nom);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_cod_matricula =(int) Convert.ToDouble(Reg["Codi_Matr"].ToString());
            }
            this.cnx.Close();
        }


        public void Fun_UpdateMensu()
        {
            Fun_ExtraerMatri();

            this.sql = string.Format("update matricula set CuotaPago = '{0}' where Alumnos_CodAlumno = '{1}' and CodMatricula = '{2}'", Var_mensualidad, Var_cod_nom, Var_cod_matricula);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();
            if (Reg > 0)
            {
                MessageBox.Show("Los datos se ingresaron correctamente","Mensaje de confirmación",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ocurrio un error en el ingreso\nPor favor contacte con su supervisor", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cnx.Close();
        }



        public void Fun_MuestraDatosGen(DataGridView Dvg_MuestraDatos)
        {
            cnx.Open();
            sql = string.Format(@"select B.CodMatricula as 'Codigo Matricula',B.FechaIngreso as 'Fecha de realizacion', D.Descripcion as 'Matricula',C.descripcion as 'Jornada',
A.CodAlumno as 'Codigo de Alumno',
A.IdAlum as 'No. Identidad', A.NomAlumno as 'Nombre de Alumno', 
B.AnioIngreso as 'Año de Ingreso', B.Entrevistador as 'Entrevistador', B.CuotaPago as 'Cuota de pago' from alumnos 
as A inner join matricula as B on A.CodAlumno = B.Alumnos_CodAlumno inner join jornada as C
on B.Cod_jornada=C.cod_jornada inner join tipo_matricula as D on B.Cod_Tipo=D.Cod_Tipo
order by B.CodMatricula desc ");
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            DataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Dvg_MuestraDatos.DataSource = dt;
            cnx.Close();
        }

        public void Fun_MuestraDatosPorAlum(DataGridView Var_Show)
        {
            cnx.Open();
            sql = string.Format(@"select B.CodMatricula as 'Codigo Matricula',B.FechaIngreso as 'Fecha de realizacion', D.Descripcion as 'Matricula',C.descripcion as 'Jornada',
A.CodAlumno as 'Codigo de Alumno',
A.IdAlum as 'No. Identidad', A.NomAlumno as 'Nombre de Alumno', 
B.AnioIngreso as 'Año de Ingreso', B.Entrevistador as 'Entrevistador', B.CuotaPago as 'Cuota de pago' from alumnos 
as A inner join matricula as B on A.CodAlumno = B.Alumnos_CodAlumno inner join jornada as C
on B.Cod_jornada=C.cod_jornada inner join tipo_matricula as D on B.Cod_Tipo=D.Cod_Tipo
where A.NomAlumno like '%{0}%' order by B.CodMatricula desc ", Var_filtro_nom_cliente);
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            DataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Var_Show.DataSource = dt;
            cnx.Close();
        }
    }
}

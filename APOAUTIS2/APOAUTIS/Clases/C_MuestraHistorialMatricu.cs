using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;


namespace APOAUTIS.Clases
{
    class C_MuestraHistorialMatricu: Conexion
    {
        private int var_anio_primario;
        private int var_anio_final;
        private int var_anio_busqueda;
        private string var_nom_filtro;

        public int Var_anio_primario
        {
            get
            {
                return var_anio_primario;
            }

            set
            {
                var_anio_primario = value;
            }
        }

        public int Var_anio_final
        {
            get
            {
                return var_anio_final;
            }

            set
            {
                var_anio_final = value;
            }
        }

        public int Var_anio_busqueda
        {
            get
            {
                return var_anio_busqueda;
            }

            set
            {
                var_anio_busqueda = value;
            }
        }

        public string Var_nom_filtro
        {
            get
            {
                return var_nom_filtro;
            }

            set
            {
                var_nom_filtro = value;
            }
        }

        public void Fun_ExtraerAñoMaximo()
        {
            sql = string.Format("select max(year(FechaIngreso)) as 'Anio' from matricula;");
            cnx.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = cmd.ExecuteReader();
            if (Reg.Read())
            {
                Var_anio_final = (int) Convert.ToDouble(Reg["Anio"].ToString());
            }
            cnx.Close();
        }

        public void Fun_ExtraerAñoMinimo()
        {
            sql = string.Format("select min(year(FechaIngreso)) as 'Anio' from matricula;");
            cnx.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = cmd.ExecuteReader();
            if (Reg.Read())
            {
                Var_anio_primario = (int)Convert.ToDouble(Reg["Anio"].ToString());
            }
            cnx.Close();
        }

        public void Fun_MostrarAños(ComboBox Var_ExFecha)
        {
            Fun_ExtraerAñoMaximo();
            Fun_ExtraerAñoMinimo();
            for (int i= Var_anio_final; i>= Var_anio_primario; i--)
            {
                Var_ExFecha.Items.Add(i);
            }
        }

        public void Fun_MostrarTodos(System.Windows.Forms.DataGridView Var_MuestraDatos)
        {
            sql = string.Format("select B.CodMatricula as 'Codigo Matricula', B.FechaIngreso as 'Fecha de realizacion',A.CodAlumno as 'Codigo de Alumno', A.IdAlum as 'No. Identidad',A.NomAlumno as 'Nombre de Alumno', A.SexoAlum as 'Genero', B.AnioIngreso as 'Año de Ingreso', B.Entrevistador as 'Entrevistador', B.CuotaPago as 'Cuota de pago' from alumnos as A inner join matricula as B on A.CodAlumno = B.Alumnos_CodAlumno order by A.NomAlumno and B.CodMatricula desc ; ");
            cnx.Open();
            cmd = new MySqlCommand(sql, cnx);
            DataAdapter = new MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Var_MuestraDatos.DataSource = dt;
            cnx.Close();
        }

        public void Fun_MostrarPorNombre(System.Windows.Forms.DataGridView Var_MuestraDatos)
        {
            sql = string.Format("select B.CodMatricula as 'Codigo Matricula',B.FechaIngreso as 'Fecha de realizacion',A.CodAlumno as 'Codigo de Alumno', A.IdAlum as 'No. Identidad',A.NomAlumno as 'Nombre de Alumno', A.SexoAlum as 'Genero', B.AnioIngreso as 'Año de Ingreso', B.Entrevistador as 'Entrevistador', B.CuotaPago as 'Cuota de pago' from alumnos as A inner join matricula as B on A.CodAlumno = B.Alumnos_CodAlumno  where A.NomAlumno like '%{0}%' order by A.NomAlumno and B.CodMatricula desc ; ", Var_nom_filtro);
            cnx.Open();
            cmd = new MySqlCommand(sql, cnx);
            DataAdapter = new MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Var_MuestraDatos.DataSource = dt;
            cnx.Close();

        }


        public void Fun_MostrarPorYear(System.Windows.Forms.DataGridView Var_MuestraDatos)
        {
            sql = string.Format(@"select B.CodMatricula as 'Codigo Matricula',A.CodAlumno as 'Codigo de Alumno', 
A.IdAlum as 'No. Identidad', A.NomAlumno as 'Nombre de Alumno', A.SexoAlum as 'Genero', B.Jornada as 'Jornada', 
B.AnioIngreso as 'Año de Ingreso', B.Entrevistador as 'Entrevistador', B.CuotaPago as 'Cuota de pago' from alumnos 
as A inner join matricula as B on A.CodAlumno = B.Alumnos_CodAlumno where YEAR(B.Fecha) = '{0}' 
order by A.NomAlumno and B.CodMatricula desc ; ", Var_anio_busqueda);
            cnx.Open();
            cmd = new MySqlCommand(sql, cnx);
            DataAdapter = new MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Var_MuestraDatos.DataSource = dt;
            cnx.Close();

        }
    }
    }

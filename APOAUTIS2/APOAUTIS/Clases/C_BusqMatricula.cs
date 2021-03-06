﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_BusqMatricula: Conexion
    {
        private int var_fecha_busq;
        private int var_anio_maximo;
        private int var_anio_minimo;

        private int var_Alum_CodAlumno;
        private int var_Mat_CodMatricula;

        private string var_Alum_IntitutoIncl;
        private string var_DG_TipoMatricula;
        private string var_Alum_Nombre;
        private string var_Alum_lugarnacimiento;
        private string var_Alum_fechanacimiento;
        private string var_Alum_direccioncompleta;
        private string var_Alum_celular;
        private string var_Alum_instprocedencia;
        private string var_DG_annioingreso;
        private string var_DG_recibioevaluacion;
        private string var_Alum_telefonofijo;
        private string var_DG_Jornada;
        private string var_Alum_direcionemergencia;
        private string var_Alum_telefonoemergencia;
        private string var_DG_Observaciones;
        private string var_DG_Fecha;
        private string var_DG_Entrevistador;


        public int Var_fecha_busq
        {
            get
            {
                return var_fecha_busq;
            }

            set
            {
                var_fecha_busq = value;
            }
        }

        public int Var_anio_maximo
        {
            get
            {
                return var_anio_maximo;
            }

            set
            {
                var_anio_maximo = value;
            }
        }

        public int Var_anio_minimo
        {
            get
            {
                return var_anio_minimo;
            }

            set
            {
                var_anio_minimo = value;
            }
        }

        public string Var_DG_TipoMatricula
        {
            get
            {
                return var_DG_TipoMatricula;
            }

            set
            {
                var_DG_TipoMatricula = value;
            }
        }

        public string Var_Alum_Nombre
        {
            get
            {
                return var_Alum_Nombre;
            }

            set
            {
                var_Alum_Nombre = value;
            }
        }

        public string Var_Alum_lugarnacimiento
        {
            get
            {
                return var_Alum_lugarnacimiento;
            }

            set
            {
                var_Alum_lugarnacimiento = value;
            }
        }

        public string Var_Alum_fechanacimiento
        {
            get
            {
                return var_Alum_fechanacimiento;
            }

            set
            {
                var_Alum_fechanacimiento = value;
            }
        }

        public string Var_Alum_direccioncompleta
        {
            get
            {
                return var_Alum_direccioncompleta;
            }

            set
            {
                var_Alum_direccioncompleta = value;
            }
        }

        public string Var_Alum_celular
        {
            get
            {
                return var_Alum_celular;
            }

            set
            {
                var_Alum_celular = value;
            }
        }

        public string Var_Alum_instprocedencia
        {
            get
            {
                return var_Alum_instprocedencia;
            }

            set
            {
                var_Alum_instprocedencia = value;
            }
        }

        public string Var_DG_annioingreso
        {
            get
            {
                return var_DG_annioingreso;
            }

            set
            {
                var_DG_annioingreso = value;
            }
        }

        public string Var_DG_recibioevaluacion
        {
            get
            {
                return var_DG_recibioevaluacion;
            }

            set
            {
                var_DG_recibioevaluacion = value;
            }
        }

        public string Var_Alum_telefonofijo
        {
            get
            {
                return var_Alum_telefonofijo;
            }

            set
            {
                var_Alum_telefonofijo = value;
            }
        }

        public string Var_DG_Jornada
        {
            get
            {
                return var_DG_Jornada;
            }

            set
            {
                var_DG_Jornada = value;
            }
        }

        public string Var_Alum_direcionemergencia
        {
            get
            {
                return var_Alum_direcionemergencia;
            }

            set
            {
                var_Alum_direcionemergencia = value;
            }
        }

        public string Var_Alum_telefonoemergencia
        {
            get
            {
                return var_Alum_telefonoemergencia;
            }

            set
            {
                var_Alum_telefonoemergencia = value;
            }
        }

        public string Var_DG_Observaciones
        {
            get
            {
                return var_DG_Observaciones;
            }

            set
            {
                var_DG_Observaciones = value;
            }
        }

        public string Var_DG_Fecha
        {
            get
            {
                return var_DG_Fecha;
            }

            set
            {
                var_DG_Fecha = value;
            }
        }

        public string Var_DG_Entrevistador
        {
            get
            {
                return var_DG_Entrevistador;
            }

            set
            {
                var_DG_Entrevistador = value;
            }
        }

        public int Var_Alum_CodAlumno
        {
            get
            {
                return var_Alum_CodAlumno;
            }

            set
            {
                var_Alum_CodAlumno = value;
            }
        }

        public int Var_Mat_CodMatricula
        {
            get
            {
                return var_Mat_CodMatricula;
            }

            set
            {
                var_Mat_CodMatricula = value;
            }
        }

        public string Var_Alum_IntitutoIncl
        {
            get
            {
                return var_Alum_IntitutoIncl;
            }

            set
            {
                var_Alum_IntitutoIncl = value;
            }
        }

        public void Fun_MostrarTodos(System.Windows.Forms.DataGridView Var_MuestraDatos)
        {
            sql = string.Format(@"select B.CodMatricula as 'Codigo Matricula',
            B.FechaIngreso as 'Fecha de realizacion',A.CodAlumno as 'Codigo de Alumno', 
            A.IdAlum as 'No. Identidad',A.NomAlumno as 'Nombre de Alumno', 
            A.SexoAlum as 'Genero', B.AnioIngreso as 'Año de Ingreso', 
            B.Entrevistador as 'Entrevistador', B.CuotaPago as 'Cuota de pago' 
            from alumnos as A inner join matricula as B on A.CodAlumno = B.Alumnos_CodAlumno 
            order by B.FechaIngreso desc ; ");
            cnx.Open();
            cmd = new MySqlCommand(sql, cnx);
            DataAdapter = new MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Var_MuestraDatos.DataSource = dt;
            cnx.Close();
        }

        public void Fun_MostrarPorFecha(System.Windows.Forms.DataGridView Var_MuestraDatos)
        {
            sql = string.Format(@"select B.CodMatricula as 'Codigo Matricula',
            B.FechaIngreso as 'Fecha de realizacion',A.CodAlumno as 'Codigo de Alumno', 
            A.IdAlum as 'No. Identidad',A.NomAlumno as 'Nombre de Alumno', 
            A.SexoAlum as 'Genero',  B.AnioIngreso as 'Año de Ingreso', 
            B.Entrevistador as 'Entrevistador', B.CuotaPago as 'Cuota de pago' 
            from alumnos as A inner join matricula as B on A.CodAlumno = B.Alumnos_CodAlumno 
            where year(B.FechaIngreso)='{0}'
            order by B.FechaIngreso desc ; ", Var_fecha_busq);
            cnx.Open();
            cmd = new MySqlCommand(sql, cnx);
            DataAdapter = new MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Var_MuestraDatos.DataSource = dt;
            cnx.Close();
        }


        public void Fun_ExtraerAñoMaximo()
        {
            sql = string.Format("select max(year(FechaIngreso)) as 'Anio' from matricula;");
            cnx.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = cmd.ExecuteReader();
            if (Reg.Read())
            {
                Var_anio_maximo = (int)Convert.ToDouble(Reg["Anio"].ToString());
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
                Var_anio_minimo = (int)Convert.ToDouble(Reg["Anio"].ToString());
            }
            cnx.Close();
        }

        public void Fun_MostrarAños(ComboBox Var_ExFecha)
        {
            Fun_ExtraerAñoMaximo();
            Fun_ExtraerAñoMinimo();
            for (int i = Var_anio_maximo; i >= Var_anio_minimo; i--)
            {
                Var_ExFecha.Items.Add(i);
            }
        }

        public void Fun_ExtraerDatos_Mat_Alumno()
        {
            sql = string.Format(@"select * from alumnos as A left join matricula as B on A.CodAlumno=B.Alumnos_CodAlumno
            where A.CodAlumno = '{0}' and B.CodMatricula = '{1}'", Var_Alum_CodAlumno, Var_Mat_CodMatricula);
            cnx.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = cmd.ExecuteReader();
            if (Reg.Read())
            {
                Var_Alum_Nombre = Reg["NomAlumno"].ToString();
                Var_Alum_lugarnacimiento = Reg["LugarNaciAlum"].ToString();
                Var_Alum_fechanacimiento = Reg["FechaNaciAlum"].ToString();
                Var_Alum_direccioncompleta = Reg["DireccionAlum"].ToString();
                Var_Alum_celular = Reg["CelAlumno"].ToString();
                Var_Alum_instprocedencia = Reg["InstProceAlumno"].ToString();

                Var_DG_annioingreso = Reg["AnioIngreso"].ToString();
                Var_DG_recibioevaluacion = Reg["RecibioEvalu"].ToString();
                Var_Alum_telefonofijo = Reg["TelFijoAlum"].ToString();
          
                Var_Alum_direcionemergencia = Reg["EmergLugar"].ToString();
                Var_Alum_telefonoemergencia = Reg["EmergTelefono"].ToString();
                Var_DG_Observaciones = Reg["Observaciones"].ToString();
                Var_DG_Fecha = Reg["FechaIngreso"].ToString();
                Var_DG_Entrevistador = Reg["Entrevistador"].ToString();
                Var_Alum_IntitutoIncl = Reg["InstDondeEstaIncluido"].ToString();
            }
            cnx.Close();
        }

    }
}

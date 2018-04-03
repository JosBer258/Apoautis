using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_Alumnos: Conexion
    {
           private int CodAlumno1;
        private string NomAlumno1;
            private string LugarNaciAlum1;
            private string FechaNaciAlum1;
        private int EdadAlum1;
        private string EdadCronologica1;
            private string SexoAlum1;
            private string IdAlum1;
        private string DireccionAlum1;
        private string TelFijoAlum1;
        private string CelAlumno1;
        private string EscolaridadAlum1;
        private string LugarOrigAlum1;
        private string InstProceAlumno1;
        private string InstDondeEstaIncluido1;
        private string ExistenciaAlergias;
        private string UsoMedicamentos;
        private string EnfermedadesPadeciFamilia;
        private string LugaresAtencionMedica;
        private double GastosMEdicos;

        public int CodAlumno11 {
            get { return CodAlumno1; }
            set { CodAlumno1 = value; }
        }
        public string NomAlumno11 { get { return NomAlumno1; }
            set { NomAlumno1 = value; }
        }
        public string LugarNaciAlum11 { get { return LugarNaciAlum1; }
            set { LugarNaciAlum1 = value; }
        }
        public string FechaNaciAlum11 { get { return FechaNaciAlum1; }
            set { FechaNaciAlum1 = value; }
        }
        public int EdadAlum11
        {
            get { return EdadAlum1; }
            set { EdadAlum1 = value; }
        }
        public string EdadCronologica11 { get { return EdadCronologica1; }
            set { EdadCronologica1 = value; }
        }
        public string SexoAlum11 { get { return SexoAlum1; }
            set { SexoAlum1 = value; }
        }
        public string IdAlum11 { get { return  IdAlum1; }
            set { IdAlum1 = value; }
        }
        public string DireccionAlum11 { get { return DireccionAlum1; }
            set { DireccionAlum1 = value; }
        }
        public string TelFijoAlum11 { get { return TelFijoAlum1; } set { TelFijoAlum1 = value; }
    }
    public string CelAlumno11 { get { return CelAlumno1; }
        set { CelAlumno1 = value; }
    }
    public string EscolaridadAlum11 { get { return EscolaridadAlum1; }
        set { EscolaridadAlum1 = value; }
    }
    public string LugarOrigAlum11 { get { return LugarOrigAlum1; }
        set { LugarOrigAlum1 = value; }
    }
    public string InstProceAlumno11 { get { return InstProceAlumno1; }
        set { InstProceAlumno1 = value; }
    }
    public string InstDondeEstaIncluido11 { get { return InstDondeEstaIncluido1; }
        set { InstDondeEstaIncluido1 = value; }
    }

        public string UsoMedicamentos1 { get { return UsoMedicamentos; }
            set { UsoMedicamentos = value; }
        }
        public string EnfermedadesPadeciFamilia1 { get { return EnfermedadesPadeciFamilia; }
            set { EnfermedadesPadeciFamilia = value; }
        }
        public string LugaresAtencionMedica1 { get { return LugaresAtencionMedica; } set { LugaresAtencionMedica = value; } }
        public double GastosMEdicos1 { get { return GastosMEdicos; }
            set { GastosMEdicos = value; }
        }

        public string ExistenciaAlergias1 { get { return ExistenciaAlergias; }
            set { ExistenciaAlergias = value; }
        }

        public void FillAlumnosPest2Por(int a)
        {
            if (a == 1)
            {
                this.sql = string.Format(@"select A.CodAlumno,A.NomAlumno,
A.LugarNaciAlum,A.FechaNaciAlum,A.EdadAlum,A.EdadCronologica,
A.SexoAlum,A.IdAlum,A.DireccionAlum,A.TelFijoAlum,A.CelAlumno,A.EscolaridadAlum,
A.LugarOrigAlum,A.InstProceAlumno,A.InstDondeEstaIncluido from Alumnos as A
where A.NomAlumno like'%{0}%'", NomAlumno11);
            }
            else if(a==2)
            {
                this.sql = string.Format(@"select A.CodAlumno,A.NomAlumno,
A.LugarNaciAlum,A.FechaNaciAlum,A.EdadAlum,A.EdadCronologica,
A.SexoAlum,A.IdAlum,A.DireccionAlum,A.TelFijoAlum,A.CelAlumno,A.EscolaridadAlum,
A.LugarOrigAlum,A.InstProceAlumno,A.InstDondeEstaIncluido from Alumnos as A
where A.CodAlumno like'%{0}%'", CodAlumno11);
            }
            else
            {
                this.sql = string.Format(@"select A.CodAlumno,A.NomAlumno,
A.LugarNaciAlum,A.FechaNaciAlum,A.EdadAlum,A.EdadCronologica,
A.SexoAlum,A.IdAlum,A.DireccionAlum,A.TelFijoAlum,A.CelAlumno,A.EscolaridadAlum,
A.LugarOrigAlum,A.InstProceAlumno,A.InstDondeEstaIncluido from Alumnos as A
where A.IdAlum like'%{0}%'", IdAlum11);
            }
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                CodAlumno11 = Convert.ToInt32((Reg["CodAlumno"].ToString()));
                NomAlumno11 = (Reg["NomAlumno"].ToString());
                LugarNaciAlum11 = (Reg["LugarNaciAlum"].ToString());
                FechaNaciAlum11 = (Reg["FechaNaciAlum"].ToString());
                EdadAlum11 = Convert.ToInt32((Reg["EdadAlum"].ToString()));
                EdadCronologica11 = (Reg["EdadCronologica"].ToString());
                SexoAlum11 = (Reg["SexoAlum"].ToString());
                IdAlum11 = (Reg["IdAlum"].ToString());
                DireccionAlum11 = (Reg["DireccionAlum"].ToString());
                TelFijoAlum11 = (Reg["TelFijoAlum"].ToString());
                CelAlumno11 = (Reg["CelAlumno"].ToString());
                EscolaridadAlum11 = (Reg["EscolaridadAlum"].ToString());
                LugarOrigAlum11 = (Reg["LugarOrigAlum"].ToString());
                InstProceAlumno11 = (Reg["InstProceAlumno"].ToString());
                InstDondeEstaIncluido11 = (Reg["InstDondeEstaIncluido"].ToString());
                this.cnx.Close();
                

            }
            else
            {
                
            }

            this.cnx.Close();
           

        }

        public void llenarDatosHistoriaMedico()
        {

            this.sql = string.Format(@"select B.NomAlumno,A.UsaMedicamentos,A.TieneAlergias,
A.LugaresRecibeAtencionMedica,A.EnfermePAdecenFamili,A.CuantoGastaEnMed from
historialmedico as A inner join alumnos as B on
A.Alumnos_CodAlumno=B.CodAlumno where B.CodAlumno like'%{0}%'", CodAlumno11);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                ExistenciaAlergias = (Reg["TieneAlergias"].ToString());
                UsoMedicamentos = (Reg["UsaMedicamentos"].ToString());
                EnfermedadesPadeciFamilia = (Reg["EnfermePAdecenFamili"].ToString());
                LugaresAtencionMedica = (Reg["LugaresRecibeAtencionMedica"].ToString());
                GastosMEdicos = Convert.ToDouble((Reg["CuantoGastaEnMed"].ToString()));
                this.cnx.Close();


            }
            else
            {

            }


        }
        public void Fun_Show(DataGridView dgv)
        {
            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"select * from alumnos", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }
        public void MostrarAcontecimientos(DataGridView dgv)
        {
            cnx.Open();
            try
            {

                


                this.sql = string.Format
               (@"select B.NomAlumno,B.SexoAlum,B.EdadAlum,B.IdAlum,A.Cuando,A.Donde,
A.DiagnosticoTratamiento from acontecimientomedco as A inner join
alumnos as B on A.Alumnos_CodAlumno=B.CodAlumno where B.CodAlumno like'%{0}%'", CodAlumno11);
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.DataAdapter = new MySqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
                dgv.DataSource = this.dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void BusquedaCargarDatosNombre(DataGridView dgv, string a)
        {
            cnx.Open();
            try
            {

                string busq;
                busq = a;


                this.sql = string.Format
               (@"select A.CodAlumno,A.NomAlumno,
A.LugarNaciAlum,A.FechaNaciAlum,A.EdadAlum,A.EdadCronologica,
A.SexoAlum,A.IdAlum,A.DireccionAlum,A.TelFijoAlum,A.CelAlumno,A.EscolaridadAlum,
A.LugarOrigAlum,A.InstProceAlumno,A.InstDondeEstaIncluido from Alumnos as A
where A.NomAlumno like'%{0}%'", busq);
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.DataAdapter = new MySqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
                dgv.DataSource = this.dt;
                


            }
            catch
            {

            }
            cnx.Close();
        }

        public void BusquedaCargarDatosIdentidad(DataGridView dgv, string a)
        {
            cnx.Open();
            try
            {

                string busq;
                busq = a;
                this.sql = string.Format
                (@"select A.CodAlumno,A.NomAlumno,
A.LugarNaciAlum,A.FechaNaciAlum,A.EdadAlum,A.EdadCronologica,
A.SexoAlum,A.IdAlum,A.DireccionAlum,A.TelFijoAlum,A.CelAlumno,A.EscolaridadAlum,
A.LugarOrigAlum,A.InstProceAlumno,A.InstDondeEstaIncluido from Alumnos as A
where A.IdAlum like '%{0}%'", busq);
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.DataAdapter = new MySqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
                dgv.DataSource = this.dt;

            }
            catch
            {

            }
            cnx.Close();
        }


    }
}

        
    

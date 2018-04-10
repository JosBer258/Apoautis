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
        private string EmergLugar;
        private string EmergTelefono;
        private int estadoAlumno;
        private int codMatricula;
        private int jornada;
        private string observaciones;
        private string fechaIngreso;
        private string recibioEvalu;
        private string anioIngreso;


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

        public int EstadoAlumno
        {
            get
            {
                return estadoAlumno;
            }

            set
            {
                estadoAlumno = value;
            }
        }

        public string EmergLugar1 { get { return EmergLugar; } set { EmergLugar = value; } }
        public string EmergTelefono1 { get { return  EmergTelefono; } set { EmergTelefono = value; } }

        public int CodMatricula { get { return codMatricula; }
        set { codMatricula = value; }
    }
    public int Jornada { get { return jornada; }
set { jornada = value; }}
        public string Observaciones { get { return observaciones; }
set { observaciones = value; }}
        public string FechaIngreso { get { return fechaIngreso; }
set { fechaIngreso = value; }}
        public string RecibioEvalu { get { return recibioEvalu; }
set { recibioEvalu = value; }}

        public string AnioIngreso { get { return anioIngreso; }
            set { anioIngreso = value; }
        }

        public void ingresoAlumnos()
        {
            this.sql = string.Format(@"INSERT INTO alumnos
                                        (NomAlumno, LugarNaciAlum, FechaNaciAlum, DireccionAlum,
                                        TelFijoAlum, CelAlumno, InstProceAlumno, Estado)
                                        VALUES
                                        ('{0}','{1}', '{2}','{3}', '{4}',
                                        '{5}', '{6}','{7}');",
                                        NomAlumno11, LugarNaciAlum11, FechaNaciAlum11, DireccionAlum11, TelFijoAlum11, CelAlumno11,
                                        InstProceAlumno11, 4);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

        public void FillAlumnosPest2Por(int a)
        {
            if (a == 1)
            {
                this.sql = string.Format(@"select A.CodAlumno,A.NomAlumno,
A.LugarNaciAlum,A.FechaNaciAlum,A.EdadAlum,A.EdadCronologica,
A.SexoAlum,A.IdAlum,A.DireccionAlum,A.TelFijoAlum,A.CelAlumno,A.EscolaridadAlum,
A.LugarOrigAlum,A.InstProceAlumno,A.InstDondeEstaIncluido,A.Estado,A.EmergLugar,A.EmergTelefono from Alumnos as A 
where A.NomAlumno like'%{0}%'", NomAlumno11);
            }
            else if(a==2)
            {
                this.sql = string.Format(@"select A.CodAlumno,A.NomAlumno,
A.LugarNaciAlum,A.FechaNaciAlum,A.EdadAlum,A.EdadCronologica,
A.SexoAlum,A.IdAlum,A.DireccionAlum,A.TelFijoAlum,A.CelAlumno,A.EscolaridadAlum,
A.LugarOrigAlum,A.InstProceAlumno,A.InstDondeEstaIncluido,A.Estado,A.EmergLugar,A.EmergTelefono from Alumnos as A 
where A.CodAlumno like'%{0}%'", CodAlumno11);
            }
            else
            {
                this.sql = string.Format(@"select A.CodAlumno,A.NomAlumno,
A.LugarNaciAlum,A.FechaNaciAlum,A.EdadAlum,A.EdadCronologica,
A.SexoAlum,A.IdAlum,A.DireccionAlum,A.TelFijoAlum,A.CelAlumno,A.EscolaridadAlum,
A.LugarOrigAlum,A.InstProceAlumno,A.InstDondeEstaIncluido,A.Estado,A.EmergLugar,A.EmergTelefono from Alumnos as A 
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
                if((Reg["EdadAlum"].ToString())==string.Empty || Reg["EdadCronologica"].ToString()==string.Empty)
                {
                    EdadAlum11 = 0;
                    EdadCronologica11 = "0";
                }
                else
                {
                    EdadAlum11 = Convert.ToInt32((Reg["EdadAlum"].ToString()));
                    EdadCronologica11 = (Reg["EdadCronologica"].ToString());
                }
               
                SexoAlum11 = (Reg["SexoAlum"].ToString());
                IdAlum11 = (Reg["IdAlum"].ToString());
                DireccionAlum11 = (Reg["DireccionAlum"].ToString());
                TelFijoAlum11 = (Reg["TelFijoAlum"].ToString());
                CelAlumno11 = (Reg["CelAlumno"].ToString());
                EscolaridadAlum11 = (Reg["EscolaridadAlum"].ToString());
                LugarOrigAlum11 = (Reg["LugarOrigAlum"].ToString());
                InstProceAlumno11 = (Reg["InstProceAlumno"].ToString());
                InstDondeEstaIncluido11 = (Reg["InstDondeEstaIncluido"].ToString());
                EstadoAlumno = Convert.ToInt32(Reg["Estado"].ToString());
                EmergLugar1 = (Reg["EmergLugar"].ToString());
                EmergTelefono1 = (Reg["EmergTelefono"].ToString());
              
                this.cnx.Close();
                VerificarYear();
                

            }
            else
            {
                
            }

            this.cnx.Close();
            
        }


        public void updateMatricula(int JJornada, string RRecibioEvalu, string OObservaciones, int CCodalumno)
        {
            
            this.sql = string.Format(@"update matricula set Cod_jornada ='{0}', RecibioEvalu='{1}', Observaciones='{2}'
where Alumnos_CodAlumno like'%{3}%'", JJornada, RRecibioEvalu, OObservaciones, CCodalumno);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void llenarDatosMatricula(int CCodAlumno11)
        {

            

            this.sql = string.Format(@"select B.CodMatricula,B.Alumnos_CodAlumno,B.Cod_jornada,B.AnioIngreso,
B.RecibioEvalu,B.Observaciones,B.FechaIngreso from matricula as B
where B.Alumnos_CodAlumno ='{0}'", CCodAlumno11);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
               
                    CodMatricula = Convert.ToInt32(Reg["CodMatricula"].ToString());
                    Jornada = Convert.ToInt32(Reg["Cod_jornada"].ToString());
                    Observaciones = (Reg["Observaciones"].ToString());
                    FechaIngreso = (Reg["FechaIngreso"].ToString());
                    RecibioEvalu = ((Reg["RecibioEvalu"].ToString()));
                    AnioIngreso = (Reg["AnioIngreso"].ToString());
                
        
                this.cnx.Close();


            }
            else
            {
                CodMatricula = 0;
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
            this.cnx.Close();


        }
        public void Fun_Show(DataGridView dgv)
        {
            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"select A.CodAlumno as'Codigo de Alumno', A.NomAlumno as 'Nombre completo',
A.LugarNaciAlum as 'Lugar de Nacimiento', A.FechaNaciAlum as 'Fecha de Nacimiento', A.EdadAlum as 'Edad', A.EdadCronologica
as 'Edad Cronologica',
A.SexoAlum as 'Sexo', A.IdAlum as 'Identidad', A.DireccionAlum as 'Direccion', A.TelFijoAlum as 'Telefono fijo', 
A.CelAlumno as 'Celular', A.EscolaridadAlum as 'Escolaridad',
A.LugarOrigAlum as 'Lugar de Origen', A.InstProceAlumno as 'Instituto de Procedencia', A.InstDondeEstaIncluido 
as 'Intituto donde esta incluido' , B.DescripcionEstado as 'Estado',A.EmergLugar as 'Lugar en Caso de Emergencia',   
A.EmergTelefono as 'Telefono de Emergencia' from alumnos as A inner join estados as B
on A.Estado=B.CodEstado
order by CodAlumno", ccnx);
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
               (@"select B.NomAlumno as 'Nombre Alumno',B.SexoAlum as 'Sexo',B.EdadAlum as 'Edad',
B.IdAlum as 'Identidad',A.Cuando,A.Donde,
A.DiagnosticoTratamiento as 'Diagnostico Y Tratamiento' from acontecimientomedco as A inner join
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
               (@"select A.CodAlumno as'Codigo de Alumno', A.NomAlumno as 'Nombre completo',
A.LugarNaciAlum as 'Lugar de Nacimiento', A.FechaNaciAlum as 'Fecha de Nacimiento', A.EdadAlum as 'Edad', A.EdadCronologica
as 'Edad Cronologica',
A.SexoAlum as 'Sexo', A.IdAlum as 'Identidad', A.DireccionAlum as 'Direccion', A.TelFijoAlum as 'Telefono fijo', 
A.CelAlumno as 'Celular', A.EscolaridadAlum as 'Escolaridad',
A.LugarOrigAlum as 'Lugar de Origen', A.InstProceAlumno as 'Instituto de Procedencia', A.InstDondeEstaIncluido 
as 'Intituto donde esta incluido' , B.DescripcionEstado as 'Estado',A.EmergLugar as 'Lugar en Caso de Emergencia',   
A.EmergTelefono as 'Telefono de Emergencia' from alumnos as A inner join estados as B
on A.Estado=B.CodEstado
where A.NomAlumno like'%{0}%'
order by CodAlumno", busq);
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
                (@"select A.CodAlumno as'Codigo de Alumno', A.NomAlumno as 'Nombre completo',
A.LugarNaciAlum as 'Lugar de Nacimiento', A.FechaNaciAlum as 'Fecha de Nacimiento', A.EdadAlum as 'Edad', A.EdadCronologica
as 'Edad Cronologica',
A.SexoAlum as 'Sexo', A.IdAlum as 'Identidad', A.DireccionAlum as 'Direccion', A.TelFijoAlum as 'Telefono fijo', 
A.CelAlumno as 'Celular', A.EscolaridadAlum as 'Escolaridad',
A.LugarOrigAlum as 'Lugar de Origen', A.InstProceAlumno as 'Instituto de Procedencia', A.InstDondeEstaIncluido 
as 'Intituto donde esta incluido' , B.DescripcionEstado as 'Estado',A.EmergLugar as 'Lugar en Caso de Emergencia',   
A.EmergTelefono as 'Telefono de Emergencia' from alumnos as A inner join estados as B
on A.Estado=B.CodEstado
where A.IdAlum like '%{0}%'
order by CodAlumno", busq);
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





        public void GenerarEstado(ComboBox Com_Roles, int estado)
        {
            cnx.Open();
            sql = string.Format(@"select CodEstado, DescripcionEstado from estados where CodtipoEstado='{0}'",estado);
            cmd = new MySqlCommand(sql, cnx);
            DataAdapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            Com_Roles.ValueMember = "CodEstado";
            Com_Roles.DisplayMember = "DescripcionEstado";
            Com_Roles.DataSource = dt;
        }
        public void GenerarJornada(ComboBox Com_Roles)
        {
            cnx.Open();
            sql = string.Format(@"select cod_jornada, descripcion from jornada");
            cmd = new MySqlCommand(sql, cnx);
            DataAdapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            Com_Roles.ValueMember = "cod_jornada";
            Com_Roles.DisplayMember = "descripcion";
            Com_Roles.DataSource = dt;
        }

        public DateTime ne;
        public string w;
        public void VerificarYear()
        {
            this.sql = string.Format(@"select FechaNaciAlum from alumnos where CodAlumno='{0}'", CodAlumno11);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                ne = DateTime.Parse(Reg["FechaNaciAlum"].ToString());
                DateTime nacimiento = new DateTime(ne.Year,ne.Month,ne.Day); //Fecha de nacimiento
                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                EdadAlum11 = edad; 
                TimeSpan ts = DateTime.Now.Date - ne.Date;
                
                double Años = ts.Days / 365;
                double Meses = Convert.ToInt32((ts.Days - (Años * 365)) / 30.4167);
                double Dias = Convert.ToInt32((ts.Days - (Años * 365)) - (Meses * 30.4167));
                string str = "Año:" + Años.ToString() + " Mes:" + Meses.ToString() + " Dia:" + Dias.ToString();
                EdadCronologica11 = str;
                this.cnx.Close();
                updateEdades();
               
            }
            else
            {

            }
            this.cnx.Close();

        }
        public void updateEdades()
        {
            this.sql = string.Format(@"update alumnos set EdadAlum ='{0}', EdadCronologica='{1}'
where CodAlumno='{2}'", EdadAlum11, EdadCronologica11, CodAlumno11);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void updateAlumnos(string SexoAlum, string DireccionAlum, string TelfijoAlum, string CelAlumno, 
            string EscolaridadAlum, string InstProceAlumno, string InstDondeEstaIncluido,
            int estado, string emerlugar, string emertelefono,int CodAlumno)
        {
            this.sql = string.Format(@"update alumnos set SexoAlum='{0}',DireccionAlum='{1}',TelfijoAlum='{2}',
CelAlumno='{3}',EscolaridadAlum='{4}',InstProceAlumno='{5}',
InstDondeEstaIncluido='{6}', Estado='{7}',EmergLugar='{8}',EmergTelefono='{9}' where CodAlumno='{10}'", SexoAlum, DireccionAlum, TelfijoAlum, CelAlumno, EscolaridadAlum,
InstProceAlumno, InstDondeEstaIncluido, estado, emerlugar, emertelefono, CodAlumno);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }

       

    }
}

        
    

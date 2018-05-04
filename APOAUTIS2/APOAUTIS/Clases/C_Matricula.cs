using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    class C_Matricula:Conexion
    {
        private int CodMatricula;
        private int Alumnos_CodAlumno;
        private int Jornada;
        private string AnioIngreso;
        private string RecibioEvalu;
        private string Observaciones;
        private string Entrevistador;
        private string CuotaPago;
        private string FechaIngreso;
        private int Tipo_Matricula;

        public int CodMatricula1
        {
            get
            {
                return CodMatricula;
            }

            set
            {
                CodMatricula = value;
            }
        }

        public int Alumnos_CodAlumno1
        {
            get
            {
                return Alumnos_CodAlumno;
            }

            set
            {
                Alumnos_CodAlumno = value;
            }
        }

        public int Jornada1
        {
            get
            {
                return Jornada;
            }

            set
            {
                Jornada = value;
            }
        }

        public string AnioIngreso1
        {
            get
            {
                return AnioIngreso;
            }

            set
            {
                AnioIngreso = value;
            }
        }

        public string RecibioEvalu1
        {
            get
            {
                return RecibioEvalu;
            }

            set
            {
                RecibioEvalu = value;
            }
        }

        public string Observaciones1
        {
            get
            {
                return Observaciones;
            }

            set
            {
                Observaciones = value;
            }
        }

        public string Entrevistador1
        {
            get
            {
                return Entrevistador;
            }

            set
            {
                Entrevistador = value;
            }
        }

        public string CuotaPago1
        {
            get
            {
                return CuotaPago;
            }

            set
            {
                CuotaPago = value;
            }
        }

       

        public int Tipo_Matricula1
        {
            get
            {
                return Tipo_Matricula;
            }

            set
            {
                Tipo_Matricula = value;
            }
        }

        public string FechaIngreso1
        {
            get
            {
                return FechaIngreso;
            }

            set
            {
                FechaIngreso = value;
            }
        }

        public void ingresoMatricula()
        {
            
            this.sql = string.Format(@"INSERT INTO matricula
                                        (Alumnos_CodAlumno, cod_jornada, AnioIngreso, RecibioEvalu,
                                        FechaIngreso, Cod_Tipo, Observaciones, Entrevistador, CuotaPago)
                                        VALUES
                                        ('{0}','{1}', '{2}','{3}', '{4}', '{5}', '{6}','{7}','0');",
                                        Alumnos_CodAlumno1, Jornada1, AnioIngreso1, RecibioEvalu1, FechaIngreso1, Tipo_Matricula1, Observaciones1, Entrevistador1);
            

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

            public int obtenerUltimo()
            {
                int ultimo=0;

                this.sql = string.Format(@"select CodAlumno from alumnos order by CodAlumno desc limit 1;");

                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                MySqlDataReader Reg = null;
                Reg = this.cmd.ExecuteReader();

                if(Reg.Read())
                {
                    ultimo = Convert.ToInt16(Reg["CodAlumno"].ToString());
                }
                this.cnx.Close();


                return (ultimo);
            }


        public int GenerarCod()
        {
            int ultimo = 0;

            this.sql = string.Format(@"select CodMatricula from matricula order by CodMatricula desc limit 1;");

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                ultimo = Convert.ToInt16(Reg["CodMatricula"].ToString()) + 1;
            }
            this.cnx.Close();


            return (ultimo);
        }


        public bool VerificarCod(int Cod)
        {
            bool Var_Ver=false;

            this.sql = string.Format(@"select * from matricula where CodMatricula='{0}';", Cod);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_Ver = true;
            }
            this.cnx.Close();


            return (Var_Ver);
        }


        public void Fun_IngresarTiposAtencion(int FV_CodAlumno)
        {
            Alumnos_CodAlumno = FV_CodAlumno;
            CuotaPago="0";

            this.sql = string.Format(@"insert into matricula values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}');", 
                CodMatricula1, Alumnos_CodAlumno1, Jornada1, AnioIngreso1, RecibioEvalu1, Observaciones1, Entrevistador1, CuotaPago1,
                FechaIngreso1, Tipo_Matricula1);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();
        

            if (Reg > 0)
            {
            }
            else
            {

            }
            this.cnx.Close();

        }
        //*********************************************+
    

        public void Fun_ActualiResp(string Name, string Profecion_Ofi,string Lugar, string TelTtr, int Cod)
        {
            this.sql = string.Format(@"update responsables set NomComRes='{0}', 
ProfecionRes='{1}',OficioRes='{2}', LugarTrabajoRes='{3}', 
TelTrabajoRes='{4}' where CodResp ='{5}'",Name, Profecion_Ofi, Profecion_Ofi, Lugar, TelTtr, Cod
                );
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();


            if (Reg > 0)
            {
            }
            else
            {

            }
            this.cnx.Close();
        }


        public void Fun_ActualiHistoria(string Medicamentos, int Cod_A)
        {
            this.sql = string.Format(@"update historialmedico set UsaMedicamentos ='{0}' where Alumnos_CodAlumno ='{1}'", Medicamentos, Cod_A);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();


            if (Reg > 0)
            {
            }
            else
            {

            }
            this.cnx.Close();
        }


        public void Fun_ActualizAtencion(string Grupa, string prevoca, string voca, string escolar, string atenidi, string distancia, string domicilio, string fisico, int cod)
        {
            this.sql = string.Format(@"update tiposatencion
set Aten_grupal='{0}', Aten_pre_vocacional='{1}', Aten_vocacional='{2}', 
Aten_Escolar='{3}', Aten_Individual='{4}', Aten_distancia='{5}', Teraia_domicilio='{6}', 
Atencion_fisica ='{7}'
where Alumnos_CodAlumno='{8}'
", Grupa,prevoca, voca, escolar, atenidi, distancia, domicilio, fisico, cod);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();


            if (Reg > 0)
            {
            }
            else
            {

            }
            this.cnx.Close();
        }



        public void Fun_ActualizarAlumno(string TelefonoFijo, string Cellular, string Direc, string Inst, string EmLu, string EmerTelefon, int Cod)
        {
            this.sql = string.Format(@"update alumnos set TelFijoAlum='{0}', CelAlumno='{1}', DireccionAlum='{2}', InstDondeEstaIncluido='{3}',EmergLugar='{4}',EmergTelefono='{5}' where CodAlumno='{6}'", TelefonoFijo, Cellular, Direc, Inst, EmLu, EmerTelefon, Cod);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();


            if (Reg > 0)
            {
            }
            else
            {

            }
            this.cnx.Close();
        }


        public void Fun_ActualizarMatricula(int Cod_Jor, int Annio, string Observ, string Entre, int Cod_M)
        {
            this.sql = string.Format(@"update matricula
                                    set Cod_jornada='{0}', AnioIngreso='{1}', Observaciones='{2}', Entrevistador='{3}'
                                    where CodMatricula='{4}'", Cod_Jor, Annio, Observ, Entre, Cod_M);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();


            if (Reg > 0)
            {
            }
            else
            {

            }
            this.cnx.Close();
        }

        public void Fun_ActualizarAl(string Name, string Direc,  string Inst,int Cod)
        {
            this.sql = string.Format(@"update alumnos 
            set NomAlumno='{0}', LugarNaciAlum ='{1}', InstProceAlumno='{2}' where CodAlumno='{3}'", 
            Name, Direc, Inst, Cod);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();


            if (Reg > 0)
            {
            }
            else
            {

            }
            this.cnx.Close();
        }

        public void Fun_OptenerCodigo(System.Windows.Forms.ComboBox Fun_ComBo)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_AlumDeResp : Conexion
    {
        public void mostarAlumnos(DataGridView dgv)
        {
            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"SELECT  A.CodAlumno as 'Codigo de Alumno',
		                                            E.DescripcionEstado as 'Estado',
		                                            A.NomAlumno as 'Nombre Completo',
		                                            A.LugarNaciAlum as 'Lugar de Nacimiento',
		                                            A.FechaNaciAlum as 'Fecha de Nacimiento',
		                                            A.EdadAlum as 'Edad en Años',
		                                            A.EdadCronologica as 'Edad Cronologica',
		                                            A.SexoAlum as 'Sexo',
		                                            A.IdAlum as 'Numero de Identidad',
		                                            A.DireccionAlum as 'Direccion',
		                                            A.TelFijoAlum as 'Telefono Fijo',
		                                            A.CelAlumno as 'Telefono Celular',
		                                            A.EscolaridadAlum as 'Escolaridad',
		                                            A.LugarOrigAlum as 'Lugar de Origen',
		                                            A.InstProceAlumno as 'Instituto de Procedencia',
		                                            A.InstDondeEstaIncluido as 'Instituto Donde Esta Incluido',
                                                    A.EmergLugar as 'Lugar en Caso de Emergencia',
                                                    A.EmergTelefono as 'Telefono de Emergencia' 
		                                            FROM estados as E
		                                            INNER JOIN  alumnos as A
		                                            ON A.Estado = E.CodEstado", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public void buscarAlumno(DataGridView dgv, string nombre)
        {
            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"SELECT  A.CodAlumno as 'Codigo de Alumno',
		                                            E.DescripcionEstado as 'Estado',
		                                            A.NomAlumno as 'Nombre Completo',
		                                            A.LugarNaciAlum as 'Lugar de Nacimiento',
		                                            A.FechaNaciAlum as 'Fecha de Nacimiento',
		                                            A.EdadAlum as 'Edad en Años',
		                                            A.EdadCronologica as 'Edad Cronologica',
		                                            A.SexoAlum as 'Sexo',
		                                            A.IdAlum as 'Numero de Identidad',
		                                            A.DireccionAlum as 'Direccion',
		                                            A.TelFijoAlum as 'Telefono Fijo',
		                                            A.CelAlumno as 'Telefono Celular',
		                                            A.EscolaridadAlum as 'Escolaridad',
		                                            A.LugarOrigAlum as 'Lugar de Origen',
		                                            A.InstProceAlumno as 'Instituto de Procedencia',
		                                            A.InstDondeEstaIncluido as 'Instituto Donde Esta Incluido',
                                                    A.EmergLugar as 'Lugar en Caso de Emergencia',
                                                    A.EmergTelefono as 'Telefono de Emergencia' 
		                                            FROM estados as E
		                                            INNER JOIN  alumnos as A
		                                            ON A.Estado = E.CodEstado
                                                    WHERE A.NomAlumno LIKE '%" + nombre + "%'", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }
    }
}

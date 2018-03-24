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
    class C_Responsables : Conexion
    {
        private int codResp;
        private string nomResp;
        private int idResp;
        private string domResp;
        private string profResp;
        private int edadResp;
        private string trabResp;
        private int estResp;
        private string lugTrab;
        private string telCasResp;
        private string telCelResp;
        private string telTrabResp;
        private string corrResp;

        public int CodResp
        {
            get
            {
                return codResp;
            }

            set
            {
                codResp = value;
            }
        }

        public string NomResp
        {
            get
            {
                return nomResp;
            }

            set
            {
                nomResp = value;
            }
        }

        public int IdResp
        {
            get
            {
                return idResp;
            }

            set
            {
                idResp = value;
            }
        }

        public string DomResp
        {
            get
            {
                return domResp;
            }

            set
            {
                domResp = value;
            }
        }

        public string ProfResp
        {
            get
            {
                return profResp;
            }

            set
            {
                profResp = value;
            }
        }

        public int EdadResp
        {
            get
            {
                return edadResp;
            }

            set
            {
                edadResp = value;
            }
        }

        public string TrabResp
        {
            get
            {
                return trabResp;
            }

            set
            {
                trabResp = value;
            }
        }

        public int EstResp
        {
            get
            {
                return estResp;
            }

            set
            {
                estResp = value;
            }
        }

        public string LugTrab
        {
            get
            {
                return lugTrab;
            }

            set
            {
                lugTrab = value;
            }
        }

        public string TelCasResp
        {
            get
            {
                return telCasResp;
            }

            set
            {
                telCasResp = value;
            }
        }

        public string TelCelResp
        {
            get
            {
                return telCelResp;
            }

            set
            {
                telCelResp = value;
            }
        }

        public string TelTrabResp
        {
            get
            {
                return telTrabResp;
            }

            set
            {
                telTrabResp = value;
            }
        }

        public string CorrResp
        {
            get
            {
                return corrResp;
            }

            set
            {
                corrResp = value;
            }
        }

        public void Fill_DGV(DataGridView dgv)
        {

            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"SELECT CodResp as 'Codigo de Responsable', 
                                                    NomComRes as 'Nombre Completo', 
                                                    NumIdRes as 'Numero de Identidad', 
                                                    DomicilioRes as 'Domicilio',
                                                    ProfecionRes as 'Profesion',
                                                    LugarTrabajoRes as 'Lugar de Trabajo',
                                                    TelCasaRes as 'Telefono de Casa',
                                                    TelCelRes as 'Telefono Celular',
                                                    TelTrabajoRes as 'Telefono de Trabajo',
                                                    CorreoRes as 'Correo' 
                                                    FROM responsables", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {
                
            }
            cnx.Close();
        }

        public void updateResp()
        {
            this.sql = string.Format(@"UPDATE responsables SET NomComRes = '{0}',
                                        NumIdRes = '{1}',
                                        DomicilioRes = '{2}', 
                                        ProfecionRes = '{3}',
                                        LugarTrabajoRes = '{4}', 
                                        TelCasaRes = '{5}',
                                        TelCelRes = '{6}',
                                        TelTrabajoRes = '{7}',
                                        CorreoRes = '{8}'
                                        WHERE CodResp = '{9}'", 
                                        nomResp, idResp, domResp, profResp, lugTrab, telCasResp, telCelResp, telTrabResp, corrResp, codResp);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

        public void msjUpdateCorrecto()
        {
            MessageBox.Show("Los datos se han actualizado correctamente","Datos Actualizados");
        }

        public void limpiarTxtResp()
        {
            Formas.Responsables.FormMantenimientoResponsable fResp = new Formas.Responsables.FormMantenimientoResponsable();
            fResp.txtCodResp.Text = string.Empty;
            fResp.txtNomResp.Text = string.Empty;
            fResp.txtDomResp.Text = string.Empty;
            fResp.txtEdadResp.Text = string.Empty;
            fResp.txtIdResp.Text = string.Empty;
            fResp.txtTelCasResp.Text = string.Empty;
            fResp.txtTelCelResp.Text = string.Empty;
            fResp.txtTelTrabResp.Text = string.Empty;
            fResp.txtLugResp.Text = string.Empty;

        }
    }
}

/*OFICIO Y PREFESION ES LO MISMO
# de ID es STRING
No se puede llenar el DGV de Alumnos sin hacer la Matricula primero
CAMPO DE EDAD
*/

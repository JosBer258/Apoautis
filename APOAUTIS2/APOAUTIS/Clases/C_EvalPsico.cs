using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

using System.IO;////////
using System.Reflection;///////
using iTextSharp.text.pdf;///////
using iTextSharp.text;///////
using System.Web;///////

namespace APOAUTIS.Clases
{
    class C_EvalPsico : Conexion
    {
        private int codEval;
        private string fechEval;
        private string fechNac;
        private string nomEval;
        private float edad;
        private string impDiag;
        private string sexo;
        private string respEval;
        private string telEval;
        private string obsEval;

        public int CodEval
        {
            get
            {
                return codEval;
            }

            set
            {
                codEval = value;
            }
        }

        public string FechEval
        {
            get
            {
                return fechEval;
            }

            set
            {
                fechEval = value;
            }
        }

        public string FechNac
        {
            get
            {
                return fechNac;
            }

            set
            {
                fechNac = value;
            }
        }

        public string NomEval
        {
            get
            {
                return nomEval;
            }

            set
            {
                nomEval = value;
            }
        }

        public float Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public string ImpDiag
        {
            get
            {
                return impDiag;
            }

            set
            {
                impDiag = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string RespEval
        {
            get
            {
                return respEval;
            }

            set
            {
                respEval = value;
            }
        }

        public string TelEval
        {
            get
            {
                return telEval;
            }

            set
            {
                telEval = value;
            }
        }

        public string ObsEval
        {
            get
            {
                return obsEval;
            }

            set
            {
                obsEval = value;
            }
        }

        public void ingresoEval()
        {
            this.sql = string.Format(@"INSERT INTO evaluacion
                                        (CodEvaluacion, FechaEvaluacion, ImpresionDiagnos, NombreEvaluado,
                                        FechaNaci, Edad, Sexo, Responsable, Telefono, Observaciones)
                                        VALUES
                                        ('{0}','{1}', '{2}','{3}', '{4}',
                                        '{5}', '{6}','{7}', '{8}','{9}');",
                                        0, fechEval, impDiag, nomEval, fechNac,  edad, 
                                        sexo, respEval, telEval, obsEval);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void Fill_DGV_Eval(DataGridView dgv)
        {

            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                                    NombreEvaluado as 'Nombre del Evaluado',
                                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                                    FechaNaci as 'Fecha de Nacimiento',
                                                    Edad,
                                                    Sexo,
                                                    Responsable,
                                                    Telefono,
                                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                                    Observaciones
                                                    FROM evaluacion;", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void busquedaNombre(DataGridView dgv, string nombre)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE NombreEvaluado LIKE '%" + nombre + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public void busquedaImpDiag(DataGridView dgv, string impresion)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE ImpresionDiagnos LIKE '%" + impresion + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public void busquedaObs(DataGridView dgv, string observacion)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE Observaciones LIKE '%" + observacion + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public void busquedaIDOB(DataGridView dgv, string impresion, string observacion)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE ImpresionDiagnos LIKE '%" + impresion + "%' AND Observaciones LIKE '%" + observacion + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }


        public void busquedaFecha(DataGridView dgv, string fecha)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE FechaEvaluacion = '" + fecha + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public string mostrarCodigo()
        {
            string cdg = "0";
            cnx.Open();

            string query = "SELECT (MAX( CodEvaluacion ) + 1) as CodEvaluacion FROM evaluacion";
            MySqlCommand comando = new MySqlCommand(query, cnx);
                
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read() == true)
            {
                cdg = reader[0].ToString();

            }

            reader.Close();
            cnx.Close();
            return cdg;
            }

        public void validarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
               e.Handled = true;
            }
        }

        public void validarDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        public void validarNumerosYLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ExportDataTableToPdf(DataGridView dgvTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 12, 1, iTextSharp.text.BaseColor.BLACK);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 10, 2, iTextSharp.text.BaseColor.BLACK);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            //prgAuthor.Add(new Chunk("Author : Dotnet Mob", fntAuthor));
            prgAuthor.Add(new Chunk("\nFecha : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line separation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dgvTable.Columns.Count);

            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 9, 0, iTextSharp.text.BaseColor.WHITE);
            for (int i = 0; i < dgvTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
                cell.AddElement(new Chunk(dgvTable.Columns[i].HeaderText, fntColumnHeader));
                table.AddCell(cell);
            }

            //Table Data
            BaseFont fntTable = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumn = new iTextSharp.text.Font(fntTable, 9, 0, iTextSharp.text.BaseColor.BLACK);
            for (int i = 0; i < dgvTable.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTable.Columns.Count; j++)
                {
                    table.AddCell(Convert.ToString(dgvTable.Rows[i].Cells[j].Value));
                    
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }//Fin ExportDataTableToPdf


    }
}

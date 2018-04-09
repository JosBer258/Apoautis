using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace APOAUTIS.Formas.Responsables
{
    public partial class FormAlumDeResp : Form
    {
        public FormAlumDeResp()
        {
            InitializeComponent();
        }
        
        private void DataGrid_Show_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataGrid_Show.Rows[e.RowIndex];
            FormMantenimientoResponsable.CodigA = row.Cells["Codigo de Alumno"].Value.ToString();
            //this.Hide();
            FormMantenimientoResponsable Resp = new FormMantenimientoResponsable();
            Resp.ShowDialog();
        }

        private void FormAlumDeResp_Load(object sender, EventArgs e)
        {
            APOAUTIS.Clases.C_AlumDeResp adr = new APOAUTIS.Clases.C_AlumDeResp();
            adr.mostarAlumnos(DataGrid_Show);
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

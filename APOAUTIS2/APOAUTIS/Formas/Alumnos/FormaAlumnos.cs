using APOAUTIS.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Alumnos
{
    public partial class FormaAlumnos : Form
    {
        C_Alumnos alumno = new C_Alumnos();

        public FormaAlumnos()
        {
            InitializeComponent();
        }

        private void FormaAlumnos_Load(object sender, EventArgs e)
        {
            alumno.Fun_Show(Pest1_Dgv_BsqAlm);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

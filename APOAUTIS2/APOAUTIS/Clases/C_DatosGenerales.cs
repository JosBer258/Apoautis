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
    public class C_DatosGenerales
    {

        

        public double idAlumno { get; set; }
        public string nombreAlumno { get; set; }
        public int edadAlumno { get; set; }
        public DateTime fecha_NacAlumno { get; set; }
        public string lugarNacAlumno { get; set; }
        public string sexoAlumno { get; set; }
     //   public string lugarEntrevista { get; set; }
    //    public string fechaEntrevista { get; set; }
   //     public string personaEntrevis { get; set; }


        public C_DatosGenerales(double idAlumno, string nombreAlumno, int edadAlumno, DateTime fecha_NacAlumno, string lugarNacAlumno, string sexoAlumno /*, string lugarEntrevista, string fechaEntrevista, string personaEntrevis*/)
        {
            this.idAlumno = idAlumno;
            this.nombreAlumno = nombreAlumno;
            this.edadAlumno = edadAlumno;
            this.fecha_NacAlumno = fecha_NacAlumno;
            this.lugarNacAlumno = lugarNacAlumno;
            this.sexoAlumno = sexoAlumno;
           // this.lugarEntrevista = lugarEntrevista;
            //this.fechaEntrevista = fechaEntrevista;
            //this.personaEntrevis = personaEntrevis;
        }

        public C_DatosGenerales()
        {
        }


    }
}


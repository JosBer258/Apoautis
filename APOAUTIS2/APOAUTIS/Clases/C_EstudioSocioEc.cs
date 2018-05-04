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
   public class C_EstudioSocioEc
    {
        private int codEstudioSocio;
        private int codAlumno;
        private string lugarEntrevista;
        private string fechaEntrevista;
        private string personaEntrevis;
        private string EntrevistadoPor;



        public C_EstudioSocioEc()
        {
        }

       

        public string LugarEntrevista
        {
            get
            {
                return lugarEntrevista;
            }

            set
            {
                lugarEntrevista = value;
            }
        }

        public string FechaEntrevista
        {
            get
            {
                return fechaEntrevista;
            }

            set
            {
                fechaEntrevista = value;
            }
        }

        public string PersonaEntrevis
        {
            get
            {
                return personaEntrevis;
            }

            set
            {
                personaEntrevis = value;
            }
        }

        public string EntrevistadoPor1
        {
            get
            {
                return EntrevistadoPor;
            }

            set
            {
                EntrevistadoPor = value;
            }
        }

        public int CodAlumno
        {
            get
            {
                return codAlumno;
            }

            set
            {
                codAlumno = value;
            }
        }

        public int CodEstudioSocio
        {
            get
            {
                return codEstudioSocio;
            }

            set
            {
                codEstudioSocio = value;
            }
        }


        public C_EstudioSocioEc(string lugarEntrevista, string fechaEntrevista, string personaEntrevis, string entrevistadoPor1, int codAlumno, int codEstudioSocio)
        {
            LugarEntrevista = lugarEntrevista;
            FechaEntrevista = fechaEntrevista;
            PersonaEntrevis = personaEntrevis;
            EntrevistadoPor1 = entrevistadoPor1;
            CodAlumno = codAlumno;
            CodEstudioSocio = codEstudioSocio;
        }

        


    }
}

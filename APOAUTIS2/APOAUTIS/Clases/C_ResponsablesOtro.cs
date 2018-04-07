using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    public class C_ResponsablesOtro
    {
        private int codAlumno;
        private int codRespOtro;
        private string nomRespOtro;
        private string parentesco;
        private int edad;
        private string telefono;
        private string profesion;
        private string oficio;
        private int tipoResp;

        public C_ResponsablesOtro(int codAlumno, int codRespOtro, string nomRespOtro, string parentesco, int edad, string telefono, string profesion, string oficio, int tipoResp)
        {
            CodAlumno = codAlumno;
            CodRespOtro = codRespOtro;
            NomRespOtro = nomRespOtro;
            Parentesco = parentesco;
            Edad = edad;
            Telefono = telefono;
            Profesion = profesion;
            Oficio = oficio;
            TipoResp = tipoResp;
        }

        public C_ResponsablesOtro()
        {
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

        public int CodRespOtro
        {
            get
            {
                return codRespOtro;
            }

            set
            {
                codRespOtro = value;
            }
        }

        public string NomRespOtro
        {
            get
            {
                return nomRespOtro;
            }

            set
            {
                nomRespOtro = value;
            }
        }

        public string Parentesco
        {
            get
            {
                return parentesco;
            }

            set
            {
                parentesco = value;
            }
        }

        public int Edad
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

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Profesion
        {
            get
            {
                return profesion;
            }

            set
            {
                profesion = value;
            }
        }

        public string Oficio
        {
            get
            {
                return oficio;
            }

            set
            {
                oficio = value;
            }
        }

        public int TipoResp
        {
            get
            {
                return tipoResp;
            }

            set
            {
                tipoResp = value;
            }
        }
    }
}

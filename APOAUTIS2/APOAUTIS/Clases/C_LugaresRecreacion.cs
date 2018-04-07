using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    class C_LugaresRecreacion
    {

        private int codAlumno;
        private string parques;
        private string centrosComerciales;
        private string museos;
        private string cine;
        private string balnearios;
        private string playa;
        private string otros;

        public C_LugaresRecreacion(int codAlumno, string parques, string centrosComerciales, string museos, string cine, string balnearios, string playa, string otros)
        {
            CodAlumno = codAlumno;
            Parques = parques;
            CentrosComerciales = centrosComerciales;
            Museos = museos;
            Cine = cine;
            Balnearios = balnearios;
            Playa = playa;
            Otros = otros;
        }

        public C_LugaresRecreacion()
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

        public string Parques
        {
            get
            {
                return parques;
            }

            set
            {
                parques = value;
            }
        }

        public string CentrosComerciales
        {
            get
            {
                return centrosComerciales;
            }

            set
            {
                centrosComerciales = value;
            }
        }

        public string Museos
        {
            get
            {
                return museos;
            }

            set
            {
                museos = value;
            }
        }

        public string Cine
        {
            get
            {
                return cine;
            }

            set
            {
                cine = value;
            }
        }

        public string Balnearios
        {
            get
            {
                return balnearios;
            }

            set
            {
                balnearios = value;
            }
        }

        public string Playa
        {
            get
            {
                return playa;
            }

            set
            {
                playa = value;
            }
        }

        public string Otros
        {
            get
            {
                return otros;
            }

            set
            {
                otros = value;
            }
        }
    }
}

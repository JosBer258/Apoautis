using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    class C_InformacionVivienda
    {
        private int codAlumno;
        private string tenencia;
        private string materialConst;
        private string materialPiso;
        private string servicioBasicos;
        private string disponeDe;

        public C_InformacionVivienda(int codAlumno, string tenencia, string materialConst, string materialPiso, string servicioBasicos, string disponeDe)
        {
            CodAlumno = codAlumno;
            Tenencia = tenencia;
            MaterialConst = materialConst;
            MaterialPiso = materialPiso;
            ServicioBasicos = servicioBasicos;
            DisponeDe = disponeDe;
        }

        public C_InformacionVivienda()
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

        public string Tenencia
        {
            get
            {
                return tenencia;
            }

            set
            {
                tenencia = value;
            }
        }

        public string MaterialConst
        {
            get
            {
                return materialConst;
            }

            set
            {
                materialConst = value;
            }
        }

        public string MaterialPiso
        {
            get
            {
                return materialPiso;
            }

            set
            {
                materialPiso = value;
            }
        }

        public string ServicioBasicos
        {
            get
            {
                return servicioBasicos;
            }

            set
            {
                servicioBasicos = value;
            }
        }

        public string DisponeDe
        {
            get
            {
                return disponeDe;
            }

            set
            {
                disponeDe = value;
            }
        }
    }
}

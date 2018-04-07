using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    public class C_responsablesMadre
    {
        
        private int codAlumno;
        private int codResp;
        private string nombResp;
        private int idResp;
        private string domicilioResp;
        private string ProfesionResp;
        private string oficioREsp;
        private string lugarTrabRes;
        private string telefonoCasaResp;
        private string celResp;
        private string trabajoResp;
        private string correoResp;
        private int tipoRes;

        public C_responsablesMadre(int codAlumno,int codResp, string nombResp, int idResp, string domicilioResp, string profesionResp1, string oficioREsp, string lugarTrabRes, string telefonoCasaResp, string celResp, string trabajoResp, string correoResp, int tipoRes)
        {
            CodAlumno = codAlumno;
            CodResp = codResp;
            NombResp = nombResp;
            IdResp = idResp;
            DomicilioResp = domicilioResp;
            ProfesionResp1 = profesionResp1;
            OficioREsp = oficioREsp;
            LugarTrabRes = lugarTrabRes;
            TelefonoCasaResp = telefonoCasaResp;
            CelResp = celResp;
            TrabajoResp = trabajoResp;
            CorreoResp = correoResp;
            TipoRes = tipoRes;
        }

        public C_responsablesMadre()
        {
        }

      

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

        public string NombResp
        {
            get
            {
                return nombResp;
            }

            set
            {
                nombResp = value;
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

        public string DomicilioResp
        {
            get
            {
                return domicilioResp;
            }

            set
            {
                domicilioResp = value;
            }
        }

        public string ProfesionResp1
        {
            get
            {
                return ProfesionResp;
            }

            set
            {
                ProfesionResp = value;
            }
        }

        public string OficioREsp
        {
            get
            {
                return oficioREsp;
            }

            set
            {
                oficioREsp = value;
            }
        }

        public string LugarTrabRes
        {
            get
            {
                return lugarTrabRes;
            }

            set
            {
                lugarTrabRes = value;
            }
        }

        public string TelefonoCasaResp
        {
            get
            {
                return telefonoCasaResp;
            }

            set
            {
                telefonoCasaResp = value;
            }
        }

        public string CelResp
        {
            get
            {
                return celResp;
            }

            set
            {
                celResp = value;
            }
        }

        public string TrabajoResp
        {
            get
            {
                return trabajoResp;
            }

            set
            {
                trabajoResp = value;
            }
        }

        public string CorreoResp
        {
            get
            {
                return correoResp;
            }

            set
            {
                correoResp = value;
            }
        }

        public int TipoRes
        {
            get
            {
                return tipoRes;
            }

            set
            {
                tipoRes = value;
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
    }
}

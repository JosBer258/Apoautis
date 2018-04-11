using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
   public class C_HistorialMedico
    {
        private int codigoAlum;
        private string LugaresRecibeAtencion;
        private string EnfermedadesPadeceFamilia;
        private double CuantoGastaMedi;

        public C_HistorialMedico(int codigoAlum, string lugaresRecibeAtencion1, string enfermedadesPadeceFamilia1, double cuantoGastaMedi1)
        {
            CodigoAlum = codigoAlum;
            LugaresRecibeAtencion1 = lugaresRecibeAtencion1;
            EnfermedadesPadeceFamilia1 = enfermedadesPadeceFamilia1;
            CuantoGastaMedi1 = cuantoGastaMedi1;
        }

        public C_HistorialMedico()
        {
        }

        public int CodigoAlum
        {
            get
            {
                return codigoAlum;
            }

            set
            {
                codigoAlum = value;
            }
        }

        public string LugaresRecibeAtencion1
        {
            get
            {
                return LugaresRecibeAtencion;
            }

            set
            {
                LugaresRecibeAtencion = value;
            }
        }

        public string EnfermedadesPadeceFamilia1
        {
            get
            {
                return EnfermedadesPadeceFamilia;
            }

            set
            {
                EnfermedadesPadeceFamilia = value;
            }
        }

        public double CuantoGastaMedi1
        {
            get
            {
                return CuantoGastaMedi;
            }

            set
            {
                CuantoGastaMedi = value;
            }
        }
    }
}

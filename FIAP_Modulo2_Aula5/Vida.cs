using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Modulo2_Aula5
{
    class Vida : Seguro, ITributavel
    {
        public string TipoPlano;

        public double CalcularImposto()
        {
            return 42;
        }
    }
}

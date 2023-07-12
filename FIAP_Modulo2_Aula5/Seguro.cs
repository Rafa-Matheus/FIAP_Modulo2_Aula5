using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Modulo2_Aula5
{
    public abstract class Seguro
    {
        public DateTime DataContratacao { get; set; }
        public double Valor { get; set; }

        public DateTime GetValidade()
        {
            if (DataContratacao != null) return DataContratacao.AddYears(1);
            return DateTime.Today;
        }

    }
}

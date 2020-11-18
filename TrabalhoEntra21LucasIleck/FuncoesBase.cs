using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    class FuncoesBase
    {
        public double RetonarAcoes(double AcoesDaLoja)
        {
            double qtdAcoes = AcoesDaLoja * (4.95 / 100);
            return qtdAcoes;
        }
    }
}

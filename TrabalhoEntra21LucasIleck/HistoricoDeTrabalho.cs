using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TrabalhoEntra21LucasIleck
{
    class HistoricoDeTrabalho
    {
        public int HorasTrabalhadaNoDia { get; private set; }
        public int HoraEntrada { get; private set; }
        public int HoraSaida { get; private set; }
        public double SalarioGanhoDia { get; private set; }

        public HistoricoDeTrabalho(int horasTrabalhadaNoDia, int horaEntrada, int horaSaida, double salarioGanhoDia)
        {
            HorasTrabalhadaNoDia = horasTrabalhadaNoDia;
            HoraEntrada = horaEntrada;
            HoraSaida = horaSaida;
            SalarioGanhoDia = salarioGanhoDia;
        }
    }
}

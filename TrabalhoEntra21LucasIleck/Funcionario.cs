using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TrabalhoEntra21LucasIleck
{
    class Funcionario : ClienteNormal
    {
        public Funcionario(string cargo, double salaryHours, string nome, string cpf, int idade, double saldo) : base(nome, cpf, idade, saldo)
        {
            Cargo = cargo;
            SalarioHours = salaryHours;
            
        }      
        public string Cargo { get; private set; }
        public double SalarioHours { get; private set; }
        public List<HistoricoDeTrabalho> HistoricoDeTrabalhos { get; set; } = new List<HistoricoDeTrabalho>();
        public override void DefineDados(string nome, string cpf, int idade, double saldo)
        {
            base.DefineDados(nome, cpf, idade, saldo);
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
        }
        public void MostrarHistorico()
        {
            foreach (var item in HistoricoDeTrabalhos)
            {
                Console.WriteLine($"Hora Trabalhada: {item.HorasTrabalhadaNoDia} | Ganho do Dia: {item.SalarioGanhoDia.ToString("C", CultureInfo.CurrentCulture)}");
            }
        }
        public void MostraCargoSalario()
        {

            Console.WriteLine($"Cargo do Funcionario: {Cargo} .Salario: {SalarioHours.ToString("C", CultureInfo.CurrentCulture)}");        
        }
        public void DefineCargoSalario(string cargo, double salario)
        {
            Cargo = cargo;
            SalarioHours = salario;
        }
        public void BaterPonto(int hrEntrada, int hrSaida)
        {
            double valorGanho = 0;
            int horasTrabalhada;
            if (hrEntrada > hrSaida)
            {
                horasTrabalhada = 24 - hrEntrada;
                horasTrabalhada = horasTrabalhada + hrSaida;
                valorGanho = horasTrabalhada * SalarioHours;
                SetSaldo(GetSaldo() + valorGanho);
            }
            else
            {
                horasTrabalhada = hrSaida - hrEntrada;
                valorGanho = horasTrabalhada * SalarioHours;
                SetSaldo(GetSaldo() + valorGanho);
            }
            HistoricoDeTrabalho historico = new HistoricoDeTrabalho(horasTrabalhada, valorGanho);
            HistoricoDeTrabalhos.Add(historico);

        }
        public void BaterPonto30Vezes()
        {
            Random ran = new Random();
            for (int i = 0; i < 30; i++)
            {

                int hrEntrada = ran.Next(7, 21);
                int hrSaida = ran.Next(7, 21);

                BaterPonto(hrEntrada, hrSaida);
            }
        }
    }
}

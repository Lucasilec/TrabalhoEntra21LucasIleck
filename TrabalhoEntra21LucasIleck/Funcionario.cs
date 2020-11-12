using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public override void DefineDados(string nome, string cpf, int idade, double saldo)
        {
            base.DefineDados(nome, cpf, idade, saldo);
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
        }
        public void MostraCargoSalario()
        {
            Console.WriteLine($"Cargo do Funcionario: {Cargo}");        
        }
        public void DefineCargoSalario(string cargo, double salario)
        {
            Cargo = cargo;
            SalarioHours = salario;
        }
        public void BaterPonto(int hrEntrada, int hrSaida)
        {
            int horarioDeTrabalho = (hrEntrada - hrSaida);
            if (hrEntrada > hrSaida)
            {
                int horario1 = hrEntrada - 24;
                horario1 = horario1 + hrSaida;
                SetSaldo(horario1* SalarioHours);
            }
            else
            {
                int horario1 = hrSaida - hrEntrada;
                SetSaldo(horario1 * SalarioHours);
            }
        }
    }
}

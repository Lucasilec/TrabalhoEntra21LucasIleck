using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    class ClienteNormal
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public int Idade { get; private set; }

      

        private double Saldo;
        public ClienteNormal()
        {

        }
        public ClienteNormal(string nome, string cpf, int idade, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            SetSaldo(GetSaldo() + saldo);
        }   
        public double GetSaldo()
        {
            return Saldo;
        }

        public void SetSaldo(double value)
        {
            Saldo = value;
        }

        public virtual void MostrarDados()
        { 
            Console.WriteLine($"Nome: {Nome} .CPF: {CPF} .Idade: {Idade} .Saldo: {GetSaldo()}");
        }
        public virtual void DefineDados(string nome, string cpf, int idade, double saldo)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            SetSaldo(GetSaldo() + saldo);
        }
    }
}

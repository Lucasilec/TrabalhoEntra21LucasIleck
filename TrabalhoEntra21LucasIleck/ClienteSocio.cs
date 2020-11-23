using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    class ClienteSocio : ClienteNormal
    {
        public ClienteSocio()
        {

        }
        public ClienteSocio(double qtdAcoes, string nome, string cpf, int idade, double saldo) : base(nome, cpf, idade, saldo)
        {
            QtdAcoes = qtdAcoes;
        }
        private double QtdAcoes;
        public double GetQtdAcoes()
        {
            return QtdAcoes;
        }
        public void SetQtdAcoes(double value)
        {
            QtdAcoes = value;
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"Quantidade de Ações: {QtdAcoes}");
        }
        public override void DefineDados(string nome, string cpf, int idade, double saldo)
        {
            base.DefineDados(nome, cpf, idade, saldo);      
        }
        public void MostraAcoes()
        {
            Console.WriteLine($"Quantidade de ações: {QtdAcoes}");
        }
        public bool DefineAcoes(double acoes)
        {
            bool limiteAcoes;
            if (acoes > (495 / 100))
            {
                limiteAcoes = false;
            }
            else
            {
                SetQtdAcoes(acoes);
                limiteAcoes = true;
            }
            return limiteAcoes;
            
        }
    }
}

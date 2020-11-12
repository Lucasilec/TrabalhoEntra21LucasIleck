using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    class Fornecedor : ClienteNormal
    {
        public Fornecedor(string cnpj, int tipoDeProduto, int quantidadeFornecidaAoMes, string nome, string cpf, int idade, double saldo) : base(nome, cpf, idade, saldo)
        {
            Cnpj = cnpj;
            TipoDeProduto = tipoDeProduto;
            QuantidadeFornecidaAoMes = quantidadeFornecidaAoMes;
        }
        public string Cnpj { get; set; }
        public int TipoDeProduto { get; set; }
        public int QuantidadeFornecidaAoMes { get; set; }

        public override void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} .Cnpj: {Cnpj} .Tipo de produto: {TipoDeProduto} .Quantidade fornecida ao Mês: {QuantidadeFornecidaAoMes}");
        }
        public void MostrarQuantidadeFornecida()
        {
            Console.WriteLine("Quantidade fornecida: {0}", QuantidadeFornecidaAoMes);
        }
        public void DefineQuantidadeFornecida(int quantidade)
        {
            QuantidadeFornecidaAoMes = quantidade;
            
        }
       
        
    }
}

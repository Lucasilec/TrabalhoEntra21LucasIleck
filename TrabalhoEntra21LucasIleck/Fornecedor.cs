using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    class Fornecedor : ClienteNormal
    {
        public string NomeFornecedor { get; set; }
        public string Cnpj { get; set; }
        public int TipoProduto { get; set; }
        public int QuantidadeFornecidaMes { get; set; }

        public Fornecedor(string nomeFornecedor, string cnpj, int tipoProduto, int quantidadeFornecidaMes)
        {
            NomeFornecedor = nomeFornecedor;
            Cnpj = cnpj;
            TipoProduto = tipoProduto;
            QuantidadeFornecidaMes = quantidadeFornecidaMes;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("Nome do Fornecedor: {0}", NomeFornecedor);
            Console.WriteLine("Cnpj: {0}", Cnpj);
            Console.WriteLine("Tipo de Produto: {0}", TipoProduto);
           
        }
        public void MostraQuantidadeFornecida()
        {
            Console.WriteLine("Quantidade Fornecida ao Mês: {0}", QuantidadeFornecidaMes);
        }
        public void DefineQuantidadeFornecida(int quantidadeFornecida)
        {
            QuantidadeFornecidaMes = quantidadeFornecida;
        }
    }
}

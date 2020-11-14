using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClienteNormal> clientesList = new List<ClienteNormal>();
            for (int i = 0; i < 5; i++)
            {
                ClienteNormal clienteNormal = new ClienteNormal(Gerador.NomePessoa(), Gerador.Cpf(), Gerador.Idade(), Gerador.Saldo());
                clientesList.Add(clienteNormal); 
               
                
            }
            foreach (var item in clientesList)
            {
                Console.WriteLine("===================//===================");
                item.MostrarDados();
            }
        }
    }
}

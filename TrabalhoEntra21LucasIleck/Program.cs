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
            //iniciar Projeto
            for (int i = 0; i < 5; i++)
            {
                FuncoesBase.IniciarAddClienteNormal();
            }
            for (int i = 0; i < 2; i++)
            {
                FuncoesBase.IniciarAddClienteSocio();
            }
            for (int i = 0; i < 5; i++)
            {
                FuncoesBase.IniciarAddFuncionario();
            }
            //Menu Principal
            do
            {
                Console.Clear();
                Console.WriteLine("BEM VINDO A O MENU");
                Console.WriteLine();
                Console.WriteLine("ESCOLHA AS OPÇÕES: ");
                Console.WriteLine("1 - ADICIONAR");
                Console.WriteLine("2 - REMOVER");
                Console.WriteLine("3 - COMPRAR");
                Console.WriteLine("4 - BATER O CARTÃO");
                Console.WriteLine("5 - ALTERAR");
                Console.WriteLine("6 - CALCULAR LUCRO");
                Console.WriteLine("7 - SAIR");
                int escolhaOpcao = int.Parse(Console.In.ReadLine());
                FuncoesMenu.Escolha(escolhaOpcao);
            } while (true);
        }
    }
}

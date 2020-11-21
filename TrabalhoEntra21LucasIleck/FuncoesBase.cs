using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    class FuncoesBase
    {
        public double GerarAcoes()
        {
            Random ran = new Random();
            double acoes = ran.Next(1, 496);
            acoes = acoes / 100;
            return acoes;
        }
        public string GeradorCargo()
        {
            Random ran = new Random();
            int index = ran.Next(1, 6);
            string cargoFuncionario = " ";
            switch (index)
            {
                case 1:
                    cargoFuncionario = "Vendedor";
                    break;
                case 2:
                    cargoFuncionario = "operador de Caixa";
                    break;
                case 3:
                    cargoFuncionario = "Abastecedor";
                    break;
                case 4:
                    cargoFuncionario = "Gerente";
                    break;
                case 5:
                    cargoFuncionario = "Suporte tecnico";
                    break;                   
            }
            return cargoFuncionario;
        }
        public double GerarSalario(string cargo)
        {
            double salary = 0;
            Random ran = new Random();
            if (cargo == "Vendedor")
            {
                salary = ran.Next(750, 900);
                salary = salary / 100;      
            }
            else if (cargo == "Operador de Caixa")
            {
                salary = ran.Next(800, 900);
                salary = salary / 100;
            }
            else if (cargo == "Abastecedor")
            {
                salary = ran.Next(750, 950);
                salary = salary / 100;
            }
            else if (cargo == "Gerente")
            {
                salary = ran.Next(1500, 2000);
                salary = salary / 100;
            }
            else if (cargo == "Suporte tecnico")
            {
                salary = ran.Next(900, 1100);
                salary = salary / 100;
            }
            return salary;
        }
        public static string Cnpj()
        {
            Random ran = new Random();
            string cnpj = "";
            for (int i = 1; i < 19; i++)
            {
                if (i == 3 || i == 7)
                {
                    cnpj += ".";
                }
                else if (i == 11)
                {
                    cnpj += "/";
                }
                else if (i == 16)
                {
                    cnpj += "-";
                }
                else
                {
                    cnpj += ran.Next(0, 10);
                }
            }
            return cnpj;
        }
        public void IniciarAddClienteNormal()
        {
            ClienteNormal clienteNormal = new ClienteNormal(Gerador.NomePessoa(), Gerador.Cpf(), Gerador.Idade(), Gerador.Saldo());
            FuncoesMenu.ClienteNormalsList.Add(clienteNormal);
        }
        public void IniciarAddClienteSocio()
        {
            ClienteSocio clienteSocio = new ClienteSocio(GerarAcoes(), Gerador.NomePessoa(), Gerador.Cpf(), Gerador.Idade(), Gerador.Saldo());
            FuncoesMenu.ClienteSociosList.Add(clienteSocio);
        }
        public void IniciarAddFuncionario()
        {
            string cargo = GeradorCargo();

            Funcionario funcionario = new Funcionario(cargo, GerarSalario(cargo), Gerador.NomePessoa(), Gerador.Cpf(), Gerador.Idade(), Gerador.Saldo());
            FuncoesMenu.FuncionariosList.Add(funcionario);
        }
        public void IniciarAddFornecedor()
        {
            //Fornecedor fornecedor = new Fornecedor(Gerador.NomeEmpresa(), Cnpj(), )
        }
    }
}

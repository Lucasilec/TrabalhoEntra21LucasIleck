﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    static class FuncoesBase
    {
        //Funções variadas que quebram um galho
        static public double GerarAcoes()
        {
            Random ran = new Random();
            double acoes = ran.Next(1, 496);
            acoes = acoes / 100;
            return acoes;
        }
        public static string GeradorCargo()
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
        public static double GerarSalario(string cargo)
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
        public static string GerarCnpj()
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
        public static void IniciarAddClienteNormal()
        {
            string cpfTemp = "";
            bool validar = true;
            do
            {
                cpfTemp = Gerador.Cpf();
                validar = VerificarCPF(cpfTemp, FuncoesMenu.ClienteNormalsList, FuncoesMenu.ClienteSociosList, FuncoesMenu.FuncionariosList);            
            } while (validar == false);

            ClienteNormal clienteNormal = new ClienteNormal(Gerador.NomePessoa(), cpfTemp, Gerador.Idade(), Gerador.Saldo());
            FuncoesMenu.ClienteNormalsList.Add(clienteNormal);

        }
        public static void IniciarAddClienteSocio()
        {
            string cpfTemp = "";
            bool validar = true;
            do
            {
                cpfTemp = Gerador.Cpf();
                validar = VerificarCPF(cpfTemp, FuncoesMenu.ClienteNormalsList, FuncoesMenu.ClienteSociosList, FuncoesMenu.FuncionariosList);
            } while (validar == false);
            ClienteSocio clienteSocio = new ClienteSocio(GerarAcoes(), Gerador.NomePessoa(), cpfTemp, Gerador.Idade(), Gerador.Saldo());
            FuncoesMenu.ClienteSociosList.Add(clienteSocio);
        }
        public static void IniciarAddFuncionario()
        {
            string cpfTemp = "";
            bool validar = true;
            do
            {
                cpfTemp = Gerador.Cpf();
                validar = VerificarCPF(cpfTemp, FuncoesMenu.ClienteNormalsList, FuncoesMenu.ClienteSociosList, FuncoesMenu.FuncionariosList);
            } while (validar == false);
            string cargo = GeradorCargo();

            Funcionario funcionario = new Funcionario(cargo, GerarSalario(cargo), Gerador.NomePessoa(), cpfTemp, Gerador.Idade(), Gerador.Saldo());
            FuncoesMenu.FuncionariosList.Add(funcionario);
        }
        public static void IniciarAddFornecedor()
        {
            string cnpjTemp = "";
            bool validar = true;
            do
            {
                cnpjTemp = GerarCnpj();
                validar = VerificarCNPJ(cnpjTemp, FuncoesMenu.FornecedorsList);
            } while (validar == false);
            Fornecedor fornecedor = new Fornecedor(Gerador.NomeEmpresa(), cnpjTemp , TipoProduto(), QuantidadeProdutoFornecido());
        }
        public static int TipoProduto()
        {
            Random ran = new Random();
            int tipoProduto = ran.Next(1, 7);
            return tipoProduto;
        }
        public static int QuantidadeProdutoFornecido()
        {
            Random ran = new Random();
            int qtdProduto = ran.Next(1, 200);
            return qtdProduto;
        }
        public static double ValorProduto(int tipoProduto)
        {
            double valorProduto = 0;
            switch (tipoProduto)
            {
                case 1:
                    valorProduto = 5.45;
                    break;
                case 2:
                    valorProduto = 6.78;
                    break;
                case 3:
                    valorProduto = 1.43;
                    break;
                case 4:
                    valorProduto = 2.68;
                    break;
                case 5:
                    valorProduto = 3.78;
                    break;
                case 6:
                    valorProduto = 2.96;
                    break;
            }
            return valorProduto;
        }
        public static bool VerificarCPF(string cpfVerificar, List<ClienteNormal> clienteNormals, List<ClienteSocio> clienteSocios, List<Funcionario> funcionarios)
        {
            bool CpfRepetido = true;
            if (CpfRepetido == true)
            {
                foreach (var item in clienteNormals)
                {
                    if (item.CPF == cpfVerificar)
                    {
                        CpfRepetido = false;
                        break;
                    }
                    else
                    {
                        CpfRepetido = true;
                    }
                }
            }
            else if (CpfRepetido == true)
            {
                foreach (var item in clienteSocios)
                {
                    if (item.CPF == cpfVerificar)
                    {
                        CpfRepetido = false;
                        break;
                    }
                    else
                    {
                        CpfRepetido = true;
                    }
                }
            }
            else if (CpfRepetido == true)
            {

                foreach (var item in funcionarios)
                {
                    if (item.CPF == cpfVerificar)
                    {
                        CpfRepetido = false;
                        break;
                    }
                    else
                    {
                        CpfRepetido = true;
                    }
                }
            }
            return CpfRepetido;
           
        }
        public static bool VerificarCNPJ(string cnpjVerificar, List<Fornecedor> fornecedor)
        {
            bool cnpjRepetido = true;
            foreach (var item in fornecedor)
            {
                if (item.Cnpj == cnpjVerificar)
                {
                    cnpjRepetido = false;
                    break;
                }
                else
                {
                    cnpjRepetido = true;
                }
            }
            return cnpjRepetido;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    static class FuncoesMenu
    {
        static List<ClienteNormal> ClienteNormalsList { get; set; } = new List<ClienteNormal>();
        static List<ClienteSocio> ClienteSociosList { get; set; } = new List<ClienteSocio>();
        static List<Funcionario> FuncionariosList { get; set; } = new List<Funcionario>();
        static List<Fornecedor> FornecedorsList { get; set; } = new List<Fornecedor>();
        public static void Escolha(int EscolhaOpcao)
        {
            switch (EscolhaOpcao)
            {
                case 1:
                    Adicionar();
                    break;
                case 2:
                    Remover();
                    break;
                case 3:
                    Comprar();
                    break;
                case 4:
                    BaterCartao();
                    break;
                case 5:
                    Alterar();
                    break;
                case 6:
                    CalcularLucro();
                    break;
                case 7:
                    Sair();
                    break;                
            }
        }
        public static void Adicionar()
        {
            Console.WriteLine("Insira oque será adicionado:");
            Console.WriteLine("1 - Cliente Normal: ");
            Console.WriteLine("2 - Cliente Socio: ");
            Console.WriteLine("3 - Funcionario: ");
            Console.WriteLine("4 - Fornecedor: ");
            int escolherOpcaoADD = int.Parse(Console.In.ReadLine());
            switch (escolherOpcaoADD)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Vamos inserir o Cliente Normal: ");
                    Console.WriteLine("Entre com os valores: ");

                    Console.WriteLine("Entre com o nome do Cliente Normal: ");
                    string nomeClienteNormal = Console.In.ReadLine();
                    Console.WriteLine("Insira o CPF do cliente Normal: ");
                    string cpfClienteNormal = Console.In.ReadLine();
                    Console.WriteLine("Insira a idade do Cliente Normal: ");
                    int idadeClienteNormal = int.Parse(Console.In.ReadLine());

                    ClienteNormal clienteNormal = new ClienteNormal(nomeClienteNormal, cpfClienteNormal, idadeClienteNormal, Gerador.Saldo());
                    ClienteNormalsList.Add(clienteNormal);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Vamos inserir o Cliente Socio: ");
                    Console.WriteLine();
                    Console.WriteLine("Insira o nome do Cliente Socio: ");
                    string nomeClienteSocio = Console.In.ReadLine();
                    Console.WriteLine("Insira o CPF do cliente Sicio: ");
                    string cpfClienteSocio = Console.In.ReadLine();
                    Console.WriteLine("Insira a Idade do Cliente Socio: ");
                    int idadeClienteSocio = int.Parse(Console.In.ReadLine());

                    ClienteSocio clienteSocio = new ClienteSocio(0, nomeClienteSocio, cpfClienteSocio, idadeClienteSocio, Gerador.Saldo());
                    ClienteSociosList.Add(clienteSocio);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Vamos inserir o Funcionario: ");
                    Console.WriteLine();
                    Console.WriteLine("Insira o nome do funcionario: ");
                    string nomeFuncionario = Console.In.ReadLine();
                    Console.WriteLine("Insira o CPF do funcionario: ");
                    string cpfFuncionario = Console.In.ReadLine();
                    Console.WriteLine("Insira a idade do funcionario: ");
                    int idadeFuncionario = int.Parse(Console.In.ReadLine());
                    Console.WriteLine("Insira o Saldo do Funcionario: ");
                    double saldoFuncionario = double.Parse(Console.In.ReadLine());
                    Console.WriteLine("Insira o cargo do funcionario: ");
                    string cargoFuncionario = Console.In.ReadLine();
                    Console.WriteLine("Insira o saldo do funcionario: ");
                    double salaryHoursFuncionario = double.Parse(Console.In.ReadLine());

                    Funcionario funcionario = new Funcionario(cargoFuncionario, salaryHoursFuncionario, nomeFuncionario, cpfFuncionario, idadeFuncionario, saldoFuncionario);
                    FuncionariosList.Add(funcionario);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Vamos Inserir o Fornecedor");
                    Console.WriteLine();
                    Console.WriteLine("Insira o nome do Fornecedor: ");
                    string nomeFornecedor = Console.In.ReadLine();
                    Console.WriteLine("Insira o Cnpj do Fornecedor: ");
                    string cnpjFornecedor = Console.In.ReadLine();
                    Console.WriteLine("Insira o Tipo de Produto: ");
                    int tipoProduto = int.Parse(Console.In.ReadLine());
                    Console.WriteLine("Insira a quantidade fornecida ao Mês: ");
                    int qtdFornecidaMes = int.Parse(Console.In.ReadLine());

                    Fornecedor fornecedor = new Fornecedor(nomeFornecedor, cnpjFornecedor, tipoProduto, qtdFornecidaMes);
                    FornecedorsList .Add(fornecedor);
                    break;
                default:
                    break;
            }

        }
        public static void Remover()
        {
            Console.WriteLine("Insira oque será removido:");
            Console.WriteLine("1 - Cliente Normal: ");
            Console.WriteLine("2 - Cliente Socio: ");
            Console.WriteLine("3 - Funcionario: ");
            Console.WriteLine("4 - Fornecedor: ");
            int escolherOpcaoRemove = int.Parse(Console.In.ReadLine());
            string cpfVerificar;
            switch (escolherOpcaoRemove)
            {
                
                case 1:
                    Console.Clear();
                    Console.Write("Insira o CPF do Cliente Normal: ");
                    cpfVerificar = Console.In.ReadLine();
                    for (int i = 0; i < ClienteNormalsList.Count; i++)
                    {
                        if (ClienteNormalsList[i].CPF.CompareTo(cpfVerificar) == 0)
                        {
                            ClienteNormalsList.Remove(ClienteNormalsList[i]);
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Insira o CPF do Cliente Socio: ");
                    cpfVerificar = Console.In.ReadLine();
                    for (int i = 0; i < ClienteSociosList.Count; i++)
                    {
                        if (ClienteSociosList[i].CPF.CompareTo(cpfVerificar) == 0)
                        {
                            ClienteSociosList.Remove(ClienteSociosList[i]); 
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Insira o CPF do Funcionario: ");
                    cpfVerificar = Console.In.ReadLine();
                    for (int i = 0; i < FuncionariosList.Count; i++)
                    {
                        if (FuncionariosList[i].CPF.CompareTo(cpfVerificar) == 0)
                        {
                            FuncionariosList.Remove(FuncionariosList[i]);
                        }
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Insira o Cnpj do Fornecedor: ");
                    cpfVerificar = Console.In.ReadLine();
                    for (int i = 0; i < FornecedorsList.Count; i++)
                    {
                        if (FornecedorsList[i].Cnpj.CompareTo(cpfVerificar) == 0)
                        {
                            FornecedorsList.Remove(FornecedorsList[i]);
                        }
                    }
                    break;
            }
        }
        public static void Comprar()
        {
            Console.Clear();
            Console.WriteLine("Insira o Tipo de Cliente");
            Console.WriteLine();
            Console.WriteLine("1-Cliente Normal");
            Console.WriteLine("2-Cliente Socio");
            int escolherTipo = int.Parse(Console.In.ReadLine());
            switch (escolherTipo)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Lista de Cliente Normal");
                    Console.WriteLine();
                    foreach (var item in ClienteNormalsList)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Insira o CPF do Cliente que esta comprando:");
                    string cpfDoClienteNormal = Console.In.ReadLine();
                    foreach (var item in ClienteNormalsList)
                    {
                        if (item.CPF.CompareTo(cpfDoClienteNormal) == 0)
                        {
                            Console.Clear();
                            Console.WriteLine(item);
                            Console.WriteLine();
                            Console.WriteLine("Insira o valor da compra:");
                            double valorDaCompra = double.Parse(Console.In.ReadLine());
                            item.SetSaldo(item.GetSaldo() - valorDaCompra);
                            Console.WriteLine(item.GetSaldo());
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Lista de Cliente Socio");
                    Console.WriteLine();
                    foreach (var item in ClienteSociosList)
                    {
                        Console.WriteLine(item );
                    }
                    Console.WriteLine("Insira o CPF do Cliente que esta comprando");
                    string cpfDoClienteSocio = Console.In.ReadLine();
                    foreach (var item in ClienteSociosList)
                    {
                        if (item.CPF.CompareTo(cpfDoClienteSocio) == 0)
                        {
                            Console.Clear();
                            Console.WriteLine(item);
                            Console.WriteLine();
                            Console.WriteLine("Insira o valor da compra: ");
                            double valorDaCompra = double.Parse(Console.In.ReadLine());
                            valorDaCompra = valorDaCompra - (valorDaCompra * 0.20);
                            item.SetSaldo(item.GetSaldo() - valorDaCompra);
                            Console.WriteLine(item.GetSaldo());
                        }
                    }
                    break;
            }
        }
        public static void BaterCartao()
        {
            Console.WriteLine("Bater Cartão ponto: ");
            Console.WriteLine();
            foreach (var item in FuncionariosList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Insira o CPF do Funcionario que esta batendo o cartão: ");
            string cpfFuncionario = Console.In.ReadLine();
            foreach (var item in FuncionariosList)
            {
                if (item.CPF.CompareTo(cpfFuncionario) == 0)
                {
                    Console.Clear();
                    Console.WriteLine(item);
                    Console.WriteLine();
                    Console.WriteLine("O cliente está batendo o cartão do dia ou de 30 dias?");

                }
            }
        }
        public static void Alterar()
        {

        }
        public static void CalcularLucro()
        {

        }
        public static void Sair()
        {
            
        }
    }
}

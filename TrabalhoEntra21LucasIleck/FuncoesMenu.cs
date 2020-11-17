using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    class FuncoesMenu
    {
        List<ClienteNormal> ClienteNormalsList { get; set; } = new List<ClienteNormal>();
        List<ClienteSocio> ClienteSociosList { get; set; } = new List<ClienteSocio>();
        List<Funcionario> FuncionariosList { get; set; } = new List<Funcionario>();
        List<Fornecedor> FornecedorsList { get; set; } = new List<Fornecedor>();
        public void Escolha(int EscolhaOpcao)
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
                default:
                    break;
            }
        }
        public void Adicionar()
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
        public void Remover()
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
                        FuncionariosList.Remove(FuncionariosList[i]);
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Insira o CPF do Fornecedor: ");
                    cpfVerificar = Console.In.ReadLine();
                    for (int i = 0; i < FornecedorsList.Count; i++)
                    {
                        FornecedorsList.Remove(FornecedorsList[i]);
                    }
                    break;
                default:
                    break;
            }
        }
        public void Comprar()
        {

        }
        public void BaterCartao()
        {

        }
        public void Alterar()
        {

        }
        public void CalcularLucro()
        {

        }
        public void Sair()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrabalhoEntra21LucasIleck
{
    static class FuncoesMenu
    {
        public static List<ClienteNormal> ClienteNormalsList { get; set; } = new List<ClienteNormal>();
        public static List<ClienteSocio> ClienteSociosList { get; set; } = new List<ClienteSocio>();
        public static List<Funcionario> FuncionariosList { get; set; } = new List<Funcionario>();
        public static List<Fornecedor> FornecedorsList { get; set; } = new List<Fornecedor>();
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
                    Console.WriteLine("Obrigado por usar o programa! Saindo em 3S");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
            }
        }
        public static void Adicionar()
        {
            bool MenuAdicionar = true;
            while (MenuAdicionar)
            {
                Console.Clear();
                Console.WriteLine("Insira oque será adicionado:");
                Console.WriteLine("1 - Cliente Normal: ");
                Console.WriteLine("2 - Cliente Socio: ");
                Console.WriteLine("3 - Funcionario: ");
                Console.WriteLine("4 - Fornecedor: ");
                Console.WriteLine("5 - Voltar:");
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
                        if (ClienteSociosList.Count <= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Vamos inserir o Cliente Socio: ");
                            Console.WriteLine();
                            Console.WriteLine("Insira o nome do Cliente Socio: ");
                            string nomeClienteSocio = Console.In.ReadLine();
                            Console.WriteLine("Insira o CPF do cliente Sicio: ");
                            string cpfClienteSocio = Console.In.ReadLine();
                            Console.WriteLine("Insira a Idade do Cliente Socio: ");
                            int idadeClienteSocio = int.Parse(Console.In.ReadLine());

                            ClienteSocio clienteSocio = new ClienteSocio(FuncoesBase.GerarAcoes(), nomeClienteSocio, cpfClienteSocio, idadeClienteSocio, Gerador.Saldo());
                            ClienteSociosList.Add(clienteSocio);
                        }
                        else
                        {
                            Console.WriteLine("Lista lotada, só pode conter 10 Cliente Socio");
                        }

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
                        Console.WriteLine("Insira o salario hora, do funcionario: ");
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
                        FornecedorsList.Add(fornecedor);
                        break;
                    case 5:
                        MenuAdicionar = false;
                        break;
                }
            }
        }
        public static void Remover()
        {
            bool menuRemover = true;
            while (menuRemover)
            {
                Console.Clear();
                Console.WriteLine("Insira oque será removido:");
                Console.WriteLine("1 - Cliente Normal: ");
                Console.WriteLine("2 - Cliente Socio: ");
                Console.WriteLine("3 - Funcionario: ");
                Console.WriteLine("4 - Fornecedor: ");
                Console.WriteLine("5 - Voltar:");
                int escolherOpcaoRemove = int.Parse(Console.In.ReadLine());
                string cpfVerificar;
                switch (escolherOpcaoRemove)
                {

                    case 1:
                        Console.Clear();
                        MostrarLista(1);
                        Console.WriteLine();
                        Console.Write("Insira o CPF do Cliente Normal: ");
                        cpfVerificar = Console.In.ReadLine();
                        for (int i = 0; i < ClienteNormalsList.Count; i++)
                        {
                            if (ClienteNormalsList[i].CPF.CompareTo(cpfVerificar) == 0)
                            {
                                ClienteNormalsList[i].MostrarDados();
                                Console.WriteLine("Removido com sucesso!!");
                                ClienteNormalsList.Remove(ClienteNormalsList[i]);
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        MostrarLista(2);
                        Console.WriteLine();
                        Console.Write("Insira o CPF do Cliente Socio: ");
                        cpfVerificar = Console.In.ReadLine();
                        for (int i = 0; i < ClienteSociosList.Count; i++)
                        {
                            if (ClienteSociosList[i].CPF.CompareTo(cpfVerificar) == 0)
                            {
                                ClienteSociosList[i].MostrarDados();
                                Console.WriteLine("Removido com sucesso!!");
                                ClienteSociosList.Remove(ClienteSociosList[i]);
                                Console.In.ReadLine();
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        MostrarLista(3);
                        Console.WriteLine();
                        Console.Write("Insira o CPF do Funcionario: ");
                        cpfVerificar = Console.In.ReadLine();
                        for (int i = 0; i < FuncionariosList.Count; i++)
                        {
                            if (FuncionariosList[i].CPF.CompareTo(cpfVerificar) == 0)
                            {
                                FuncionariosList[i].MostrarDados();
                                Console.WriteLine("Removido com sucesso!!");
                                FuncionariosList.Remove(FuncionariosList[i]);
                                Console.In.ReadLine();
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        MostrarLista(4);
                        Console.WriteLine();
                        Console.WriteLine("Insira o Cnpj do Fornecedor: ");
                        cpfVerificar = Console.In.ReadLine();
                        for (int i = 0; i < FornecedorsList.Count; i++)
                        {
                            if (FornecedorsList[i].Cnpj.CompareTo(cpfVerificar) == 0)
                            {
                                FornecedorsList[i].MostrarDados();
                                Console.WriteLine("Removido com sucesso");
                                FornecedorsList.Remove(FornecedorsList[i]);
                                Console.In.ReadLine();
                            }
                        }
                        break;
                    case 5:
                        menuRemover = false;
                        break;
                }
            }

        }
        public static void Comprar()
        {
            bool MenuComprar = true;
            while (MenuComprar)
            {
                Console.Clear();
                Console.WriteLine("Insira o Tipo de Cliente");
                Console.WriteLine();
                Console.WriteLine("1 - Cliente Normal:");
                Console.WriteLine("2 - Cliente Socio:");
                Console.WriteLine("3 - Voltar:");
                int escolherTipo = int.Parse(Console.In.ReadLine());
                string cpfCliente;
                switch (escolherTipo)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Lista de Cliente Normal:");
                        Console.WriteLine();
                        MostrarLista(1);
                        Console.WriteLine("Insira o CPF do Cliente que eesta comprando:");
                        cpfCliente = Console.In.ReadLine();
                        foreach (var item in ClienteNormalsList)
                        {
                            if (cpfCliente == item.CPF)
                            {
                                Console.Clear();
                                item.MostrarDados();
                                Console.WriteLine();
                                Console.WriteLine("Insira o valor que o Cliente está comprando: ");
                                double valorGasto = double.Parse(Console.In.ReadLine());
                                item.SetSaldo(item.GetSaldo() + valorGasto);
                                Console.WriteLine();
                                item.MostrarDados();
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Lista de Cliente Socio:");
                        Console.WriteLine();
                        MostrarLista(2);
                        Console.WriteLine("Insira o CPF do Cliente que eesta comprando:");
                        cpfCliente = Console.In.ReadLine();
                        foreach (var item in ClienteSociosList)
                        {
                            if (cpfCliente == item.CPF)
                            {
                                Console.Clear();
                                item.MostrarDados();
                                Console.WriteLine();
                                Console.WriteLine("Insira o valor que o Cliente está comprando: ");
                                double valorGasto = double.Parse(Console.In.ReadLine());
                                valorGasto = valorGasto - (valorGasto * 0.20);
                                Console.WriteLine("Desconto aplicado: {0}", valorGasto);
                                item.SetSaldo(item.GetSaldo() + valorGasto);
                                Console.WriteLine();
                                item.MostrarDados();
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 3:
                        MenuComprar = false;
                        break;
                }
            }
           
        }
        public static void BaterCartao()
        {
            bool menuBaterCartao = true;
            while (menuBaterCartao)
            {
                Console.Clear();
                Console.WriteLine("Bater Cartão Ponto");
                Console.WriteLine();
                MostrarLista(3);
                Console.WriteLine();
                Console.WriteLine("1 - Bater Ponto:");
                Console.WriteLine("2 - Voltar");
                bool fim = false;
                int escolha1 = 0;
                while (!fim)
                {
                    try
                    {
                        escolha1 = int.Parse(Console.In.ReadLine());
                        fim = true;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Digite 1 ou 2");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }              
                switch (escolha1)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Digite o CPF");
                        string cpfEscolher = Console.In.ReadLine();
                        foreach (var item in FuncionariosList)
                        {
                            if (cpfEscolher == item.CPF)
                            {
                                Console.Clear();
                                Console.WriteLine("Bater Cartão Ponto");
                                Console.WriteLine();
                                item.MostrarDados();
                                item.MostraCargoSalario();
                                Console.WriteLine();
                                Console.WriteLine("1 - Cartão do Dia:");
                                Console.WriteLine("2 - Cartão do mês:");
                                Console.WriteLine("3 - Voltar:");
                                int esc = int.Parse(Console.In.ReadLine());
                                switch (esc)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Insira o horario de entrada:");
                                        int entrada = int.Parse(Console.In.ReadLine());
                                        Console.WriteLine("Insira  horario de Saida:");
                                        int saida = int.Parse(Console.In.ReadLine());
                                        item.BaterPonto(entrada, saida);
                                        item.MostrarDados();
                                        item.MostraCargoSalario();
                                        Console.WriteLine();
                                        item.MostrarHistorico();
                                        Console.In.ReadLine();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        item.BaterPonto30Vezes();
                                        item.MostrarDados();
                                        item.MostraCargoSalario();
                                        Console.WriteLine();
                                        item.MostrarHistorico();
                                        Console.In.ReadLine();
                                        break;
                                    case 3:
                                        menuBaterCartao = false;
                                        break;
                                }
                            }
                            if (menuBaterCartao == false)
                            {
                                break;                               
                            }
                        }
                        break;
                    case 2:
                        menuBaterCartao = false;
                        break;
                }
            }         
        }
        public static void Alterar()
        {
            bool menuAlterar = true;
            while (menuAlterar == true)
            {
                Console.Clear();
                Console.WriteLine("Menu Alterar");
                Console.WriteLine();
                Console.WriteLine("1 - Cliente Normal: ");
                Console.WriteLine("2 - Cliente Socio: ");
                Console.WriteLine("3 - Funcionario: ");
                Console.WriteLine("4 - Fornecedor: ");
                Console.WriteLine("5 - Voltar:");
                int escolhaAlterar = int.Parse(Console.In.ReadLine());
                switch (escolhaAlterar)
                {
                    case 1:
                        Console.Clear();
                        MostrarLista(1);
                        Console.WriteLine();
                        Console.WriteLine("Digite o CPF:");
                        string cpfCliente = Console.In.ReadLine();
                        foreach (var item in ClienteNormalsList)
                        {
                            if (item.CPF.CompareTo(cpfCliente) == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite o Novo nome:");
                                string nome = Console.In.ReadLine();
                                Console.WriteLine("Digite o Novo CPF:");
                                string cpf = Console.In.ReadLine();
                                Console.WriteLine("Digite a Nova Idade:");
                                int idade = int.Parse(Console.In.ReadLine());

                                item.DefineDados(nome, cpf, idade, 0);
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        MostrarLista(2);
                        Console.WriteLine();
                        Console.WriteLine("Digite o CPF:");
                        string cpfSocio = Console.In.ReadLine();
                        foreach (var item in ClienteSociosList)
                        {
                            if (item.CPF.CompareTo(cpfSocio) == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite o Novo nome:");
                                string nome = Console.In.ReadLine();
                                Console.WriteLine("Digite o Novo CPF:");
                                string cpf = Console.In.ReadLine();
                                Console.WriteLine("Digite a Nova Idade:");
                                int idade = int.Parse(Console.In.ReadLine());

                                item.DefineDados(nome, cpf, idade, 0);
                                Console.WriteLine("Digite a porcentagem de Ações do Cliente Socio:");
                                Console.WriteLine("Quantidade maxima = 4,95%");
                                bool indexAcoes;
                                do
                                {
                                    double acoes = double.Parse(Console.In.ReadLine());
                                    indexAcoes = item.DefineAcoes(acoes);
                                } while (indexAcoes == false);
                               
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        MostrarLista(3);
                        Console.WriteLine();
                        Console.WriteLine("Digite o CPF:");
                        string cpfFuncionario = Console.In.ReadLine();
                        foreach (var item in FuncionariosList)
                        {
                            if (item.CPF.CompareTo(cpfFuncionario) == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite o Novo nome:");
                                string nome = Console.In.ReadLine();
                                Console.WriteLine("Digite o Novo CPF:");
                                string cpf = Console.In.ReadLine();
                                Console.WriteLine("Digite a Nova Idade:");
                                int idade = int.Parse(Console.In.ReadLine());
                                Console.WriteLine("Digite o Novo Cargo:");
                                string cargo = Console.In.ReadLine();
                                Console.WriteLine("Digite o Novo Salario:");
                                double salarioHr = double.Parse(Console.In.ReadLine());
                                item.DefineDados(nome, cpf, idade, 0);
                                item.DefineCargoSalario(cargo, salarioHr);

                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        MostrarLista(4);
                        Console.WriteLine();
                        Console.WriteLine("Digite o Cnpj:");
                        string cnpjFornecedor = Console.In.ReadLine();
                        foreach (var item in FornecedorsList)
                        {
                            if (item.Cnpj.CompareTo(cnpjFornecedor) == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite o Novo Tipo dè Produto:");
                                int tipoProduto = int.Parse(Console.In.ReadLine());
                                Console.WriteLine("Digite a Nova quantidade Fornecida:");
                                int qtdFornecida = int.Parse(Console.In.ReadLine());
                                item.DefineQuantidadeFornecida(qtdFornecida, tipoProduto);
                            }
                        }
                        break;
                    case 5:
                        menuAlterar = false;
                        break;
                      
                }
            }
        }
        public static void CalcularLucro()
        {

            //Calcular Ganho
            double lucroTotal = 0;
            double valorGastoClienteSocio = 0;
            double valorGastoClienteNormal = 0;
            foreach (var item in ClienteNormalsList)
            {
                valorGastoClienteNormal += item.GetSaldo();
            }
            foreach (var item in ClienteSociosList)
            {
                valorGastoClienteSocio += item.GetSaldo();
            }
            lucroTotal = valorGastoClienteSocio + valorGastoClienteNormal;
            Console.WriteLine("Lucro Total: {0}", lucroTotal);
            // Calcular Prejuizo
            //double PrejuizoRDSocio = 0;
            double SalarioFuncionarios = 0;
            double ValorProdutosFornecidos = 0;
            foreach (var item in FuncionariosList)
            {
                SalarioFuncionarios += item.GetSaldo();
            }
            foreach (var item in FornecedorsList)
            {
                ValorProdutosFornecidos += (FuncoesBase.ValorProduto(item.TipoProduto) * item.QuantidadeFornecidaMes);
            }
            double valorTTPreju = (SalarioFuncionarios + ValorProdutosFornecidos);
            Console.WriteLine("Gasto Total: {0}", valorTTPreju);
            valorTTPreju = valorTTPreju - (valorTTPreju * (FuncoesBase.AcoesTotais() / 100));
            Console.WriteLine("Valor prejuizo Reduzido por Socios: {0}", valorTTPreju);
            double ValorFinal1 = lucroTotal - valorTTPreju;
            if (ValorFinal1 > 0)
            {
                Console.WriteLine("Saldo Positivo");
                Console.WriteLine("Valor ganho dos Socios: {0}", ValorFinal1 * (FuncoesBase.AcoesTotais() / 100));
                ValorFinal1 = ValorFinal1 - (ValorFinal1 * (FuncoesBase.AcoesTotais() / 100));
                Console.WriteLine("Lucro Final: {0}", ValorFinal1);
            }
            else if (ValorFinal1 < 0)
            {
                Console.WriteLine("Saldo Negativo");
                Console.WriteLine(ValorFinal1);
            }
            
            Console.WriteLine();
            Console.In.ReadLine();
                  
            
        }
        public static bool Sair(int escolha)
        {
            if (escolha == 7)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        /// <summary>
        /// Escolha o tipo:
        /// 1 => Cliente Normal
        /// 2 => Cliente Socio
        /// 3 => Funcionario
        /// 4 => Fornecedor
        /// </summary>
        /// <param name="index"></param>
        public static void MostrarLista(int index)
        {
            switch (index)
            {
                case 1:
                    Console.WriteLine("Cliente Normal:");
                    Console.WriteLine();
                    foreach (var item in ClienteNormalsList)
                    {
                        item.MostrarDados();
                        Console.WriteLine("=============================================================================");
                    }
                    break;
                case 2:
                    Console.WriteLine("Cliente Socio:");
                    Console.WriteLine();
                    foreach (var item in ClienteSociosList)
                    {
                        item.MostrarDados();
                        item.MostraAcoes();
                        Console.WriteLine("=============================================================================");
                    }
                    break;
                case 3:
                    Console.WriteLine("Cliente Funcionario:");
                    Console.WriteLine();
                    foreach (var item in FuncionariosList)
                    {
                        item.MostrarDados();
                        item.MostraCargoSalario();
                        Console.WriteLine("=============================================================================");
                    }
                    break;
                case 4:
                    Console.WriteLine("Cliente Fornecedor:");
                    Console.WriteLine();
                    foreach (var item in FornecedorsList)
                    {
                        item.MostrarDados();
                        item.MostraQuantidadeFornecida();
                        Console.WriteLine("=============================================================================");
                    }
                    break;
            }
        }
    }
}

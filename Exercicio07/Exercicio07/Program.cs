using System;
using System.Linq;

namespace GerenciamentoVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int codigoProduto, quantidade;
                string nomeProduto;
                double valorUnitario, valorTotal;

                // Solicita ao usuário para inserir o código do produto
                Console.WriteLine("Digite o código do produto:");
                while (!int.TryParse(Console.ReadLine(), out codigoProduto) || codigoProduto <= 0)
                {
                    Console.WriteLine("Por favor, insira um código de produto válido.");
                }

                // Solicita ao usuário para inserir o nome do produto
                Console.WriteLine("Digite o nome do produto:");
                nomeProduto = Console.ReadLine();

                // Verifica se o nome do produto contém pelo menos um caractere não numérico
                while (string.IsNullOrWhiteSpace(nomeProduto) || nomeProduto.All(char.IsDigit))
                {
                    Console.WriteLine("Por favor, insira um nome de produto válido contendo pelo menos um caractere não numérico.");
                    nomeProduto = Console.ReadLine();
                }

                // Solicita ao usuário para inserir a quantidade comprada
                Console.WriteLine("Digite a quantidade comprada:");
                while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
                {
                    Console.WriteLine("Por favor, insira uma quantidade válida.");
                }

                // Solicita ao usuário para inserir o valor unitário
                Console.WriteLine("Digite o valor unitário do produto:");
                while (!double.TryParse(Console.ReadLine(), out valorUnitario) || valorUnitario <= 0)
                {
                    Console.WriteLine("Por favor, insira um valor unitário válido.");
                }

                // Calcula o valor total da venda
                valorTotal = quantidade * valorUnitario;

                // Exibe os detalhes da venda
                Console.WriteLine("Detalhes da Venda:");
                Console.WriteLine("Código do Produto: " + codigoProduto);
                Console.WriteLine("Nome do Produto: " + nomeProduto);
                Console.WriteLine("Quantidade Comprada: " + quantidade);
                Console.WriteLine("Valor Unitário: R$" + valorUnitario.ToString("F2"));
                Console.WriteLine("Valor Total da Venda: R$" + valorTotal.ToString("F2"));

                // Oferece a opção de fechar a compra ou inserir um novo produto
                Console.WriteLine("\nDeseja fechar a compra (S para Sim ou qualquer outra tecla para inserir um novo produto)?");
                string opcao = Console.ReadLine().ToUpper();
                if (opcao == "S")
                {
                    Console.WriteLine("Compra fechada. Obrigado por sua compra!");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}


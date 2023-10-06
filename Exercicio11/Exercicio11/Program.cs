using System;

namespace ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                double salario, percentualAumento, valorAumento, novoSalario;

                Console.WriteLine("Digite o salário atual do colaborador:");
                while (!double.TryParse(Console.ReadLine(), out salario) || salario < 0)
                {
                    Console.WriteLine("Por favor, insira um valor de salário válido.");
                }

                // Calcula o reajuste salarial com base nos critérios fornecidos
                if (salario <= 280)
                {
                    percentualAumento = 0.2; // 20%
                }
                else if (salario <= 700)
                {
                    percentualAumento = 0.15; // 15%
                }
                else if (salario <= 1500)
                {
                    percentualAumento = 0.1; // 10%
                }
                else
                {
                    percentualAumento = 0.05; // 5%
                }

                // Calcula o valor do aumento e o novo salário
                valorAumento = salario * percentualAumento;
                novoSalario = salario + valorAumento;

                // Exibe os resultados
                Console.WriteLine("Salário antes do reajuste: R$" + salario.ToString("F2"));
                Console.WriteLine("Percentual de aumento aplicado: " + (percentualAumento * 100).ToString("F0") + "%");
                Console.WriteLine("Valor do aumento: R$" + valorAumento.ToString("F2"));
                Console.WriteLine("Novo salário após o aumento: R$" + novoSalario.ToString("F2"));

                Console.WriteLine("Deseja fazer outro cálculo? (S/N):");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S")
                {
                    continuar = false;
                }
            }
        }
    }
}

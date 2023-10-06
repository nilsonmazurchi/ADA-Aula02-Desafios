using System;

namespace EscolhaCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um curso na área de programação:");
            Console.WriteLine("1 - Desenvolvimento Web");
            Console.WriteLine("2 - Desenvolvimento Mobile");
            Console.WriteLine("3 - Ciência de Dados");
            Console.WriteLine("4 - Inteligência Artificial");
            Console.WriteLine("5 - Segurança da Informação");

            int opcao = 0;

            // Loop para garantir que o usuário insira uma opção válida
            while (opcao < 1 || opcao > 5)
            {
                Console.Write("Digite o número correspondente ao curso desejado: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    if (opcao < 1 || opcao > 5)
                    {
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 5.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                }
            }

            string turma = "";

            // Seleciona a turma com base na opção escolhida
            switch (opcao)
            {
                case 1:
                    turma = "Desenvolvimento Web";
                    break;
                case 2:
                    turma = "Desenvolvimento Mobile";
                    break;
                case 3:
                    turma = "Ciência de Dados";
                    break;
                case 4:
                    turma = "Inteligência Artificial";
                    break;
                case 5:
                    turma = "Segurança da Informação";
                    break;
            }

            Console.WriteLine("Você escolheu o curso: " + turma);
            Console.WriteLine("Bem-vindo! Boa jornada de aprendizado!");
        }
    }
}

using System;

namespace CalculoNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double prova1, prova2, prova3, media, notaExame;

            // Solicita ao usuário para inserir as notas das três provas
            Console.WriteLine("Digite a nota da Prova 1:");
            while (!double.TryParse(Console.ReadLine(), out prova1) || prova1 < 0 || prova1 > 10)
            {
                Console.WriteLine("Por favor, insira uma nota válida entre 0 e 10.");
            }

            Console.WriteLine("Digite a nota da Prova 2:");
            while (!double.TryParse(Console.ReadLine(), out prova2) || prova2 < 0 || prova2 > 10)
            {
                Console.WriteLine("Por favor, insira uma nota válida entre 0 e 10.");
            }

            Console.WriteLine("Digite a nota da Prova 3:");
            while (!double.TryParse(Console.ReadLine(), out prova3) || prova3 < 0 || prova3 > 10)
            {
                Console.WriteLine("Por favor, insira uma nota válida entre 0 e 10.");
            }

            // Calcula a média das provas
            media = (prova1 + prova2 + prova3) / 3;

            // Verifica se o aluno precisa fazer exame final
            if (media < 7.0)
            {
                Console.WriteLine("Você precisa fazer o exame final.");

                // Calcula a nota necessária no exame final para passar de ano
                notaExame = 10 - media;

                Console.WriteLine("Nota necessária no exame final: " + notaExame.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Parabéns! Você foi aprovado com média " + media.ToString("F2"));
            }

            Console.ReadLine();
        }
    }
}

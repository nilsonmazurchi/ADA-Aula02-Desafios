using System;

namespace ClassificacaoNadador
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            do
            {
                Console.WriteLine("Digite a idade do nadador: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    Console.WriteLine("Por favor, insira uma idade válida.");
                }
            } while (idade <= 0);

            switch (idade)
            {
                case int i when i >= 5 && i <= 7:
                    Console.WriteLine("Categoria: Infantil A");
                    break;
                case int i when i >= 8 && i <= 11:
                    Console.WriteLine("Categoria: Infantil B");
                    break;
                case int i when i >= 12 && i <= 13:
                    Console.WriteLine("Categoria: Juvenil A");
                    break;
                case int i when i >= 14 && i <= 17:
                    Console.WriteLine("Categoria: Juvenil B");
                    break;
                case int i when i >= 18:
                    Console.WriteLine("Categoria: Adultos");
                    break;
                default:
                    Console.WriteLine("Desculpe, não possuímos categoria para esta idade.");
                    break;
            }

            Console.ReadLine();
        }
    }
}



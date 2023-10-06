using System;
using System.Linq;

namespace VerificarPalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = ObterEntradaValida();

            // Converte a palavra para minúsculas para tornar a comparação sem diferenciação de maiúsculas e minúsculas
            palavra = palavra.ToLower();

            // Verifica se a palavra é um palíndromo
            bool ePalindromo = VerificarPalindromo(palavra);

            // Exibe o resultado
            if (ePalindromo)
            {
                Console.WriteLine("A palavra '" + palavra + "' é um palíndromo.");
            }
            else
            {
                Console.WriteLine("A palavra '" + palavra + "' não é um palíndromo.");
            }
        }

        static string ObterEntradaValida()
        {
            string entrada = "";
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.WriteLine("Digite uma palavra para verificar se é um palíndromo:");
                entrada = Console.ReadLine();

                // Verifica se a entrada contém apenas letras
                if (!string.IsNullOrEmpty(entrada) && entrada.All(char.IsLetter))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Por favor, insira apenas letras.");
                }
            }

            return entrada;
        }

        static bool VerificarPalindromo(string palavra)
        {
            int esquerda = 0;
            int direita = palavra.Length - 1;

            // Verifica se a palavra é um palíndromo comparando caracteres da esquerda para a direita e vice-versa
            while (esquerda < direita)
            {
                if (palavra[esquerda] != palavra[direita])
                {
                    return false;
                }
                esquerda++;
                direita--;
            }
            return true;
        }
    }
}

using System;

namespace ControleRendimentoPesca
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoPeixes;
            const double pesoLimite = 50;
            const double valorMultaPorQuilo = 4.00;

            Console.WriteLine("Digite o peso dos peixes (em quilos): ");

            // Loop para verificar se o valor inserido é válido
            while (!double.TryParse(Console.ReadLine(), out pesoPeixes) || pesoPeixes <= 0)
            {
                Console.WriteLine("Por favor, insira um valor válido para o peso dos peixes.");
                Console.WriteLine("Digite o peso dos peixes (em quilos): ");
            }

            double excesso = 0;
            double multa = 0;

            if (pesoPeixes > pesoLimite)
            {
                excesso = pesoPeixes - pesoLimite;
                multa = excesso * valorMultaPorQuilo;
            }
            else
            {
                Console.WriteLine("Você está dentro do limite de peso permitido!");
            }

            if (excesso > 0)
            {
                Console.WriteLine("O limite de peso perimitido é 50kg! Você ultrapasou e seu excesso de peso é: " + excesso.ToString("F2") + " kg");
                Console.WriteLine("Valor da multa a ser pago: R$" + multa.ToString("F2"));
            }

            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreJokenPo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Pedra, Papel e Tesoura!");

            bool jogarNovamente = true;

            while (jogarNovamente)
            {
                Console.WriteLine("\nEscolha 1 - Pedra, 2 - Papel, 3 - Tesoura");

                Console.Write("Sua escolha: ");
                bool valido = int.TryParse(Console.ReadLine(), out int escolherjogador);

                if (!valido || escolherjogador < 1 || escolherjogador > 3)
                {
                    Console.WriteLine("Escolha inválida!");
                    continue;
                }

                Random random = new Random();
                int escolhercomputador = random.Next(1, 4);

                Console.WriteLine($"Você escolheu: {NomeEscolha(escolherjogador)}");
                Console.WriteLine($"Computador escolheu: {NomeEscolha(escolhercomputador)}");

                if (escolherjogador == escolhercomputador)
                {
                    Console.WriteLine("Deu empate!");
                }
                else if (
                    (escolherjogador == 1 && escolhercomputador == 3) ||
                    (escolherjogador == 2 && escolhercomputador == 1) ||
                    (escolherjogador == 3 && escolhercomputador == 2)
                )
                {
                    Console.WriteLine("Parabéns, você venceu!");
                }
                else
                {
                    Console.WriteLine("Infelizmente o computador ganhou.");
                }

                Console.WriteLine("\nDeseja jogar novamente? (s/n): ");
                string resposta = Console.ReadLine().ToLower();
                jogarNovamente = resposta == "s";

            }

            Console.WriteLine("Valeu por jogar!");
        }

        static string NomeEscolha(int num)
        {
            switch (num)
            {
                case 1: return "Pedra";
                case 2: return "Papel";
                case 3: return "Tesoura";
                default: return "Inválido";
            }
        }
    }
}

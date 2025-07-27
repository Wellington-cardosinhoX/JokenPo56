using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region JokenPo
            //    Console.WriteLine("Jogo Pedra, Papel e Tesoura");
            //    Console.WriteLine("Escolha: 1 = Pedra, 2 = Papel, 3 = Tesoura");

            //    int escolherjogador;

            //    Console.Write("Sua escolha: ");
            //    escolherjogador = int.Parse(Console.ReadLine());

            //    if (escolherjogador < 1 || escolherjogador > 3)
            //    {
            //        Console.WriteLine("Escolha inválida! fim de jogo.");
            //        return;
            //    }

            //    // gerar a escolha do computador
            //    Random random = new Random();
            //    int escolhercomputador = random.Next(1, 4);

            //    // Mostrar escolhas
            //    Console.WriteLine($"Você escolheu: {NomeEscolha(escolherjogador)}");
            //    Console.WriteLine($"Computador escolheu: {NomeEscolha(escolhercomputador)}");

            //    if (escolherjogador == escolhercomputador)
            //    {
            //        Console.WriteLine("Empate!");
            //    }
            //    else if (
            //        (escolherjogador == 1 && escolhercomputador == 3) ||
            //        (escolherjogador == 2 && escolhercomputador == 1) ||
            //        (escolherjogador == 3 && escolhercomputador == 2)
            //    )
            //    {
            //        Console.WriteLine("Você ganhou");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Você perdeu!");
            //    }

            //}

            //static string NomeEscolha(int num)
            //{
            //    switch (num)
            //    {
            //        case 1: return "Pedra";
            //        case 2: return "Papel";
            //        case 3: return "Tesoura";
            //        default: return "Inválido";
            //
            //    }
            #endregion


            #region JokenPo, mas sem o loop
            Console.WriteLine("Bem vindo ao pedra, papel e tesoura");
            Console.WriteLine("Escolha 1 - Pedra, Escolha 2 - Papel, Escolha 3 - Tesoura");

            int escolherjogador;

            Console.Write("Sua escolha: ");
            escolherjogador = int.Parse(Console.ReadLine());

            if (escolherjogador < 1 || escolherjogador > 3)
            {
                Console.WriteLine("Escolha inválida, programa finalizado!");
                return;
            }

            Random random = new Random();
            int escolhercomputador = random.Next(1, 4);

            Console.WriteLine($"Você escolheu: {NomeEscolha(escolherjogador)}");
            Console.WriteLine($"Computador escolheu: {NomeEscolha(escolhercomputador)}");

            if (escolherjogador == escolhercomputador)
            {
                Console.WriteLine("Deu empate!");
            }
            else if
                (
                (escolherjogador == 1 && escolhercomputador == 3) ||
                (escolherjogador == 2 && escolhercomputador == 1) ||
                (escolherjogador == 3 && escolhercomputador == 2)
                )
            {
                Console.WriteLine("Parabéns, você venceu!");
            }
            else
            {
                Console.WriteLine("Infelizmente o computador ganhou");
            }
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
            #endregion
        }






    }
}

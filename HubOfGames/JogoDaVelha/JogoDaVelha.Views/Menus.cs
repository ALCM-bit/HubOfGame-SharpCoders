using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.JogoDaVelha.JogoDaVelha.Views
{
    public class Menus
    {
        public static void ShowWelcome()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("== Bem vindo ao Jogo da Velha ==");
            Console.WriteLine("================================");
            Console.WriteLine("Para começar aperte ENTER");
            Console.ReadKey();
        }

        public static void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - Novo jogo");
            Console.WriteLine("2 - Pontuação");
            Console.Write("Digite a opção desejada: ");
        }
    }
}

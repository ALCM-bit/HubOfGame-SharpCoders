using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.HubSystem.Views
{
    public class HubView
    {
        public static void StarterMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Logar Jogadores");
            Console.WriteLine("3 - Ranking");
            Console.Write("Digite a opção desejada: ");
        }

        public static void GameMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Jogo da Velha");
            Console.WriteLine("2 - Batalha Naval");
            Console.WriteLine("3 - Para voltar ao Menu principal");
            Console.Write("Digite a opção desejada: ");
        }
    }
}

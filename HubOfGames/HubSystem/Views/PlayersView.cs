using HubOfGames.HubSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.HubSystem.Views
{
    public class PlayersView
    {
        public static Player AddPlayer()
        {
            Console.Write("Digite o nome: ");
            string name = Console.ReadLine();
            Console.Write("Digite a senha: ");
            string password = Console.ReadLine();

            return new Player(name, password);
        }
    }
}

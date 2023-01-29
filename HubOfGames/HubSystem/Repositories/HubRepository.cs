using HubOfGames.BatalhaNaval.Services;
using HubOfGames.HubSystem.Views;
using HubOfGames.JogoDaVelha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.HubSystem.Repositories
{
    public class HubRepository
    {
        public static void StartHub()
        {
            int option;
            do
            {
                HubView.StarterMenu();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PlayersRepository.AddNewPlayers();
                        break;
                    case 2:
                        PlayersRepository.Login();
                        break;
                    case 3:
                        PlayersRepository.GetRanking();
                        break;
                    default:
                        break;
                }
            }
            while (option != 0);
        }

        public static void StartGames()
        {
            int option;
            do
            {
                HubView.GameMenu();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        JogoDaVelhaStart.Start();
                        break;
                    case 2:
                        StartNavalBattleSystem.StartGame();
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
            }
            while (option != 0);
        }


    }

}
       



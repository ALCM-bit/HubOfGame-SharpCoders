using HubOfGames.HubSystem.Models;
using HubOfGames.HubSystem.Views;
using HubOfGames.JsonControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.HubSystem.Repositories
{
    public class PlayersRepository
    {
        public static Player player1 { get; set; }
        public static Player player2 { get; set; }

        public static void AddNewPlayers()
        {
            List<Player> list = new List<Player>();
            list = HubOfGames.JsonControl.JsonReadWrite.JsonReader();
            char optionForContinue = 'n';
            do
            {
                Player player = PlayersView.AddPlayer();
                Player checkExistence = list.Find(playerInList => playerInList.Name == player.Name);
                if (checkExistence != null)
                {
                    Console.Clear();
                    Console.WriteLine("Usuário já existe");
                    Console.Write("Deseja tentar novamente? ('s' - Sim)/('n' - Não): ");
                    optionForContinue = char.Parse(Console.ReadLine());
                }
                else
                {
                    list.Add(player);
                    optionForContinue = 'n';
                }
            } while (optionForContinue == 's');
            JsonReadWrite.JsonWriter(list);
        }
        public static void GetRanking()
        {
            List<Player> list = new List<Player>();
            list = HubOfGames.JsonControl.JsonReadWrite.JsonReader();
            list.Sort((x, y) => y.Points.CompareTo(x.Points));
            //list.ForEach(playerInList => Console.WriteLine($"{playerInList.Name}: {playerInList.Points}\n----------\n"));
            int contRanking = 0;
            foreach (var item in list)
            {
                contRanking++;
                Console.WriteLine($"{contRanking} - {item.Name}: {item.Points}\n----------\n");
            }
            Console.WriteLine("Aperte ENTER para sair");
            Console.ReadKey();
        }
        public static void Login()
        {
            List<Player> list = new List<Player>();
            list = HubOfGames.JsonControl.JsonReadWrite.JsonReader();
            char optionForContinue = 'n';
            do
            {
                Player player = PlayersView.AddPlayer();
                Player checkPlayer = list.Find(playerInList => playerInList.Name == player.Name 
                        && playerInList.Password == player.Password);
                if (checkPlayer == null)
                {
                    Console.Clear();
                    Console.WriteLine("Jogador não encontrado ou senha inválida");
                    Console.Write("Deseja tentar novamente? ('s' - Sim)/('n' - Não): ");
                    optionForContinue = char.Parse(Console.ReadLine());
                    if (optionForContinue == 'n')
                    {
                        return;
                    }
                }
                else
                {
                    player1 = player;
                    optionForContinue = 'n';
                }

            } while (optionForContinue == 's');

            do
            {
                Player player = PlayersView.AddPlayer();
                Player checkPlayer = list.Find(playerInList => playerInList.Name == player.Name
                        && playerInList.Password == player.Password);
                if (checkPlayer == null)
                {
                    Console.Clear();
                    Console.WriteLine("Jogador não encontrado ou senha inválida");
                    Console.Write("Deseja tentar novamente? ('s' - Sim)/('n' - Não): ");
                    optionForContinue = char.Parse(Console.ReadLine());
                    if (optionForContinue == 'n')
                    {
                        return;
                    }
                }
                else
                {
                    player2 = player;
                    optionForContinue = 'n';
                }

            } while (optionForContinue == 's');

            HubRepository.StartGames();
        }
    }
}

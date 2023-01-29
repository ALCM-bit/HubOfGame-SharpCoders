using HubOfGames.BatalhaNaval.Models;
using HubOfGames.BatalhaNaval.Views;
using HubOfGames.HubSystem.Models;
using HubOfGames.HubSystem.Repositories;
using HubOfGames.HubSystem.Views;
using HubOfGames.JsonControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.BatalhaNaval.Services
{
    public class StartNavalBattleSystem
    {
        static List<Player> PlayerList = JsonReadWrite.JsonReader();

        public static void StartGame()
        {
            List<Player> list = JsonReadWrite.JsonReader();
            Player player1 = PlayersRepository.player1;
            Player player2 = PlayersRepository.player2;
            Board board = new Board(player1, player2);
            board.StartBoards();
            int hiddenShips = 0;
            while (hiddenShips < 5)
            {
                if (Board.CheckTime() == 1)
                {
                    BoardView.ShowBoard(board._ocean);
                    Console.WriteLine($"Vez de: {player1.Name}");
                    BoardView.PlaceSelection(board._ocean, board);
                    hiddenShips = Board.CheckVictory(board._ocean);
                    if (hiddenShips == 5)
                    {
                        Console.WriteLine($"Vitória de: {player1.Name}");
                        var index = list.FindIndex(x => x.Name == player1.Name);
                        list[index].Points++;
                        JsonReadWrite.JsonWriter(list);
                    }
                }
                else
                {
                    BoardView.ShowBoard(board._ocean2);
                    Console.WriteLine($"Vez de: {player2.Name}");
                    BoardView.PlaceSelection(board._ocean2, board);
                    hiddenShips = Board.CheckVictory(board._ocean2);
                    if (hiddenShips == 5)
                    {
                        Console.WriteLine($"Vitória de: {player2.Name}");
                        var index = list.FindIndex(x => x.Name == player2.Name);
                        list[index].Points++;
                        JsonReadWrite.JsonWriter(list);
                    }
                }
            }

        }

    }
}

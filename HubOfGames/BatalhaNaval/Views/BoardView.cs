using HubOfGames.BatalhaNaval.Models;
using HubOfGames.JogoDaVelha.JogoDaVelha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.BatalhaNaval.Views
{
    public class BoardView
    {
        public static void ShowBoard(Piece[,] ocean)
        {
            Console.Clear();
            for (int i = 0; i < 8; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($" | {ocean[i, j].Simbol} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("    0     1     2     3     4     5     6     7");
        }

        public static bool PlaceSelection(Piece[,] ocean, Board board)
        {
            Console.Write("Digite a Linha: ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Digite a Coluna: ");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");

            return board.SelectPiece(ocean, line, column);
        }
    }
}

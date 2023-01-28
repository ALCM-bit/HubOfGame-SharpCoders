using HubOfGames.HubSystem.Models;
using HubOfGames.JogoDaVelha.JogoDaVelha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.JogoDaVelha
{
    public class JogoDaVelhaStart
    {
        public static void Start()
        {
            Board board = new Board();
            
            while (board.checkForVictory() != 1)
            {
                board.ShowBoard();
                char place = char.Parse(Console.ReadLine());
                board.PlacePiece(place);
            }
        }
    }
}

using HubOfGames.HubSystem.Models;
using HubOfGames.HubSystem.Repositories;
using HubOfGames.JsonControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.JogoDaVelha.JogoDaVelha.Models
{
    public class Board
    {
        static List<Player> list = JsonReadWrite.JsonReader();
        public char piece = 'X';
        public static int times = 0;
        private char[] positions =
            { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private Player player1;
        private Player player2;
        public Board()
        {
            this.player1 = PlayersRepository.player1;
            this.player2 = PlayersRepository.player2;
        }

        public void ShowBoard()
        {
            Console.Clear();
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"|{positions[j]}|");
            }
            Console.WriteLine();
            for (int j = 3; j < 6; j++)
            {
                Console.Write($"|{positions[j]}|");
            }
            Console.WriteLine();
            for (int j = 6; j < 9; j++)
            {
                Console.Write($"|{positions[j]}|");
            }
            Console.WriteLine();
            Console.Write("Escolha a posição da peça: ");
        }
        public bool PlacePiece(char positionChosed)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                if (positions[i] == positionChosed)
                {
                    if (times % 2 == 0)
                    {
                        piece = 'X';
                    }
                    else
                    {
                        piece = 'O';
                    }
                    positions[i] = piece;
                    times++;
                    return true;
                }

                if (times >= 5)
                    checkForVictory();
            }
            Console.WriteLine("Posição Inválida");
            Console.ReadKey();
            return false;
        }
        //public void ClearBoard()
        //{
        //    char[] chars = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //    chars.CopyTo(positions, 0);
        //}

        public int checkForVictory()
        {
            if (CheckHorizontal() == true || CheckDiagonal() == true || CheckVertical() == true)
            {
                if (piece == 'X')
                {
                    Console.WriteLine($"Vitória de: {player1.Name}");
                    player1.Points++;
                    list.Add(player1);
                    JsonReadWrite.JsonWriter(list);
                    Console.ReadKey();
                    return 1;

                }
                else
                {
                    Console.WriteLine($"Vitória de: {player2.Name}");
                    player2.Points++;
                    list.Add(player2);
                    JsonReadWrite.JsonWriter(list);
                    Console.ReadKey();
                    return 1;

                }
                return 0;
            }
            else
            {
                int numberOfSpaces = 0;
                foreach (var item in positions)
                {
                    if (item != 'X' && item != 'O')
                        numberOfSpaces++;
                }
                if (numberOfSpaces == 0)
                {
                    Console.WriteLine("EMPATE");
                    Console.ReadKey();
                    return 1;
                }
                return 0;
            }


        }
        private bool CheckHorizontal()
        {
            bool vitoriaLinha1 = positions[0] == positions[1] && positions[0] == positions[2];
            bool vitoriaLinha2 = positions[3] == positions[4] && positions[3] == positions[5];
            bool vitoriaLinha3 = positions[6] == positions[7] && positions[6] == positions[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;

        }
        private bool CheckVertical()
        {
            bool victoryLine1 = positions[0] == positions[3] && positions[0] == positions[6];
            bool victoryLine2 = positions[1] == positions[4] && positions[1] == positions[7];
            bool victoryLine3 = positions[2] == positions[5] && positions[2] == positions[8];

            return victoryLine1 || victoryLine2 || victoryLine3;

        }
        private bool CheckDiagonal()
        {
            bool victoryLine1 = positions[0] == positions[4] && positions[0] == positions[8];
            bool victoryLine2 = positions[2] == positions[4] && positions[2] == positions[6];


            return victoryLine1 || victoryLine1;

        }
    }
}

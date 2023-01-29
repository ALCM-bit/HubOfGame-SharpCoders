using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.BatalhaNaval.Models
{
    public abstract class Piece
    {
        public char Simbol { get; set; }
        public bool Hidden { get; set; }
        public int Line { get; private set; }
        public int Column { get; private set; }

        public Piece(int line, int column)
        {
            Hidden = false;
            Simbol = '~';
            Line = line;
            Column = column;
        }


    }
}

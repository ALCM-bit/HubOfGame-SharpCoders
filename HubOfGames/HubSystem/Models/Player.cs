using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubOfGames.HubSystem.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }

        public Player(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}

using HubOfGames.HubSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HubOfGames.JsonControl
{
    public class JsonReadWrite
    {
        static readonly string _fileName = @"Players.json";
        public static void JsonWriter(List<Player> player)
        {
            string jsonString = JsonSerializer.Serialize(player);
            File.WriteAllText(_fileName, jsonString);
        }

        public static List<Player> JsonReader()
        {
            string jsonString = File.ReadAllText(_fileName);

            if (!String.IsNullOrEmpty(jsonString))
            {
                List<Player> allPlayers = JsonSerializer.Deserialize<List<Player>>(jsonString);
                //allPlayers.ForEach(player => allPlayers.Add(player));

                return allPlayers;
            }

            Console.WriteLine("Problema ao ler base de dados");
            return null;
        }
    }
}

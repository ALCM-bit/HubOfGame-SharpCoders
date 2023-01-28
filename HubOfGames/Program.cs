// See https://aka.ms/new-console-template for more information
using HubOfGames.HubSystem.Models;
using HubOfGames.HubSystem.Repositories;

Console.WriteLine("Hello, World!");

List<Player> list = new List<Player>();

list = HubOfGames.JsonControl.JsonReadWrite.JsonReader();

list.ForEach(e => Console.WriteLine(e.Name));

HubRepository.StartHub();
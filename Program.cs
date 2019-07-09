using System;
using System.Collections.Generic;
using blockbuster.Models;

namespace blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Store b2319 = new Store("Monsters Inc. Local Store");
            DvD jp = new DvD("Jurassic Park", "Dinosaurs kill people, its great fun", 1993, 1, new List<Languages>() { Languages.en, Languages.sp });
            DvD jp2 = new DvD("Jurassic Park 2", "More Dinosaurs kill people, its great fun", 1995, 1, new List<Languages>() { Languages.en, Languages.sp });
            DvD jp3 = new DvD("Jurassic Park 3", "Even More Dinosaurs kill people, its great fun", 1998, 1, new List<Languages>() { Languages.en, Languages.sp });
            Actor jeffGoldblum = new Actor("Jeff Goldblum");
            jp.AddActor(jeffGoldblum);
            VHS id = new VHS("Independence Day", "In the epic adventure film `Independence Day,' strange phenomena surface around the globe. The skies ignite. Terror races through the world's major cities. As these extraordinary events unfold, it becomes increasingly clear that a force of incredible magnitude has arrived. Its mission: total annihilation over the Fourth of July weekend. The last hope to stop the destruction is an unlikely group of people united by fate and unimaginable circumstances.", 1996);
            id.AddActor(jeffGoldblum);
            b2319.AddMovie(jp);
            b2319.AddMovie(jp2);
            b2319.AddMovie(jp3);
            b2319.AddMovie(id);

            string title = @"
  ____  _            _    _               _            
 |  _ \| |          | |  | |             | |           
 | |_) | | ___   ___| | _| |__  _   _ ___| |_ ___ _ __ 
 |  _ <| |/ _ \ / __| |/ / '_ \| | | / __| __/ _ \ '__|
 | |_) | | (_) | (__|   <| |_) | |_| \__ \ ||  __/ |   
 |____/|_|\___/ \___|_|\_\_.__/ \__,_|___/\__\___|_|   
            ";
            bool available = true;
            bool inStore = true;
            System.Console.WriteLine(title);
            while (inStore)
            {
                b2319.Print(available);
                string choice = Console.ReadLine().ToLower();
                Console.Clear();
                System.Console.WriteLine(title);
                switch (choice)
                {
                    case "return":
                        available = false;
                        break;
                    case "rent":
                        available = true;
                        break;
                    default:
                        b2319.ExchangeMovie(choice, available);
                        break;
                }

            }
        }
    }
}

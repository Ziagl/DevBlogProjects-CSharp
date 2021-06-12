using OneOf;
using System;
using System.Collections.Generic;

namespace Spracherweiterungen
{
    public class OneOfSample
    {
        public void Run()
        {
            var list = new List<OneOf<Human, Orc, Dungeon>>();

            // create some objects
            for (int i = 0; i < 10; ++i)
            {
                list.Add(CreateRandomDnDObject());
            }

            // do something with this objects
            foreach(var element in list)
            {
                Console.WriteLine(element.ToString());
            }
        }

        private OneOf<Human, Orc, Dungeon> CreateRandomDnDObject()
        {
            var rand = new Random();
            switch(rand.Next(0,3))
            {
                case 0:
                    var human = new Human();
                    human.Title = "Sir";
                    human.Firstname = "Roderic";
                    human.Lastname = "The Brave";
                    human.Whisdom = rand.Next(0, 100);
                    human.Charisma = rand.Next(0, 100);
                    return human;
                case 1:
                    var orc = new Orc();
                    orc.Name = "Gork";
                    orc.Strength = rand.Next(0, 100);
                    orc.Honor = rand.Next(0, 100);
                    orc.Kills = rand.Next(0, 10);
                    return orc;
                default:
                    var dungeon = new Dungeon();
                    dungeon.Story = "One deadly dungeon was discovered once and ...";
                    dungeon.Levels = rand.Next(1,10);
                    dungeon.Monsters = rand.Next(10, 100);
                    dungeon.Difficulty = rand.Next(0, 100);
                    return dungeon;
            }
        }
    }

    class Orc
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Honor { get; set; }
        public int Kills { get; set; }
    }

    class Human
    {
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Whisdom { get; set; }
        public int Charisma { get; set; }
    }

    class Dungeon
    {
        public string Story { get; set; }
        public int Levels { get; set; }
        public int Monsters { get; set; }
        public int Difficulty { get; set; }
    }
}

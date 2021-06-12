using Optional;
using System;

namespace Spracherweiterungen
{
    public class OptionalSample
    {
        public void Run()
        {
            // try to get a quest
            for(int i = 0; i < 10; ++i)
            {
                var quest = GetQuest();
                quest.Match(
                    some: x => Console.WriteLine($"NPC {i} has quest: {x.Title}"),
                    none: () => Console.WriteLine($"NPC {i} has no quest.")
                );
            }
        }

        private Option<Quest> GetQuest()
        {
            var rand = new Random();

            if(rand.Next(0,2) == 0)
            {
                var quest = new Quest();
                quest.Title = "The Red Dragon";
                quest.Text = "Kill the red dragon on the hills of dead.";
                quest.RewardGold = 5000;
                return Option.Some<Quest>(quest);
            }
            else
            {
                return Option.None<Quest>();
            }
        }

        class Quest
        {
            public string Title { get; set; }
            public string Text { get; set; }
            public int RewardGold { get; set; }
        }
    }
}

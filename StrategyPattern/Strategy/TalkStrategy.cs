using System;

namespace StrategyPattern
{
    public class TalkStrategy : IStrategy
    {
        private string victim;
        public void Action()
        {
            Console.WriteLine($"You engaged in a talk with {victim}");
        }

        public void PokePerson(string personName)
        {
            victim = personName;
            Console.WriteLine($"You walk up to {personName} and poke em");
        }
    }
}
}
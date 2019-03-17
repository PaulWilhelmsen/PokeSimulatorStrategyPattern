using System;

namespace StrategyPattern
{
    public class RunStrategy : IStrategy
    {
        private string victim;
        public void Action()
        {
            Console.WriteLine($"You ran away from {victim} snickering like a little snotty girl");
        }

        public void PokePerson(string personName)
        {
            victim = personName;
            Console.WriteLine($"You sneak up on {personName} and POKE em");
        }
    }
}
}
using System;

namespace StrategyPattern
{
    class Program
    {
        public enum PokeAnd
        {
            Run,
            Talk
        };

        public class PokeSimulator
        {
            public IStrategy strategy;

            public void SetPokeStrategy(PokeAnd pokeAnd)
            {
                switch (pokeAnd)
                {
                    case PokeAnd.Run:
                        strategy = new RunStrategy();
                        break;
                    case PokeAnd.Talk:
                        strategy = new TalkStrategy();
                        break;
                }
            }

            public void Poke(string victimName)
            {
                strategy.PokePerson(victimName);
                strategy.Action();
            }

            public interface IStrategy
            {
                void PokePerson(string personName);
                void Action();
            }

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

            static void Main(string[] args)
            {
                var poke = new PokeSimulator();
                poke.SetPokeStrategy(PokeAnd.Run);
                poke.Poke("Tpg");
                Console.WriteLine("");

                poke.SetPokeStrategy(PokeAnd.Talk);
                poke.Poke("Caroline");
                Console.ReadKey();
            }
        }
    }
}
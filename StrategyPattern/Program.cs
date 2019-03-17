using System;

namespace StrategyPattern
{
    partial class Program
    {
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
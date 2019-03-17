namespace StrategyPattern
{
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
    }
}

using wServer.realm.entities.player;

namespace wServer.realm
{
    public class Inflation
    {
        float max,min;
        public Inflation()
        {
            // TODO: Actually implement real inflation based on the real averidge wealth.
            min = new wRandom().Next(10000, 20000);
            max = new wRandom().Next(80000, 100000);
        }
        public float Get(Player p)
        {
            int wealth = (p.CurrentFame + p.Fame + p.Tokens + p.Credits) / 3;
            if (wealth < min)
                return 1;
            if (wealth > max)
                return max / min;

            return wealth / min;
        }
    }
}

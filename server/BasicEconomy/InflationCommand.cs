#region

using wServer.realm;
using wServer.realm.commands;
using wServer.realm.entities;
using wServer.realm.entities.player;

#endregion

namespace BasicEconomy
{
    public class InflationCommand : Command
    {
        public InflationCommand() : base("inf", 0)
        {
        }

        protected override bool Process(Player player, RealmTime time, string[] args)
        {
            int r;
            if (args.Length == 1 && int.TryParse(args[0], out r))
            {
                player.SendInfo("Calculated price: " + (int)(MerchantLists.inf.Get(player) * r));
                return true;
            }
            player.SendInfo($"Your inflation: {(int)(MerchantLists.inf.Get(player) * 100)}% ({(int)(MerchantLists.inf.Get(player))}x)");
            return true;
        }
    }
}

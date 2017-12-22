#region

using db;
using System;
using System.Collections.Generic;
using System.Linq;
using wServer.realm;
using wServer.realm.commands;
using wServer.realm.entities;
using wServer.realm.entities.player;

#endregion


namespace BasicEconomy
{
    public class SellCommand : Command
    {
        public SellCommand()
            : base("sell", 0)
        {
        }

        protected override bool Process(Player player, RealmTime time, string[] args)
        {
            if (args.Length == 0)
            {
                player.SendHelp("Usage: /sell <name>");
                return false;
            }
            string name = string.Join(" ", args.ToArray()).Trim();
            ushort objType;
            Dictionary<string, ushort> icdatas = new Dictionary<string, ushort>(player.Manager.GameData.IdToObjectType,
                StringComparer.OrdinalIgnoreCase);
            if (!icdatas.TryGetValue(name, out objType))
            {
                player.SendError("Unknown type!");
                return false;
            }
            for (int i = 0; i < player.Inventory.Length; i++)
            {
                if (player.Inventory[i]?.DisplayId == player.Manager.GameData.Items[objType].DisplayId)
                {
                    if (MerchantLists.prices.ContainsKey(objType))
                    {
                        var db = new Database();
                        switch (MerchantLists.prices[objType].Item2)
                        {
                            case CurrencyType.Fame:
                                db.UpdateFame(player.Client.Account, MerchantLists.prices[objType].Item1 / 2);
                                break;
                            case CurrencyType.Gold:
                                db.UpdateCredit(player.Client.Account, MerchantLists.prices[objType].Item1 / 2);
                                break;
                            default:
                                player.SendError($"Cannot sell item for {MerchantLists.prices[objType].Item2}!");
                                return false;
                        }
                        player.Inventory[i] = null;
                        player.UpdateCount++;
                        player.SaveToCharacter();
                        player.SendInfo($"Sold \"{player.Manager.GameData.Items[objType].DisplayId}\" for {MerchantLists.prices[objType].Item1 / 2} {MerchantLists.prices[objType].Item2}");
                        return true;
                    }
                    else
                    {
                        player.SendError("Item not sellable!");
                        return false;
                    }
                }
            }
            player.SendError("Item not found!");
            return false;
        }
    }
}

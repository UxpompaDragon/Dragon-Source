using wServer.realm.entities.player;

namespace wServer.realm
{
    public static class Ranks
    {
        public static string GetRanked(this Player p)
        {
            // Thanks to that guy who commented on my video i implemented this
            string prefix = "";
            switch (p.Client.Account.Rank)
            {
                case 0:
                    prefix = "#[Player]";
                    break;
                case 1:
                    prefix = "#[VIP]";
                    break;
                case 2:
                    prefix = "#[Vip+]";
                    break;
                case 3:
                    prefix = "#[Donator]";
                    break;
                case 4:
                    prefix = "#[Donator+]";
                    break;
                case 5:
                    prefix = "@[Helper]";
                    break;
                case 6:
                    prefix = "@[Moderator]";
                    break;
                case 7:
                    prefix = "@[Administrator]";
                    break;
                case 8:
                    prefix = "@[Developer]";
                    break;
                case 9:
                    prefix = "@[Co-Owner]";
                    break;
                case 10:
                    prefix = "@[Owner]";
                    break;
                default:
                    prefix = "#[Hacker]";
                    break;
            }
            return prefix + "#" + p.Name;
        }
    }
}

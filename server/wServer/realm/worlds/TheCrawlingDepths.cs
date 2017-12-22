namespace wServer.realm.worlds
{
    public class TheCrawlingDepths : World
    {
        public TheCrawlingDepths()
        {
            Name = "The Crawling Depths";
            ClientWorldName = "epicspiderDen.The_Crawling_Depths";
            Background = 0;
            Difficulty = 5;
            AllowTeleport = true;
            Dungeon = true;
        }

        public override bool NeedsPortalKey => true;

        protected override void Init()
        {
            LoadMap("wServer.realm.worlds.maps.TheCrawlingDepths.jm", MapType.Json);
        }
    }
}
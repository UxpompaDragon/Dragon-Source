﻿namespace wServer.networking.svrPackets
{
    public class RemovePetFromListPacket : ServerPacket
    {
        public int PetId { get; set; }

        public override PacketID ID
        {
            get { return PacketID.REMOVEPET; }
        }

        public override Packet CreateInstance()
        {
            return new RemovePetFromListPacket();
        }

        protected override void Read(Client client, NReader rdr)
        {
            PetId = rdr.ReadInt32();
        }

        protected override void Write(Client client, NWriter wtr)
        {
            wtr.Write(PetId);
        }
    }
}

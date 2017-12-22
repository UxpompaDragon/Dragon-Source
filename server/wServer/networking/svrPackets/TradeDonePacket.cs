﻿namespace wServer.networking.svrPackets
{
    public class TradeDonePacket : ServerPacket
    {
        public int Result { get; set; }
        public string Message { get; set; }

        public override PacketID ID
        {
            get { return PacketID.TRADEDONE; }
        }

        public override Packet CreateInstance()
        {
            return new TradeDonePacket();
        }

        protected override void Read(Client psr, NReader rdr)
        {
            Result = rdr.ReadInt32();
            Message = rdr.ReadUTF();
        }

        protected override void Write(Client psr, NWriter wtr)
        {
            wtr.Write(Result);
            wtr.WriteUTF(Message);
        }
    }
}
#region

using System;
using System.Collections.Generic;
using wServer.networking.cliPackets;
using FailurePacket = wServer.networking.svrPackets.FailurePacket;
using wServer.realm;

#endregion

namespace wServer.networking
{
    internal interface IPacketHandler
    {
        PacketID ID { get; }
        void Handle(Client client, ClientPacket packet);
    }

    internal abstract class PacketHandlerBase<T> : IPacketHandler where T : ClientPacket
    {
        private Client client;

        public abstract PacketID ID { get; }

        public void Handle(Client client, ClientPacket packet)
        {
            this.client = client;
            HandlePacket(client, (T) packet);
        }

        public RealmManager Manager { get { return client.Manager; } }
        public Client Client { get { return client; } }

        protected abstract void HandlePacket(Client client, T packet);

        protected void SendFailure(string text)
        {
            client.SendPacket(new FailurePacket {ErrorId = 0, ErrorDescription = text});
        }
    }

    internal class PacketHandlers
    {
        public static Dictionary<PacketID, IPacketHandler> Handlers = new Dictionary<PacketID, IPacketHandler>();

        static PacketHandlers()
        {
            foreach (Type i in typeof (Packet).Assembly.GetTypes())
            {
                if (typeof (IPacketHandler).IsAssignableFrom(i) &&
                    !i.IsAbstract && !i.IsInterface)
                {
                    IPacketHandler pkt = (IPacketHandler) Activator.CreateInstance(i);
                    Handlers.Add(pkt.ID, pkt);
                }
            }
        }
    }
}
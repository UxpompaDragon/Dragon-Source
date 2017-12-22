using Rotux.Classes;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Rotux.Problems
{
    class Ports : Problem
    {
        ProcManager pkill = new ProcManager();
        public Ports(ProgressBar prog) : base(prog)
        {

        }

        public override bool Check()
        {
            return PortInUse(80) || PortInUse(3306) || PortInUse(2050) || PortInUse(843);
        }

        public override void Solve()
        {
            CheckKillPort(80);
            CheckKillPort(3306);
            CheckKillPort(2050);
            CheckKillPort(843);
        }

        private bool CheckKillPort(int port)
        {
            if (PortInUse(port))
            {
                pkill.KillByPort(port);
            }
            return PortInUse(port);
        }

        private bool PortInUse(int port)
        {
            bool inUse = false;

            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();


            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                if (endPoint.Port == port)
                {
                    inUse = true;
                    break;
                }
            }
            return inUse;
        }
    }
}

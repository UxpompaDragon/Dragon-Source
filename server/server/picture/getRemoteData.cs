#region

using System;
using System.Linq;

#endregion

namespace server.picture
{
    internal class getRemoteData : RequestHandler
    {
        protected override void HandleRequest()
        {
            WriteLine(Program.GameData.AdditionXml.Aggregate(String.Empty, (current, i) => current + i));
        }
    }
}
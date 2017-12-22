#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using wServer.realm.entities.player;

#endregion

namespace wServer.realm.commands
{
    public abstract class Command
    {

        public Command(string name, int permLevel = 0)
        {
            CommandName = name;
            PermissionLevel = permLevel;
        }

        public string CommandName { get; private set; }
        public int PermissionLevel { get; private set; }

        protected abstract bool Process(Player player, RealmTime time, string[] args);

        private static int GetPermissionLevel(Player player)
        {
            return player.Client.Account.Rank;
        }


        public bool HasPermission(Player player)
        {
            if (GetPermissionLevel(player) < PermissionLevel)
                return false;
            return true;
        }

        public bool Execute(Player player, RealmTime time, string args)
        {
            if (!HasPermission(player))
            {
                player.SendError("No permission!");
                return false;
            }

            try
            {
                string[] a = args.Split(' ');
                return Process(player, time, a);
            }
            catch (Exception ex)
            {
				Console.WriteLine("Error when executing the command: {0}", ex);
                player.SendError("Error when executing the command.");
                return false;
            }
        }
    }

    public static class CommandList
    {
        public static Dictionary<string, Command> cmds;
        public static void LoadDLL(string DLL)
        {
            int count = 0;
            try
            {
                Assembly asm = Assembly.LoadFrom(DLL);
                Type t = typeof(Command);
                foreach (Type i in asm.GetTypes())
                    if (t.IsAssignableFrom(i) && i != t)
                    {
                        Command instance = (Command)Activator.CreateInstance(i);
                        cmds.Add(instance.CommandName, instance);
                        count++;
                    }
                Console.WriteLine($"{count} commands loaded from \"{Path.GetFileName(DLL)}\".");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured while loading commands from \"{Path.GetFileName(DLL)}\": {e}");
            }

        }

    }
    public class CommandManager
    {
        private RealmManager manager;

        private string[] blacklist =
        {
            "BouncyCastle.Crypto.dll".ToLower(),
            "BouncyCastle.dll".ToLower(),
            "db.dll".ToLower(),
            "DungeonGen.dll".ToLower(),
            "GoogleMaps.LocationServices.dll".ToLower(),
            "Ionic.ZLib.dll".ToLower(),
            "MailKit.dll".ToLower(),
            "MimeKit.dll".ToLower(),
            "MySql.Data.dll".ToLower(),
            "Newtonsoft.Json.dll".ToLower(),
            "RotMG.Common.dll".ToLower(),
            "zlib.net.dll".ToLower()
        };

        public CommandManager(RealmManager manager)
        {
            this.manager = manager;
            CommandList.cmds = new Dictionary<string, Command>(StringComparer.InvariantCultureIgnoreCase);
            Type t = typeof(Command);
            foreach (Type i in t.Assembly.GetTypes())
                if (t.IsAssignableFrom(i) && i != t)
                {
                    Command instance = (Command)Activator.CreateInstance(i);
                    CommandList.cmds.Add(instance.CommandName, instance);
                }
            foreach (string s in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.dll"))
            {
                if (!blacklist.Contains(Path.GetFileName(s).ToLower()))
                {
                    CommandList.LoadDLL(s);
                }
            }
        }

        public IDictionary<string, Command> Commands
        {
            get { return CommandList.cmds; }
        }

        public bool Execute(Player player, RealmTime time, string text)
        {
            int index = text.IndexOf(' ');
            string cmd = text.Substring(1, index == -1 ? text.Length - 1 : index - 1);
            string args = index == -1 ? "" : text.Substring(index + 1);

            Command command;
            if (!CommandList.cmds.TryGetValue(cmd, out command))
            {
                player.SendError("Unknown command!");
                return false;
            }
			Console.WriteLine("[Command] <{0}> {1}", player.Name, text);
            return command.Execute(player, time, args);
        }
    }
}
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace WinHaste
{
    static class Haste
    {
        internal static string HasteURL = "Error";
        private static readonly Regex _HasteKeyRegex = new Regex(@"{""key"":""(?<key>[a-z].*)""}", RegexOptions.Compiled);

        internal static void Run(params string[] args)
        {
            var parameters = new Parameters(args);
            var parseResult = parameters.Parse();
            if (parseResult != Parameters.ParseResult.Success)
            {
                Console.WriteLine(parameters.Usage);
                Console.WriteLine(Environment.NewLine + "ERROR: " + parseResult);
                return;
            }

            string haste;
            if (!String.IsNullOrEmpty(parameters.Filename))
            {
                haste = File.ReadAllText(parameters.Filename);
            }
            else
            {
                Console.WriteLine("Invalid parameters.");
                return;
            }

            using (var client = new WebClient())
            {
                var response = client.UploadString(parameters.Url + "/documents", haste);
                var match = _HasteKeyRegex.Match(response);

                if (!match.Success)
                {
                    Console.WriteLine(response);
                    return;
                }

                string hasteUrl = String.Concat(parameters.Url, "/", match.Groups["key"]);

                HasteURL = hasteUrl;
            }
        }

        private static bool IsInputPiped()
        {
            try
            {
                var tmp = Console.KeyAvailable;
                return false;
            }
            catch (InvalidOperationException)
            {
                return true;
            }
        }
    }
    internal class Parameters
    {
        public enum ParseResult
        {
            Success,
            BadUrl,
            BadFilename,
            BadArgs
        }

        private const string DEFAULT_URL = "https://hastebin.com";

        private const string USAGE =
@"Usage: WinHaste.exe [service url] [file to haste]

Defaults:
			[service url] = https://hastebin.com

			When [file to haste] is omitted, haste.exe reads from
			standard input until an end-of-file character (^Z) is
			encountered.";
        private readonly string[] _args;
        public Parameters(string[] args)
        {
            _args = args;
        }
        public string Usage { get { return USAGE; } }
        public string Url { get; private set; }
        public string Filename { get; private set; }
        public ParseResult Parse()
        {
            if (_args.Length == 0)
            {
                Url = DEFAULT_URL;
                return ParseResult.Success;
            }
            if (_args.Length > 2)
                return ParseResult.BadArgs;
            if (_args.Length > 0)
            {
                Uri tmpUri;
                if (!Uri.TryCreate(_args[0], UriKind.Absolute, out tmpUri))
                    return ParseResult.BadUrl;
                if (tmpUri.Scheme != "http" && tmpUri.Scheme != "https")
                    return ParseResult.BadUrl;
                Url = _args[0].TrimEnd('/');
            }
            if (_args.Length > 1)
            {
                if (!File.Exists(_args[1]))
                    return ParseResult.BadFilename;
                Filename = _args[1];
            }
            return ParseResult.Success;
        }
    }
}

using System.IO;

namespace BehaviorConverter
{
    public static class StreamUtils
    {
        public static Stream StringToStream(string text)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(text);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}

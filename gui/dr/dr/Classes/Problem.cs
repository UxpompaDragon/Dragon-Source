using System.Windows.Forms;

namespace Rotux.Classes
{
    public abstract class Problem
    {
        public static string Title = "An error was found";
        public static string Description = "The troubleshooter didn't exit correctly!";
        internal ProgressBar Progress;
        internal Problem(ProgressBar prog)
        {
            Progress = prog;
        }
        public abstract void Solve();
        public abstract bool Check();
    }
}

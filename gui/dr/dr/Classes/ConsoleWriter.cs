using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Rotux.Classes
{
    internal class ControlWriter : TextWriter
    {
        private Control control;
        private Control parent;
        public ControlWriter(Control control, Control parent)
        {
            this.control = control;
            this.parent = parent;
        }

        public override void Write(char value)
        {
            parent.BeginInvoke(new Action(() => control.Text += value));
        }

        public override void Write(string value)
        {
            parent.BeginInvoke(new Action(() => control.Text += value));
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}

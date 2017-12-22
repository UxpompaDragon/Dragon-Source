using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Rotux.Forms
{
    partial class ExceptionWindow : Form
    {
        public ExceptionWindow(string e)
        {

            InitializeComponent();
            errortext.Text = e;
        }

        private void setupbtn_Click(object sender, System.EventArgs e)
        {
            Process.Start(Assembly.GetExecutingAssembly().Location, "setup");
            Close();
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}

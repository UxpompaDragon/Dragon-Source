using Rotux.Classes;
using System;
using System.Windows.Forms;

namespace Rotux.Forms
{
    internal partial class ChangeParameter : Form
    {
        Settings s;
        public ChangeParameter(Settings s)
        {
            this.s = s;
            InitializeComponent();
        }

        private void changerankbtn_Click(object sender, EventArgs e)
        {
            UpdateDatabase.RunQuery(s, string.Format("UPDATE rotmgprod.accounts SET `{2}`={0} WHERE `uuid` = '{1}'", Parse(value.Text), email.Text, key.Text).Split(';'));
            Close();
        }

        string Parse(string input)
        {
            int res = 0;
            if (int.TryParse(input,out res))
            {
                return input;
            } else
            {
                return "'" + input + "'";
            }
        }
    }
}

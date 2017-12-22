using Rotux.Classes;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Rotux.Forms
{
    public partial class Troubleshoot : Form
    {
        ProblemFinder problem;
        internal Troubleshoot()
        {
            InitializeComponent();
        }

        private void Troubleshoot_Load(object sender, EventArgs e)
        {
            new Thread(Fix).Start();
        }

        private void Fix()
        {
            problem = new ProblemFinder(detecting_label, problem_label, progress);
            Pages.Invoke(new Action(() => Pages.TabIndex = 0));
            ProblemResult res = ProblemResult.OK;
            problem.Init();
            while (res != ProblemResult.NoMoreProblems)
            {
                res = problem.Solve();

                if (res == ProblemResult.Fail)
                {
                    Problem.Description = "A problem couldn't be fixed.";
                    Next();
                    return;
                }
                Thread.Sleep(100);
            }
            Problem.Title = "All problems were fixed";
            Problem.Description = "All the problems that were detected are currently fixed.";
            Next();
        }

        private void Next()
        {
            detecting_label.Invoke(new Action(() => detecting_label.Text = "Finished"));
            desc.Invoke(new Action(() => desc.Text = Problem.Description));
            title.Invoke(new Action(() =>title.Text = Problem.Title));
            Pages.Invoke(new Action(() => Pages.SelectedIndex = (Pages.SelectedIndex + 1 < Pages.TabCount) ?
                                         Pages.SelectedIndex + 1 : Pages.SelectedIndex));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace ITMO.CourseCS.FormsApp.Ex05._2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextForm newNext = new NextForm();
            newNext.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

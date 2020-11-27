using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITMO.CourseCS.FormsApp.Ex05._2
{
    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();
        }

        private void NextForm_Load(object sender, EventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, this.Height / 2), new Point(this.Width / 2, 0), new Point(this.Width, this.Height / 2), new Point( this.Width / 2,this.Height) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

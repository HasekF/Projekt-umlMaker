using System.Windows;
using umlMaker.Objects;
using umlMaker.SubObjects;

namespace umlMaker
{
    public partial class Form1 : Form
    {
        WorkSpace workSpace;
        public Form1()
        {
            InitializeComponent();
            workSpace = new WorkSpace();
            WorkSpace.WindowHeight = pictureBox1.Height;
            WorkSpace.WindowWidth = pictureBox1.Width;
            pictureBox1.Refresh();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            workSpace.OpenEditor();
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            workSpace.MovingAction(e);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            workSpace.Move(e);
            WorkSpace.WindowHeight = pictureBox1.Height;
            WorkSpace.WindowWidth = pictureBox1.Width;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            workSpace.Click(e);
            pictureBox1.Refresh();
            pictureBox1.Refresh();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            workSpace.DrawAll(e.Graphics);
        }
    }
}
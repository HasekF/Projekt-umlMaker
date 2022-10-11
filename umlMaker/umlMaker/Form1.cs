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
            workSpace = new WorkSpace(pictureBox1.CreateGraphics());
            WorkSpace.WindowHeight = pictureBox1.Height;
            WorkSpace.WindowWidth = pictureBox1.Width;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            workSpace.OpenEditor();
            workSpace.DrawAll();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            workSpace.MovingAction(e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            workSpace.Move(e);
            WorkSpace.WindowHeight = pictureBox1.Height;
            WorkSpace.WindowWidth = pictureBox1.Width;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            workSpace.Click(e);
            workSpace.DrawAll();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            WorkSpace.WindowHeight = pictureBox1.Height;
            WorkSpace.WindowWidth = pictureBox1.Width;
            workSpace.DrawAll();
        }
    }
}
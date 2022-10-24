using System.Windows;
using umlMaker.Buttons;
using umlMaker.Objects;
using umlMaker.SubObjects;

namespace umlMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplicationGetter.WindowHeight = pictureBox1.Height;
            ApplicationGetter.WindowWidth = pictureBox1.Width;
            pictureBox1.Refresh();
            ApplicationGetter.PictureBox = pictureBox1;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            ApplicationGetter.WorkSpace.OpenEditor();
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ApplicationGetter.WorkSpace.MovingAction(e);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ApplicationGetter.WorkSpace.Move(e);
            ApplicationGetter.WindowHeight = pictureBox1.Height;
            ApplicationGetter.WindowWidth = pictureBox1.Width;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ApplicationGetter.WorkSpace.Click(e);
            pictureBox1.Refresh();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ApplicationGetter.WorkSpace.DrawAll(e.Graphics);
        }
    }
}
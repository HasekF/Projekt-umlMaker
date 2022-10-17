using System.Windows;
using umlMaker.Objects;
using umlMaker.SubObjects;

namespace umlMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.WindowHeight = pictureBox1.Height;
            Application.WindowWidth = pictureBox1.Width;
            pictureBox1.Refresh();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Application.WorkSpace.OpenEditor();
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Application.WorkSpace.MovingAction(e);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Application.WorkSpace.Move(e);
            Application.WindowHeight = pictureBox1.Height;
            Application.WindowWidth = pictureBox1.Width;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Application.WorkSpace.Click(e);
            pictureBox1.Refresh();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Application.WorkSpace.DrawAll(e.Graphics);
        }
    }
}
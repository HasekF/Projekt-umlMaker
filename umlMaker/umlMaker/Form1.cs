using System.Windows;


namespace umlMaker
{
    public partial class Form1 : Form
    {
        WorkSpace workSpace;
        public Form1()
        {
            InitializeComponent();
            workSpace = new WorkSpace(pictureBox1.CreateGraphics());
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            workSpace.OpenEditor();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            workSpace.MovingAction(e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            workSpace.Move(e);
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            WorkSpace.WindowHeight = pictureBox1.Height;
            WorkSpace.WindowWidth = pictureBox1.Width;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            workSpace.Click(e);
        }

    }
}
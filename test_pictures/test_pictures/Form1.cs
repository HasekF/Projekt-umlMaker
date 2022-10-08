using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;

namespace test_pictures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\frant\Desktop\6711405.png");
            Bitmap bitmap = new Bitmap(img, new Size(50, 50));
            Graphics g = pictureBox1.CreateGraphics();
            g.FillEllipse(Brushes.Red, 50, 50, 60, 60);
            g.DrawImage(bitmap, 50, 50);
        }
    }
}
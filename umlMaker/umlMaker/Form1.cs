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
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            workSpace.OpenEditor();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //workSpace.MovingAction(e);
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
            //workSpace.Click(e);
            Class cl = new Class() { X = 500, Y = 500, Name = "Testovací tøída" };
            cl.Attributes.Add(new Attributes() { Name = "Att1", DataType = "string", Visibility = Visibility.PUBLIC });
            cl.Attributes.Add(new Attributes() { Name = "Att2", DataType = "int", Visibility = Visibility.PUBLIC });
            cl.Attributes.Add(new Attributes() { Name = "Att3", DataType = "bool", Visibility = Visibility.PRIVATE });
            cl.Attributes.Add(new Attributes() { Name = "Attjknjkyfncjknsjkynvjksndfjk4", DataType = "string", Visibility = Visibility.PROTECTED });

            cl.Operations.Add(new Operations() { Name = "MyOperation", Parametrs = "", ReturnType = "int", Visibility = Visibility.PUBLIC });
            cl.Operations.Add(new Operations() { Name = "GetString", Parametrs = "int", ReturnType = "string", Visibility=Visibility.PROTECTED });
            cl.Draw(WorkSpace.MyGraphics);

            Menu menu = new Menu();
            menu.Draw();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Objects;

namespace umlMaker
{
    public class Preview
    {
        public Class Class { get; set; }

        public Preview()
        {
            Class = new Class();
        }
        public Preview(Class @class)
        {
            Class = @class;
        }

        public void Update(PictureBox pictureBox, string className)
        {
            Graphics g = pictureBox.CreateGraphics();
            int tempX = Class.X;
            int tempY = Class.Y;
            Class.Draw(g);
            Class.X = ((pictureBox.Width - (Class.SizeX - Class.X)) / 2);
            Class.Y = ((pictureBox.Height - (Class.SizeY - Class.Y)) / 2);
            Class.Name = className;
            g.Clear(Color.White);
            Class.Draw(g);
                
            Class.X = tempX;
            Class.Y = tempY;
        }
    }
}

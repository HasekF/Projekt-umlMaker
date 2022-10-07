using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker
{
    public class Menu : IDrawable
    {

        public void Draw()
        {
            var menuBrush = new SolidBrush(Color.FromArgb(255,130,130,130));
            WorkSpace.MyGraphics.FillRectangle(menuBrush, 0, 0, Convert.ToInt32(WorkSpace.WindowWidth * 0.15), WorkSpace.WindowHeight);

        }
    }
}

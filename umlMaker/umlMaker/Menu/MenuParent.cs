using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Menu
{
    public class MenuParent
    {
        protected SolidBrush MenuBrush = new SolidBrush(Color.FromArgb(255, 130, 130, 130));
        protected SolidBrush BoxBrush = new SolidBrush(Color.FromArgb(255, 190, 190, 190));
        protected List<MenuBox> MenuBoxes { get; set; } = new List<MenuBox>();
        private int UpX = 0;
        private int DownX = 0;
        public void Draw()
        {

            int menuWeight = Convert.ToInt32(WorkSpace.WindowWidth * 0.1);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, 0, 0, menuWeight, WorkSpace.WindowHeight);

            foreach (MenuBox item in MenuBoxes)
            {
                item.Draw();
            }

        }
        protected void AddBox(Picture icon, BoxPosition position)
        {
            int menuWeight = Convert.ToInt32(WorkSpace.WindowWidth * 0.1);
            int boxSize = Convert.ToInt32(menuWeight * 0.7);
            int y = (menuWeight - boxSize) / 2;
            int x;
            if (position == BoxPosition.UP)
            {
                UpX += Convert.ToInt32(WorkSpace.WindowHeight * 0.05);
                x = UpX;
            }
            else //down
            {
                if(DownX == 0)
                    DownX = menuWeight;
                DownX -= Convert.ToInt32(WorkSpace.WindowHeight * 0.05);
                x = DownX;
            }
            MenuBoxes.Add(new MenuBox(x, y, 20, icon, position));
        }

    }
}

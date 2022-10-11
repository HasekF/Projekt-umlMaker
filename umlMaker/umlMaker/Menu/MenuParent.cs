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
        private int UpY = 0;
        private int DownY = 0;
        public void Draw()
        {

            int menuWeight = Convert.ToInt32(WorkSpace.WindowWidth * 0.1);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, 0, 0, menuWeight, WorkSpace.WindowHeight);

            foreach (MenuBox item in MenuBoxes)
            {
                item.Draw();
            }

        }
        protected void AddBox(BoxType icon, BoxPosition position)
        {
            int menuWeight = Convert.ToInt32(WorkSpace.WindowWidth * 0.1);
            int boxSize = Convert.ToInt32(menuWeight * 0.6);
            int x = (menuWeight - boxSize) / 2;
            int y;
            if (position == BoxPosition.UP)
            {
                if (UpY == 0)
                    UpY += Convert.ToInt32(WorkSpace.WindowHeight * 0.05);
                else
                    UpY += Convert.ToInt32(WorkSpace.WindowHeight * 0.05) + boxSize;
                y = UpY;
            }
            else //down
            {
                if(DownY == 0)
                    DownY = WorkSpace.WindowHeight;

                DownY = DownY - Convert.ToInt32(WorkSpace.WindowHeight * 0.05) - boxSize;
                y = DownY;
            }
            MenuBoxes.Add(new MenuBox(x, y, 25, icon, position, boxSize));
        }
        public MenuBox? ChoseOption(int x, int y)
        {
            foreach (MenuBox box in MenuBoxes)
            {
                if(box.Check(x, y))
                    return box;
            }
            return null;
        }

    }
}

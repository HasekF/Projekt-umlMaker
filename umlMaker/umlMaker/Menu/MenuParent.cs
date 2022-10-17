using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Buttons;
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
        public event Action<bool> Connect;
        public void Draw(Graphics g)
        {

            int menuWeight = Convert.ToInt32(Application.WindowWidth * 0.1);
            g.FillRectangle(MenuBrush, 0, 0, menuWeight, Application.WindowHeight);

            foreach (MenuBox item in MenuBoxes)
            {
                item.Draw(g);
                item.Connect += ConnectAction;
            }

        }
        private void ConnectAction(bool connect)
        {
            Connect(connect);
        }
        protected void AddBox(IButton button, BoxPosition position)
        {
            int menuWeight = Convert.ToInt32(Application.WindowWidth * 0.1);
            int boxSize = Convert.ToInt32(menuWeight * 0.6);
            int x = (menuWeight - boxSize) / 2;
            int y;
            if (position == BoxPosition.UP)
            {
                if (UpY == 0)
                    UpY += Convert.ToInt32(Application.WindowHeight * 0.05);
                else
                    UpY += Convert.ToInt32(Application.WindowHeight * 0.05) + boxSize;
                y = UpY;
            }
            else //down
            {
                if(DownY == 0)
                    DownY = Application.WindowHeight;

                DownY = DownY - Convert.ToInt32(Application.WindowHeight * 0.05) - boxSize;
                y = DownY;
            }
            MenuBoxes.Add(new MenuBox(x, y, 25, button, position, boxSize));
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

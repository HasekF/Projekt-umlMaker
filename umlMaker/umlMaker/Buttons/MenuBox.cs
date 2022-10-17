using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Buttons
{
    public class MenuBox
    {
        private int CornerRadius;
        public SolidBrush MenuBrush = new SolidBrush(Color.FromArgb(255, 130, 130, 130));
        public SolidBrush BoxBrush = new SolidBrush(Color.FromArgb(255, 190, 190, 190));
        public IButton Button { get; set; }
        public int BoxSize { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public BoxPosition Position { get; set; }
        public event Action<bool> Connect;


        public MenuBox(int x, int y, int cornerRadius, IButton button, BoxPosition position, int boxSize)
        {
            X = x;
            Y = y;
            CornerRadius = cornerRadius;
            Button = button;
            Position = position;
            BoxSize = boxSize;
            Button.Connect += ConnectAction;
        }
        private void ConnectAction(bool connect)
        {
            Connect(connect);
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(BoxBrush, X, Y, BoxSize, BoxSize);

            g.FillRectangle(MenuBrush, X, Y, CornerRadius, CornerRadius);
            g.FillRectangle(MenuBrush, X + BoxSize - CornerRadius, Y, CornerRadius, CornerRadius);
            g.FillRectangle(MenuBrush, X, Y + BoxSize - CornerRadius, CornerRadius, CornerRadius);
            g.FillRectangle(MenuBrush, X + BoxSize - CornerRadius, Y + BoxSize - CornerRadius, CornerRadius, CornerRadius);

            g.FillEllipse(BoxBrush, X, Y, CornerRadius * 2, CornerRadius * 2);
            g.FillEllipse(BoxBrush, X + BoxSize - 2 * CornerRadius, Y, CornerRadius * 2, CornerRadius * 2);
            g.FillEllipse(BoxBrush, X, Y + BoxSize - 2 * CornerRadius, CornerRadius * 2, CornerRadius * 2);
            g.FillEllipse(BoxBrush, X + BoxSize - 2 * CornerRadius, Y + BoxSize - 2 * CornerRadius, CornerRadius * 2, CornerRadius * 2);


            int imageSize = BoxSize - Convert.ToInt32(0.3 * BoxSize);
            Bitmap bitmap = new Bitmap(Button.GetImage(), new Size(imageSize, imageSize));
            g.DrawImage(bitmap, X + (BoxSize - imageSize) / 2, Y + (BoxSize - imageSize) / 2);
        }
        public bool Check(int x, int y)
        {
            return x > X && y > Y && x < X + BoxSize && y < Y + BoxSize;
        }
    }
    public enum BoxPosition
    {
        UP,
        DOWN
    }
}

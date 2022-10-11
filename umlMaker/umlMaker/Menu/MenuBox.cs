using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker.Menu
{
    public class MenuBox
    {
        private int CornerRadius;
        public SolidBrush MenuBrush = new SolidBrush(Color.FromArgb(255, 130, 130, 130));
        public SolidBrush BoxBrush = new SolidBrush(Color.FromArgb(255, 190, 190, 190));
        public BoxType BoxType { get; set; }
        public int BoxSize { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public BoxPosition Position { get; set; }


        public MenuBox(int x, int y, int cornerRadius, BoxType boxType, BoxPosition position, int boxSize)
        {
            X = x;
            Y = y;
            CornerRadius = cornerRadius;
            BoxType = boxType;
            Position = position;
            BoxSize = boxSize;
        }
        public void Draw()
        {
            WorkSpace.MyGraphics.FillRectangle(BoxBrush, X, Y, BoxSize, BoxSize);

            WorkSpace.MyGraphics.FillRectangle(MenuBrush, X, Y, CornerRadius, CornerRadius);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, X + BoxSize - CornerRadius, Y, CornerRadius, CornerRadius);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, X, Y + BoxSize - CornerRadius, CornerRadius, CornerRadius);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, X + BoxSize - CornerRadius, Y + BoxSize - CornerRadius, CornerRadius, CornerRadius);

            WorkSpace.MyGraphics.FillEllipse(BoxBrush, X, Y, CornerRadius * 2, CornerRadius * 2);
            WorkSpace.MyGraphics.FillEllipse(BoxBrush, X + BoxSize - 2 * CornerRadius, Y, CornerRadius * 2, CornerRadius * 2);
            WorkSpace.MyGraphics.FillEllipse(BoxBrush, X, Y + BoxSize - 2 * CornerRadius, CornerRadius * 2, CornerRadius * 2);
            WorkSpace.MyGraphics.FillEllipse(BoxBrush, X + BoxSize - 2 * CornerRadius, Y + BoxSize - 2 * CornerRadius, CornerRadius * 2, CornerRadius * 2);


            int imageSize = BoxSize - Convert.ToInt32(0.3 * BoxSize);
            Bitmap bitmap = new Bitmap(PictureManager.GetImage(BoxType), new Size(imageSize, imageSize));
            WorkSpace.MyGraphics.DrawImage(bitmap, X + (BoxSize - imageSize) / 2, Y + (BoxSize - imageSize) / 2);
        }
        public bool Check(int x, int y)
        {
            return (x > X && y > Y && x < X + BoxSize && y < Y + BoxSize);
        }
    }
    public enum BoxPosition
    {
        UP,
        DOWN
    }
}

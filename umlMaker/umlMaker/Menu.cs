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
        private int CornerRadius = 50;
        SolidBrush MenuBrush = new SolidBrush(Color.FromArgb(255, 130, 130, 130));
        SolidBrush BoxBrush = new SolidBrush(Color.FromArgb(255, 190, 190, 190));
        public void Draw()
        {

            int menuWeight = Convert.ToInt32(WorkSpace.WindowWidth * 0.1);
            int boxSize = Convert.ToInt32(menuWeight * 0.7);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, 0, 0, menuWeight, WorkSpace.WindowHeight);
            DrawBox((menuWeight - boxSize)/2, Convert.ToInt32(WorkSpace.WindowHeight * 0.05), boxSize);


        }
        public void DrawBox(int x, int y, int boxSize)
        {
            WorkSpace.MyGraphics.FillRectangle(BoxBrush, x, y, boxSize, boxSize);

            WorkSpace.MyGraphics.FillRectangle(MenuBrush, x, y, CornerRadius, CornerRadius);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, x + boxSize - CornerRadius, y, CornerRadius, CornerRadius);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, x, y + boxSize - CornerRadius, CornerRadius, CornerRadius);
            WorkSpace.MyGraphics.FillRectangle(MenuBrush, x + boxSize - CornerRadius, y + boxSize - CornerRadius, CornerRadius, CornerRadius);

            WorkSpace.MyGraphics.FillEllipse(BoxBrush, x, y,CornerRadius * 2, CornerRadius * 2);
            WorkSpace.MyGraphics.FillEllipse(BoxBrush, x + boxSize - 2 * CornerRadius, y, CornerRadius * 2, CornerRadius * 2);
            WorkSpace.MyGraphics.FillEllipse(BoxBrush, x, y + boxSize - 2 * CornerRadius, CornerRadius * 2, CornerRadius * 2);
            WorkSpace.MyGraphics.FillEllipse(BoxBrush, x + boxSize - 2 * CornerRadius, y + boxSize - 2 * CornerRadius, CornerRadius * 2, CornerRadius * 2);

           
            int imageSize = boxSize - Convert.ToInt32(0.25 * boxSize);
            Bitmap bitmap = new Bitmap(PictureManager.GetImage(Picture.KOS), new Size(imageSize, imageSize));
            WorkSpace.MyGraphics.DrawImage(bitmap, x + (boxSize - imageSize)/2, y + (boxSize - imageSize) / 2);
        }
    }
}

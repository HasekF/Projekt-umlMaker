using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;
using umlMaker.SubObjects;

namespace umlMaker.Objects
{
    public class Class : IDrawable, IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public List<Attributes> Attributes { get; set; }
        public List<Operations> Operations { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public int FontSize { get; set; } = 15;


        private int BorderWeight = 3;
        private int ContentOffset = 5;
        SolidBrush BorderBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
        SolidBrush ContentBrush = new SolidBrush(Color.FromArgb(255, 180, 255, 240));
        public Class()
        {
            Attributes = new List<Attributes>();
            Operations = new List<Operations>();
        }

        public void Draw()
        {


            string longest = "";
            List<IGetStringAble> list = new List<IGetStringAble>(Attributes);
            list.AddRange(Operations);
            foreach (IGetStringAble item in list)
            {
                string stringForm = item.GetString();
                int lenght = stringForm.Length;
                if (longest.Length < lenght)
                    longest = stringForm;
            }
            if (Name.Length > longest.Length)
                longest = Name;
            int sizeWeight = Convert.ToInt32(WorkSpace.MyGraphics.MeasureString(longest, new Font("Arial", FontSize)).Width);
            sizeWeight += ContentOffset * 2;
            SizeX = X + sizeWeight;

            //horní border
            //vykreslení jména třídy
            int nameHeight = Convert.ToInt32(WorkSpace.MyGraphics.MeasureString(Name, new Font("Arial", FontSize)).Height) + ContentOffset;
            int nameWeight = Convert.ToInt32(WorkSpace.MyGraphics.MeasureString(Name, new Font("Arial", FontSize)).Width);
            WorkSpace.MyGraphics.FillRectangle(BorderBrush, X, Y, sizeWeight + 2 * BorderWeight, BorderWeight * 2 + 2 * ContentOffset + nameHeight);
            WorkSpace.MyGraphics.FillRectangle(ContentBrush, X + BorderWeight, Y + BorderWeight, sizeWeight, nameHeight + 2 * ContentOffset);
            WorkSpace.MyGraphics.DrawString(Name, new Font("Arial", FontSize), Brushes.Black, X + sizeWeight / 2 - nameWeight / 2, Y + BorderWeight + ContentOffset);

            int tempY = Y + 2 * BorderWeight + nameHeight + 2 * ContentOffset;
            //vykresli atributy
            foreach (Attributes item in Attributes)
            {

                tempY += DrawTextLineAndReturnHeight(item.GetString(), X, tempY, sizeWeight);
            }
            DrawLine(X, tempY, sizeWeight);
            tempY += BorderWeight;

            //vykresli operace
            foreach (Operations item in Operations)
            {
                tempY += DrawTextLineAndReturnHeight(item.GetString(),X, tempY, sizeWeight);
            }
            DrawLine(X, tempY, sizeWeight);



        }
        public void Move(MouseEventArgs e)
        {

        }
        private int DrawTextLineAndReturnHeight(string text, int x, int y, int longest)
        {
            SizeF size = WorkSpace.MyGraphics.MeasureString(text, new Font("Arial", FontSize));
            WorkSpace.MyGraphics.FillRectangle(BorderBrush, x, y, longest + BorderWeight * 2, size.Height + 2 * ContentOffset);
            WorkSpace.MyGraphics.FillRectangle(ContentBrush, x + BorderWeight, y, longest, size.Height + 2 * ContentOffset);
            WorkSpace.MyGraphics.DrawString(text, new Font("Arial", FontSize), Brushes.Black, x + BorderWeight + ContentOffset, y + ContentOffset);
            return Convert.ToInt32(size.Height) + 2 * ContentOffset;
        }
        private void DrawLine(int x, int y, int longest)
        {
            WorkSpace.MyGraphics.FillRectangle(BorderBrush, x, y, longest + 2 * BorderWeight, BorderWeight);
        }
    }
}

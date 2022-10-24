using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;
using umlMaker.SubObjects;

namespace umlMaker.Objects
{
    public class Class
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public string Name { get; set; } = "";
        public BindingList<Attributes> Attributes { get; set; }
        public BindingList<Operations> Operations { get; set; }
        public int SizeX { get; set; } = 0;
        public int SizeY { get; set; } = 0;
        public int FontSize { get; set; } = 15;
        public ClassType ClassType { get; set; }

        private int BorderWeight = 5;
        private int ContentOffset = 5;
        public SolidBrush BorderBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
        public SolidBrush ContentBrush = new SolidBrush(Color.FromArgb(255, 180, 255, 240));
        private Graphics LocalGraphics;
        public Class()
        {
            ClassType = ClassType.CLASS;
            Attributes = new BindingList<Attributes>();
            Operations = new BindingList<Operations>();
        }
        public int CalculateLenght()
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
            int sizeWeight = Convert.ToInt32(LocalGraphics.MeasureString(longest, new Font("Arial", FontSize)).Width);
            sizeWeight += ContentOffset * 2;
            SizeX = X + sizeWeight;
            return sizeWeight;
        }

        public void Draw(Graphics g)
        {
            LocalGraphics = g;

            int sizeWeight = CalculateLenght();
            Brush borderBrush = BorderBrush;
            //if (ClassType == ClassType.ABSTRACT)
            //    borderBrush = new HatchBrush(HatchStyle.Percent50, BorderBrush.Color);
            //else if (ClassType == ClassType.INTERFACE)
            //    borderBrush = new HatchBrush(HatchStyle.SmallCheckerBoard, BorderBrush.Color);
            //horní border
            //vykreslení jména třídy
            int nameHeight = Convert.ToInt32(LocalGraphics.MeasureString(Name, new Font("Arial", FontSize)).Height) + ContentOffset;
            int nameWeight = Convert.ToInt32(LocalGraphics.MeasureString(Name, new Font("Arial", FontSize)).Width);
            LocalGraphics.FillRectangle(borderBrush, X, Y, sizeWeight + 2 * BorderWeight, BorderWeight * 2 + 2 * ContentOffset + nameHeight);
            LocalGraphics.FillRectangle(ContentBrush, X + BorderWeight, Y + BorderWeight, sizeWeight, nameHeight + 2 * ContentOffset);
            LocalGraphics.DrawString(Name, new Font("Arial", FontSize), Brushes.Black, X + sizeWeight / 2 - nameWeight / 2, Y + BorderWeight + ContentOffset);

            int tempY = Y + 2 * BorderWeight + nameHeight + 2 * ContentOffset;
            //vykresli atributy
            foreach (Attributes item in Attributes)
            {
                tempY += DrawTextLineAndReturnHeight(item.GetString(), X, tempY, sizeWeight, borderBrush);
            }

            if(Attributes.Count > 0)//vykreslení dělící čáry
            {
                DrawLine(X, tempY, sizeWeight, borderBrush);
                tempY += BorderWeight;
            }


            //vykresli operace
            foreach (Operations item in Operations)
            {
                tempY += DrawTextLineAndReturnHeight(item.GetString(),X, tempY, sizeWeight, borderBrush);
            }

            if (Operations.Count > 0)//vykreslení dělící čáry
            {
                DrawLine(X, tempY, sizeWeight, borderBrush);
                tempY += BorderWeight;
            }
            SizeY = tempY;


        }
        public void Move(MouseEventArgs e)
        {

        }
        private int DrawTextLineAndReturnHeight(string text, int x, int y, int longest, Brush borderBrush)
        {
            SizeF size = LocalGraphics.MeasureString(text, new Font("Arial", FontSize));
            LocalGraphics.FillRectangle(borderBrush, x, y, longest + BorderWeight * 2, size.Height + 2 * ContentOffset);
            LocalGraphics.FillRectangle(ContentBrush, x + BorderWeight, y, longest, size.Height + 2 * ContentOffset);
            LocalGraphics.DrawString(text, new Font("Arial", FontSize), Brushes.Black, x + BorderWeight + ContentOffset, y + ContentOffset);
            return Convert.ToInt32(size.Height) + 2 * ContentOffset;
        }
        private void DrawLine(int x, int y, int longest, Brush borderBrush)
        {
            LocalGraphics.FillRectangle(borderBrush, x, y, longest + 2 * BorderWeight, BorderWeight);
        }
    }
    public enum ClassType
    {
        CLASS,
        INTERFACE,
        ABSTRACT
    }
}

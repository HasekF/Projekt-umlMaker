using System;
using System.Collections.Generic;
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
        

        public void Draw(int x, int y)
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
            //vykresli pozadí
            //vypiš jednotlivé texty
            


        }
        public void Move(MouseEventArgs e)
        {

        }
        private void DrawTextLine(string text)
        {
            SizeF size = WorkSpace.MyGraphics.MeasureString(text, new Font("Arial", 20));
            WorkSpace.MyGraphics.DrawString("Hellooo!", new Font("Arial", 20), Brushes.Blue, 200 - size.Width / 2, 150 - size.Height / 2);
        }
    }
}

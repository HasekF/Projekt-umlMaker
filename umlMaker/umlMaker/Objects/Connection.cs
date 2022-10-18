using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Buttons.Lines;
using umlMaker.Interfaces;

namespace umlMaker.Objects
{
    public class Connection
    {
        public Class From { get; set; }
        public Class To { get; set; }
        public bool Classify { get; set; }
        public ILine LineType { get; set; }
        public Connection(Class from, Class to)
        {
            From = from;
            To = to;
            Classify = false;
            LineType = new AssociationLine();
        }

        public void Draw(Graphics g)
        {
            Pen linePen = new Pen(Brushes.Black, 4);
            Point from = new Point(this.From.X + ((this.From.SizeX - this.From.X) / 2), this.From.Y + ((this.From.SizeY - this.From.Y) / 2));
            Point to = new Point(this.To.X + ((this.To.SizeX - this.To.X) / 2), this.To.Y + ((this.To.SizeY - this.To.Y) / 2));
            int x = to.X - from.X;
            int y = to.Y - from.Y;
            Point checkpoint1;
            Point checkpoint2;
            if (Math.Abs(x) >= Math.Abs(y))
            {//horizontální
                if(x>0)//p
                {
                    from = new Point(From.SizeX, from.Y);
                    to = new Point(To.X, to.Y);
                }
                else//l
                {
                    from = new Point(From.X, from.Y);
                    to = new Point(To.SizeX, to.Y);
                }
                x = to.X - from.X;
                y = to.Y - from.Y;
                checkpoint1 = new Point(from.X + (x/2), from.Y);
                checkpoint2 = new Point(from.X + (x/2), to.Y);
            }
            else
            {//vertikální
                if(y>0)//down
                {
                    from = new Point(from.X, From.SizeY);
                    to = new Point(to.X, To.Y);
                }
                else//up
                {
                    from = new Point(from.X, From.Y);
                    to = new Point(to.X, To.SizeY);
                }
                x = to.X - from.X;
                y = to.Y - from.Y;
                checkpoint1 = new Point(from.X, from.Y + (y/2));
                checkpoint2 = new Point(to.X, from.Y + (y/2));
            }


            LineType.Draw(g, from, to, checkpoint1, checkpoint2);

        }
    }
}

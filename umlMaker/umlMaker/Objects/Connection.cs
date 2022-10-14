using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Objects
{
    public class Connection
    {
        public Class From { get; set; }
        public Class To { get; set; }

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
            {
                checkpoint1 = new Point(from.X + (x/2), from.Y);
                checkpoint2 = new Point(from.X + (x/2), to.Y);
            }
            else
            {
                checkpoint1 = new Point(from.X, from.Y + (y/2));
                checkpoint2 = new Point(to.X, from.Y + (y/2));
            }

            g.DrawLine(linePen, from, checkpoint1);
            g.DrawLine(linePen, checkpoint1, checkpoint2);
            g.DrawLine(linePen, checkpoint2, to);

        }
    }
}

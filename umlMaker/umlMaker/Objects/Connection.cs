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

        public void Draw()
        {
            Point from = new Point(this.From.X + this.From.SizeY / 2, this.From.Y + this.From.SizeY / 2); ;
            Point to = new Point(this.To.X + this.To.SizeX / 2, this.To.Y + this.To.SizeY / 2);
            Point checkpoint1 = new Point();
            Point checkpoint2 = new Point();

        }
    }
}

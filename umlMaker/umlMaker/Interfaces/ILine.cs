using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker.Interfaces
{
    public interface ILine
    {
        public void Draw(Graphics g, Point from, Point to, Point checkpoint1, Point checkpoint2);
    }
}

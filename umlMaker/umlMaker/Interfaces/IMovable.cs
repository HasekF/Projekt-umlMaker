using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker.Interfaces
{
    public interface IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        void Move(MouseEventArgs e) { }
    }
}

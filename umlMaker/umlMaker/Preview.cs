using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Objects;

namespace umlMaker
{
    public class Preview
    {
        public Class Class { get; set; }

        public void Update(Graphics g, string name)
        {
            Class.X = 10;
            Class.Y = 10;
            Class.Name = name;
            Class.Draw(g);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.SubObjects
{
    public class Attributes : IGetStringAble
    {
        public string Name { get; set; }
        public Visibility Visibility { get; set; }
        public string DataType { get; set; }

        public string GetString()
        {
            return GetVisibility(this.Visibility) + " " + this.Name + ":" + this.DataType;
        }

        private string GetVisibility(Visibility vis)
        {
            string visibility = "";
            if (vis == Visibility.PRIVATE)
                visibility = "‒";
            else if (vis == Visibility.PROTECTED)
                visibility = "#";
            else if (vis == Visibility.PUBLIC)
                visibility = "+";
            return visibility;
        }
    }
}

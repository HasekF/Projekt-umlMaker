using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker
{
    public static class PictureManager
    {
        public static Image GetImage(BoxType boxType)
        {
            if(BoxType.PLUS == boxType)
                return Image.FromFile(@"../../../../../obrazky/plus.png");
            else if (BoxType.EDIT == boxType)
                return Image.FromFile(@"../../../../../obrazky/edit.png");
            else 
                return Image.FromFile(@"../../../../../obrazky/kos.png");
        }
    }
    public enum BoxType
    {
        KOS,
        PLUS,
        EDIT
    }
}

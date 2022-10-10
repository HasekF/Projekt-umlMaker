using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker
{
    public static class PictureManager
    {
        public static Image GetImage(Picture picture)
        {
            if(Picture.PLUS == picture)
                return Image.FromFile(@"../../../../../obrazky/plus.png");
            else if (Picture.PLUS == picture)
                return Image.FromFile(@"../../../../../obrazky/edit.png");
            else 
                return Image.FromFile(@"../../../../../obrazky/kos.png");
        }
    }
    public enum Picture
    {
        KOS,
        PLUS,
        EDIT
    }
}

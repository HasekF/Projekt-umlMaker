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
            else if (BoxType.CONNECT == boxType)
                return Image.FromFile(@"../../../../../obrazky/connect.png");
            else if (BoxType.DISCONNECT == boxType)
                return Image.FromFile(@"../../../../../obrazky/disconnect.png");
            else if (BoxType.EXPORT == boxType)
                return Image.FromFile(@"../../../../../obrazky/export.png");
            else if (BoxType.IMPORT == boxType)
                return Image.FromFile(@"../../../../../obrazky/import.png");
            else 
                return Image.FromFile(@"../../../../../obrazky/kos.png");
        }
    }
    public enum BoxType
    {
        KOS,
        PLUS,
        EDIT,
        CONNECT,
        DISCONNECT,
        EXPORT,
        IMPORT
    }
}

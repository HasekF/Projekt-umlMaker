using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker.Buttons
{
    public static class PictureManager
    {

        private static int ImageSize = Convert.ToInt32(Convert.ToInt32(Application.WindowWidth * 0.1) * 0.6) - Convert.ToInt32(0.3 * Convert.ToInt32(Convert.ToInt32(Application.WindowWidth * 0.1) * 0.6));
        public static Bitmap DeleteIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/delete.png"), new Size(ImageSize, ImageSize));
        public static Bitmap AddIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/add.png"), new Size(ImageSize, ImageSize));
        public static Bitmap EditIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/edit.png"), new Size(ImageSize, ImageSize));
        public static Bitmap ConnectIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/connect.png"), new Size(ImageSize, ImageSize));
        public static Bitmap DisconnectIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/disconnect.png"), new Size(ImageSize, ImageSize));
        public static Bitmap ImportIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/import.png"), new Size(ImageSize, ImageSize));
        public static Bitmap ExportIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/export.png"), new Size(ImageSize, ImageSize));

    }
}

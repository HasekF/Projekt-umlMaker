using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker.Buttons
{
    public static class PictureManager
    {

        private static int ImageSize = Convert.ToInt32(Convert.ToInt32(ApplicationGetter.WindowWidth * 0.1) * 0.65) - Convert.ToInt32(0.3 * Convert.ToInt32(Convert.ToInt32(ApplicationGetter.WindowWidth * 0.1) * 0.65));
        public static Bitmap DeleteIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/delete.png"), new Size(ImageSize, ImageSize));
        public static Bitmap AddIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/add.png"), new Size(ImageSize, ImageSize));
        public static Bitmap EditIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/edit.png"), new Size(ImageSize, ImageSize));
        public static Bitmap ConnectIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/connect.png"), new Size(ImageSize, ImageSize));
        public static Bitmap DisconnectIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/disconnect.png"), new Size(ImageSize, ImageSize));
        public static Bitmap ImportIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/import.png"), new Size(ImageSize, ImageSize));
        public static Bitmap ExportIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/export.png"), new Size(ImageSize, ImageSize));
        public static Bitmap FileIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/file.png"), new Size(ImageSize, ImageSize));
        public static Bitmap CodeIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/code.png"), new Size(ImageSize, ImageSize));
        public static Bitmap PictureIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/picture.png"), new Size(ImageSize, ImageSize));
        public static Bitmap HelpIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/help.png"), new Size(ImageSize, ImageSize));



        public static Bitmap AggregationLineIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/aggregation.png"), new Size(ImageSize, ImageSize));
        public static Bitmap AssociationLineIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/association.png"), new Size(ImageSize, ImageSize));
        public static Bitmap ContainmentLineIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/containment.png"), new Size(ImageSize, ImageSize));
        public static Bitmap DependencyLineIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/dependency.png"), new Size(ImageSize, ImageSize));
        public static Bitmap DirectAssociationLineIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/directAssociation.png"), new Size(ImageSize, ImageSize));
        public static Bitmap InheritanceLineIcon = new Bitmap(Image.FromFile(@"../../../../../obrazky/inheritance.png"), new Size(ImageSize, ImageSize));
        public static Bitmap RealizationLineIcon =  new Bitmap(Image.FromFile(@"../../../../../obrazky/realization.png"), new Size(ImageSize, ImageSize));

    }
}

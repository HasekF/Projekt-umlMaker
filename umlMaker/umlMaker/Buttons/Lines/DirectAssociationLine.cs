using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Buttons.Lines
{
    public class DirectAssociationLine : LineParent, IButton, ILine
    {
        public event Action<bool> Connect;
        public event Action OpenExportMenu;

        public void Click()
        {
            Classify(new DirectAssociationLine());
        }

        public void Draw(Graphics g, Point from, Point to, Point checkpoint1, Point checkpoint2)
        {
            Pen linePen = new Pen(Brushes.Black, 2);
            DrawLine(g, linePen, from, to, checkpoint1, checkpoint2);
            DrawArrow(g, to);
        }

        public Bitmap GetImage()
        {
            return PictureManager.DirectAssociationLineIcon;
        }
    }
}

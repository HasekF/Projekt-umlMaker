using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using umlMaker.Interfaces;
using umlMaker.Objects;

namespace umlMaker.Buttons.Lines
{
    public class LineParent
    {
        public void Classify(ILine lineType)
        {
            foreach (Connection item in Application.GetConnections())
            {
                if(!item.Classify)
                {
                    item.LineType = lineType;
                    item.Classify = true;
                }
            }
        }
        public void DrawLine(Graphics g, Pen pen, Point from, Point to, Point checkpoint1, Point checkpoint2)
        {
            g.DrawLine(pen, from, checkpoint1);
            g.DrawLine(pen, checkpoint1, checkpoint2);
            g.DrawLine(pen, checkpoint2, to);
        }
        public void DrawArrow(Graphics g, Point point)
        {
            Pen linePen = new Pen(Brushes.Black, 4);
            int lineLenght = 40;
            g.DrawLine(linePen, point.X - lineLenght, point.Y - lineLenght, point.X + lineLenght, point.Y + lineLenght);
            g.DrawLine(linePen, point.X - lineLenght, point.Y + lineLenght, point.X + lineLenght, point.Y - lineLenght);

        }
        public void DrawTriangle(Graphics g, Point point, Point checkpoint2)
        {
            Pen linePen = new Pen(Brushes.Black, 4);
            SolidBrush brush = new SolidBrush(Color.FromArgb(255,240,240,240));
            int lineLenght = 40;
            if (checkpoint2.Y == point.Y)
            {//horizontální
                if (point.X < checkpoint2.X)//p
                {
                    g.FillPolygon(brush, new Point[] { point, new Point(point.X + lineLenght, point.Y - lineLenght), new Point(point.X + lineLenght, point.Y + lineLenght) });
                    g.DrawPolygon(linePen, new Point[] { point, new Point(point.X + lineLenght, point.Y - lineLenght), new Point(point.X + lineLenght, point.Y + lineLenght) });
                }
                else//l
                {
                    g.FillPolygon(brush, new Point[] { point, new Point(point.X - lineLenght, point.Y - lineLenght), new Point(point.X - lineLenght, point.Y + lineLenght) });
                    g.DrawPolygon(linePen, new Point[] { point, new Point(point.X - lineLenght, point.Y - lineLenght), new Point(point.X - lineLenght, point.Y + lineLenght) });
                }
            }
            else
            {//vertikální
                if (point.Y < checkpoint2.Y)//down
                {
                    g.FillPolygon(brush, new Point[] { point, new Point(point.X - lineLenght, point.Y + lineLenght), new Point(point.X + lineLenght, point.Y + lineLenght) });
                    g.DrawPolygon(linePen, new Point[] { point, new Point(point.X - lineLenght, point.Y + lineLenght), new Point(point.X + lineLenght, point.Y + lineLenght) });
                }
                else//up
                {
                    g.FillPolygon(brush, new Point[] { point, new Point(point.X + lineLenght, point.Y - lineLenght), new Point(point.X - lineLenght, point.Y - lineLenght) });
                    g.DrawPolygon(linePen, new Point[] { point, new Point(point.X + lineLenght, point.Y - lineLenght), new Point(point.X - lineLenght, point.Y - lineLenght) });
                }
            }

        }
        public void DrawPolygon(Graphics g, Point point, Point checkpoint1, bool filled)
        {
            Pen linePen = new Pen(Brushes.Black, 4);
            SolidBrush brush;
            if (filled)
                brush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
            else
                brush = new SolidBrush(Color.FromArgb(255, 240, 240, 240));
            int lineLenght = 30;
            if (checkpoint1.Y == point.Y)
            {//horizontální
                if (point.X < checkpoint1.X)//p
                {
                    g.FillPolygon(brush, new Point[] { point, new Point(point.X + lineLenght, point.Y - lineLenght / 2), new Point(point.X + lineLenght * 2, point.Y), new Point(point.X + lineLenght, point.Y + lineLenght / 2) });
                    g.DrawPolygon(linePen, new Point[] { point, new Point(point.X + lineLenght, point.Y - lineLenght / 2), new Point(point.X + lineLenght * 2, point.Y), new Point(point.X + lineLenght, point.Y + lineLenght / 2) });
                }
                else//l
                {
                    g.FillPolygon(brush, new Point[] { point, new Point(point.X - lineLenght, point.Y - lineLenght / 2), new Point(point.X - lineLenght * 2, point.Y), new Point(point.X - lineLenght, point.Y + lineLenght / 2) });
                    g.DrawPolygon(linePen, new Point[] { point, new Point(point.X - lineLenght, point.Y - lineLenght / 2), new Point(point.X - lineLenght * 2, point.Y), new Point(point.X - lineLenght, point.Y + lineLenght / 2) });
                }
            }
            else
            {//vertikální
                if (point.Y < checkpoint1.Y)//down
                {
                    g.FillPolygon(brush, new Point[] { point, new Point(point.X - lineLenght / 2, point.Y + lineLenght), new Point(point.X, point.Y + lineLenght * 2), new Point(point.X + lineLenght / 2, point.Y + lineLenght) });
                    g.DrawPolygon(linePen, new Point[] { point, new Point(point.X - lineLenght / 2, point.Y + lineLenght), new Point(point.X, point.Y + lineLenght * 2), new Point(point.X + lineLenght / 2, point.Y + lineLenght) });
                }
                else//up
                {
                    g.FillPolygon(brush, new Point[] { point, new Point(point.X + lineLenght / 2, point.Y - lineLenght), new Point(point.X, point.Y - lineLenght * 2), new Point(point.X - lineLenght / 2, point.Y - lineLenght) });
                    g.DrawPolygon(linePen, new Point[] { point, new Point(point.X + lineLenght / 2, point.Y - lineLenght), new Point(point.X, point.Y - lineLenght * 2), new Point(point.X - lineLenght / 2, point.Y - lineLenght) });
                }
            }
        }
    }
}

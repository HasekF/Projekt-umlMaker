using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Objects;

namespace umlMaker
{
    public class Mover
    {
        public int XMouseOffset { get; set; }
        public int YMouseOffset { get; set; }
        public Class SelectedClass { get; set; }
        private List<Class> ClassList;
        private int StartX { get; set; }
        private int StartY { get; set; }
        public bool BigMove { get; set; } = false;
        public Mover(int xMouseOffset, int yMouseOffset, Class selectedClass, List<Class> classList)
        {
            XMouseOffset = xMouseOffset;
            YMouseOffset = yMouseOffset;
            SelectedClass = selectedClass;
            ClassList = new List<Class>(classList);
            ClassList.Remove(selectedClass);
            StartX = SelectedClass.X;
            StartY = SelectedClass.Y;
            //ClassList.Remove(ClassList.Where(x => x.X == selectedClass.X && x.Y == selectedClass.Y).First());
        }
        public void Move(int x, int y)
        {
            if(XMouseOffset < SelectedClass.SizeX - SelectedClass.X && YMouseOffset < SelectedClass.SizeY - SelectedClass.Y)
            {
                SelectedClass.X = x - XMouseOffset;
                SelectedClass.Y = y - YMouseOffset;
            }

            
            int moveOffset = 15;
            if(!BigMove)
                BigMove = (SelectedClass.X < StartX - moveOffset || SelectedClass.X > StartX + moveOffset || SelectedClass.Y < StartY - moveOffset || SelectedClass.Y > StartY + moveOffset);
        }
    }
}

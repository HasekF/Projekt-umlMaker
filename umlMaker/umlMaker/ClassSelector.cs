using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Objects;

namespace umlMaker
{
    public class ClassSelector
    {
        public List<Class> Classes { get; set; }
        public List<Class> NotAbleToSelect { get; set; }
        public ClassSelector(List<Class> classes)
        {
            Classes = classes;
            NotAbleToSelect = new List<Class>();
        }

        public void StartSelecting() 
        {
            foreach (var item in Classes)
            {
                if(!NotAbleToSelect.Contains(item))
                    item.ContentBrush = new SolidBrush(Color.FromArgb(255, 70, 204, 107));
                else
                    item.ContentBrush = new SolidBrush(Color.FromArgb(255, 128, 128, 128));
            }

        }
        public Class? Select(int x, int y)
        {
            foreach (var item in Classes)
            {
                if(!NotAbleToSelect.Contains(item))
                {
                    if(x > item.X && x < item.SizeX && y > item.Y && y < item.SizeY)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        public void EndSelecting()
        {
            foreach (var item in Classes)
            {
                item.ContentBrush = new SolidBrush(Color.FromArgb(255, 180, 255, 240));
            }
        }
    }
}

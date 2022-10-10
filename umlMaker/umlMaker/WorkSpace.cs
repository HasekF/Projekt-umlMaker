using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;
using umlMaker.Objects;

namespace umlMaker
{
    public class WorkSpace
    {
        public static Graphics MyGraphics { get; set; }
        public static int WindowHeight { get; set; }
        public static int WindowWidth { get; set; }

        public Class? ClassToMove { get; set; }
        public List<Class> ClassList { get; set; }
        public List<IDrawable> ToDraw { get; set; }
        public bool MenuIsOpen { get; set; }
        public WorkSpace(Graphics myGraphics)
        {
            MyGraphics = myGraphics;

            ClassList = new List<Class>();
            ToDraw = new List<IDrawable>();
            ToDraw.Add(new Menu());

        }
        public void Move(MouseEventArgs e)
        {
            if(ClassToMove != null)
            {
                
            }
            //else if(LineDrawing)
            //{
                
            //}
        }
        public void OpenEditor()
        {
            ClassToMove = null;
            ClassEditor edit = new ClassEditor();
            //open editor
        }
        public void MovingAction(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ClassToMove = GetSelectedClass(e.X, e.Y);
            }   
            //else if (e.Button == MouseButtons.Right) //kreslení čáry
            //    this.LineDrawing = true;
        }
        public void Click(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.ClassToMove = null;
            //else if (e.Button == MouseButtons.Right) //kreslení čáry
            //    this.LineDrawing = null;
        }


        public void DrawAll()
        {
            MyGraphics.Clear(Color.White);
            foreach (IDrawable item in ToDraw)
            {
                item.Draw();
            }
        }
        private Class? GetSelectedClass(int mouseX, int mouseY)
        {
            Class? classToReturn = null;
            foreach (Class item in ClassList)
            {
                if (mouseX > item.X && mouseX < item.X + item.SizeX && mouseY > item.Y && mouseY < item.Y + item.SizeY)
                {
                    classToReturn = item;
                    break;
                }
            }
            return classToReturn;
        }
    }
}

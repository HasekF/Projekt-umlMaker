using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;
using umlMaker.Objects;
using umlMaker.Menu;

namespace umlMaker
{
    public class WorkSpace
    {
        public static Graphics MyGraphics { get; set; }
        public static int WindowHeight { get; set; }
        public static int WindowWidth { get; set; }

        public Class? SelectedClass { get; set; }
        public List<Class> ClassList { get; set; }
        public MenuParent? OpenedMenu { get; set; }
        private bool ClassMoving;
        public WorkSpace(Graphics myGraphics)
        {
            MyGraphics = myGraphics;
            ClassList = new List<Class>();
            ClassMoving = false;

        }
        public void Move(MouseEventArgs e)
        {
            if(ClassMoving)
            {
                
            }
            //else if(LineDrawing)
            //{
                
            //}
        }
        public void OpenEditor()
        {
            if(SelectedClass != null)
            {
                ClassMoving = false;
                ClassEditor edit = new ClassEditor();
            }
        }
        public void MovingAction(MouseEventArgs e)
        {
            if(ClassMoving)
            {
                 if (e.Button == MouseButtons.Left)
                 {
                     this.SelectedClass = GetSelectedClass(e.X, e.Y);
                 }
                //else if (e.Button == MouseButtons.Right) //kreslení čáry
                //    this.LineDrawing = true;
            }
        }
        public void Click(MouseEventArgs e)
        {
            SelectedClass = GetSelectedClass(e.X, e.Y);
            if (e.Button == MouseButtons.Left)
            {
                this.ClassMoving = false;
                //this.LineDrawing = null;

                if(SelectedClass == null)
                {
                    OpenedMenu = new MainMenu();
                }
                else
                {
                    OpenedMenu = new ClassMenu();
                }
            }
        }


        public void DrawAll()
        {
            MyGraphics.Clear(Color.White);
            foreach (Class item in ClassList)
            {
                item.Draw(WorkSpace.MyGraphics);
            }
            if(OpenedMenu != null)
            {
                OpenedMenu.Draw();
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

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
        private Mover? Mover;
        public WorkSpace(Graphics myGraphics)
        {
            MyGraphics = myGraphics;
            ClassList = new List<Class>();
            Mover = null;

        }
        public void Move(MouseEventArgs e)
        {
            if(Mover != null)
            {
                Mover.Move(e.X, e.Y);
                this.DrawAll();
                if(Mover.BigMove)
                {
                    OpenedMenu = null;
                }
            }
            //else if(LineDrawing)
            //{
                
            //}
        }
        public void OpenEditor()
        {
            Mover = null;

            if (SelectedClass == null)
            {
                ClassEditor edit = new ClassEditor();
                if (edit.ShowDialog() == DialogResult.OK)
                    ClassList.Add(edit.Preview.Class);
            }
            else
                OpenEditor(SelectedClass);
        }
        public void OpenEditor(Class classToEdit)
        {
            ClassEditor edit = new ClassEditor(classToEdit);
            if (edit.ShowDialog() == DialogResult.OK)
                if (edit.Preview.Class != SelectedClass)
                    ClassList.Add(edit.Preview.Class);
                            
        }
        public void MovingAction(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(SelectedClass == null)
                    this.SelectedClass = GetSelectedClass(e.X, e.Y);
                if(SelectedClass != null)
                {
                    Mover = new Mover(e.X - SelectedClass.X, e.Y - SelectedClass.Y, SelectedClass, ClassList);
                }
            }
            //else if (e.Button == MouseButtons.Right) //kreslení čáry
            //    this.LineDrawing = true;
        }
        public void Click(MouseEventArgs e)
        {
            bool bigMove = false;
            if (Mover != null)
            {
                bigMove = Mover.BigMove;
                Mover = null;
            }
            if (!bigMove)
            {
                Mover = null;
                if (OpenedMenu == null)
                {
                    SelectedClass = GetSelectedClass(e.X, e.Y);
                    if (e.Button == MouseButtons.Left)
                    {

                        if (SelectedClass == null)
                        {
                            OpenedMenu = new MainMenu();
                        }
                        else
                        {
                            OpenedMenu = new ClassMenu();
                        }
                    }
                }
                else
                {
                    MenuBox? box = OpenedMenu.ChoseOption(e.X, e.Y);
                    if (box != null)
                    {
                        if (box.BoxType == BoxType.PLUS)
                        {
                            OpenEditor();
                        }
                        else if (box.BoxType == BoxType.KOS)
                        {
                            //delete class
                            ClassList.Remove(SelectedClass);
                            OpenedMenu = null;
                            SelectedClass = null;
                        }
                        else if (box.BoxType == BoxType.EDIT)
                        {
                            OpenEditor(SelectedClass);
                        }
                    }
                    else
                    {
                        OpenedMenu = null;
                        SelectedClass = null;
                        this.DrawAll();
                    }
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
                if (mouseX > item.X && mouseX < item.SizeX && mouseY > item.Y && mouseY < item.SizeY)
                {
                    classToReturn = item;
                    break;
                }
            }
            return classToReturn;
        }
    }
}

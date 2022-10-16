using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;
using umlMaker.Objects;
using umlMaker.Menu;
using umlMaker.SubObjects;

namespace umlMaker
{
    public class WorkSpace
    {
        public static int WindowHeight { get; set; }
        public static int WindowWidth { get; set; }

        public Class? SelectedClass { get; set; }
        public List<Class> ClassList { get; set; }
        public MenuParent? OpenedMenu { get; set; }
        private Mover? Mover;
        public List<Connection> Connections { get; set; }
        public ClassSelector? ClassSelector { get; set; }
        public WorkSpace()
        {
            ClassList = new List<Class>();
            Connections = new List<Connection>();
            ClassList.Add(new Class() { Name = "Person", X = 50, Y = 50 });
            ClassList.Add(new Class() { Name = "Item", X = 200, Y = 200 });
            ClassList[0].Attributes.Add(new Attributes() { Name = "Age", Visibility = Visibility.PUBLIC, DataType = "int" });
            ClassList[1].Attributes.Add(new Attributes() { Name = "ItemType", Visibility = Visibility.PUBLIC, DataType = "ItemType"});
            Connections.Add(new Connection(ClassList[0], ClassList[1]));


            Mover = null;

        }
        public void Move(MouseEventArgs e)
        {
            if(Mover != null)
            {
                Mover.Move(e.X, e.Y);
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
            if(ClassSelector != null)
            {
                Class? classToConnect = ClassSelector.Select(e.X, e.Y);
                if(classToConnect != null)
                    Connections.Add(new Connection(SelectedClass, classToConnect));
                ClassSelector.EndSelecting();
                ClassSelector = null;
            }
            else if (!bigMove)
            {
                Mover = null;
                if (OpenedMenu == null)
                {
                    SelectedClass = GetSelectedClass(e.X, e.Y);
                    if (e.Button == MouseButtons.Left)
                    {

                        if (SelectedClass == null)
                            OpenedMenu = new MainMenu();
                        else
                            OpenedMenu = new ClassMenu(SelectedClass, Connections);
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
                            for (int i = 0; i < Connections.Count; i++)
                            {
                                if(Connections[i].From == SelectedClass || Connections[i].To == SelectedClass)
                                {
                                    Connections.RemoveAt(i);
                                    i--;
                                }
                            }
                            ClassList.Remove(SelectedClass);
                            OpenedMenu = null;
                            SelectedClass = null;
                        }
                        else if (box.BoxType == BoxType.EDIT)
                        {
                            OpenEditor(SelectedClass);
                        }
                        else if (box.BoxType == BoxType.CONNECT)
                        {
                            OpenedMenu = null;
                            Mover = null;
                            ClassSelector = new ClassSelector(ClassList);
                            ClassSelector.NotAbleToSelect.Add(SelectedClass);
                            ClassSelector.StartSelecting();
                        }
                        else if (box.BoxType == BoxType.DISCONNECT)
                        {
                            ClassSelector = new ClassSelector(ClassList);
                            ClassSelector.NotAbleToSelect.Add(SelectedClass);
                            ClassSelector.StartSelecting();
                        }
                    }
                    else
                    {
                        OpenedMenu = null;
                        SelectedClass = null;
                    }
                }
            }
        }


        public void DrawAll(Graphics g)
        {
            foreach (Connection item in Connections)
            {
                item.Draw(g);
            }
            foreach (Class item in ClassList)
            {
                item.Draw(g);
            }
            if(OpenedMenu != null)
            {
                OpenedMenu.Draw(g);
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

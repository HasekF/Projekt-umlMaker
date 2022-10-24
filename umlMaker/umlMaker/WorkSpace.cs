using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;
using umlMaker.Objects;
using umlMaker.Menu;
using umlMaker.SubObjects;
using umlMaker.Buttons;
using umlMaker.Buttons.Lines;

namespace umlMaker
{
    public class WorkSpace
    {
        public Class? SelectedClass { get; set; }
        public List<Class> ClassList { get; set; }
        public MenuParent? OpenedMenu { get; set; }
        private Mover? Mover;
        public List<Connection> Connections { get; set; }
        private Connector? Connector;

        public WorkSpace()
        {
            ClassList = new List<Class>();
            Connections = new List<Connection>();
            //ClassList.Add(new Class() { Name = "Person", X = 500, Y = 50 });
            //ClassList.Add(new Class() { Name = "Item", X = 1000, Y = 200 });
            //ClassList[0].Attributes.Add(new Attributes() { Name = "Age", Visibility = Visibility.PUBLIC, DataType = "int" });
            //ClassList[1].Attributes.Add(new Attributes() { Name = "ItemType", Visibility = Visibility.PUBLIC, DataType = "ItemType"});
            //Connections.Add(new Connection(ClassList[0], ClassList[1]) { Classify = true, LineType = new ContainmentLine() });

            Mover = null;

        }
        private void ConnectAction(bool connect)
        {
            Connector = new Connector(ClassList, Connections, SelectedClass, connect);
            Connector.ChooseLine += ChooseLineAction;
        }
        private void ChooseLineAction()
        {
            OpenedMenu = new LineMenu();
        }
        public void Move(MouseEventArgs e)
        {
            if(Mover != null)
            {
                Mover.Move(e.X, e.Y);
                if(Mover.BigMove)
                    OpenedMenu = null;
            }
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
                if (OpenedMenu == null)
                    this.SelectedClass = GetSelectedClass(e.X, e.Y);
                if(SelectedClass != null)
                {
                    Mover = new Mover(e.X - SelectedClass.X, e.Y - SelectedClass.Y, SelectedClass, ClassList);
                }
            }
        }
        public void Click(MouseEventArgs e)
        {
            bool bigMove = false;
            if (Mover != null)
            {
                bigMove = Mover.BigMove;
            }
            Mover = null;
            if (Connector != null)
            {
                Connector.Select(e);
                Connector = null;
            }
            else if (!bigMove)
            {
                if (OpenedMenu == null)
                {
                    SelectedClass = GetSelectedClass(e.X, e.Y);
                    if (e.Button == MouseButtons.Left)
                    {
                        if (SelectedClass == null)
                            OpenedMenu = new MainMenu();
                        else
                            OpenedMenu = new ClassMenu(SelectedClass, Connections);
                        OpenedMenu.Connect += ConnectAction;
                    }
                }
                else
                {
                    MenuBox? menuBox = OpenedMenu.ChoseOption(e.X, e.Y);
                    if (menuBox != null)
                        menuBox.Button.Click();
                    OpenedMenu = null;
                        
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Objects;

namespace umlMaker
{
    public class Connector
    {
        private ClassSelector ClassSelector;
        private bool DisconnectMode;
        private List<Connection> Connections;
        private List<Class> Classes;
        private Class SelectedClass;

        public Connector(List<Class> classes, List<Connection> connections, Class selectedClass, bool disconnectMode)
        {
            ClassSelector = new ClassSelector(classes);
            DisconnectMode = !disconnectMode;
            Connections = connections;
            SelectedClass = selectedClass;
            Classes = classes;
            ClassSelector.NotAbleToSelect.Add(selectedClass);
            if(disconnectMode)
            {
                foreach (Connection connection in Connections)
                {
                    if (connection.From == selectedClass)
                        ClassSelector.NotAbleToSelect.Add(connection.To);
                    else if (connection.To == selectedClass)
                        ClassSelector.NotAbleToSelect.Add(connection.From);
                }
            }
            else
            {
                List<Class> neighbours = new List<Class>();
                foreach (Connection connection in Connections)
                {
                    if (connection.From != selectedClass && connection.To != selectedClass)
                    {
                        if (!ClassSelector.NotAbleToSelect.Contains(connection.To))
                            ClassSelector.NotAbleToSelect.Add(connection.To);
                        if (!ClassSelector.NotAbleToSelect.Contains(connection.From))
                            ClassSelector.NotAbleToSelect.Add(connection.From);
                    }
                    else
                    {
                        if (connection.From == SelectedClass)
                            neighbours.Add(connection.To);
                        else
                            neighbours.Add(connection.From);
                    }  
                }
                foreach (Class item in neighbours)
                {
                    ClassSelector.NotAbleToSelect.Remove(item);
                }
            }

            ClassSelector.StartSelecting();
        }
        public void Select(MouseEventArgs e)
        {
            Class? choosedClass = ClassSelector.Select(e.X, e.Y);
            if(choosedClass != null)
            {
                if (DisconnectMode)
                    Disconnect(choosedClass);
                else
                    Connect(choosedClass);
            }
            ClassSelector.EndSelecting();
        }
        private void Connect(Class classToConnect)
        {
            Connections.Add(new Connection(SelectedClass, classToConnect));
        }
        private void Disconnect(Class classToDisconnect)
        {
            for (int i = 0; i < Connections.Count; i++)
            {
                if ((Connections[i].From == SelectedClass && Connections[i].To == classToDisconnect) || (Connections[i].From == classToDisconnect && Connections[i].To == SelectedClass))
                {
                    Connections.Remove(Connections[i]);
                    i--;
                }
            }
            
        }
    }
}

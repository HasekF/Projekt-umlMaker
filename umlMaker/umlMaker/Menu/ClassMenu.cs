using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Buttons;
using umlMaker.Objects;

namespace umlMaker.Menu
{
    public class ClassMenu : MenuParent
    {
        public ClassMenu(Class selectedClass, List<Connection> connections)
        {
            foreach (Connection item in connections)
            {
                if (item.From == selectedClass || item.To == selectedClass)
                {
                    AddBoxes(true);
                    break;
                }
            }
            if (MenuBoxes.Count == 0)
                AddBoxes(false);
        }
        private void AddBoxes(bool deleteConections)
        {
            AddBox(new EditButton(), BoxPosition.UP);
            AddBox(new DeleteButton(), BoxPosition.UP);
            AddBox(new ConnectButton(), BoxPosition.UP);
            if (deleteConections)
                AddBox(new DisconnectButton(), BoxPosition.DOWN);
        }
    }
}

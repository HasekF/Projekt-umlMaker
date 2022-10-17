using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;
using umlMaker.Objects;

namespace umlMaker.Buttons
{
    public class DeleteButton : IButton
    {
        public event Action<bool> Connect;

        public void Click()
        {
            List<Connection> connections = Application.GetConnections();
            Class? selectedClas = Application.GetSelectedClass();
            for (int i = 0; i < connections.Count; i++)
            {
                if (connections[i].From == selectedClas || connections[i].To == selectedClas)
                {
                    connections.RemoveAt(i);
                    i--;
                }
            }
            Application.GetClasses().Remove(selectedClas);
        }

        public Image GetImage()
        {
            return PictureManager.DeleteIcon;
        }
    }
}

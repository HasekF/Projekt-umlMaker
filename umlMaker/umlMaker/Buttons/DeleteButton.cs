﻿using System;
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
        public event Action OpenExportMenu;

        public void Click()
        {
            List<Connection> connections = ApplicationGetter.GetConnections();
            Class? selectedClas = ApplicationGetter.GetSelectedClass();
            for (int i = 0; i < connections.Count; i++)
            {
                if (connections[i].From == selectedClas || connections[i].To == selectedClas)
                {
                    connections.RemoveAt(i);
                    i--;
                }
            }
            ApplicationGetter.GetClasses().Remove(selectedClas);
        }

        public Bitmap GetImage()
        {
            return PictureManager.DeleteIcon;
        }
    }
}

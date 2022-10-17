using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Buttons
{
    public class ConnectButton : IButton
    {
        public event Action<bool> Connect;

        public void Click()
        {
            Connect(true);
        }

        public Image GetImage()
        {
            return PictureManager.ConnectIcon;
        }
    }
}

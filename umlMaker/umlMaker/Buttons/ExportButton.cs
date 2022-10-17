using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Buttons
{
    public class ExportButton : IButton
    {
        public event Action<bool> Connect;

        public void Click()
        {
            throw new NotImplementedException();
        }

        public Bitmap GetImage()
        {
            return PictureManager.ExportIcon;
        }
    }
}

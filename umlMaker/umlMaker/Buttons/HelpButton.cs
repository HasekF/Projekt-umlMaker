using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Buttons
{
    public class HelpButton : IButton
    {
        public event Action<bool> Connect;
        public event Action OpenExportMenu;
        public void Click()
        {
            Process.Start(new ProcessStartInfo { FileName = @"C:\Users\frant\Documents\GitHub\Projekt-umlMaker\helpWeb\index.html", UseShellExecute = true });
        }

        public Bitmap GetImage()
        {
            return PictureManager.HelpIcon;
        }
    }
}

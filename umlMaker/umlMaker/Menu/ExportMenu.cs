using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Buttons;

namespace umlMaker.Menu
{
    public class ExportMenu : MenuParent
    {
        public ExportMenu()
        {
            AddBox(new ExportToCodeButton(), BoxPosition.UP);
            AddBox(new ExportToImageButton(), BoxPosition.UP);
            AddBox(new ExportToFileButton(), BoxPosition.UP);

        }
    }
}

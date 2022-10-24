using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Buttons;

namespace umlMaker.Menu
{
    public class MainMenu : MenuParent
    {
        public MainMenu()
        {
            AddBox(new AddButton(), BoxPosition.UP);
            AddBox(new HelpButton(), BoxPosition.DOWN);
            AddBox(new ImportButton(), BoxPosition.DOWN);
            AddBox(new ExportButton(), BoxPosition.DOWN);

        }
    }
}

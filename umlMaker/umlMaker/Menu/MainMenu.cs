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
        }
    }
}

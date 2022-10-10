using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker.Menu
{
    public class MainMenu : MenuParent
    {
        public MainMenu()
        {
            AddBox(Picture.PLUS, BoxPosition.UP);
        }
    }
}

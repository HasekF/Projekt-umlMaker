using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Menu;

namespace umlMaker.Menu
{
    public class ClassMenu : MenuParent
    {
        public ClassMenu()
        {
            AddBox(BoxType.EDIT, BoxPosition.UP);
            AddBox(BoxType.KOS, BoxPosition.UP);
        }
    }
}

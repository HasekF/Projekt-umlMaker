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
            AddBox(Picture.EDIT, BoxPosition.UP);
            AddBox(Picture.KOS, BoxPosition.UP);
        }
    }
}

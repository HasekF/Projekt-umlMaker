using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Buttons
{
    public class AddButton : IButton
    {
        public void Click()
        {
            ClassEditor edit = new ClassEditor();
            if (edit.ShowDialog() == DialogResult.OK)
                Application.GetClasses().Add(edit.Preview.Class);
        }
    }
}

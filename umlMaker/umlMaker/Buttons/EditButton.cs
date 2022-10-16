using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;
using umlMaker.Objects;

namespace umlMaker.Buttons
{
    public class EditButton : IButton
    {
        public Class ClassToEdit { get; set; }
        public EditButton(Class classToEdit)
        {
            ClassToEdit = classToEdit;
        }

        public void Click()
        {
            ClassEditor edit = new ClassEditor(ClassToEdit);
            if (edit.ShowDialog() == DialogResult.OK)
                if (edit.Preview.Class != Application.GetSelectedClass())
                    Application.GetClasses().Add(edit.Preview.Class);
        }
    }
}

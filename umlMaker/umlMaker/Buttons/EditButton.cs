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
        public event Action<bool> Connect;

        public void Click()
        {
            ClassEditor edit = new ClassEditor(ApplicationGetter.GetSelectedClass());
            if (edit.ShowDialog() == DialogResult.OK)
                if (edit.Preview.Class != ApplicationGetter.GetSelectedClass())
                    ApplicationGetter.GetClasses().Add(edit.Preview.Class);
        }

        public Bitmap GetImage()
        {
            return PictureManager.EditIcon;
        }
    }
}

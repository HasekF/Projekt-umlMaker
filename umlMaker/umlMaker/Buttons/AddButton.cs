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
        public event Action<bool> Connect;

        public void Click()
        {
            ClassEditor edit = new ClassEditor();
            if (edit.ShowDialog() == DialogResult.OK)
                ApplicationGetter.GetClasses().Add(edit.Preview.Class);
        }

        public Bitmap GetImage()
        {
            return PictureManager.AddIcon;
        }
    }
}

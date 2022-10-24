using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Buttons
{
    public class ExportToCodeButton : IButton
    {
        public event Action<bool> Connect;
        public event Action OpenExportMenu;

        public void Click()
        {
            string path = GetPath();
            if(path != "")
            {
                Directory.CreateDirectory(path);
                ExportCode exportCode = new ExportCode();
                exportCode.Export(path);
            }
        }
        private string GetPath()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.CheckFileExists = false;
            fileDialog.Title = "Save as File";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            return "";
        }
        public Bitmap GetImage()
        {
            return PictureManager.CodeIcon;
        }
    }
}

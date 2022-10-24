using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using umlMaker.Interfaces;

namespace umlMaker.Buttons
{
    internal class ExportToImageButton : IButton
    {
        public event Action<bool> Connect;
        public event Action OpenExportMenu;
        public void Click()
        {
            string path = GetPath();
            if(path != "")
            {
                Image image = new Bitmap(ApplicationGetter.WindowWidth, ApplicationGetter.WindowHeight);
                Graphics g = Graphics.FromImage(image);
                g.Clear(Color.White);
                foreach (var item in ApplicationGetter.GetConnections())
                {
                    item.Draw(g);
                }
                foreach (var item in ApplicationGetter.GetClasses())
                {
                    item.Draw(g);
                }
                image.Save(path + ".png", ImageFormat.Png);
            }
        }

        public Bitmap GetImage()
        {
            return PictureManager.PictureIcon;
        }
        private string GetPath()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Title = "Save as File";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            return "";
        }
    }
}

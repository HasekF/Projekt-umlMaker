using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using umlMaker.Interfaces;
using Formatting = Newtonsoft.Json.Formatting;

namespace umlMaker.Buttons
{
    public class ExportToFileButton : IButton
    {
        public event Action<bool> Connect;
        public event Action OpenExportMenu;
        public void Click()
        {
            string path = GetPath();
            if(path != "")
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                settings.TypeNameHandling = TypeNameHandling.Objects;

                StreamWriter sw = new StreamWriter(path);
                sw.Write(JsonConvert.SerializeObject(ApplicationGetter.WorkSpace, Formatting.Indented, settings));
                sw.Close();
            }
        }
        private string GetPath()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Title = "Save as File";
            fileDialog.Filter = "Json (*.json)|*.json";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            return "";
        }
        public Bitmap GetImage()
        {
            return PictureManager.FileIcon;
        }
    }
}

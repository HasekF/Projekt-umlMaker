using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Interfaces;

namespace umlMaker.Buttons
{
    public class ImportButton : IButton
    {
        public event Action<bool> Connect;
        public event Action OpenExportMenu;
        public void Click()
        {
            string path = GetPath();
            try
            {
                if (path != "")
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                    settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    settings.TypeNameHandling = TypeNameHandling.Objects;

                    StreamReader sr = new StreamReader(path);
                    string text = sr.ReadToEnd();
                    sr.Close();

                    WorkSpace ws = JsonConvert.DeserializeObject<WorkSpace>(text, settings);

                    if(ws != null)
                        ApplicationGetter.WorkSpace = ws;
                }
            }
            catch { }
        }
        private string GetPath()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Title = "Open File";
            fileDialog.Filter = "Json (*.json)|*.json";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            return "";
        }

        public Bitmap GetImage()
        {
            return PictureManager.ImportIcon;
        }
    }
}

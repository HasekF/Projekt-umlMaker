﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlMaker.Interfaces
{
    public interface IButton
    {
        public event Action<bool> Connect;
        public event Action OpenExportMenu;
        public void Click();
        public Bitmap GetImage();
    }
}

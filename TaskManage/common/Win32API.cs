﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskManage.common
{
    public class Win32API
    {
        [DllImport("User32.dll")]
        public static extern bool PtInRect(ref Rectangle r, Point p);
    }
}

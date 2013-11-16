using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace inputGlove
{
    public static class debugHelper
    {
        public static Form1 frmInstance;
        public static ListBox lstDebug;

        public static void addDbgMsg(string msg)
        {
            lstDebug.Items.Add(msg);
        }
    }
}

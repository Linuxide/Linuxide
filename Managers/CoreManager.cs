/*
    Filename: Managers.cs
    Managers.cs is a part of Linuxide. 
    Used for method declaration 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linuxide
{
    public class Core
    {
        public void initMainWindow_Control() // controlling MainWindow controls
        {
            var mainWindow = (Application.OpenForms.OfType<MainWindow>().FirstOrDefault() ?? new MainWindow());
            return;
        }
        public void letMainWindow_Control() // erasing f contents
        {
            var mainWindow = String.Empty;
            return;
        }
    }
}

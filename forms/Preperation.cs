using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using DiskPartWrapper;

namespace Linuxide
{
    public partial class Preperation : Form
    {
        Linuxide.Core core = new Linuxide.Core(); // declaring the coreManager so it can take control of the parent form

        
        public Preperation()
        {
            InitializeComponent();



        }

        private void Preperation_Load(object sender, EventArgs e)
        {
            core.initMainWindow_Control(); // taking over MainWindow control
        }

        private void dlRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (aldlRadio.Checked )
            {
                aldlRadio.Checked = false;
            }
        }
        private void aldlRadio_CheckedChanged( object sender, EventArgs e)
        {
            if (dlRadio.Checked ) 
            { 
                dlRadio.Checked = false;
            }
        }
    }
}

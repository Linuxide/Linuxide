using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace Linuxide
{
    public partial class PartitionManager : Form
    {
        public PartitionManager()
        {
            InitializeComponent();
        }

        public List<String> partitionList = new List<String>();
        public List<String> diskList = new List<String>();

        public int selectedValue = 0;
        public int partcount = 0;
        public string[] Fullpart = new string[256];
        public string[] partNums = new string[256];
        public string[] diskNums = new string[256];
        private void PartitionManager_Load(object sender, EventArgs e)
        {

            Partition_listBox.Items.Clear();

            // Access all partitions using the Windows API and update UI list
            ManagementObjectSearcher win32DiskPartitions = new ManagementObjectSearcher("select * from Win32_DiskPartition");
            foreach (ManagementObject win32DiskPartition in win32DiskPartitions.Get())
            {
                partcount++;
                Fullpart[partcount] = win32DiskPartition["Name"].ToString();
                partNums[partcount] = win32DiskPartition["Index"].ToString();
                diskNums[partcount] = win32DiskPartition["DiskIndex"].ToString();

                Partition_listBox.Items.Add(Fullpart[partcount]);
                partitionList.Add(partNums[partcount]);
                diskList.Add(diskNums[partcount]);
                Console.WriteLine("Partition nums all: {0}", Fullpart[partcount]);

                // Hide warning UI elements
                warning_txt.Visible = false;
                warning_icon.Visible = false;

            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = Partition_listBox.SelectedIndex;
        }
    }
}

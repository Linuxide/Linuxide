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

        //public List<Int16> partitionList = new List<Int16>();
        public int selectedValue = 0;
        public int partcount = 0;
        public string[] Fullpart = new string[256];
        public string[] partNums = new string[256];
        public string[] diskNums = new string[256];
        private void PartitionManager_Load(object sender, EventArgs e)
        {


            Partition_listBox.Items.Clear(); // took me a while to realize that i need this

            // windows API provides me the fucking solution in partition managment, and i was making my own one, oh well, 3 days wasted.
            ManagementObjectSearcher win32DiskPartitions = new ManagementObjectSearcher("select * from Win32_DiskPartition");
            foreach (ManagementObject win32DiskPartition in win32DiskPartitions.Get())
            {
                partcount++;
                Fullpart[partcount] = win32DiskPartition["Name"].ToString();
                partNums[partcount] = win32DiskPartition["Index"].ToString();
                diskNums[partcount] = win32DiskPartition["DiskIndex"].ToString();

                //string part[] = win32DiskPartition["Name"].ToString();
                Partition_listBox.Items.Add(Fullpart[partcount]);
                partitionList.Add(partNums[partcount]);
                diskList.Add(diskNums[partcount]);
                //Console.WriteLine("Partition found:\n{0}",win32DiskPartition["Name"]);
                Console.WriteLine("Partition nums all: {0}", Fullpart[partcount]);

            }
            //warningPanel.Visible = false;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = Partition_listBox.SelectedIndex;

            Console.WriteLine("|Disk Selected: {0}", diskList[selectedValue]);
            Console.WriteLine(" ->Partition of Disk Selected: {0}", partitionList[selectedValue]);
        }
    }
}

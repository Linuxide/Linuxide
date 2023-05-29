using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;
using DiskPartWrapper;

namespace Linuxide
{
    public partial class Preperation : Form
    {
        public string fileName = string.Empty;

        public MainWindow parentForm;
        public Preperation()
        {
            InitializeComponent();
            button1.Enabled = false;
            domainUpDown1.Enabled = false;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { button1.Enabled = true; return; }
            else { button1.Enabled = false; return; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { domainUpDown1.Enabled = true; return; }
            else { domainUpDown1.Enabled = false; return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var filePath = string.Empty;
            using (openFileDialog1)
            {
                openFileDialog1.Filter = "ISO files (*.iso)|*.iso";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Title = "Open ISO file";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName.ToString();
                    textBox1.Text = fileName;
                    // Incomplete... 
                }
            }
        }

        private void Preperation_Load(object sender, EventArgs e)
        {
            return;
        }

        // this disk manager using the windows api contained blood and tears
        public List<String> partitionList = new List<String>();
        public List<String> diskList = new List<String>();

        //public List<Int16> partitionList = new List<Int16>();
        public int selectedValue = 0;
        public int partcount = 0;
        public string[] Fullpart = new string[256];
        public string[] partNums = new string[256];
        public string[] diskNums = new string[256];
        public void button2_Click(object sender, EventArgs e)
        {
            /* broken 
             
            i am lazy af, i need to read some biology as i have fucking exams, so i will do something stupid but hence it will work, who tf cares?
             */


            //nextButton = parentForm.button1;
            //nextButton.Text = string.Empty;

            DiskPart dp = new DiskPart();
            //dp.ShrinkPartition();


            listBox1.Items.Clear(); // took me a while to realize that i need this


            // windows API provides me the fucking solution in partition managment, and i was making my own one, oh well, 3 days wasted.
            ManagementObjectSearcher win32DiskPartitions = new ManagementObjectSearcher("select * from Win32_DiskPartition");
            foreach (ManagementObject win32DiskPartition in win32DiskPartitions.Get())
            {
                partcount++;
                Fullpart[partcount] = win32DiskPartition["Name"].ToString();
                partNums[partcount] = win32DiskPartition["Index"].ToString();
                diskNums[partcount] = win32DiskPartition["DiskIndex"].ToString();

                //string part[] = win32DiskPartition["Name"].ToString();
                listBox1.Items.Add(Fullpart[partcount]);
                partitionList.Add(partNums[partcount]);
                diskList.Add(diskNums[partcount]);
                //Console.WriteLine("Partition found:\n{0}",win32DiskPartition["Name"]);
                Console.WriteLine("Partition nums all: {0}", Fullpart[partcount]);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = listBox1.SelectedIndex;

            Console.WriteLine("|Disk Selected: {0}", diskList[selectedValue]);
            Console.WriteLine(" ->Partition of Disk Selected: {0}", partitionList[selectedValue]);
        }
    }
}

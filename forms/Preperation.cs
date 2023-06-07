using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Management;
using System.Windows.Forms;
using DiskPartWrapper;

namespace Linuxide
{
    public partial class Preperation : Form
    {
        public string fileName = string.Empty;
        public MemoryStream stream;
        
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
            progressBar1.Visible = false;
            return;
        }


        public void button2_Click(object sender, EventArgs e)
        {

            using (StreamWriter memWriter = new StreamWriter(stream)){ // Not working :(
                stream.Position = 0;
                if (stream.Position < 16)
                {
                    stream.Position = 16;
                }
                memWriter.Write("dlStarted");
                memWriter.Flush();
                memWriter.Close();
            }

        }
    }
}

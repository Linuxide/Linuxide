/*
 Linuxide AKA "A tool that helps you to be vegan easily"
 */

using System;
using System.Windows.Forms;

namespace Linuxide
{

    public partial class MainWindow : Form
    {
        public int currentPageNum;
        Welcome welcome = new Welcome();
        Preperation preperation = new Preperation();
        PartitionManager partitionManager = new PartitionManager();

        public MainWindow()
        {
            InitializeComponent();

            button3.Enabled = false;
            welcome.TopLevel = false;
            displayPanel.Controls.Add(welcome);
            welcome.Show();
            return;
        }

        public void nextButtonOff(int fuckyou)
        {
            button1.Enabled = false;
        }
        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            currentPageNum++;
            int totalPageNum = 9 % currentPageNum;


            if (currentPageNum > 0)
            { //if the current page is greater than 0, enable the back button
                button3.Enabled = true;
            }

            if (totalPageNum == currentPageNum)
            {
                currentPageNum = 0;
            }

            if (currentPageNum == 9)
            { // if the current page is equal to the total number of pages, change the name to finish (because what tool should finsish with next, huh?)
                button1.Text = "Finish";
                button3.Enabled = false;
                return; //If the function doesn't stop, it will force close the executeable (oh damn)
            }
            if (button1.Text == "Finish")
            { // if it is the last page, close the app
                button1.Enabled = false; // who the fuck wants next->finish->next here? An endless next/finish?
                Application.Exit();
                return;
            }

            if (currentPageNum == 1)
            {
                displayPanel.Controls.Remove(welcome);
                preperation.TopLevel = false;
                displayPanel.Controls.Add(preperation);
                preperation.Show();
                return;
            }
            if (currentPageNum == 2)
            {
                button3.Enabled = false;
                displayPanel.Controls.Remove(preperation);
                partitionManager.TopLevel = false;
                displayPanel.Controls.Add(partitionManager);
                partitionManager.Show();
                return;
            }
            if (currentPageNum == 3)
            {
                if (displayPanel.Contains(partitionManager)) 
                {
                    if (MessageBox.Show("Are you sure to deploy the installation files to this partition? ANY DATA THAT WERE SAVED TO THIS PARTITION ARE GOING TO BE DELETED! \nContinue with your selection??", "Hey", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        displayPanel.Controls.Remove(partitionManager);
                    }
                    else
                    {
                        currentPageNum--;
                    }
                }
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentPageNum > 0)
            {
                currentPageNum--;
                button3.Enabled = true;
            }

            if (currentPageNum < 0)
            {
                currentPageNum += 1;
            }

            if (currentPageNum <= 0)
            {

                button3.Enabled = false;
            }

            if (currentPageNum == 0)
            {
                displayPanel.Controls.Remove(preperation);
                welcome.TopLevel = false;
                displayPanel.Controls.Add(welcome);
                welcome.Show();
                return;
            }
            if (currentPageNum == 1)
            {
                button3.Enabled = true;
                displayPanel.Controls.Remove(partitionManager);
                partitionManager.TopLevel = false;
                displayPanel.Controls.Add(preperation);
                preperation.Show();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
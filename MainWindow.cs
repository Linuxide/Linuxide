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

        // I was fighting with those shit for a whole day (thankfully i discovered what debuggers are)
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
            Application.Exit(); // exits DUH
            return;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            currentPageNum++;
            int totalPageNum = 9 % currentPageNum; // maths. Thanks bg16 for his help here!


            if (currentPageNum > 0)
            { //if the current page is greater than 0, enable the back button
                button3.Enabled = true;
                //label1.Text = currentPageNum.ToString() " " + totalPageNum.ToString() + " left"; <= For debugging the prev/next buttons
                //return; //<= returning things isn't always good
            }

            // let's hope it won't get past 9 :)
            if (totalPageNum == currentPageNum)
            {
                currentPageNum = 0; // causing amnesia to the counter
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
                return; //debugger == hungry
            }

            if (currentPageNum == 1) //ill-fat code. too lazy for switches
            {
                displayPanel.Controls.Remove(welcome);
                preperation.TopLevel = false;
                displayPanel.Controls.Add(preperation);
                preperation.Show();
                return;
            }
            if (currentPageNum == 2) //ill-fat code. too lazy for switches
            {
                button3.Enabled = false;
                displayPanel.Controls.Remove(preperation);
                partitionManager.TopLevel = false;
                displayPanel.Controls.Add(partitionManager);
                partitionManager.Show();
                return;
            }
            if (currentPageNum == 3) //ill-fat code. too lazy for switches
            {
                if (displayPanel.Controls.Equals(preperation)) // not working :(
                {
                    MessageBox.Show("Hello World!");
                }
                displayPanel.Controls.Remove(preperation);
                partitionManager.TopLevel = false;
                displayPanel.Controls.Add(partitionManager);
                partitionManager.Show();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentPageNum > 0)
            {
                currentPageNum--;
                button3.Enabled = true; //previous-zero hawaii
            }


            if (currentPageNum < 0)
            {
                currentPageNum += 1; // i mean, a rock can understand tf i typed here?
            }

            if (currentPageNum <= 0)
            {

                button3.Enabled = false; // still curious? oh god
            }

            if (currentPageNum == 0) // ill-fat like my body
            {
                displayPanel.Controls.Remove(preperation);
                welcome.TopLevel = false;
                displayPanel.Controls.Add(welcome);
                welcome.Show();
                return;
            }
            if (currentPageNum == 1) //ill-fat code. too lazy for switches
            {
                button3.Enabled = true;
                displayPanel.Controls.Remove(partitionManager);
                partitionManager.TopLevel = false;
                displayPanel.Controls.Add(preperation);
                preperation.Show();
                return;
            }
        }
    }
}
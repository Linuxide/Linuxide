namespace Linuxide
{
    partial class PartitionManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartitionManager));
            this.label1 = new System.Windows.Forms.Label();
            this.Partition_listBox = new System.Windows.Forms.ListBox();
            this.warningPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.warningPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Partition_listBox
            // 
            this.Partition_listBox.BackColor = System.Drawing.SystemColors.Control;
            this.Partition_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Partition_listBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Partition_listBox.FormattingEnabled = true;
            resources.ApplyResources(this.Partition_listBox, "Partition_listBox");
            this.Partition_listBox.Name = "Partition_listBox";
            this.Partition_listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // warningPanel
            // 
            this.warningPanel.Controls.Add(this.pictureBox1);
            this.warningPanel.Controls.Add(this.label2);
            resources.ApplyResources(this.warningPanel, "warningPanel");
            this.warningPanel.Name = "warningPanel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Linuxide.Properties.Resources.warningIcon1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // PartitionManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.warningPanel);
            this.Controls.Add(this.Partition_listBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartitionManager";
            this.Load += new System.EventHandler(this.PartitionManager_Load);
            this.warningPanel.ResumeLayout(false);
            this.warningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Partition_listBox;
        private System.Windows.Forms.Panel warningPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
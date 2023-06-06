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
            this.warning_txt = new System.Windows.Forms.Label();
            this.warning_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.warning_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // warning_txt
            // 
            resources.ApplyResources(this.warning_txt, "warning_txt");
            this.warning_txt.BackColor = System.Drawing.Color.Transparent;
            this.warning_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warning_txt.Name = "warning_txt";
            // 
            // warning_icon
            // 
            this.warning_icon.BackColor = System.Drawing.Color.Transparent;
            this.warning_icon.Image = global::Linuxide.Properties.Resources.warningIcon;
            resources.ApplyResources(this.warning_icon, "warning_icon");
            this.warning_icon.Name = "warning_icon";
            this.warning_icon.TabStop = false;
            // 
            // PartitionManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Linuxide.Properties.Resources.bg_img1;
            this.Controls.Add(this.warning_icon);
            this.Controls.Add(this.warning_txt);
            this.Controls.Add(this.Partition_listBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartitionManager";
            this.Load += new System.EventHandler(this.PartitionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warning_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Partition_listBox;
        private System.Windows.Forms.Label warning_txt;
        private System.Windows.Forms.PictureBox warning_icon;
    }
}
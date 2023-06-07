namespace Linuxide
{
    partial class Preperation
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
            this.label1 = new System.Windows.Forms.Label();
            this.dlRadio = new System.Windows.Forms.RadioButton();
            this.aldlRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "What do you want to do?";
            // 
            // dlRadio
            // 
            this.dlRadio.AutoSize = true;
            this.dlRadio.BackColor = System.Drawing.Color.Transparent;
            this.dlRadio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dlRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dlRadio.Location = new System.Drawing.Point(12, 155);
            this.dlRadio.Name = "dlRadio";
            this.dlRadio.Size = new System.Drawing.Size(230, 24);
            this.dlRadio.TabIndex = 4;
            this.dlRadio.TabStop = true;
            this.dlRadio.Text = "Download a distribution now";
            this.dlRadio.UseVisualStyleBackColor = false;
            this.dlRadio.CheckedChanged += new System.EventHandler(this.dlRadio_CheckedChanged);
            // 
            // aldlRadio
            // 
            this.aldlRadio.AutoSize = true;
            this.aldlRadio.BackColor = System.Drawing.Color.Transparent;
            this.aldlRadio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.aldlRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aldlRadio.Location = new System.Drawing.Point(12, 266);
            this.aldlRadio.Name = "aldlRadio";
            this.aldlRadio.Size = new System.Drawing.Size(241, 24);
            this.aldlRadio.TabIndex = 5;
            this.aldlRadio.TabStop = true;
            this.aldlRadio.Text = "Use a downloaded distribution";
            this.aldlRadio.UseVisualStyleBackColor = false;
            // 
            // Preperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Linuxide.Properties.Resources.bg_img1;
            this.ClientSize = new System.Drawing.Size(621, 474);
            this.Controls.Add(this.aldlRadio);
            this.Controls.Add(this.dlRadio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Preperation";
            this.Text = "Preperation";
            this.Load += new System.EventHandler(this.Preperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dlRadio;
        private System.Windows.Forms.RadioButton aldlRadio;
    }
}
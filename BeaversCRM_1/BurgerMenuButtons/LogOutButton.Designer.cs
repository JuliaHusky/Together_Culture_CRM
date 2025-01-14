using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class LogOutButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOutButton));
            this.logOutBtnPanel = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.PictureBox();
            this.logOutBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtnPanel
            // 
            this.logOutBtnPanel.Controls.Add(this.logOutBtn);
            this.logOutBtnPanel.Location = new System.Drawing.Point(0, 0);
            this.logOutBtnPanel.Margin = new System.Windows.Forms.Padding(0);
            this.logOutBtnPanel.Name = "logOutBtnPanel";
            this.logOutBtnPanel.Size = new System.Drawing.Size(141, 31);
            this.logOutBtnPanel.TabIndex = 5;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.Location = new System.Drawing.Point(41, 5);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(59, 21);
            this.logOutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.TabStop = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // LogOutButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logOutBtnPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogOutButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.logOutBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logOutBtn)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel logOutBtnPanel;
        private System.Windows.Forms.PictureBox logOutBtn;

        #endregion
    }
}
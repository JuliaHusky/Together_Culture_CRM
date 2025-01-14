using System.ComponentModel;

namespace BeaversCRM_1
{
    partial class EventControl
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

        #region Component Designer generated codeupcomingEvents

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventDescriptionPanel = new System.Windows.Forms.Panel();
            this.eventDescriptionLabel = new System.Windows.Forms.Label();
            this.eventPicture = new System.Windows.Forms.PictureBox();
            this.eventPanel = new System.Windows.Forms.Panel();
            this.eventDescriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventPicture)).BeginInit();
            this.eventPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(89, 3);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(232, 18);
            this.eventNameLabel.TabIndex = 0;
            this.eventNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eventNameLabel.Click += new System.EventHandler(this.eventNameLabel_Click);
            // 
            // eventDescriptionPanel
            // 
            this.eventDescriptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.eventDescriptionPanel.BackColor = System.Drawing.Color.Black;
            this.eventDescriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventDescriptionPanel.Controls.Add(this.eventDescriptionLabel);
            this.eventDescriptionPanel.Controls.Add(this.eventPicture);
            this.eventDescriptionPanel.Location = new System.Drawing.Point(13, 27);
            this.eventDescriptionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.eventDescriptionPanel.Name = "eventDescriptionPanel";
            this.eventDescriptionPanel.Size = new System.Drawing.Size(384, 69);
            this.eventDescriptionPanel.TabIndex = 1;
            // 
            // eventDescriptionLabel
            // 
            this.eventDescriptionLabel.BackColor = System.Drawing.Color.White;
            this.eventDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.eventDescriptionLabel.Location = new System.Drawing.Point(96, 0);
            this.eventDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventDescriptionLabel.Name = "eventDescriptionLabel";
            this.eventDescriptionLabel.Size = new System.Drawing.Size(286, 67);
            this.eventDescriptionLabel.TabIndex = 1;
            this.eventDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventPicture
            // 
            this.eventPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.eventPicture.Location = new System.Drawing.Point(0, 0);
            this.eventPicture.Margin = new System.Windows.Forms.Padding(2);
            this.eventPicture.Name = "eventPicture";
            this.eventPicture.Size = new System.Drawing.Size(92, 67);
            this.eventPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventPicture.TabIndex = 0;
            this.eventPicture.TabStop = false;
            // 
            // eventPanel
            // 
            this.eventPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.eventPanel.Controls.Add(this.eventDescriptionPanel);
            this.eventPanel.Controls.Add(this.eventNameLabel);
            this.eventPanel.Location = new System.Drawing.Point(0, 0);
            this.eventPanel.Margin = new System.Windows.Forms.Padding(2);
            this.eventPanel.Name = "eventPanel";
            this.eventPanel.Size = new System.Drawing.Size(410, 104);
            this.eventPanel.TabIndex = 1;
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.eventPanel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(410, 104);
            this.eventDescriptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventPicture)).EndInit();
            this.eventPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Panel eventDescriptionPanel;
        public System.Windows.Forms.PictureBox eventPicture;
        public System.Windows.Forms.Label eventDescriptionLabel;
        private System.Windows.Forms.Panel eventPanel;

        #endregion
    }
}
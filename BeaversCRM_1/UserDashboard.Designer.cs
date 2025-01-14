namespace BeaversCRM_1
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.BenefitsButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.recommendedTextBox2 = new System.Windows.Forms.TextBox();
            this.recommendedTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EventsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.Event2 = new System.Windows.Forms.TextBox();
            this.Event3 = new System.Windows.Forms.TextBox();
            this.Event4 = new System.Windows.Forms.TextBox();
            this.Event5 = new System.Windows.Forms.TextBox();
            this.burgerMenu1 = new BeaversCRM_1.BurgerMenu();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.EventsFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // BenefitsButton
            // 
            this.BenefitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenefitsButton.Location = new System.Drawing.Point(506, 428);
            this.BenefitsButton.Name = "BenefitsButton";
            this.BenefitsButton.Size = new System.Drawing.Size(311, 93);
            this.BenefitsButton.TabIndex = 0;
            this.BenefitsButton.Text = "View your available benefits";
            this.BenefitsButton.UseVisualStyleBackColor = true;
            this.BenefitsButton.Click += new System.EventHandler(this.BenefitsButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.recommendedTextBox2);
            this.panel3.Controls.Add(this.recommendedTextBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(503, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 224);
            this.panel3.TabIndex = 0;
            // 
            // recommendedTextBox2
            // 
            this.recommendedTextBox2.Location = new System.Drawing.Point(0, 138);
            this.recommendedTextBox2.Multiline = true;
            this.recommendedTextBox2.Name = "recommendedTextBox2";
            this.recommendedTextBox2.ReadOnly = true;
            this.recommendedTextBox2.Size = new System.Drawing.Size(321, 109);
            this.recommendedTextBox2.TabIndex = 8;
            // 
            // recommendedTextBox1
            // 
            this.recommendedTextBox1.Location = new System.Drawing.Point(0, 26);
            this.recommendedTextBox1.Multiline = true;
            this.recommendedTextBox1.Name = "recommendedTextBox1";
            this.recommendedTextBox1.ReadOnly = true;
            this.recommendedTextBox1.Size = new System.Drawing.Size(321, 109);
            this.recommendedTextBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recommended Events";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(142, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 55);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.EventsFlow);
            this.panel2.Location = new System.Drawing.Point(150, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 349);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upcoming Events";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventsFlow
            // 
            this.EventsFlow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventsFlow.AutoScroll = true;
            this.EventsFlow.Controls.Add(this.Event2);
            this.EventsFlow.Controls.Add(this.Event3);
            this.EventsFlow.Controls.Add(this.Event4);
            this.EventsFlow.Controls.Add(this.Event5);
            this.EventsFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EventsFlow.Location = new System.Drawing.Point(0, 10);
            this.EventsFlow.Name = "EventsFlow";
            this.EventsFlow.Size = new System.Drawing.Size(323, 375);
            this.EventsFlow.TabIndex = 4;
            this.EventsFlow.WrapContents = false;
            // 
            // Event2
            // 
            this.Event2.Location = new System.Drawing.Point(3, 3);
            this.Event2.Multiline = true;
            this.Event2.Name = "Event2";
            this.Event2.ReadOnly = true;
            this.Event2.Size = new System.Drawing.Size(327, 109);
            this.Event2.TabIndex = 1;
            // 
            // Event3
            // 
            this.Event3.Location = new System.Drawing.Point(3, 118);
            this.Event3.Multiline = true;
            this.Event3.Name = "Event3";
            this.Event3.ReadOnly = true;
            this.Event3.Size = new System.Drawing.Size(327, 109);
            this.Event3.TabIndex = 3;
            // 
            // Event4
            // 
            this.Event4.Location = new System.Drawing.Point(3, 233);
            this.Event4.Multiline = true;
            this.Event4.Name = "Event4";
            this.Event4.ReadOnly = true;
            this.Event4.Size = new System.Drawing.Size(327, 109);
            this.Event4.TabIndex = 4;
            // 
            // Event5
            // 
            this.Event5.Location = new System.Drawing.Point(3, 348);
            this.Event5.Multiline = true;
            this.Event5.Name = "Event5";
            this.Event5.ReadOnly = true;
            this.Event5.Size = new System.Drawing.Size(327, 109);
            this.Event5.TabIndex = 5;
            // 
            // burgerMenu1
            // 
            this.burgerMenu1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.burgerMenu1.Location = new System.Drawing.Point(0, 0);
            this.burgerMenu1.Name = "burgerMenu1";
            this.burgerMenu1.Size = new System.Drawing.Size(144, 287);
            this.burgerMenu1.TabIndex = 7;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(985, 665);
            this.Controls.Add(this.burgerMenu1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BenefitsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Together Culture CRM";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.EventsFlow.ResumeLayout(false);
            this.EventsFlow.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button BenefitsButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recommendedTextBox2;
        private System.Windows.Forms.TextBox recommendedTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel EventsFlow;
        private System.Windows.Forms.TextBox Event2;
        private System.Windows.Forms.TextBox Event3;
        private System.Windows.Forms.TextBox Event4;
        private System.Windows.Forms.TextBox Event5;
        private BurgerMenu burgerMenu1;
    }
}
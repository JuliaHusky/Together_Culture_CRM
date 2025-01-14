namespace BeaversCRM_1
{
    partial class ModuleBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleBooking));
            this.TCLOGO = new System.Windows.Forms.PictureBox();
            this.TopOfPage = new System.Windows.Forms.PictureBox();
            this.DigitalModuleTitleLbl = new System.Windows.Forms.Label();
            this.ModuleFlowPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.TCLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopOfPage)).BeginInit();
            this.SuspendLayout();
            // 
            // TCLOGO
            // 
            this.TCLOGO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TCLOGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.TCLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TCLOGO.Image = ((System.Drawing.Image)(resources.GetObject("TCLOGO.Image")));
            this.TCLOGO.Location = new System.Drawing.Point(849, 1);
            this.TCLOGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TCLOGO.Name = "TCLOGO";
            this.TCLOGO.Size = new System.Drawing.Size(291, 176);
            this.TCLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TCLOGO.TabIndex = 6;
            this.TCLOGO.TabStop = false;
            // 
            // TopOfPage
            // 
            this.TopOfPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.TopOfPage.Location = new System.Drawing.Point(-529, 1);
            this.TopOfPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopOfPage.Name = "TopOfPage";
            this.TopOfPage.Size = new System.Drawing.Size(1541, 176);
            this.TopOfPage.TabIndex = 7;
            this.TopOfPage.TabStop = false;
            // 
            // DigitalModuleTitleLbl
            // 
            this.DigitalModuleTitleLbl.AutoSize = true;
            this.DigitalModuleTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigitalModuleTitleLbl.Location = new System.Drawing.Point(383, 215);
            this.DigitalModuleTitleLbl.Name = "DigitalModuleTitleLbl";
            this.DigitalModuleTitleLbl.Size = new System.Drawing.Size(437, 42);
            this.DigitalModuleTitleLbl.TabIndex = 8;
            this.DigitalModuleTitleLbl.Text = "Digital Content Modules";
            this.DigitalModuleTitleLbl.Click += new System.EventHandler(this.DigitalModuleTitleLbl_Click);
            // 
            // ModuleFlowPanel1
            // 
            this.ModuleFlowPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ModuleFlowPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ModuleFlowPanel1.Location = new System.Drawing.Point(247, 297);
            this.ModuleFlowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModuleFlowPanel1.Name = "ModuleFlowPanel1";
            this.ModuleFlowPanel1.Size = new System.Drawing.Size(666, 363);
            this.ModuleFlowPanel1.TabIndex = 9;
            this.ModuleFlowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.ModuleFlowPanel1_Paint);
            // 
            // ModuleBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 735);
            this.Controls.Add(this.ModuleFlowPanel1);
            this.Controls.Add(this.DigitalModuleTitleLbl);
            this.Controls.Add(this.TCLOGO);
            this.Controls.Add(this.TopOfPage);
            this.Name = "ModuleBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuleBooking";
            ((System.ComponentModel.ISupportInitialize)(this.TCLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopOfPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TCLOGO;
        private System.Windows.Forms.PictureBox TopOfPage;
        private System.Windows.Forms.Label DigitalModuleTitleLbl;
        private System.Windows.Forms.FlowLayoutPanel ModuleFlowPanel1;
    }
}
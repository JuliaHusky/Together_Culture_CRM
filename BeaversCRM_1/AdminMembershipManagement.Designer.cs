namespace BeaversCRM_1
{
    partial class AdminMembershipManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMembershipManagement));
            this.TCLOGO = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminMembershipTitle = new System.Windows.Forms.TextBox();
            this.MembershipTiers = new System.Windows.Forms.Button();
            this.ChangeMInfo = new System.Windows.Forms.Button();
            this.QuickSearchVScrollBar = new System.Windows.Forms.VScrollBar();
            this.MemberNameTitleLbl = new System.Windows.Forms.Label();
            this.MemberIDTitleLbl = new System.Windows.Forms.Label();
            this.MembershipTierTitleLbl = new System.Windows.Forms.Label();
            this.ExpiryDateTitleLbl = new System.Windows.Forms.Label();
            this.QuickSearchTitle = new System.Windows.Forms.Label();
            this.QuickSearchBox = new System.Windows.Forms.TextBox();
            this.QuickSearchBtn = new System.Windows.Forms.Button();
            this.MemberNameOutputLbl = new System.Windows.Forms.Label();
            this.burgerMenu1 = new BeaversCRM_1.BurgerMenu();
            ((System.ComponentModel.ISupportInitialize)(this.TCLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TCLOGO
            // 
            this.TCLOGO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TCLOGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.TCLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TCLOGO.Image = ((System.Drawing.Image)(resources.GetObject("TCLOGO.Image")));
            this.TCLOGO.Location = new System.Drawing.Point(1454, -3);
            this.TCLOGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TCLOGO.Name = "TCLOGO";
            this.TCLOGO.Size = new System.Drawing.Size(415, 194);
            this.TCLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TCLOGO.TabIndex = 6;
            this.TCLOGO.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pictureBox1.Location = new System.Drawing.Point(2, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1692, 194);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMembershipTitle
            // 
            this.AdminMembershipTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdminMembershipTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminMembershipTitle.Font = new System.Drawing.Font("Segoe UI Black", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMembershipTitle.Location = new System.Drawing.Point(439, 218);
            this.AdminMembershipTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminMembershipTitle.Name = "AdminMembershipTitle";
            this.AdminMembershipTitle.ReadOnly = true;
            this.AdminMembershipTitle.Size = new System.Drawing.Size(1014, 77);
            this.AdminMembershipTitle.TabIndex = 8;
            this.AdminMembershipTitle.Text = "Admin Membership Management";
            this.AdminMembershipTitle.TextChanged += new System.EventHandler(this.BenefitsHubTitle_TextChanged);
            // 
            // MembershipTiers
            // 
            this.MembershipTiers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MembershipTiers.BackColor = System.Drawing.Color.RosyBrown;
            this.MembershipTiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipTiers.Location = new System.Drawing.Point(520, 335);
            this.MembershipTiers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MembershipTiers.Name = "MembershipTiers";
            this.MembershipTiers.Size = new System.Drawing.Size(261, 112);
            this.MembershipTiers.TabIndex = 10;
            this.MembershipTiers.Text = "View Membership Tiers";
            this.MembershipTiers.UseVisualStyleBackColor = false;
            this.MembershipTiers.Click += new System.EventHandler(this.MembershipTiers_Click);
            // 
            // ChangeMInfo
            // 
            this.ChangeMInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeMInfo.BackColor = System.Drawing.Color.RosyBrown;
            this.ChangeMInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeMInfo.Location = new System.Drawing.Point(932, 335);
            this.ChangeMInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeMInfo.Name = "ChangeMInfo";
            this.ChangeMInfo.Size = new System.Drawing.Size(261, 112);
            this.ChangeMInfo.TabIndex = 11;
            this.ChangeMInfo.Text = "Change Member Information";
            this.ChangeMInfo.UseVisualStyleBackColor = false;
            this.ChangeMInfo.Click += new System.EventHandler(this.ChangeMInfo_Click);
            // 
            // QuickSearchVScrollBar
            // 
            this.QuickSearchVScrollBar.Location = new System.Drawing.Point(1291, 537);
            this.QuickSearchVScrollBar.Name = "QuickSearchVScrollBar";
            this.QuickSearchVScrollBar.Size = new System.Drawing.Size(21, 100);
            this.QuickSearchVScrollBar.TabIndex = 12;
            this.QuickSearchVScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.QuickSearchVScrollBar_Scroll);
            // 
            // MemberNameTitleLbl
            // 
            this.MemberNameTitleLbl.AutoSize = true;
            this.MemberNameTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameTitleLbl.Location = new System.Drawing.Point(465, 664);
            this.MemberNameTitleLbl.Name = "MemberNameTitleLbl";
            this.MemberNameTitleLbl.Size = new System.Drawing.Size(180, 29);
            this.MemberNameTitleLbl.TabIndex = 13;
            this.MemberNameTitleLbl.Text = "Member Name:";
            this.MemberNameTitleLbl.Click += new System.EventHandler(this.MemberNameTitleLbl_Click);
            // 
            // MemberIDTitleLbl
            // 
            this.MemberIDTitleLbl.AutoSize = true;
            this.MemberIDTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDTitleLbl.Location = new System.Drawing.Point(691, 664);
            this.MemberIDTitleLbl.Name = "MemberIDTitleLbl";
            this.MemberIDTitleLbl.Size = new System.Drawing.Size(183, 29);
            this.MemberIDTitleLbl.TabIndex = 14;
            this.MemberIDTitleLbl.Text = "Membership ID:";
            this.MemberIDTitleLbl.Click += new System.EventHandler(this.MemberIDTitleLbl_Click);
            // 
            // MembershipTierTitleLbl
            // 
            this.MembershipTierTitleLbl.AutoSize = true;
            this.MembershipTierTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipTierTitleLbl.Location = new System.Drawing.Point(905, 664);
            this.MembershipTierTitleLbl.Name = "MembershipTierTitleLbl";
            this.MembershipTierTitleLbl.Size = new System.Drawing.Size(204, 29);
            this.MembershipTierTitleLbl.TabIndex = 15;
            this.MembershipTierTitleLbl.Text = "Membership Tier:";
            this.MembershipTierTitleLbl.Click += new System.EventHandler(this.MembershipTierTitleLbl_Click);
            // 
            // ExpiryDateTitleLbl
            // 
            this.ExpiryDateTitleLbl.AutoSize = true;
            this.ExpiryDateTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDateTitleLbl.Location = new System.Drawing.Point(1142, 664);
            this.ExpiryDateTitleLbl.Name = "ExpiryDateTitleLbl";
            this.ExpiryDateTitleLbl.Size = new System.Drawing.Size(141, 29);
            this.ExpiryDateTitleLbl.TabIndex = 16;
            this.ExpiryDateTitleLbl.Text = "Expiry Date:";
            this.ExpiryDateTitleLbl.Click += new System.EventHandler(this.ExpiryDateTitleLbl_Click);
            // 
            // QuickSearchTitle
            // 
            this.QuickSearchTitle.AutoSize = true;
            this.QuickSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickSearchTitle.Location = new System.Drawing.Point(465, 508);
            this.QuickSearchTitle.Name = "QuickSearchTitle";
            this.QuickSearchTitle.Size = new System.Drawing.Size(274, 29);
            this.QuickSearchTitle.TabIndex = 17;
            this.QuickSearchTitle.Text = "Quick search a member:";
            this.QuickSearchTitle.Click += new System.EventHandler(this.QuickSearchTitle_Click);
            // 
            // QuickSearchBox
            // 
            this.QuickSearchBox.Location = new System.Drawing.Point(620, 570);
            this.QuickSearchBox.Name = "QuickSearchBox";
            this.QuickSearchBox.Size = new System.Drawing.Size(506, 22);
            this.QuickSearchBox.TabIndex = 18;
            this.QuickSearchBox.TextChanged += new System.EventHandler(this.QuickSearchBox_TextChanged);
            // 
            // QuickSearchBtn
            // 
            this.QuickSearchBtn.Location = new System.Drawing.Point(1132, 570);
            this.QuickSearchBtn.Name = "QuickSearchBtn";
            this.QuickSearchBtn.Size = new System.Drawing.Size(70, 44);
            this.QuickSearchBtn.TabIndex = 19;
            this.QuickSearchBtn.Text = "Search";
            this.QuickSearchBtn.UseVisualStyleBackColor = true;
            this.QuickSearchBtn.Click += new System.EventHandler(this.QuickSearchBtn_Click);
            // 
            // MemberNameOutputLbl
            // 
            this.MemberNameOutputLbl.AutoSize = true;
            this.MemberNameOutputLbl.Location = new System.Drawing.Point(531, 732);
            this.MemberNameOutputLbl.Name = "MemberNameOutputLbl";
            this.MemberNameOutputLbl.Size = new System.Drawing.Size(44, 16);
            this.MemberNameOutputLbl.TabIndex = 20;
            this.MemberNameOutputLbl.Text = "label1";
            // 
            // burgerMenu1
            // 
            this.burgerMenu1.Location = new System.Drawing.Point(2, 124);
            this.burgerMenu1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.burgerMenu1.Name = "burgerMenu1";
            this.burgerMenu1.Size = new System.Drawing.Size(192, 353);
            this.burgerMenu1.TabIndex = 21;
            // 
            // AdminMembershipManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1710, 844);
            this.Controls.Add(this.burgerMenu1);
            this.Controls.Add(this.MemberNameOutputLbl);
            this.Controls.Add(this.QuickSearchBtn);
            this.Controls.Add(this.QuickSearchBox);
            this.Controls.Add(this.QuickSearchTitle);
            this.Controls.Add(this.ExpiryDateTitleLbl);
            this.Controls.Add(this.MembershipTierTitleLbl);
            this.Controls.Add(this.MemberIDTitleLbl);
            this.Controls.Add(this.MemberNameTitleLbl);
            this.Controls.Add(this.QuickSearchVScrollBar);
            this.Controls.Add(this.ChangeMInfo);
            this.Controls.Add(this.MembershipTiers);
            this.Controls.Add(this.AdminMembershipTitle);
            this.Controls.Add(this.TCLOGO);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMembershipManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMembershipManagement";
            this.Load += new System.EventHandler(this.AdminMembershipManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TCLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TCLOGO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox AdminMembershipTitle;
        private System.Windows.Forms.Button MembershipTiers;
        private System.Windows.Forms.Button ChangeMInfo;
        private System.Windows.Forms.VScrollBar QuickSearchVScrollBar;
        private System.Windows.Forms.Label MemberNameTitleLbl;
        private System.Windows.Forms.Label MemberIDTitleLbl;
        private System.Windows.Forms.Label MembershipTierTitleLbl;
        private System.Windows.Forms.Label ExpiryDateTitleLbl;
        private System.Windows.Forms.Label QuickSearchTitle;
        private System.Windows.Forms.TextBox QuickSearchBox;
        private System.Windows.Forms.Button QuickSearchBtn;
        private System.Windows.Forms.Label MemberNameOutputLbl;
        private BurgerMenu burgerMenu1;
    }
}
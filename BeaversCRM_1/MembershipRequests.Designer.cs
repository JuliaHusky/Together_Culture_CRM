using System.ComponentModel;

namespace BeaversCRM_1
{
    partial class MembershipRequests
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipRequests));
            this.pageHeaderPanel = new System.Windows.Forms.Panel();
            this.pageNameLabel = new System.Windows.Forms.Label();
            this.TogCulLogoBox = new System.Windows.Forms.PictureBox();
            this.requestsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBarAndFiltersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tagFilter = new System.Windows.Forms.ComboBox();
            this.dateFilter = new System.Windows.Forms.ComboBox();
            this.searchBar = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBarTextBox = new System.Windows.Forms.TextBox();
            this.burgerMenu1 = new BeaversCRM_1.BurgerMenu();
            this.pageHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TogCulLogoBox)).BeginInit();
            this.searchBarAndFiltersPanel.SuspendLayout();
            this.searchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeaderPanel
            // 
            this.pageHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pageHeaderPanel.Controls.Add(this.pageNameLabel);
            this.pageHeaderPanel.Controls.Add(this.TogCulLogoBox);
            this.pageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.pageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pageHeaderPanel.Name = "pageHeaderPanel";
            this.pageHeaderPanel.Size = new System.Drawing.Size(918, 68);
            this.pageHeaderPanel.TabIndex = 2;
            // 
            // pageNameLabel
            // 
            this.pageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNameLabel.Location = new System.Drawing.Point(330, 18);
            this.pageNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pageNameLabel.Name = "pageNameLabel";
            this.pageNameLabel.Size = new System.Drawing.Size(258, 24);
            this.pageNameLabel.TabIndex = 1;
            this.pageNameLabel.Text = "Membership Requests";
            this.pageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TogCulLogoBox
            // 
            this.TogCulLogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TogCulLogoBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.TogCulLogoBox.Image = ((System.Drawing.Image)(resources.GetObject("TogCulLogoBox.Image")));
            this.TogCulLogoBox.Location = new System.Drawing.Point(782, 0);
            this.TogCulLogoBox.Margin = new System.Windows.Forms.Padding(2);
            this.TogCulLogoBox.Name = "TogCulLogoBox";
            this.TogCulLogoBox.Size = new System.Drawing.Size(136, 68);
            this.TogCulLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TogCulLogoBox.TabIndex = 0;
            this.TogCulLogoBox.TabStop = false;
            // 
            // requestsPanel
            // 
            this.requestsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.requestsPanel.AutoScroll = true;
            this.requestsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.requestsPanel.Location = new System.Drawing.Point(159, 194);
            this.requestsPanel.Name = "requestsPanel";
            this.requestsPanel.Size = new System.Drawing.Size(649, 450);
            this.requestsPanel.TabIndex = 3;
            this.requestsPanel.WrapContents = false;
            // 
            // searchBarAndFiltersPanel
            // 
            this.searchBarAndFiltersPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBarAndFiltersPanel.Controls.Add(this.tagFilter);
            this.searchBarAndFiltersPanel.Controls.Add(this.dateFilter);
            this.searchBarAndFiltersPanel.Controls.Add(this.searchBar);
            this.searchBarAndFiltersPanel.Controls.Add(this.searchButton);
            this.searchBarAndFiltersPanel.Controls.Add(this.searchBarTextBox);
            this.searchBarAndFiltersPanel.Location = new System.Drawing.Point(146, 104);
            this.searchBarAndFiltersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchBarAndFiltersPanel.Name = "searchBarAndFiltersPanel";
            this.searchBarAndFiltersPanel.Size = new System.Drawing.Size(674, 60);
            this.searchBarAndFiltersPanel.TabIndex = 5;
            // 
            // tagFilter
            // 
            this.tagFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tagFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagFilter.FormattingEnabled = true;
            this.tagFilter.Items.AddRange(new object[] { "Learning", "Sharing", "Working", "Happening", "Caring" });
            this.tagFilter.Location = new System.Drawing.Point(6, 19);
            this.tagFilter.Margin = new System.Windows.Forms.Padding(6, 19, 3, 19);
            this.tagFilter.Name = "tagFilter";
            this.tagFilter.Size = new System.Drawing.Size(75, 21);
            this.tagFilter.TabIndex = 6;
            this.tagFilter.SelectedIndexChanged += new System.EventHandler(this.tagFilter_SelectedIndexChanged);
            // 
            // dateFilter
            // 
            this.dateFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilter.FormattingEnabled = true;
            this.dateFilter.Items.AddRange(new object[] { "Latest", "Oldest" });
            this.dateFilter.Location = new System.Drawing.Point(90, 19);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(6, 19, 3, 19);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(75, 21);
            this.dateFilter.TabIndex = 7;
            this.dateFilter.SelectedIndexChanged += new System.EventHandler(this.dateFilter_SelectedIndexChanged);
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Controls.Add(this.searchTextBox);
            this.searchBar.Location = new System.Drawing.Point(178, 10);
            this.searchBar.Margin = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(417, 40);
            this.searchBar.TabIndex = 7;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.searchTextBox.Location = new System.Drawing.Point(11, 11);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(394, 18);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Search for requests...";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.BorderSize = 2;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(599, 10);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 10, 2, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(70, 40);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBarTextBox
            // 
            this.searchBarTextBox.AcceptsReturn = true;
            this.searchBarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBarTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.searchBarTextBox.Location = new System.Drawing.Point(2, 62);
            this.searchBarTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBarTextBox.Name = "searchBarTextBox";
            this.searchBarTextBox.Size = new System.Drawing.Size(312, 24);
            this.searchBarTextBox.TabIndex = 6;
            this.searchBarTextBox.Text = "Search";
            this.searchBarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // burgerMenu1
            // 
            this.burgerMenu1.Location = new System.Drawing.Point(5, 13);
            this.burgerMenu1.Name = "burgerMenu1";
            this.burgerMenu1.Size = new System.Drawing.Size(144, 287);
            this.burgerMenu1.TabIndex = 6;
            // 
            // MembershipRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 680);
            this.Controls.Add(this.burgerMenu1);
            this.Controls.Add(this.searchBarAndFiltersPanel);
            this.Controls.Add(this.requestsPanel);
            this.Controls.Add(this.pageHeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MembershipRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembershipRequests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MembershipRequests_FormClosed);
            this.Shown += new System.EventHandler(this.MembershipRequests_Shown);
            this.pageHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TogCulLogoBox)).EndInit();
            this.searchBarAndFiltersPanel.ResumeLayout(false);
            this.searchBarAndFiltersPanel.PerformLayout();
            this.searchBar.ResumeLayout(false);
            this.searchBar.PerformLayout();
            this.ResumeLayout(false);
        }

        private BeaversCRM_1.BurgerMenu burgerMenu1;

        private System.Windows.Forms.ComboBox tagFilter;

        private System.Windows.Forms.Button searchButton;

        private System.Windows.Forms.TextBox searchTextBox;

        private System.Windows.Forms.Panel searchBar;
        private System.Windows.Forms.FlowLayoutPanel searchBarAndFiltersPanel;
        private System.Windows.Forms.TextBox searchBarTextBox;

        private System.Windows.Forms.ComboBox dateFilter;

        private System.Windows.Forms.FlowLayoutPanel requestsPanel;

        private System.Windows.Forms.Panel pageHeaderPanel;
        private System.Windows.Forms.Label pageNameLabel;
        private System.Windows.Forms.PictureBox TogCulLogoBox;

        #endregion
    }
}
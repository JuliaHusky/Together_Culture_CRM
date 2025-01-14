namespace BeaversCRM_1
{
    partial class EventManagementAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManagementAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCreateEvent = new System.Windows.Forms.Button();
            this.lbNumberOfAttendees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEventTag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbMemberships = new System.Windows.Forms.ComboBox();
            this.tbAttendeeSearch = new System.Windows.Forms.TextBox();
            this.btAllEvents = new System.Windows.Forms.Button();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdminDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMemRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTagManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btCreateEvent);
            this.panel1.Controls.Add(this.lbNumberOfAttendees);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbEventTag);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btAllEvents);
            this.panel1.Controls.Add(this.cbEvents);
            this.panel1.Controls.Add(this.dgvEvents);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 695);
            this.panel1.TabIndex = 0;
            // 
            // btCreateEvent
            // 
            this.btCreateEvent.BackColor = System.Drawing.Color.LightGray;
            this.btCreateEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateEvent.Location = new System.Drawing.Point(754, 213);
            this.btCreateEvent.Name = "btCreateEvent";
            this.btCreateEvent.Size = new System.Drawing.Size(220, 37);
            this.btCreateEvent.TabIndex = 12;
            this.btCreateEvent.Text = "CREATE EVENT";
            this.btCreateEvent.UseVisualStyleBackColor = false;
            this.btCreateEvent.Click += new System.EventHandler(this.btCreateEvent_Click);
            // 
            // lbNumberOfAttendees
            // 
            this.lbNumberOfAttendees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumberOfAttendees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbNumberOfAttendees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNumberOfAttendees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbNumberOfAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfAttendees.ForeColor = System.Drawing.Color.Black;
            this.lbNumberOfAttendees.Location = new System.Drawing.Point(689, 219);
            this.lbNumberOfAttendees.Name = "lbNumberOfAttendees";
            this.lbNumberOfAttendees.Size = new System.Drawing.Size(56, 25);
            this.lbNumberOfAttendees.TabIndex = 11;
            this.lbNumberOfAttendees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(485, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Number Of Attendees";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEventTag
            // 
            this.lbEventTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEventTag.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbEventTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEventTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbEventTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventTag.ForeColor = System.Drawing.Color.Black;
            this.lbEventTag.Location = new System.Drawing.Point(337, 219);
            this.lbEventTag.Name = "lbEventTag";
            this.lbEventTag.Size = new System.Drawing.Size(139, 25);
            this.lbEventTag.TabIndex = 9;
            this.lbEventTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(258, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Event tag";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtpStartDate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtpEndDate);
            this.panel4.Controls.Add(this.cbMemberships);
            this.panel4.Controls.Add(this.tbAttendeeSearch);
            this.panel4.Location = new System.Drawing.Point(258, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(716, 26);
            this.panel4.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpStartDate.Checked = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(233, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(178, 24);
            this.dtpStartDate.TabIndex = 8;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "FILTER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(411, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(178, 24);
            this.dtpEndDate.TabIndex = 9;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // cbMemberships
            // 
            this.cbMemberships.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMemberships.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMemberships.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMemberships.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbMemberships.FormattingEnabled = true;
            this.cbMemberships.Location = new System.Drawing.Point(78, -1);
            this.cbMemberships.Name = "cbMemberships";
            this.cbMemberships.Size = new System.Drawing.Size(155, 26);
            this.cbMemberships.TabIndex = 7;
            this.cbMemberships.Text = "Membership Type";
            this.cbMemberships.SelectedIndexChanged += new System.EventHandler(this.cbMemberships_SelectedIndexChanged);
            // 
            // tbAttendeeSearch
            // 
            this.tbAttendeeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAttendeeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAttendeeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAttendeeSearch.Location = new System.Drawing.Point(588, 0);
            this.tbAttendeeSearch.Name = "tbAttendeeSearch";
            this.tbAttendeeSearch.Size = new System.Drawing.Size(126, 24);
            this.tbAttendeeSearch.TabIndex = 3;
            this.tbAttendeeSearch.Text = " Attendee Search";
            this.tbAttendeeSearch.Click += new System.EventHandler(this.tbAttendeeSearch_Click);
            this.tbAttendeeSearch.TextChanged += new System.EventHandler(this.tbAttendeeSearch_TextChanged);
            this.tbAttendeeSearch.Leave += new System.EventHandler(this.tbAttendeeSearch_Leave);
            // 
            // btAllEvents
            // 
            this.btAllEvents.BackColor = System.Drawing.Color.LightGray;
            this.btAllEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAllEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAllEvents.Location = new System.Drawing.Point(868, 163);
            this.btAllEvents.Name = "btAllEvents";
            this.btAllEvents.Size = new System.Drawing.Size(106, 37);
            this.btAllEvents.TabIndex = 6;
            this.btAllEvents.Text = "ALL EVENTS";
            this.btAllEvents.UseVisualStyleBackColor = false;
            this.btAllEvents.Click += new System.EventHandler(this.btAllEvents_Click);
            // 
            // cbEvents
            // 
            this.cbEvents.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEvents.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(258, 168);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(487, 28);
            this.cbEvents.TabIndex = 5;
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(258, 319);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEvents.Size = new System.Drawing.Size(716, 360);
            this.dgvEvents.TabIndex = 4;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.LightGray;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(754, 163);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(106, 37);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "SEARCH";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 142);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(366, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Management";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.profilePic);
            this.panel3.Controls.Add(this.lbName);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 142);
            this.panel3.TabIndex = 1;
            // 
            // profilePic
            // 
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(54, 38);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(95, 95);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(13, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(190, 25);
            this.lbName.TabIndex = 3;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdminDashboard,
            this.menuManageAccounts,
            this.menuMemRequests,
            this.menuTagManager,
            this.toolStripMenuItem4,
            this.menuLogOut});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 142);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(209, 550);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdminDashboard
            // 
            this.menuAdminDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdminDashboard.Image = ((System.Drawing.Image)(resources.GetObject("menuAdminDashboard.Image")));
            this.menuAdminDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuAdminDashboard.Name = "menuAdminDashboard";
            this.menuAdminDashboard.Size = new System.Drawing.Size(202, 34);
            this.menuAdminDashboard.Text = "Dashboard";
            this.menuAdminDashboard.Click += new System.EventHandler(this.menuAdminDashboard_Click);
            // 
            // menuManageAccounts
            // 
            this.menuManageAccounts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuManageAccounts.Image = ((System.Drawing.Image)(resources.GetObject("menuManageAccounts.Image")));
            this.menuManageAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuManageAccounts.Name = "menuManageAccounts";
            this.menuManageAccounts.Size = new System.Drawing.Size(202, 34);
            this.menuManageAccounts.Text = "Manage Accounts";
            this.menuManageAccounts.Click += new System.EventHandler(this.menuManageAccounts_Click);
            // 
            // menuMemRequests
            // 
            this.menuMemRequests.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMemRequests.Image = ((System.Drawing.Image)(resources.GetObject("menuMemRequests.Image")));
            this.menuMemRequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuMemRequests.Name = "menuMemRequests";
            this.menuMemRequests.Size = new System.Drawing.Size(202, 34);
            this.menuMemRequests.Text = "Member Requests";
            this.menuMemRequests.Click += new System.EventHandler(this.menuMemRequests_Click);
            // 
            // menuTagManager
            // 
            this.menuTagManager.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTagManager.Image = ((System.Drawing.Image)(resources.GetObject("menuTagManager.Image")));
            this.menuTagManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuTagManager.Name = "menuTagManager";
            this.menuTagManager.Size = new System.Drawing.Size(202, 34);
            this.menuTagManager.Text = "Admin Search";
            this.menuTagManager.Click += new System.EventHandler(this.menuTagManager_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(202, 34);
            this.toolStripMenuItem4.Text = "Event Manager";
            // 
            // menuLogOut
            // 
            this.menuLogOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLogOut.Image = ((System.Drawing.Image)(resources.GetObject("menuLogOut.Image")));
            this.menuLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuLogOut.Name = "menuLogOut";
            this.menuLogOut.Size = new System.Drawing.Size(202, 34);
            this.menuLogOut.Text = "Log Out";
            this.menuLogOut.Click += new System.EventHandler(this.menuLogOut_Click);
            // 
            // EventManagementAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 687);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EventManagementAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Together Culture CRM";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.ToolStripMenuItem menuManageAccounts;
        private System.Windows.Forms.ToolStripMenuItem menuAdminDashboard;
        private System.Windows.Forms.ToolStripMenuItem menuMemRequests;
        private System.Windows.Forms.ToolStripMenuItem menuTagManager;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuLogOut;
        private System.Windows.Forms.TextBox tbAttendeeSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.Button btAllEvents;
        private System.Windows.Forms.ComboBox cbMemberships;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEventTag;
        private System.Windows.Forms.Label lbNumberOfAttendees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCreateEvent;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}
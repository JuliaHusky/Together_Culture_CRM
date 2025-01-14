using System.ComponentModel;

namespace BeaversCRM_1
{
    partial class UserProfileAdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileAdminView));
            this.pageHeaderPanel = new System.Windows.Forms.Panel();
            this.pageNameLabel = new System.Windows.Forms.Label();
            this.TogCulLogoBox = new System.Windows.Forms.PictureBox();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.userEventsHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.eventAttendanceLabel = new System.Windows.Forms.Label();
            this.userDetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.copyUserType = new System.Windows.Forms.PictureBox();
            this.copyMembership = new System.Windows.Forms.PictureBox();
            this.copyTags = new System.Windows.Forms.PictureBox();
            this.copyPosition = new System.Windows.Forms.PictureBox();
            this.copyAddress = new System.Windows.Forms.PictureBox();
            this.copyPhone = new System.Windows.Forms.PictureBox();
            this.copyEmail = new System.Windows.Forms.PictureBox();
            this.userTypeValue = new System.Windows.Forms.Label();
            this.membershipValue = new System.Windows.Forms.Label();
            this.tagsValue = new System.Windows.Forms.Label();
            this.positionValue = new System.Windows.Forms.Label();
            this.addressValue = new System.Windows.Forms.Label();
            this.phoneValue = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.Label();
            this.nameRow = new System.Windows.Forms.Label();
            this.emailRow = new System.Windows.Forms.Label();
            this.phoneRow = new System.Windows.Forms.Label();
            this.addressRow = new System.Windows.Forms.Label();
            this.positionRow = new System.Windows.Forms.Label();
            this.tagsRow = new System.Windows.Forms.Label();
            this.membershipRow = new System.Windows.Forms.Label();
            this.userTypeRow = new System.Windows.Forms.Label();
            this.copyName = new System.Windows.Forms.PictureBox();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.burgerMenu1 = new BeaversCRM_1.BurgerMenu();
            this.pageHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TogCulLogoBox)).BeginInit();
            this.profilePanel.SuspendLayout();
            this.userDetailsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyUserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyMembership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
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
            this.pageHeaderPanel.TabIndex = 3;
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
            this.pageNameLabel.Text = "User Profile";
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
            // profilePanel
            // 
            this.profilePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.profilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePanel.Controls.Add(this.userEventsHistory);
            this.profilePanel.Controls.Add(this.eventAttendanceLabel);
            this.profilePanel.Controls.Add(this.userDetailsTable);
            this.profilePanel.Controls.Add(this.userAvatar);
            this.profilePanel.Location = new System.Drawing.Point(151, 83);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(616, 661);
            this.profilePanel.TabIndex = 5;
            // 
            // userEventsHistory
            // 
            this.userEventsHistory.AutoScroll = true;
            this.userEventsHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.userEventsHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userEventsHistory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userEventsHistory.Location = new System.Drawing.Point(78, 406);
            this.userEventsHistory.Name = "userEventsHistory";
            this.userEventsHistory.Size = new System.Drawing.Size(460, 241);
            this.userEventsHistory.TabIndex = 3;
            this.userEventsHistory.WrapContents = false;
            // 
            // eventAttendanceLabel
            // 
            this.eventAttendanceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventAttendanceLabel.Location = new System.Drawing.Point(232, 374);
            this.eventAttendanceLabel.Name = "eventAttendanceLabel";
            this.eventAttendanceLabel.Size = new System.Drawing.Size(152, 23);
            this.eventAttendanceLabel.TabIndex = 2;
            this.eventAttendanceLabel.Text = "Events Attendance";
            this.eventAttendanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userDetailsTable
            // 
            this.userDetailsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.userDetailsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.userDetailsTable.ColumnCount = 3;
            this.userDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09259F));
            this.userDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.90741F));
            this.userDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.userDetailsTable.Controls.Add(this.copyUserType, 2, 7);
            this.userDetailsTable.Controls.Add(this.copyMembership, 2, 6);
            this.userDetailsTable.Controls.Add(this.copyTags, 2, 5);
            this.userDetailsTable.Controls.Add(this.copyPosition, 2, 4);
            this.userDetailsTable.Controls.Add(this.copyAddress, 2, 3);
            this.userDetailsTable.Controls.Add(this.copyPhone, 2, 2);
            this.userDetailsTable.Controls.Add(this.copyEmail, 2, 1);
            this.userDetailsTable.Controls.Add(this.userTypeValue, 1, 7);
            this.userDetailsTable.Controls.Add(this.membershipValue, 1, 6);
            this.userDetailsTable.Controls.Add(this.tagsValue, 1, 5);
            this.userDetailsTable.Controls.Add(this.positionValue, 1, 4);
            this.userDetailsTable.Controls.Add(this.addressValue, 1, 3);
            this.userDetailsTable.Controls.Add(this.phoneValue, 1, 2);
            this.userDetailsTable.Controls.Add(this.emailValue, 1, 1);
            this.userDetailsTable.Controls.Add(this.nameValue, 1, 0);
            this.userDetailsTable.Controls.Add(this.nameRow, 0, 0);
            this.userDetailsTable.Controls.Add(this.emailRow, 0, 1);
            this.userDetailsTable.Controls.Add(this.phoneRow, 0, 2);
            this.userDetailsTable.Controls.Add(this.addressRow, 0, 3);
            this.userDetailsTable.Controls.Add(this.positionRow, 0, 4);
            this.userDetailsTable.Controls.Add(this.tagsRow, 0, 5);
            this.userDetailsTable.Controls.Add(this.membershipRow, 0, 6);
            this.userDetailsTable.Controls.Add(this.userTypeRow, 0, 7);
            this.userDetailsTable.Controls.Add(this.copyName, 2, 0);
            this.userDetailsTable.ForeColor = System.Drawing.Color.Black;
            this.userDetailsTable.Location = new System.Drawing.Point(78, 140);
            this.userDetailsTable.Name = "userDetailsTable";
            this.userDetailsTable.RowCount = 8;
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.userDetailsTable.Size = new System.Drawing.Size(460, 218);
            this.userDetailsTable.TabIndex = 1;
            // 
            // copyUserType
            // 
            this.copyUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyUserType.Image = ((System.Drawing.Image)(resources.GetObject("copyUserType.Image")));
            this.copyUserType.Location = new System.Drawing.Point(429, 193);
            this.copyUserType.Name = "copyUserType";
            this.copyUserType.Size = new System.Drawing.Size(27, 21);
            this.copyUserType.TabIndex = 31;
            this.copyUserType.TabStop = false;
            this.copyUserType.Click += new System.EventHandler(this.copyUserType_Click);
            // 
            // copyMembership
            // 
            this.copyMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyMembership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyMembership.Image = ((System.Drawing.Image)(resources.GetObject("copyMembership.Image")));
            this.copyMembership.Location = new System.Drawing.Point(429, 166);
            this.copyMembership.Name = "copyMembership";
            this.copyMembership.Size = new System.Drawing.Size(27, 20);
            this.copyMembership.TabIndex = 30;
            this.copyMembership.TabStop = false;
            this.copyMembership.Click += new System.EventHandler(this.copyMembership_Click);
            // 
            // copyTags
            // 
            this.copyTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyTags.Image = ((System.Drawing.Image)(resources.GetObject("copyTags.Image")));
            this.copyTags.Location = new System.Drawing.Point(429, 139);
            this.copyTags.Name = "copyTags";
            this.copyTags.Size = new System.Drawing.Size(27, 20);
            this.copyTags.TabIndex = 29;
            this.copyTags.TabStop = false;
            this.copyTags.Click += new System.EventHandler(this.copyTags_Click);
            // 
            // copyPosition
            // 
            this.copyPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyPosition.Image = ((System.Drawing.Image)(resources.GetObject("copyPosition.Image")));
            this.copyPosition.Location = new System.Drawing.Point(429, 112);
            this.copyPosition.Name = "copyPosition";
            this.copyPosition.Size = new System.Drawing.Size(27, 20);
            this.copyPosition.TabIndex = 28;
            this.copyPosition.TabStop = false;
            this.copyPosition.Click += new System.EventHandler(this.copyPosition_Click);
            // 
            // copyAddress
            // 
            this.copyAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyAddress.Image = ((System.Drawing.Image)(resources.GetObject("copyAddress.Image")));
            this.copyAddress.Location = new System.Drawing.Point(429, 85);
            this.copyAddress.Name = "copyAddress";
            this.copyAddress.Size = new System.Drawing.Size(27, 20);
            this.copyAddress.TabIndex = 27;
            this.copyAddress.TabStop = false;
            this.copyAddress.Click += new System.EventHandler(this.copyAddress_Click);
            // 
            // copyPhone
            // 
            this.copyPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyPhone.Image = ((System.Drawing.Image)(resources.GetObject("copyPhone.Image")));
            this.copyPhone.Location = new System.Drawing.Point(429, 58);
            this.copyPhone.Name = "copyPhone";
            this.copyPhone.Size = new System.Drawing.Size(27, 20);
            this.copyPhone.TabIndex = 26;
            this.copyPhone.TabStop = false;
            this.copyPhone.Click += new System.EventHandler(this.copyPhone_Click);
            // 
            // copyEmail
            // 
            this.copyEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyEmail.Image = ((System.Drawing.Image)(resources.GetObject("copyEmail.Image")));
            this.copyEmail.Location = new System.Drawing.Point(429, 31);
            this.copyEmail.Name = "copyEmail";
            this.copyEmail.Size = new System.Drawing.Size(27, 20);
            this.copyEmail.TabIndex = 25;
            this.copyEmail.TabStop = false;
            this.copyEmail.Click += new System.EventHandler(this.copyEmail_Click);
            // 
            // userTypeValue
            // 
            this.userTypeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTypeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.userTypeValue.Location = new System.Drawing.Point(132, 190);
            this.userTypeValue.Name = "userTypeValue";
            this.userTypeValue.Size = new System.Drawing.Size(290, 27);
            this.userTypeValue.TabIndex = 23;
            this.userTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // membershipValue
            // 
            this.membershipValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membershipValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.membershipValue.Location = new System.Drawing.Point(132, 163);
            this.membershipValue.Name = "membershipValue";
            this.membershipValue.Size = new System.Drawing.Size(290, 26);
            this.membershipValue.TabIndex = 21;
            this.membershipValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tagsValue
            // 
            this.tagsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.tagsValue.Location = new System.Drawing.Point(132, 136);
            this.tagsValue.Name = "tagsValue";
            this.tagsValue.Size = new System.Drawing.Size(290, 26);
            this.tagsValue.TabIndex = 19;
            this.tagsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // positionValue
            // 
            this.positionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.positionValue.Location = new System.Drawing.Point(132, 109);
            this.positionValue.Name = "positionValue";
            this.positionValue.Size = new System.Drawing.Size(290, 26);
            this.positionValue.TabIndex = 17;
            this.positionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressValue
            // 
            this.addressValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.addressValue.Location = new System.Drawing.Point(132, 82);
            this.addressValue.Name = "addressValue";
            this.addressValue.Size = new System.Drawing.Size(290, 26);
            this.addressValue.TabIndex = 15;
            this.addressValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneValue
            // 
            this.phoneValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.phoneValue.Location = new System.Drawing.Point(132, 55);
            this.phoneValue.Name = "phoneValue";
            this.phoneValue.Size = new System.Drawing.Size(290, 26);
            this.phoneValue.TabIndex = 13;
            this.phoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailValue
            // 
            this.emailValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.emailValue.Location = new System.Drawing.Point(132, 28);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(290, 26);
            this.emailValue.TabIndex = 11;
            this.emailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameValue
            // 
            this.nameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameValue.Location = new System.Drawing.Point(132, 1);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(290, 26);
            this.nameValue.TabIndex = 8;
            this.nameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameRow
            // 
            this.nameRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRow.Location = new System.Drawing.Point(4, 1);
            this.nameRow.Name = "nameRow";
            this.nameRow.Size = new System.Drawing.Size(121, 26);
            this.nameRow.TabIndex = 0;
            this.nameRow.Text = "Full Name";
            this.nameRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailRow
            // 
            this.emailRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailRow.Location = new System.Drawing.Point(4, 28);
            this.emailRow.Name = "emailRow";
            this.emailRow.Size = new System.Drawing.Size(121, 26);
            this.emailRow.TabIndex = 1;
            this.emailRow.Text = "Email";
            this.emailRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneRow
            // 
            this.phoneRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.phoneRow.Location = new System.Drawing.Point(4, 55);
            this.phoneRow.Name = "phoneRow";
            this.phoneRow.Size = new System.Drawing.Size(121, 26);
            this.phoneRow.TabIndex = 2;
            this.phoneRow.Text = "Phone Number";
            this.phoneRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressRow
            // 
            this.addressRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.addressRow.Location = new System.Drawing.Point(4, 82);
            this.addressRow.Name = "addressRow";
            this.addressRow.Size = new System.Drawing.Size(121, 26);
            this.addressRow.TabIndex = 3;
            this.addressRow.Text = "Address";
            this.addressRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // positionRow
            // 
            this.positionRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.positionRow.Location = new System.Drawing.Point(4, 109);
            this.positionRow.Name = "positionRow";
            this.positionRow.Size = new System.Drawing.Size(121, 26);
            this.positionRow.TabIndex = 4;
            this.positionRow.Text = "Position";
            this.positionRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tagsRow
            // 
            this.tagsRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tagsRow.Location = new System.Drawing.Point(4, 136);
            this.tagsRow.Name = "tagsRow";
            this.tagsRow.Size = new System.Drawing.Size(121, 26);
            this.tagsRow.TabIndex = 5;
            this.tagsRow.Text = "Tags";
            this.tagsRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // membershipRow
            // 
            this.membershipRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membershipRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.membershipRow.Location = new System.Drawing.Point(4, 163);
            this.membershipRow.Name = "membershipRow";
            this.membershipRow.Size = new System.Drawing.Size(121, 26);
            this.membershipRow.TabIndex = 6;
            this.membershipRow.Text = "Membership Type";
            this.membershipRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userTypeRow
            // 
            this.userTypeRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTypeRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.userTypeRow.Location = new System.Drawing.Point(4, 190);
            this.userTypeRow.Name = "userTypeRow";
            this.userTypeRow.Size = new System.Drawing.Size(121, 27);
            this.userTypeRow.TabIndex = 7;
            this.userTypeRow.Text = "User Type";
            this.userTypeRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyName
            // 
            this.copyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyName.Image = ((System.Drawing.Image)(resources.GetObject("copyName.Image")));
            this.copyName.Location = new System.Drawing.Point(429, 4);
            this.copyName.Name = "copyName";
            this.copyName.Size = new System.Drawing.Size(27, 20);
            this.copyName.TabIndex = 24;
            this.copyName.TabStop = false;
            this.copyName.Click += new System.EventHandler(this.copyName_Click);
            // 
            // userAvatar
            // 
            this.userAvatar.Image = ((System.Drawing.Image)(resources.GetObject("userAvatar.Image")));
            this.userAvatar.Location = new System.Drawing.Point(250, 3);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(116, 116);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAvatar.TabIndex = 0;
            this.userAvatar.TabStop = false;
            // 
            // burgerMenu1
            // 
            this.burgerMenu1.Location = new System.Drawing.Point(5, 13);
            this.burgerMenu1.Name = "burgerMenu1";
            this.burgerMenu1.Size = new System.Drawing.Size(144, 287);
            this.burgerMenu1.TabIndex = 6;
            // 
            // UserProfileAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 766);
            this.Controls.Add(this.burgerMenu1);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.pageHeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProfileAdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfileAdminView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserProfileAdminView_FormClosed);
            this.Shown += new System.EventHandler(this.UserProfileAdminView_Shown);
            this.pageHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TogCulLogoBox)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.userDetailsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.copyUserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyMembership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);
        }

        private BeaversCRM_1.BurgerMenu burgerMenu1;

        private System.Windows.Forms.FlowLayoutPanel userEventsHistory;

        private System.Windows.Forms.Label eventAttendanceLabel;

        private System.Windows.Forms.PictureBox copyEmail;
        private System.Windows.Forms.PictureBox copyPhone;
        private System.Windows.Forms.PictureBox copyAddress;
        private System.Windows.Forms.PictureBox copyPosition;
        private System.Windows.Forms.PictureBox copyTags;
        private System.Windows.Forms.PictureBox copyMembership;
        private System.Windows.Forms.PictureBox copyUserType;

        private System.Windows.Forms.PictureBox copyName;

        private System.Windows.Forms.Label nameValue;
        private System.Windows.Forms.Label emailValue;
        private System.Windows.Forms.Label phoneValue;
        private System.Windows.Forms.Label addressValue;
        private System.Windows.Forms.Label positionValue;
        private System.Windows.Forms.Label tagsValue;
        private System.Windows.Forms.Label membershipValue;
        private System.Windows.Forms.Label userTypeValue;

        private System.Windows.Forms.Label emailRow;
        private System.Windows.Forms.Label phoneRow;
        private System.Windows.Forms.Label addressRow;
        private System.Windows.Forms.Label positionRow;
        private System.Windows.Forms.Label tagsRow;
        private System.Windows.Forms.Label membershipRow;
        private System.Windows.Forms.Label userTypeRow;

        private System.Windows.Forms.Label nameRow;

        private System.Windows.Forms.TableLayoutPanel userDetailsTable;

        private System.Windows.Forms.PictureBox userAvatar;

        private System.Windows.Forms.Panel profilePanel;

        private System.Windows.Forms.Panel pageHeaderPanel;
        private System.Windows.Forms.Label pageNameLabel;
        private System.Windows.Forms.PictureBox TogCulLogoBox;

        #endregion
    }
}
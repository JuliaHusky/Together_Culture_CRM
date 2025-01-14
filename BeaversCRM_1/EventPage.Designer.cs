using System.ComponentModel;

namespace BeaversCRM_1
{
    partial class EventPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventPage));
            this.pageHeaderPanel = new System.Windows.Forms.Panel();
            this.pageNameLabel = new System.Windows.Forms.Label();
            this.TogCulLogoBox = new System.Windows.Forms.PictureBox();
            this.eventDetailsPanel = new System.Windows.Forms.Panel();
            this.userDetailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.copyDescription = new System.Windows.Forms.PictureBox();
            this.copyLimit = new System.Windows.Forms.PictureBox();
            this.copyAttendees = new System.Windows.Forms.PictureBox();
            this.copyTag = new System.Windows.Forms.PictureBox();
            this.copyLocation = new System.Windows.Forms.PictureBox();
            this.copyEndDate = new System.Windows.Forms.PictureBox();
            this.copyStartDate = new System.Windows.Forms.PictureBox();
            this.copyType = new System.Windows.Forms.PictureBox();
            this.limitValue = new System.Windows.Forms.Label();
            this.peopleAttendedValue = new System.Windows.Forms.Label();
            this.tagsValue = new System.Windows.Forms.Label();
            this.locationValue = new System.Windows.Forms.Label();
            this.endDateValue = new System.Windows.Forms.Label();
            this.startDateValue = new System.Windows.Forms.Label();
            this.typeValue = new System.Windows.Forms.Label();
            this.titleValue = new System.Windows.Forms.Label();
            this.eventTitleRow = new System.Windows.Forms.Label();
            this.eventTypeRow = new System.Windows.Forms.Label();
            this.eventStartDateRow = new System.Windows.Forms.Label();
            this.eventEndDateRow = new System.Windows.Forms.Label();
            this.eventLocationRow = new System.Windows.Forms.Label();
            this.eventTagRow = new System.Windows.Forms.Label();
            this.eventAttendenceRow = new System.Windows.Forms.Label();
            this.eventAttendeeLimitRow = new System.Windows.Forms.Label();
            this.copyName = new System.Windows.Forms.PictureBox();
            this.eventDescriptionRow = new System.Windows.Forms.Label();
            this.eventDescriptionValue = new System.Windows.Forms.Label();
            this.eventPicture = new System.Windows.Forms.PictureBox();
            this.burgerMenu1 = new BeaversCRM_1.BurgerMenu();
            this.pageHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TogCulLogoBox)).BeginInit();
            this.eventDetailsPanel.SuspendLayout();
            this.userDetailsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyAttendees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPicture)).BeginInit();
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
            this.pageNameLabel.Text = "Event Details";
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
            // eventDetailsPanel
            // 
            this.eventDetailsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eventDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.eventDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventDetailsPanel.Controls.Add(this.userDetailsTable);
            this.eventDetailsPanel.Controls.Add(this.eventPicture);
            this.eventDetailsPanel.Location = new System.Drawing.Point(151, 83);
            this.eventDetailsPanel.Name = "eventDetailsPanel";
            this.eventDetailsPanel.Size = new System.Drawing.Size(616, 661);
            this.eventDetailsPanel.TabIndex = 6;
            // 
            // userDetailsTable
            // 
            this.userDetailsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.userDetailsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.userDetailsTable.ColumnCount = 3;
            this.userDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.27103F));
            this.userDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.72897F));
            this.userDetailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.userDetailsTable.Controls.Add(this.copyDescription, 2, 8);
            this.userDetailsTable.Controls.Add(this.copyLimit, 2, 7);
            this.userDetailsTable.Controls.Add(this.copyAttendees, 2, 6);
            this.userDetailsTable.Controls.Add(this.copyTag, 2, 5);
            this.userDetailsTable.Controls.Add(this.copyLocation, 2, 4);
            this.userDetailsTable.Controls.Add(this.copyEndDate, 2, 3);
            this.userDetailsTable.Controls.Add(this.copyStartDate, 2, 2);
            this.userDetailsTable.Controls.Add(this.copyType, 2, 1);
            this.userDetailsTable.Controls.Add(this.limitValue, 1, 7);
            this.userDetailsTable.Controls.Add(this.peopleAttendedValue, 1, 6);
            this.userDetailsTable.Controls.Add(this.tagsValue, 1, 5);
            this.userDetailsTable.Controls.Add(this.locationValue, 1, 4);
            this.userDetailsTable.Controls.Add(this.endDateValue, 1, 3);
            this.userDetailsTable.Controls.Add(this.startDateValue, 1, 2);
            this.userDetailsTable.Controls.Add(this.typeValue, 1, 1);
            this.userDetailsTable.Controls.Add(this.titleValue, 1, 0);
            this.userDetailsTable.Controls.Add(this.eventTitleRow, 0, 0);
            this.userDetailsTable.Controls.Add(this.eventTypeRow, 0, 1);
            this.userDetailsTable.Controls.Add(this.eventStartDateRow, 0, 2);
            this.userDetailsTable.Controls.Add(this.eventEndDateRow, 0, 3);
            this.userDetailsTable.Controls.Add(this.eventLocationRow, 0, 4);
            this.userDetailsTable.Controls.Add(this.eventTagRow, 0, 5);
            this.userDetailsTable.Controls.Add(this.eventAttendenceRow, 0, 6);
            this.userDetailsTable.Controls.Add(this.eventAttendeeLimitRow, 0, 7);
            this.userDetailsTable.Controls.Add(this.copyName, 2, 0);
            this.userDetailsTable.Controls.Add(this.eventDescriptionRow, 0, 8);
            this.userDetailsTable.Controls.Add(this.eventDescriptionValue, 1, 8);
            this.userDetailsTable.ForeColor = System.Drawing.Color.Black;
            this.userDetailsTable.Location = new System.Drawing.Point(78, 258);
            this.userDetailsTable.Name = "userDetailsTable";
            this.userDetailsTable.RowCount = 9;
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.userDetailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.userDetailsTable.Size = new System.Drawing.Size(460, 387);
            this.userDetailsTable.TabIndex = 1;
            // 
            // copyDescription
            // 
            this.copyDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyDescription.Image = ((System.Drawing.Image)(resources.GetObject("copyDescription.Image")));
            this.copyDescription.Location = new System.Drawing.Point(432, 304);
            this.copyDescription.Margin = new System.Windows.Forms.Padding(3, 55, 3, 55);
            this.copyDescription.Name = "copyDescription";
            this.copyDescription.Size = new System.Drawing.Size(24, 24);
            this.copyDescription.TabIndex = 34;
            this.copyDescription.TabStop = false;
            this.copyDescription.Click += new System.EventHandler(this.copyDescription_Click);
            // 
            // copyLimit
            // 
            this.copyLimit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyLimit.Image = ((System.Drawing.Image)(resources.GetObject("copyLimit.Image")));
            this.copyLimit.Location = new System.Drawing.Point(432, 221);
            this.copyLimit.Name = "copyLimit";
            this.copyLimit.Size = new System.Drawing.Size(24, 24);
            this.copyLimit.TabIndex = 31;
            this.copyLimit.TabStop = false;
            this.copyLimit.Click += new System.EventHandler(this.copyLimit_Click);
            // 
            // copyAttendees
            // 
            this.copyAttendees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyAttendees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyAttendees.Image = ((System.Drawing.Image)(resources.GetObject("copyAttendees.Image")));
            this.copyAttendees.Location = new System.Drawing.Point(432, 190);
            this.copyAttendees.Name = "copyAttendees";
            this.copyAttendees.Size = new System.Drawing.Size(24, 24);
            this.copyAttendees.TabIndex = 30;
            this.copyAttendees.TabStop = false;
            this.copyAttendees.Click += new System.EventHandler(this.copyAttendees_Click);
            // 
            // copyTag
            // 
            this.copyTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyTag.Image = ((System.Drawing.Image)(resources.GetObject("copyTag.Image")));
            this.copyTag.Location = new System.Drawing.Point(432, 159);
            this.copyTag.Name = "copyTag";
            this.copyTag.Size = new System.Drawing.Size(24, 24);
            this.copyTag.TabIndex = 29;
            this.copyTag.TabStop = false;
            this.copyTag.Click += new System.EventHandler(this.copyTag_Click);
            // 
            // copyLocation
            // 
            this.copyLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyLocation.Image = ((System.Drawing.Image)(resources.GetObject("copyLocation.Image")));
            this.copyLocation.Location = new System.Drawing.Point(432, 128);
            this.copyLocation.Name = "copyLocation";
            this.copyLocation.Size = new System.Drawing.Size(24, 24);
            this.copyLocation.TabIndex = 28;
            this.copyLocation.TabStop = false;
            this.copyLocation.Click += new System.EventHandler(this.copyLocation_Click);
            // 
            // copyEndDate
            // 
            this.copyEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyEndDate.Image = ((System.Drawing.Image)(resources.GetObject("copyEndDate.Image")));
            this.copyEndDate.Location = new System.Drawing.Point(432, 97);
            this.copyEndDate.Name = "copyEndDate";
            this.copyEndDate.Size = new System.Drawing.Size(24, 24);
            this.copyEndDate.TabIndex = 27;
            this.copyEndDate.TabStop = false;
            this.copyEndDate.Click += new System.EventHandler(this.copyEndDate_Click);
            // 
            // copyStartDate
            // 
            this.copyStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyStartDate.Image = ((System.Drawing.Image)(resources.GetObject("copyStartDate.Image")));
            this.copyStartDate.Location = new System.Drawing.Point(432, 66);
            this.copyStartDate.Name = "copyStartDate";
            this.copyStartDate.Size = new System.Drawing.Size(24, 24);
            this.copyStartDate.TabIndex = 26;
            this.copyStartDate.TabStop = false;
            this.copyStartDate.Click += new System.EventHandler(this.copyStartDate_Click);
            // 
            // copyType
            // 
            this.copyType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyType.Image = ((System.Drawing.Image)(resources.GetObject("copyType.Image")));
            this.copyType.Location = new System.Drawing.Point(432, 35);
            this.copyType.Name = "copyType";
            this.copyType.Size = new System.Drawing.Size(24, 24);
            this.copyType.TabIndex = 25;
            this.copyType.TabStop = false;
            this.copyType.Click += new System.EventHandler(this.copyType_Click);
            // 
            // limitValue
            // 
            this.limitValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limitValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.limitValue.Location = new System.Drawing.Point(125, 218);
            this.limitValue.Name = "limitValue";
            this.limitValue.Size = new System.Drawing.Size(300, 30);
            this.limitValue.TabIndex = 23;
            this.limitValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peopleAttendedValue
            // 
            this.peopleAttendedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peopleAttendedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.peopleAttendedValue.Location = new System.Drawing.Point(125, 187);
            this.peopleAttendedValue.Name = "peopleAttendedValue";
            this.peopleAttendedValue.Size = new System.Drawing.Size(300, 30);
            this.peopleAttendedValue.TabIndex = 21;
            this.peopleAttendedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tagsValue
            // 
            this.tagsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.tagsValue.Location = new System.Drawing.Point(125, 156);
            this.tagsValue.Name = "tagsValue";
            this.tagsValue.Size = new System.Drawing.Size(300, 30);
            this.tagsValue.TabIndex = 19;
            this.tagsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationValue
            // 
            this.locationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.locationValue.Location = new System.Drawing.Point(125, 125);
            this.locationValue.Name = "locationValue";
            this.locationValue.Size = new System.Drawing.Size(300, 30);
            this.locationValue.TabIndex = 17;
            this.locationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endDateValue
            // 
            this.endDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.endDateValue.Location = new System.Drawing.Point(125, 94);
            this.endDateValue.Name = "endDateValue";
            this.endDateValue.Size = new System.Drawing.Size(300, 30);
            this.endDateValue.TabIndex = 15;
            this.endDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDateValue
            // 
            this.startDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.startDateValue.Location = new System.Drawing.Point(125, 63);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(300, 30);
            this.startDateValue.TabIndex = 13;
            this.startDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeValue
            // 
            this.typeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.typeValue.Location = new System.Drawing.Point(125, 32);
            this.typeValue.Name = "typeValue";
            this.typeValue.Size = new System.Drawing.Size(300, 30);
            this.typeValue.TabIndex = 11;
            this.typeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleValue
            // 
            this.titleValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleValue.Location = new System.Drawing.Point(125, 1);
            this.titleValue.Name = "titleValue";
            this.titleValue.Size = new System.Drawing.Size(300, 30);
            this.titleValue.TabIndex = 8;
            this.titleValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventTitleRow
            // 
            this.eventTitleRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTitleRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventTitleRow.Location = new System.Drawing.Point(4, 1);
            this.eventTitleRow.Name = "eventTitleRow";
            this.eventTitleRow.Size = new System.Drawing.Size(114, 30);
            this.eventTitleRow.TabIndex = 0;
            this.eventTitleRow.Text = "Title";
            this.eventTitleRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventTypeRow
            // 
            this.eventTypeRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTypeRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventTypeRow.Location = new System.Drawing.Point(4, 32);
            this.eventTypeRow.Name = "eventTypeRow";
            this.eventTypeRow.Size = new System.Drawing.Size(114, 30);
            this.eventTypeRow.TabIndex = 1;
            this.eventTypeRow.Text = "Type";
            this.eventTypeRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventStartDateRow
            // 
            this.eventStartDateRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventStartDateRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.eventStartDateRow.Location = new System.Drawing.Point(4, 63);
            this.eventStartDateRow.Name = "eventStartDateRow";
            this.eventStartDateRow.Size = new System.Drawing.Size(114, 30);
            this.eventStartDateRow.TabIndex = 2;
            this.eventStartDateRow.Text = "Start Date";
            this.eventStartDateRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventEndDateRow
            // 
            this.eventEndDateRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventEndDateRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.eventEndDateRow.Location = new System.Drawing.Point(4, 94);
            this.eventEndDateRow.Name = "eventEndDateRow";
            this.eventEndDateRow.Size = new System.Drawing.Size(114, 30);
            this.eventEndDateRow.TabIndex = 3;
            this.eventEndDateRow.Text = "End Date";
            this.eventEndDateRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventLocationRow
            // 
            this.eventLocationRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventLocationRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.eventLocationRow.Location = new System.Drawing.Point(4, 125);
            this.eventLocationRow.Name = "eventLocationRow";
            this.eventLocationRow.Size = new System.Drawing.Size(114, 30);
            this.eventLocationRow.TabIndex = 4;
            this.eventLocationRow.Text = "Location";
            this.eventLocationRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventTagRow
            // 
            this.eventTagRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTagRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.eventTagRow.Location = new System.Drawing.Point(4, 156);
            this.eventTagRow.Name = "eventTagRow";
            this.eventTagRow.Size = new System.Drawing.Size(114, 30);
            this.eventTagRow.TabIndex = 5;
            this.eventTagRow.Text = "Tag";
            this.eventTagRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventAttendenceRow
            // 
            this.eventAttendenceRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventAttendenceRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventAttendenceRow.Location = new System.Drawing.Point(4, 187);
            this.eventAttendenceRow.Name = "eventAttendenceRow";
            this.eventAttendenceRow.Size = new System.Drawing.Size(114, 30);
            this.eventAttendenceRow.TabIndex = 6;
            this.eventAttendenceRow.Text = "People Attended";
            this.eventAttendenceRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventAttendeeLimitRow
            // 
            this.eventAttendeeLimitRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventAttendeeLimitRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.eventAttendeeLimitRow.Location = new System.Drawing.Point(4, 218);
            this.eventAttendeeLimitRow.Name = "eventAttendeeLimitRow";
            this.eventAttendeeLimitRow.Size = new System.Drawing.Size(114, 30);
            this.eventAttendeeLimitRow.TabIndex = 7;
            this.eventAttendeeLimitRow.Text = "Attendee Limit";
            this.eventAttendeeLimitRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyName
            // 
            this.copyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyName.Image = ((System.Drawing.Image)(resources.GetObject("copyName.Image")));
            this.copyName.Location = new System.Drawing.Point(432, 4);
            this.copyName.Name = "copyName";
            this.copyName.Size = new System.Drawing.Size(24, 24);
            this.copyName.TabIndex = 24;
            this.copyName.TabStop = false;
            this.copyName.Click += new System.EventHandler(this.copyName_Click);
            // 
            // eventDescriptionRow
            // 
            this.eventDescriptionRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventDescriptionRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.eventDescriptionRow.Location = new System.Drawing.Point(3, 249);
            this.eventDescriptionRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventDescriptionRow.Name = "eventDescriptionRow";
            this.eventDescriptionRow.Size = new System.Drawing.Size(116, 137);
            this.eventDescriptionRow.TabIndex = 32;
            this.eventDescriptionRow.Text = "Description";
            this.eventDescriptionRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventDescriptionValue
            // 
            this.eventDescriptionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventDescriptionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventDescriptionValue.Location = new System.Drawing.Point(124, 249);
            this.eventDescriptionValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventDescriptionValue.Name = "eventDescriptionValue";
            this.eventDescriptionValue.Size = new System.Drawing.Size(302, 137);
            this.eventDescriptionValue.TabIndex = 33;
            this.eventDescriptionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventPicture
            // 
            this.eventPicture.Location = new System.Drawing.Point(78, 13);
            this.eventPicture.Name = "eventPicture";
            this.eventPicture.Size = new System.Drawing.Size(460, 229);
            this.eventPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eventPicture.TabIndex = 0;
            this.eventPicture.TabStop = false;
            // 
            // burgerMenu1
            // 
            this.burgerMenu1.Location = new System.Drawing.Point(5, 13);
            this.burgerMenu1.Name = "burgerMenu1";
            this.burgerMenu1.Size = new System.Drawing.Size(144, 287);
            this.burgerMenu1.TabIndex = 7;
            // 
            // EventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 762);
            this.Controls.Add(this.burgerMenu1);
            this.Controls.Add(this.eventDetailsPanel);
            this.Controls.Add(this.pageHeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventPage_FormClosed);
            this.Shown += new System.EventHandler(this.EventPage_Shown);
            this.pageHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TogCulLogoBox)).EndInit();
            this.eventDetailsPanel.ResumeLayout(false);
            this.userDetailsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.copyDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyAttendees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPicture)).EndInit();
            this.ResumeLayout(false);
        }

        private BeaversCRM_1.BurgerMenu burgerMenu1;

        private System.Windows.Forms.PictureBox copyDescription;

        private System.Windows.Forms.Label eventDescriptionValue;

        private System.Windows.Forms.Label eventDescriptionRow;

        private System.Windows.Forms.Label limitValue;

        private System.Windows.Forms.Panel eventDetailsPanel;
        private System.Windows.Forms.TableLayoutPanel userDetailsTable;
        private System.Windows.Forms.PictureBox copyLimit;
        private System.Windows.Forms.PictureBox copyAttendees;
        private System.Windows.Forms.PictureBox copyTag;
        private System.Windows.Forms.PictureBox copyLocation;
        private System.Windows.Forms.PictureBox copyEndDate;
        private System.Windows.Forms.PictureBox copyStartDate;
        private System.Windows.Forms.PictureBox copyType;
        private System.Windows.Forms.Label peopleAttendedValue;
        private System.Windows.Forms.Label tagsValue;
        private System.Windows.Forms.Label locationValue;
        private System.Windows.Forms.Label endDateValue;
        private System.Windows.Forms.Label startDateValue;
        private System.Windows.Forms.Label typeValue;
        private System.Windows.Forms.Label titleValue;
        private System.Windows.Forms.Label eventTitleRow;
        private System.Windows.Forms.Label eventTypeRow;
        private System.Windows.Forms.Label eventStartDateRow;
        private System.Windows.Forms.Label eventEndDateRow;
        private System.Windows.Forms.Label eventLocationRow;
        private System.Windows.Forms.Label eventTagRow;
        private System.Windows.Forms.Label eventAttendenceRow;
        private System.Windows.Forms.Label eventAttendeeLimitRow;
        private System.Windows.Forms.PictureBox copyName;
        private System.Windows.Forms.PictureBox eventPicture;

        private System.Windows.Forms.Panel pageHeaderPanel;
        private System.Windows.Forms.Label pageNameLabel;
        private System.Windows.Forms.PictureBox TogCulLogoBox;

        #endregion
    }
}
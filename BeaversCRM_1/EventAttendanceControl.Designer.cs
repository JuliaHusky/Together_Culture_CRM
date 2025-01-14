using System.ComponentModel;

namespace BeaversCRM_1
{
    partial class EventAttendanceControl
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
            this.eventAttendancePanel = new System.Windows.Forms.Panel();
            this.detailsTable = new System.Windows.Forms.TableLayoutPanel();
            this.checkInDateLabel = new System.Windows.Forms.Label();
            this.attendeeStatusValueLabel = new System.Windows.Forms.Label();
            this.checkInDateValueLabel = new System.Windows.Forms.Label();
            this.attendeeStatusLabel = new System.Windows.Forms.Label();
            this.checkOutDateLabel = new System.Windows.Forms.Label();
            this.checkOutDateValueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.eventAttendancePanel.SuspendLayout();
            this.detailsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventAttendancePanel
            // 
            this.eventAttendancePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.eventAttendancePanel.Controls.Add(this.detailsTable);
            this.eventAttendancePanel.Controls.Add(this.nameLabel);
            this.eventAttendancePanel.Location = new System.Drawing.Point(0, 0);
            this.eventAttendancePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.eventAttendancePanel.Name = "eventAttendancePanel";
            this.eventAttendancePanel.Size = new System.Drawing.Size(435, 79);
            this.eventAttendancePanel.TabIndex = 1;
            // 
            // detailsTable
            // 
            this.detailsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.detailsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.detailsTable.ColumnCount = 2;
            this.detailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.90184F));
            this.detailsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.09816F));
            this.detailsTable.Controls.Add(this.checkInDateLabel, 0, 1);
            this.detailsTable.Controls.Add(this.attendeeStatusValueLabel, 1, 0);
            this.detailsTable.Controls.Add(this.checkInDateValueLabel, 1, 1);
            this.detailsTable.Controls.Add(this.attendeeStatusLabel, 0, 0);
            this.detailsTable.Controls.Add(this.checkOutDateLabel, 0, 2);
            this.detailsTable.Controls.Add(this.checkOutDateValueLabel, 1, 2);
            this.detailsTable.Location = new System.Drawing.Point(54, 24);
            this.detailsTable.Name = "detailsTable";
            this.detailsTable.RowCount = 3;
            this.detailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.detailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.detailsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.detailsTable.Size = new System.Drawing.Size(327, 50);
            this.detailsTable.TabIndex = 1;
            // 
            // checkInDateLabel
            // 
            this.checkInDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkInDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkInDateLabel.Location = new System.Drawing.Point(4, 18);
            this.checkInDateLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.checkInDateLabel.Name = "checkInDateLabel";
            this.checkInDateLabel.Size = new System.Drawing.Size(97, 13);
            this.checkInDateLabel.TabIndex = 1;
            this.checkInDateLabel.Text = "Check-In Time";
            this.checkInDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // attendeeStatusValueLabel
            // 
            this.attendeeStatusValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendeeStatusValueLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attendeeStatusValueLabel.Location = new System.Drawing.Point(108, 2);
            this.attendeeStatusValueLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.attendeeStatusValueLabel.Name = "attendeeStatusValueLabel";
            this.attendeeStatusValueLabel.Size = new System.Drawing.Size(215, 13);
            this.attendeeStatusValueLabel.TabIndex = 3;
            this.attendeeStatusValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkInDateValueLabel
            // 
            this.checkInDateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkInDateValueLabel.Location = new System.Drawing.Point(108, 18);
            this.checkInDateValueLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.checkInDateValueLabel.Name = "checkInDateValueLabel";
            this.checkInDateValueLabel.Size = new System.Drawing.Size(215, 13);
            this.checkInDateValueLabel.TabIndex = 4;
            this.checkInDateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attendeeStatusLabel
            // 
            this.attendeeStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendeeStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.attendeeStatusLabel.Location = new System.Drawing.Point(4, 2);
            this.attendeeStatusLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.attendeeStatusLabel.Name = "attendeeStatusLabel";
            this.attendeeStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.attendeeStatusLabel.TabIndex = 5;
            this.attendeeStatusLabel.Text = "Attendee Status";
            this.attendeeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkOutDateLabel
            // 
            this.checkOutDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkOutDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkOutDateLabel.Location = new System.Drawing.Point(4, 34);
            this.checkOutDateLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.checkOutDateLabel.Name = "checkOutDateLabel";
            this.checkOutDateLabel.Size = new System.Drawing.Size(97, 14);
            this.checkOutDateLabel.TabIndex = 6;
            this.checkOutDateLabel.Text = "Check-Out Time";
            this.checkOutDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkOutDateValueLabel
            // 
            this.checkOutDateValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkOutDateValueLabel.Location = new System.Drawing.Point(108, 34);
            this.checkOutDateValueLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.checkOutDateValueLabel.Name = "checkOutDateValueLabel";
            this.checkOutDateValueLabel.Size = new System.Drawing.Size(215, 14);
            this.checkOutDateValueLabel.TabIndex = 7;
            this.checkOutDateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(3, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(429, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventAttendanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.eventAttendancePanel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "EventAttendanceControl";
            this.Size = new System.Drawing.Size(435, 79);
            this.eventAttendancePanel.ResumeLayout(false);
            this.detailsTable.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label attendeeStatusLabel;
        private System.Windows.Forms.Label checkOutDateLabel;
        public System.Windows.Forms.Label checkOutDateValueLabel;

        private System.Windows.Forms.TableLayoutPanel detailsTable;
        public System.Windows.Forms.Label attendeeStatusValueLabel;
        public System.Windows.Forms.Label checkInDateValueLabel;

        private System.Windows.Forms.Label checkInDateLabel;

        public System.Windows.Forms.Label nameLabel;

        private System.Windows.Forms.Panel eventAttendancePanel;

        #endregion
    }
}
using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class CalendarOfEventsButton
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
            this.eventsCalendarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventsCalendarBtn
            // 
            this.eventsCalendarBtn.BackColor = System.Drawing.SystemColors.Window;
            this.eventsCalendarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventsCalendarBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsCalendarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eventsCalendarBtn.Location = new System.Drawing.Point(0, 0);
            this.eventsCalendarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.eventsCalendarBtn.Name = "eventsCalendarBtn";
            this.eventsCalendarBtn.Size = new System.Drawing.Size(141, 31);
            this.eventsCalendarBtn.TabIndex = 9;
            this.eventsCalendarBtn.Text = "Events Calendar";
            this.eventsCalendarBtn.UseVisualStyleBackColor = false;
            this.eventsCalendarBtn.Click += new System.EventHandler(this.calendarOfEventsBtn_Click);
            // 
            // CalendarOfEventsButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventsCalendarBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CalendarOfEventsButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button eventsCalendarBtn;

        #endregion
    }
}
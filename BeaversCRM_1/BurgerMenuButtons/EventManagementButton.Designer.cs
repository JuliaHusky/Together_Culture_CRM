using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class EventManagementButton
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
            this.eventManagementBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventManagementBtn
            // 
            this.eventManagementBtn.BackColor = System.Drawing.SystemColors.Window;
            this.eventManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventManagementBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventManagementBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eventManagementBtn.Location = new System.Drawing.Point(0, 0);
            this.eventManagementBtn.Margin = new System.Windows.Forms.Padding(0);
            this.eventManagementBtn.Name = "eventManagementBtn";
            this.eventManagementBtn.Size = new System.Drawing.Size(141, 31);
            this.eventManagementBtn.TabIndex = 10;
            this.eventManagementBtn.Text = "Event Management";
            this.eventManagementBtn.UseVisualStyleBackColor = false;
            this.eventManagementBtn.Click += new System.EventHandler(this.eventManagementBtn_Click);
            // 
            // EventManagementButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventManagementBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventManagementButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button eventManagementBtn;

        #endregion
    }
}
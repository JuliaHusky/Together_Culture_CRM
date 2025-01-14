using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class UserDashboardButton
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
            this.userDashboardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userDashboardBtn
            // 
            this.userDashboardBtn.BackColor = System.Drawing.SystemColors.Window;
            this.userDashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userDashboardBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDashboardBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userDashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.userDashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.userDashboardBtn.Name = "userDashboardBtn";
            this.userDashboardBtn.Size = new System.Drawing.Size(141, 31);
            this.userDashboardBtn.TabIndex = 10;
            this.userDashboardBtn.Text = "Dashboard";
            this.userDashboardBtn.UseVisualStyleBackColor = false;
            this.userDashboardBtn.Click += new System.EventHandler(this.userDashboardBtn_Click);
            // 
            // UserDashboardButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userDashboardBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserDashboardButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button userDashboardBtn;

        #endregion
    }
}
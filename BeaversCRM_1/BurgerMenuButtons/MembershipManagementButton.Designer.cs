using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class MembershipManagementButton
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
            this.membershipManagementBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // membershipManagementBtn
            // 
            this.membershipManagementBtn.BackColor = System.Drawing.SystemColors.Window;
            this.membershipManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.membershipManagementBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipManagementBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.membershipManagementBtn.Location = new System.Drawing.Point(0, 0);
            this.membershipManagementBtn.Margin = new System.Windows.Forms.Padding(0);
            this.membershipManagementBtn.Name = "membershipManagementBtn";
            this.membershipManagementBtn.Size = new System.Drawing.Size(141, 31);
            this.membershipManagementBtn.TabIndex = 10;
            this.membershipManagementBtn.Text = "Membership Management";
            this.membershipManagementBtn.UseVisualStyleBackColor = false;
            this.membershipManagementBtn.Click += new System.EventHandler(this.membershipManagementBtn_Click);
            // 
            // MembershipManagementButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.membershipManagementBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MembershipManagementButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button membershipManagementBtn;

        #endregion
    }
}
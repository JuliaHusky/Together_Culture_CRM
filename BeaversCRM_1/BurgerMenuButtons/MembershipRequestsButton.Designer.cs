using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class MembershipRequestsButton
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
            this.membershipRequestsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // membershipRequestsBtn
            // 
            this.membershipRequestsBtn.BackColor = System.Drawing.SystemColors.Window;
            this.membershipRequestsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.membershipRequestsBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipRequestsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.membershipRequestsBtn.Location = new System.Drawing.Point(0, 0);
            this.membershipRequestsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.membershipRequestsBtn.Name = "membershipRequestsBtn";
            this.membershipRequestsBtn.Size = new System.Drawing.Size(141, 31);
            this.membershipRequestsBtn.TabIndex = 10;
            this.membershipRequestsBtn.Text = "Membership Requests";
            this.membershipRequestsBtn.UseVisualStyleBackColor = false;
            this.membershipRequestsBtn.Click += new System.EventHandler(this.membershipRequestsBtn_Click);
            // 
            // MembershipRequestsButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.membershipRequestsBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MembershipRequestsButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button membershipRequestsBtn;

        #endregion
    }
}
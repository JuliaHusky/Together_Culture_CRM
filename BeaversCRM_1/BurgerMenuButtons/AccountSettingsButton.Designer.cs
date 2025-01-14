using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class AccountSettingsButton
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
            this.accSettingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accSettingsBtn
            // 
            this.accSettingsBtn.BackColor = System.Drawing.SystemColors.Window;
            this.accSettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accSettingsBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accSettingsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accSettingsBtn.Location = new System.Drawing.Point(0, 0);
            this.accSettingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.accSettingsBtn.Name = "accSettingsBtn";
            this.accSettingsBtn.Size = new System.Drawing.Size(141, 31);
            this.accSettingsBtn.TabIndex = 5;
            this.accSettingsBtn.Text = "Settings";
            this.accSettingsBtn.UseVisualStyleBackColor = false;
            this.accSettingsBtn.Click += new System.EventHandler(this.accSettingsBtn_Click);
            // 
            // AccountSettingsButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accSettingsBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountSettingsButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button accSettingsBtn;

        #endregion
    }
}
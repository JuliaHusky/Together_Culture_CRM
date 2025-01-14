using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class AdminSearchButton
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
            this.adminSearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminSearchBtn
            // 
            this.adminSearchBtn.BackColor = System.Drawing.SystemColors.Window;
            this.adminSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminSearchBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSearchBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminSearchBtn.Location = new System.Drawing.Point(0, 0);
            this.adminSearchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.adminSearchBtn.Name = "adminSearchBtn";
            this.adminSearchBtn.Size = new System.Drawing.Size(141, 31);
            this.adminSearchBtn.TabIndex = 7;
            this.adminSearchBtn.Text = "Admin Search";
            this.adminSearchBtn.UseVisualStyleBackColor = false;
            this.adminSearchBtn.Click += new System.EventHandler(this.adminSearchBtn_Click);
            // 
            // AdminSearchButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminSearchBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminSearchButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button adminSearchBtn;

        #endregion
    }
}
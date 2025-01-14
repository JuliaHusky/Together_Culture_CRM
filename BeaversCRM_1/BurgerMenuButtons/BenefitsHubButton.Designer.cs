using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class BenefitsHubButton
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
            this.benefitsHubBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // benefitsHubBtn
            // 
            this.benefitsHubBtn.BackColor = System.Drawing.SystemColors.Window;
            this.benefitsHubBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.benefitsHubBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benefitsHubBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.benefitsHubBtn.Location = new System.Drawing.Point(0, 0);
            this.benefitsHubBtn.Margin = new System.Windows.Forms.Padding(0);
            this.benefitsHubBtn.Name = "benefitsHubBtn";
            this.benefitsHubBtn.Size = new System.Drawing.Size(141, 31);
            this.benefitsHubBtn.TabIndex = 8;
            this.benefitsHubBtn.Text = "Benefits Hub";
            this.benefitsHubBtn.UseVisualStyleBackColor = false;
            this.benefitsHubBtn.Click += new System.EventHandler(this.benefitsHubBtn_Click);
            // 
            // BenefitsHubButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.benefitsHubBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BenefitsHubButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button benefitsHubBtn;

        #endregion
    }
}
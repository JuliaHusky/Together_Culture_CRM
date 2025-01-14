using System.ComponentModel;

namespace BeaversCRM_1.BurgerMenuButtons
{
    partial class DigitalConnectionsButton
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
            this.digitalConnectionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digitalConnectionsBtn
            // 
            this.digitalConnectionsBtn.BackColor = System.Drawing.SystemColors.Window;
            this.digitalConnectionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digitalConnectionsBtn.Font = new System.Drawing.Font("Segoe UI", 7.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalConnectionsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.digitalConnectionsBtn.Location = new System.Drawing.Point(0, 0);
            this.digitalConnectionsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.digitalConnectionsBtn.Name = "digitalConnectionsBtn";
            this.digitalConnectionsBtn.Size = new System.Drawing.Size(141, 31);
            this.digitalConnectionsBtn.TabIndex = 10;
            this.digitalConnectionsBtn.Text = "Digital Connections";
            this.digitalConnectionsBtn.UseVisualStyleBackColor = false;
            this.digitalConnectionsBtn.Click += new System.EventHandler(this.digitalConnectionsBtn_Click);
            // 
            // DigitalConnectionsButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.digitalConnectionsBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DigitalConnectionsButton";
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button digitalConnectionsBtn;

        #endregion
    }
}
namespace BeaversCRM_1
{
    partial class EventDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDateTime = new System.Windows.Forms.Label();
            this.txtEventDetails = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(35, 26);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(118, 42);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "label1";
            // 
            // lblEventDateTime
            // 
            this.lblEventDateTime.AutoSize = true;
            this.lblEventDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDateTime.Location = new System.Drawing.Point(37, 84);
            this.lblEventDateTime.Name = "lblEventDateTime";
            this.lblEventDateTime.Size = new System.Drawing.Size(79, 29);
            this.lblEventDateTime.TabIndex = 1;
            this.lblEventDateTime.Text = "label1";
            // 
            // txtEventDetails
            // 
            this.txtEventDetails.AutoSize = true;
            this.txtEventDetails.Location = new System.Drawing.Point(39, 129);
            this.txtEventDetails.Name = "txtEventDetails";
            this.txtEventDetails.Size = new System.Drawing.Size(35, 13);
            this.txtEventDetails.TabIndex = 2;
            this.txtEventDetails.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(624, 397);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(152, 23);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book this Event";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtEventDetails);
            this.Controls.Add(this.lblEventDateTime);
            this.Controls.Add(this.lblEventName);
            this.Name = "EventDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventDetails";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDateTime;
        private System.Windows.Forms.Label txtEventDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBook;
    }
}
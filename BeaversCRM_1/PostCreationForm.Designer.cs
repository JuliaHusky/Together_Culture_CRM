namespace BeaversCRM_1
{
    partial class PostCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostCreationForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PostButton1 = new System.Windows.Forms.Button();
            this.SkillComboBox = new System.Windows.Forms.ComboBox();
            this.TagComboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 253);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PostButton1
            // 
            this.PostButton1.Location = new System.Drawing.Point(33, 415);
            this.PostButton1.Name = "PostButton1";
            this.PostButton1.Size = new System.Drawing.Size(75, 23);
            this.PostButton1.TabIndex = 3;
            this.PostButton1.Text = "Post";
            this.PostButton1.UseVisualStyleBackColor = true;
            this.PostButton1.Click += new System.EventHandler(this.PostButton1_Click);
            // 
            // SkillComboBox
            // 
            this.SkillComboBox.FormattingEnabled = true;
            this.SkillComboBox.Location = new System.Drawing.Point(33, 41);
            this.SkillComboBox.Name = "SkillComboBox";
            this.SkillComboBox.Size = new System.Drawing.Size(121, 21);
            this.SkillComboBox.TabIndex = 5;
            this.SkillComboBox.SelectedIndexChanged += new System.EventHandler(this.SkillComboBox_SelectedIndexChanged);
            // 
            // TagComboBox1
            // 
            this.TagComboBox1.FormattingEnabled = true;
            this.TagComboBox1.Location = new System.Drawing.Point(33, 355);
            this.TagComboBox1.Name = "TagComboBox1";
            this.TagComboBox1.Size = new System.Drawing.Size(121, 21);
            this.TagComboBox1.TabIndex = 6;
            this.TagComboBox1.SelectedIndexChanged += new System.EventHandler(this.TagComboBox1_SelectedIndexChanged);
            // 
            // PostCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.TagComboBox1);
            this.Controls.Add(this.SkillComboBox);
            this.Controls.Add(this.PostButton1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PostCreationForm";
            this.Text = "PostCreationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PostButton1;
        private System.Windows.Forms.ComboBox SkillComboBox;
        private System.Windows.Forms.ComboBox TagComboBox1;
    }
}
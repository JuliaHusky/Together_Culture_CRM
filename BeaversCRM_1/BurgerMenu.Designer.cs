using System.ComponentModel;

namespace BeaversCRM_1
{
    partial class BurgerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurgerMenu));
            this.menuOuterPanel = new System.Windows.Forms.Panel();
            this.menuBtnPanel = new System.Windows.Forms.Panel();
            this.popUpMenuBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameAndProfilePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pofilePictureBox = new System.Windows.Forms.PictureBox();
            this.menuOuterPanel.SuspendLayout();
            this.menuBtnPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.nameAndProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pofilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOuterPanel
            // 
            this.menuOuterPanel.BackColor = System.Drawing.Color.White;
            this.menuOuterPanel.Controls.Add(this.menuBtnPanel);
            this.menuOuterPanel.Controls.Add(this.menuPanel);
            this.menuOuterPanel.Location = new System.Drawing.Point(0, 0);
            this.menuOuterPanel.Name = "menuOuterPanel";
            this.menuOuterPanel.Size = new System.Drawing.Size(144, 287);
            this.menuOuterPanel.TabIndex = 6;
            // 
            // menuBtnPanel
            // 
            this.menuBtnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.menuBtnPanel.Controls.Add(this.popUpMenuBtn);
            this.menuBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBtnPanel.Location = new System.Drawing.Point(0, 0);
            this.menuBtnPanel.Name = "menuBtnPanel";
            this.menuBtnPanel.Size = new System.Drawing.Size(144, 55);
            this.menuBtnPanel.TabIndex = 3;
            // 
            // popUpMenuBtn
            // 
            this.popUpMenuBtn.BackColor = System.Drawing.Color.White;
            this.popUpMenuBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popUpMenuBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.popUpMenuBtn.Location = new System.Drawing.Point(4, 4);
            this.popUpMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.popUpMenuBtn.Name = "popUpMenuBtn";
            this.popUpMenuBtn.Size = new System.Drawing.Size(34, 34);
            this.popUpMenuBtn.TabIndex = 2;
            this.popUpMenuBtn.Text = "☰";
            this.popUpMenuBtn.UseVisualStyleBackColor = false;
            this.popUpMenuBtn.Click += new System.EventHandler(this.popUpMenuBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.menuPanel.Controls.Add(this.nameAndProfilePanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.Location = new System.Drawing.Point(0, 60);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(144, 227);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.Visible = false;
            // 
            // nameAndProfilePanel
            // 
            this.nameAndProfilePanel.Controls.Add(this.nameLabel);
            this.nameAndProfilePanel.Controls.Add(this.pofilePictureBox);
            this.nameAndProfilePanel.Location = new System.Drawing.Point(2, 2);
            this.nameAndProfilePanel.Margin = new System.Windows.Forms.Padding(2);
            this.nameAndProfilePanel.Name = "nameAndProfilePanel";
            this.nameAndProfilePanel.Size = new System.Drawing.Size(140, 85);
            this.nameAndProfilePanel.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLabel.Location = new System.Drawing.Point(0, 61);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(140, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name Surname(Admin)";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pofilePictureBox
            // 
            this.pofilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pofilePictureBox.Image")));
            this.pofilePictureBox.Location = new System.Drawing.Point(46, 4);
            this.pofilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pofilePictureBox.Name = "pofilePictureBox";
            this.pofilePictureBox.Size = new System.Drawing.Size(48, 48);
            this.pofilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pofilePictureBox.TabIndex = 0;
            this.pofilePictureBox.TabStop = false;
            // 
            // BurgerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuOuterPanel);
            this.Name = "BurgerMenu";
            this.Size = new System.Drawing.Size(144, 287);
            this.Load += new System.EventHandler(this.BurgerMenuAdmin_Load);
            this.menuOuterPanel.ResumeLayout(false);
            this.menuBtnPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.nameAndProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pofilePictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel menuOuterPanel;
        private System.Windows.Forms.Panel menuBtnPanel;
        private System.Windows.Forms.Button popUpMenuBtn;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private System.Windows.Forms.Panel nameAndProfilePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pofilePictureBox;

        #endregion
    }
}
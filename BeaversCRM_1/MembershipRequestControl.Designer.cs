using System.ComponentModel;

namespace BeaversCRM_1
{
    partial class MembershipRequestControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipRequestControl));
            this.requestPanel = new System.Windows.Forms.Panel();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.requestDetailsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.membershipLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.requestAvatar = new System.Windows.Forms.PictureBox();
            this.requestPanel.SuspendLayout();
            this.requestDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // requestPanel
            // 
            this.requestPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.requestPanel.Controls.Add(this.declineButton);
            this.requestPanel.Controls.Add(this.acceptButton);
            this.requestPanel.Controls.Add(this.requestDetailsPanel);
            this.requestPanel.Controls.Add(this.emailLabel);
            this.requestPanel.Controls.Add(this.nameLabel);
            this.requestPanel.Controls.Add(this.requestAvatar);
            this.requestPanel.Location = new System.Drawing.Point(0, 0);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(626, 122);
            this.requestPanel.TabIndex = 1;
            // 
            // declineButton
            // 
            this.declineButton.BackColor = System.Drawing.Color.Red;
            this.declineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.declineButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.declineButton.FlatAppearance.BorderSize = 2;
            this.declineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declineButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.declineButton.Location = new System.Drawing.Point(525, 68);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(88, 40);
            this.declineButton.TabIndex = 5;
            this.declineButton.Text = "Decline";
            this.declineButton.UseVisualStyleBackColor = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Lime;
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.acceptButton.FlatAppearance.BorderSize = 2;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(525, 13);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(88, 40);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // requestDetailsPanel
            // 
            this.requestDetailsPanel.Controls.Add(this.membershipLabel);
            this.requestDetailsPanel.Controls.Add(this.paymentLabel);
            this.requestDetailsPanel.Controls.Add(this.statusLabel);
            this.requestDetailsPanel.Location = new System.Drawing.Point(336, 13);
            this.requestDetailsPanel.Name = "requestDetailsPanel";
            this.requestDetailsPanel.Size = new System.Drawing.Size(178, 95);
            this.requestDetailsPanel.TabIndex = 3;
            // 
            // membershipLabel
            // 
            this.membershipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.membershipLabel.BackColor = System.Drawing.Color.White;
            this.membershipLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.membershipLabel.Location = new System.Drawing.Point(3, 3);
            this.membershipLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.membershipLabel.Name = "membershipLabel";
            this.membershipLabel.Padding = new System.Windows.Forms.Padding(3);
            this.membershipLabel.Size = new System.Drawing.Size(172, 23);
            this.membershipLabel.TabIndex = 0;
            this.membershipLabel.Text = "Membership: ";
            this.membershipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentLabel
            // 
            this.paymentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentLabel.BackColor = System.Drawing.Color.White;
            this.paymentLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentLabel.Location = new System.Drawing.Point(3, 36);
            this.paymentLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(172, 23);
            this.paymentLabel.TabIndex = 1;
            this.paymentLabel.Text = "Payment Status: ";
            this.paymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.BackColor = System.Drawing.Color.White;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Location = new System.Drawing.Point(3, 69);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(172, 23);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Approval Status: ";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.emailLabel.Location = new System.Drawing.Point(112, 61);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(210, 24);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email: ";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(112, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(210, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name: ";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // requestAvatar
            // 
            this.requestAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestAvatar.Image = ((System.Drawing.Image)(resources.GetObject("requestAvatar.Image")));
            this.requestAvatar.Location = new System.Drawing.Point(24, 24);
            this.requestAvatar.Name = "requestAvatar";
            this.requestAvatar.Size = new System.Drawing.Size(74, 74);
            this.requestAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.requestAvatar.TabIndex = 0;
            this.requestAvatar.TabStop = false;
            this.requestAvatar.Click += new System.EventHandler(this.requestAvatar_Click);
            // 
            // MembershipRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestPanel);
            this.Name = "MembershipRequestControl";
            this.Size = new System.Drawing.Size(626, 122);
            this.requestPanel.ResumeLayout(false);
            this.requestDetailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestAvatar)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.FlowLayoutPanel requestDetailsPanel;
        private System.Windows.Forms.Label membershipLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox requestAvatar;

        #endregion
    }
}
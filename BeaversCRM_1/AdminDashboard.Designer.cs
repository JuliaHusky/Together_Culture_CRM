using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    partial class AdminDashboard : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pageHeaderPanel = new System.Windows.Forms.Panel();
            this.pageNameLabel = new System.Windows.Forms.Label();
            this.TogCulLogoBox = new System.Windows.Forms.PictureBox();
            this.eventsOuterPanel = new System.Windows.Forms.Panel();
            this.upcomingEventsBtn = new System.Windows.Forms.Button();
            this.pastEventsBtn = new System.Windows.Forms.Button();
            this.eventsInnerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.membershipPopularityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.burgerMenu1 = new BeaversCRM_1.BurgerMenu();
            this.pageHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TogCulLogoBox)).BeginInit();
            this.eventsOuterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membershipPopularityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pageHeaderPanel
            // 
            this.pageHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pageHeaderPanel.Controls.Add(this.pageNameLabel);
            this.pageHeaderPanel.Controls.Add(this.TogCulLogoBox);
            this.pageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.pageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pageHeaderPanel.Name = "pageHeaderPanel";
            this.pageHeaderPanel.Size = new System.Drawing.Size(918, 68);
            this.pageHeaderPanel.TabIndex = 1;
            // 
            // pageNameLabel
            // 
            this.pageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNameLabel.Location = new System.Drawing.Point(359, 18);
            this.pageNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pageNameLabel.Name = "pageNameLabel";
            this.pageNameLabel.Size = new System.Drawing.Size(200, 24);
            this.pageNameLabel.TabIndex = 1;
            this.pageNameLabel.Text = "Admin Dashboard";
            this.pageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TogCulLogoBox
            // 
            this.TogCulLogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TogCulLogoBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.TogCulLogoBox.Image = ((System.Drawing.Image)(resources.GetObject("TogCulLogoBox.Image")));
            this.TogCulLogoBox.Location = new System.Drawing.Point(782, 0);
            this.TogCulLogoBox.Margin = new System.Windows.Forms.Padding(2);
            this.TogCulLogoBox.Name = "TogCulLogoBox";
            this.TogCulLogoBox.Size = new System.Drawing.Size(136, 68);
            this.TogCulLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TogCulLogoBox.TabIndex = 0;
            this.TogCulLogoBox.TabStop = false;
            // 
            // eventsOuterPanel
            // 
            this.eventsOuterPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eventsOuterPanel.AutoScroll = true;
            this.eventsOuterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.eventsOuterPanel.Controls.Add(this.upcomingEventsBtn);
            this.eventsOuterPanel.Controls.Add(this.pastEventsBtn);
            this.eventsOuterPanel.Controls.Add(this.eventsInnerPanel);
            this.eventsOuterPanel.Location = new System.Drawing.Point(161, 107);
            this.eventsOuterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.eventsOuterPanel.Name = "eventsOuterPanel";
            this.eventsOuterPanel.Size = new System.Drawing.Size(509, 550);
            this.eventsOuterPanel.TabIndex = 3;
            // 
            // upcomingEventsBtn
            // 
            this.upcomingEventsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upcomingEventsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.upcomingEventsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upcomingEventsBtn.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingEventsBtn.Location = new System.Drawing.Point(262, 25);
            this.upcomingEventsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.upcomingEventsBtn.Name = "upcomingEventsBtn";
            this.upcomingEventsBtn.Size = new System.Drawing.Size(119, 30);
            this.upcomingEventsBtn.TabIndex = 2;
            this.upcomingEventsBtn.Text = "Upcoming Events";
            this.upcomingEventsBtn.UseVisualStyleBackColor = false;
            this.upcomingEventsBtn.Click += new System.EventHandler(this.upcomingEventsBtn_Click);
            // 
            // pastEventsBtn
            // 
            this.pastEventsBtn.BackColor = System.Drawing.Color.White;
            this.pastEventsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pastEventsBtn.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastEventsBtn.Location = new System.Drawing.Point(127, 25);
            this.pastEventsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pastEventsBtn.Name = "pastEventsBtn";
            this.pastEventsBtn.Size = new System.Drawing.Size(119, 30);
            this.pastEventsBtn.TabIndex = 1;
            this.pastEventsBtn.Text = "Past Events";
            this.pastEventsBtn.UseVisualStyleBackColor = false;
            this.pastEventsBtn.Click += new System.EventHandler(this.pastEventsBtn_Click);
            // 
            // eventsInnerPanel
            // 
            this.eventsInnerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsInnerPanel.AutoScroll = true;
            this.eventsInnerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.eventsInnerPanel.Location = new System.Drawing.Point(46, 80);
            this.eventsInnerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.eventsInnerPanel.Name = "eventsInnerPanel";
            this.eventsInnerPanel.Size = new System.Drawing.Size(433, 456);
            this.eventsInnerPanel.TabIndex = 0;
            this.eventsInnerPanel.WrapContents = false;
            this.eventsInnerPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.eventsInnerPanel_Scroll);
            this.eventsInnerPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.eventsInnerPanel_MouseWheel);
            // 
            // membershipPopularityChart
            // 
            this.membershipPopularityChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.membershipPopularityChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "membershipChartArea";
            this.membershipPopularityChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "membershipChartLegend";
            this.membershipPopularityChart.Legends.Add(legend1);
            this.membershipPopularityChart.Location = new System.Drawing.Point(674, 107);
            this.membershipPopularityChart.Margin = new System.Windows.Forms.Padding(2);
            this.membershipPopularityChart.Name = "membershipPopularityChart";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 3;
            series1.ChartArea = "membershipChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Label = "#PERCENT";
            series1.Legend = "membershipChartLegend";
            series1.Name = "membershipSeries";
            dataPoint1.Color = System.Drawing.Color.Red;
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.LegendText = "Community Membership";
            dataPoint2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            dataPoint2.Color = System.Drawing.Color.Olive;
            dataPoint2.Label = "#PERCENT";
            dataPoint2.LabelToolTip = "#VALY: #PERCENT";
            dataPoint2.LegendText = "Business Unusual Membership";
            dataPoint3.LegendText = "Workspace Membership";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.membershipPopularityChart.Series.Add(series1);
            this.membershipPopularityChart.Size = new System.Drawing.Size(238, 392);
            this.membershipPopularityChart.TabIndex = 4;
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "membershipChartTitle";
            title1.Text = "Popularity Of Memberships";
            this.membershipPopularityChart.Titles.Add(title1);
            // 
            // burgerMenu1
            // 
            this.burgerMenu1.Location = new System.Drawing.Point(5, 13);
            this.burgerMenu1.Name = "burgerMenu1";
            this.burgerMenu1.Size = new System.Drawing.Size(144, 287);
            this.burgerMenu1.TabIndex = 5;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(918, 680);
            this.Controls.Add(this.burgerMenu1);
            this.Controls.Add(this.membershipPopularityChart);
            this.Controls.Add(this.eventsOuterPanel);
            this.Controls.Add(this.pageHeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.Shown += new System.EventHandler(this.AdminDashboard_Shown);
            this.pageHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TogCulLogoBox)).EndInit();
            this.eventsOuterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membershipPopularityChart)).EndInit();
            this.ResumeLayout(false);
        }

        private BeaversCRM_1.BurgerMenu burgerMenu1;

        private System.Windows.Forms.DataVisualization.Charting.Chart membershipPopularityChart;

        private System.Windows.Forms.Button pastEventsBtn;
        private System.Windows.Forms.Button upcomingEventsBtn;

        private System.Windows.Forms.FlowLayoutPanel eventsInnerPanel;

        private System.Windows.Forms.Panel eventsOuterPanel;

        private System.Windows.Forms.Label pageNameLabel;

        private System.Windows.Forms.PictureBox TogCulLogoBox;

        private System.Windows.Forms.Panel pageHeaderPanel;

        private System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1;
        
        private System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2;
        
        private System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3;

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace BeaversCRM_1
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            initialiseBackgroundWorker();
        }

        private bool upcomingEventsDisplayed = true;
        private BackgroundWorker worker;
        private int pastEventsOffset = 0;
        private int upcomingEventsOffset = 0;
        private bool allUpcomingEventsDisplayed = false;
        private bool allPastEventsDisplayed = false;

        private void pastEventsBtn_Click(object sender, EventArgs e)
        {
            if (upcomingEventsDisplayed && !worker.IsBusy)
            {   (pastEventsBtn.BackColor, upcomingEventsBtn.BackColor) = (upcomingEventsBtn.BackColor, pastEventsBtn.BackColor);
                upcomingEventsDisplayed = false;
                eventsInnerPanel.Controls.Clear();
                allUpcomingEventsDisplayed = false;
                upcomingEventsOffset = 0;
                worker.RunWorkerAsync(Constants.GET_PAST_EVENTS);
            }
        }

        private void upcomingEventsBtn_Click(object sender, EventArgs e)
        {
            if (!upcomingEventsDisplayed && !worker.IsBusy)
            {
                (pastEventsBtn.BackColor, upcomingEventsBtn.BackColor) = (upcomingEventsBtn.BackColor, pastEventsBtn.BackColor);
                upcomingEventsDisplayed = true;
                eventsInnerPanel.Controls.Clear();
                allPastEventsDisplayed = false;
                pastEventsOffset = 0;
                worker.RunWorkerAsync(Constants.GET_UPCOMING_EVENTS);
            }
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.isLoggedIn)
            {
                Application.Exit();
            }
        }

        private void AdminDashboard_Shown(object sender, EventArgs e)
        {
            setPieChartData();
            worker.RunWorkerAsync(Constants.GET_UPCOMING_EVENTS);
        }

        private void initialiseBackgroundWorker()
        {
            worker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            worker.DoWork += workerCreateEventControls;
            worker.RunWorkerCompleted += workerLoadEventControls;
        }

        private void workerCreateEventControls(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<EventControl> eventControls = new List<EventControl>();
                DataRowCollection events;
                if ((string)e.Argument == Constants.GET_UPCOMING_EVENTS && !allUpcomingEventsDisplayed)
                {
                    events = Event.getEventsFromDb(Constants.GET_UPCOMING_EVENTS, upcomingEventsOffset);
                    upcomingEventsOffset += 10;
                }
                else if ((string)e.Argument == Constants.GET_PAST_EVENTS && !allPastEventsDisplayed)
                {
                    events = Event.getEventsFromDb(Constants.GET_PAST_EVENTS, pastEventsOffset);
                    pastEventsOffset += 10;
                }
                else
                {
                    return;
                }
                foreach (DataRow eventRecord in events)
                {
                    EventControl ctrl = new EventControl();
                    ctrl.setEventControlProperties(eventRecord);
                    eventControls.Add(ctrl);
                }
                e.Result = eventControls;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating event controls: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void workerLoadEventControls(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                List<EventControl> eventControls = e.Result as List<EventControl>;
                if (eventControls == null)
                {
                    return;
                }
                if (e.Error == null && eventControls.Count != 0)
                {
                    foreach (EventControl eventControl in eventControls)
                    {
                        eventsInnerPanel.Controls.Add(eventControl);
                    }
                } else if (eventControls.Count == 0 && eventsInnerPanel.Controls.Count == 0)
                {
                    NoResultsControl ctrl = new NoResultsControl();
                    ctrl.Size = new Size(eventsInnerPanel.Width - 6, eventsInnerPanel.Height - 6);
                    ctrl.mainPanel.Size = new Size(eventsInnerPanel.Width - 6, eventsInnerPanel.Height - 6);
                    ctrl.mainPanel.BackColor = eventsInnerPanel.BackColor;
                    eventsInnerPanel.Controls.Add(ctrl);
                } else if (eventControls.Count == 0)
                {
                    if (upcomingEventsDisplayed)
                    {
                        allUpcomingEventsDisplayed = true;
                    }
                    else
                    {
                        allPastEventsDisplayed = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding event controls to page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setPieChartData()
        {
            DataRowCollection popularityData = MembershipType.getMembershipTypesPopularity();
            List<double> data = new List<double>()
            {
                Convert.ToDouble(popularityData[0][1]),
                Convert.ToDouble(popularityData[2][1]),
                Convert.ToDouble(popularityData[1][1])
            };
            dataPoint1.SetValueY(data[0] + (100 - data.Sum()));
            dataPoint2.SetValueY(data[1]);
            dataPoint3.SetValueY(data[2]);
        }

        private void eventsInnerPanel_Scroll(object sender, ScrollEventArgs e)
        {
            if (eventsInnerPanel.VerticalScroll.Value + eventsInnerPanel.ClientSize.Height >= eventsInnerPanel.VerticalScroll.Maximum - 1000)
            {
                if (!worker.IsBusy)
                {
                    worker.RunWorkerAsync(upcomingEventsDisplayed
                        ? Constants.GET_UPCOMING_EVENTS
                        : Constants.GET_PAST_EVENTS);
                }
            }
        }

        private void eventsInnerPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            eventsInnerPanel_Scroll(sender, new ScrollEventArgs(ScrollEventType.ThumbTrack, eventsInnerPanel.VerticalScroll.Value, eventsInnerPanel.VerticalScroll.Value + e.Delta));
        }
    }
}
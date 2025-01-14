using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class MembershipRequests : Form
    {
        public MembershipRequests()
        {
            InitializeComponent();
            initialiseBackgroundWorker();
        }
        
        private BackgroundWorker worker;
        private int dateFilterLastIndex = -1;
        private int tagFilterLastIndex = -1;
        public List<MembershipRequestControl> requestControls;

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (string.Equals(searchTextBox.Text, "Search for requests..."))
            {
                searchTextBox.Text = "";
                searchTextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                searchTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                searchTextBox.ForeColor = Color.FromArgb(144, 135, 135);
                searchTextBox.Text = "Search for requests...";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = string.Equals(searchTextBox.Text, "Search for requests...") ? "" : searchTextBox.Text;
            if (dateFilter.SelectedIndex == 0 && !worker.IsBusy)
            {
                requestsPanel.Controls.Clear();
                worker.RunWorkerAsync(new List<string> {Constants.FILTER_REQUESTS_BY_SEARCH_TEXT.Replace("@text", search), Constants.ORDER_REQUESTS_BY_DATE_LATEST});
            }
            else if (dateFilter.SelectedIndex == 1 && !worker.IsBusy)
            {
                requestsPanel.Controls.Clear();
                worker.RunWorkerAsync(new List<string> {Constants.FILTER_REQUESTS_BY_SEARCH_TEXT.Replace("@text",  search), Constants.ORDER_REQUESTS_BY_DATE_OLDEST});
            }
        }

        private void MembershipRequests_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.isLoggedIn)
            {
                Application.Exit();   
            }
        }

        private void MembershipRequests_Shown(object sender, EventArgs e)
        {
            tagFilter.Items.Add("Choose..");
            tagFilter.SelectedIndex = 5;
            dateFilter.SelectedIndex = 0;
        }
        
        private void initialiseBackgroundWorker()
        {
            worker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            worker.DoWork += workerCreateMembershipRequestControls;
            worker.RunWorkerCompleted += workerLoadMembershipRequestControls;
        }

        private void workerCreateMembershipRequestControls(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<string> args = e.Argument as List<string>;
                List<string> emails = new List<string>();
                if (requestControls == null)
                {
                    requestControls = new List<MembershipRequestControl>();
                }
                else
                {
                    requestControls.Clear();
                }
                foreach (DataRow requestRecord in MembershipRequest.getRequestsFromDb(args[0], args[1]))
                {
                    if (!emails.Contains((string)requestRecord[5]))
                    {
                        MembershipRequestControl ctrl = new MembershipRequestControl();
                        ctrl.setRequestProperties(requestRecord);
                        requestControls.Add(ctrl);
                    }
                    else
                    {
                        foreach (MembershipRequestControl ctrl in requestControls)
                        {
                            if (ctrl.request.user.Email == (string)requestRecord[5])
                            {
                                ctrl.request.user.Tags.Add((string)requestRecord[8]);
                            }
                        }
                    }
                    emails.Add((string)requestRecord[5]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating membership request controls: " + ex.Message);
            }
        }

        private void workerLoadMembershipRequestControls(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                requestsPanel.Controls.Clear();
                if (e.Error == null && requestControls.Count != 0)
                {
                    foreach (MembershipRequestControl requestControl in requestControls)
                    {
                        requestsPanel.Controls.Add(requestControl);
                    }
                    tagFilter_SelectedIndexChanged(this, EventArgs.Empty);
                } else if (requestControls.Count == 0)
                {
                    showNoResultsInRequestsPanel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding membership requests to page: " + ex.Message);
            }
        }

        private void tagFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!sender.Equals(tagFilter))
            {
                tagFilterLastIndex--;
            }
            if (!worker.IsBusy && tagFilter.SelectedIndex != 5 && tagFilterLastIndex != tagFilter.SelectedIndex)
            {
                requestsPanel.Controls.Clear();
                foreach (MembershipRequestControl request in requestControls)
                {
                    if (request.request.user.Tags.Contains((string)tagFilter.Items[tagFilter.SelectedIndex]))
                    {
                        requestsPanel.Controls.Add(request);
                    }
                }
                if (!requestsPanel.HasChildren)
                {
                    showNoResultsInRequestsPanel();
                }
            }
            else if (!worker.IsBusy && tagFilterLastIndex != tagFilter.SelectedIndex)
            {
                if (requestControls != null) {
                    requestsPanel.Controls.Clear();
                    foreach (MembershipRequestControl request in requestControls)
                    {
                        requestsPanel.Controls.Add(request);
                    }

                    if (!requestsPanel.HasChildren)
                    {
                        showNoResultsInRequestsPanel();
                    }
                }
            }
            tagFilterLastIndex = tagFilter.SelectedIndex;
        }

        private void dateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateFilter.SelectedIndex == 0 && !worker.IsBusy && dateFilterLastIndex != 0)
            {
                worker.RunWorkerAsync(new List<string> {null, Constants.ORDER_REQUESTS_BY_DATE_LATEST});
            }
            else if (dateFilter.SelectedIndex == 1 && !worker.IsBusy && dateFilterLastIndex != 1)
            {
                worker.RunWorkerAsync(new List<string> {null, Constants.ORDER_REQUESTS_BY_DATE_OLDEST});
            }
            dateFilterLastIndex = dateFilter.SelectedIndex;
        }

        private void showNoResultsInRequestsPanel()
        {
            NoResultsControl ctrl = new NoResultsControl();
            ctrl.Size = new Size(requestsPanel.Width - 6, requestsPanel.Height - 6);
            ctrl.mainPanel.Size = new Size(requestsPanel.Width - 6, requestsPanel.Height - 6);
            ctrl.mainPanel.BackColor = requestsPanel.BackColor;
            requestsPanel.Controls.Add(ctrl);
        }
    }
}
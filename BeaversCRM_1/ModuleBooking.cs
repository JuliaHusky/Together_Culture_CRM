using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;//ProcessStartInfo - Allows url redirecting

namespace BeaversCRM_1
{
    public partial class ModuleBooking : Form
    {
        public ModuleBooking()
        {
            InitializeComponent();
            this.Load += DigitalContentModules_Load;
        }

        private void DigitalContentModules_Load(object sender, EventArgs e)
        {
            var modules = new List<ContentModule>
            {
                new ContentModule
                {
                    Title = "Monthly Restorative Rest", //Title of content
                    Description = "Relax and recharge with a monthly session", //Description of module/content
                    RedirectUrl = "https://www.eventbrite.co.uk/e/monthly-restorative-rest-with-antoinette-tickets-871925882787", //redirects user upon clicking to ticket booking
                    DateTime = new DateTime(2024, 12, 19, 10, 0, 0)  //19th December 10am.
                },

                new ContentModule
                {
                    Title = "Creative Writing Workshop",
                    Description = "Discover your creativity.",
                    DateTime = new DateTime(2024, 12, 20, 14, 0, 0)
                }
            };

            //Populate Flowlayoutpanel
            foreach (var module in modules)
            { 
                var panel = new Panel
                { 
                    Padding = new Padding(10),
                    BackColor = Color.White,
                    Width = 220,
                    Height = 250,
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand,



                };

                var TitleLbl = new Label 
                { 
                    Text = module.Title,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    TextAlign = ContentAlignment.TopCenter,
                    Dock = DockStyle.Top,
                    Height = 40,
                };

                var DescLbl = new Label
                { 
                    Text = module.Description,
                    Font = new Font("Arial", 10),
                    TextAlign = ContentAlignment.TopLeft,
                    Dock = DockStyle.Fill,
                    Padding = new Padding(5),
                    Height = 50,
                    BackColor = Color.LightBlue
                };

                Label dateTimeLbl = null;
                if (module.DateTime.HasValue)
                {
                    dateTimeLbl = new Label
                    {
                        Text= module.DateTime.Value.ToString("MMMM dd, yyy - h:mm tt"),
                        Font = new Font("Arial", 10, FontStyle.Italic),
                        TextAlign = ContentAlignment.TopCenter,
                        Dock = DockStyle.Bottom,
                        Height = 30,
                        BackColor = Color.LightPink
                    };
                }
                //Add labels to panel. Last added will appear at top, hence order added
                if (dateTimeLbl != null) panel.Controls.Add(dateTimeLbl);
                panel.Controls.Add(DescLbl);
                panel.Controls.Add(TitleLbl);
                ModuleFlowPanel1.Controls.Add(panel);

                panel.Click += (s, args2) => //makes entire panel clickable + redirects to url
                {
                    Process.Start(new ProcessStartInfo(module.RedirectUrl) { UseShellExecute = true });
                };

 
            };
        } 

             
        
        private void ModuleFlowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModuleFlowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleLbl_Click(object sender, EventArgs e)
        {

        }

        private void DescLbl_Click(object sender, EventArgs e)
        {

        }

        private void DateTimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void DigitalModuleTitleLbl_Click(object sender, EventArgs e)
        {

        }
    }

    public class ContentModule
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string RedirectUrl { get; set; }
        public DateTime? DateTime { get; set; } //Optional date and time as not all digital modules will be at a set date/time
    }

    }

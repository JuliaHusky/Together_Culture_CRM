using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeaversCRM_1
{
    public partial class BenefitsHub : Form
    {
        public BenefitsHub()
        {
            InitializeComponent();
        }



        private void LearnNewSkills_Click(object sender, EventArgs e) //Actually opens module booking form
        {
            ModuleBooking moduleBookingForm = new ModuleBooking();
            moduleBookingForm.Show();

        }

        private void TCLOGO_Click(object sender, EventArgs e)
        {

        }

        private void ViewUnusedBenefits_Click(object sender, EventArgs e)
        {

        }

        //HireAPlace button opens Together Culture's "Place hire" booking form via their website.
        private void HireAPlace_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.togetherculture.com/place-hire-enquiry-form");
        }

        private void CurrentBenefitsTitle_Click(object sender, EventArgs e)
        {

        }

        private void InnerBenefitsHubPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BenefitsPanelBackgroundPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BenefitsHubTitleLbl_Click(object sender, EventArgs e)
        {

        }
        //Populate each benefit panel with title and description taken from Together culture's website
        private void BenefitsHub_Load(object sender, EventArgs e)
        {
            var benefits = new List<Benefit>  //Stores the benefit as a title and description to be displayed in the panel
            {
                new Benefit
                {
                    Title = "Your own living room on the high street",
                    Description = "\r\n\r\nYou’ll get access to Together Culture on Fitzroy Street in Cambridge within our opening hours (Monday - Friday, 12 - 5pm). \r\n\r\nThe space has been designed for you by the award-winning Ab Rogers Design. Drop in regularly to work, enjoy the space, watch a film and take part in pop-up events."
                }, // "\r\n\r\n" is included before each description to add a spacer (creates new paragraph) between title and description.

                new Benefit
                {
                    Title = "Free or discounted event tickets",
                    Description = "\r\n\r\nMembership includes a free or discounted tickets to every event that we run, including our seasonal events and creative skills development workshops, including our Turning Up and Butter Making Disco!"
                },

                new Benefit
                {
                    Title = "Contribute to our Saturday Lounge events",
                    Description = "\r\n\r\nEvery month, we’ll invite members of Together Culture to contribute to the programme by creating and delivering workshops, events or masterclasses at our monthly Saturday Lounges. "
                },

                new Benefit
                {
                    Title = "Our Citizens' Studio",
                    Description = "\r\n\r\nAdd your voice to designing a more inclusive creative economy in our Citizens’ Studio this year - a dedicated space to identify and agree on the themes we want to take to our incubator to build new enterprises for a more inclusive creative economy. This immersive experience, which we describe as a Bake Off technical challenge meets an escape room, helps you learn more about design thinking as we explore the question; ‘What is a creative community and what is its potential to create a more inclusive and vibrant Cambridge?’\r\n\r\nThen, help us pull together the common threads emerging from the Citizens’ Studio, and decide what theme we’ll tackle in our Systems Change Incubator to create a more vibrant, inclusive and ecological Cambridge."
                },
                new Benefit
                {
                    Title = "Hot Desks and Free wifi",
                    Description = "\r\n\r\nSay goodbye to expensive co-working spaces and uninspiring coffee chains - make use of affordable hot-desking in our creative space."
                }, 

                new Benefit
                {
                    Title = "5 Free passes for your friends",
                    Description = "\r\n\r\n Together Culture is a growing community, and we believe we can achieve so much more as a collective than as individuals. We also know that collaboration allows new ideas to emerge. With this in mind, we encourage you to bring guests into the space to work alongside you. \r\n\r\nEvery month you get five passes to bring your friends into Together Culture Fitzroy. Once you’re out of passes, Day Passes cost £5."
                },

                new Benefit
                {
                    Title = "The Living Book, Our toolkit for creative living",
                    Description = "\r\n\r\n Every member receives a digital copy of the Living Book when they join Together Culture.\r\n\r\nThe Living Book is a guide to the Together Culture values. It’s also a workbook for building the skills that help us develop a creative practice that we can bring into everything we do in life. The Living Book is the foundation of every experience you’ll have at Together Culture. It is how we are designing for connection and turning ideas into action.\r\n\r\nThe Living Book in and of itself will evolve. The first edition is the product of co-design and after 6 months at Fitzroy, we’ll be inviting members to feedback on the Living Book and help to craft our second edition. "
                },

                new Benefit
                {
                    Title = "Your own Just People membership badge",
                    Description = "\r\n\r\n Several decades ago the faculty of a public (read: state) school in Upstate New York was polarised about how to best serve the students in their care in the wake of new curriculum policies and budget cuts. Gossip flew and tempers flared. People lost perspective that people were just people, not villains, and otherness abounded.\r\n\r\nOne teacher, in an act of creative generosity, spent a weekend making badges that read “Just…people”, which she gave to her colleagues the following week. It was an inspired act that began to turn the tide and help people realise their shared intent to serve the young people of their community, to help them thrive. That teacher was the beloved Auntie of one of our founders. Aunt Sig is no longer with us, yet that story of her creative superpower to offer perspective and bridge peace, reached Heather for the first time, quite unexpectedly, in a business meeting last year.\r\n\r\nTogether Culture's Just People badge is a collab between Auntie Sig and each person who joins our community. It’s our mission."
                },

                new Benefit
                {
                    Title = "Put the kettle on!",
                    Description = "\r\n\r\n All our members enjoy free tea and coffee"
                },

                new Benefit
                {
                    Title = "Pay it forward",
                    Description = "\r\n\r\n For every 100 paying members, 25 memberships are paid forward to people facing financial hardship. "
                } //Any new benefits are added here
            }; 
            //Loop to populate panel with each benefit title and description
            foreach (var benefit in benefits)
            {
                var panel = new Panel //defines how each panel should display data
                {
                    Padding = new Padding (10),
                    Margin = new Padding (5),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoSize = true, //allows the panels to resize height to fit description text
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Width = 500, //Sets a uniform width for panels

                    //MaximumSize = new Size(500, 0)
                };

                var titleLabel = new Label
                {
                    Text = benefit.Title, 
                    Font = new Font("Arial", 14, FontStyle.Bold), //set font, size and font style for title
                    //Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.TopLeft, //sets how the title alligns within the panel
                    AutoSize = true, //allows the title to autosize to fit within panel
                    MaximumSize = new Size (480, 0),
                };

                var descriptionLabel = new Label
                {
                    Text = benefit.Description,
                    Font = new Font("Arial", 12),
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true, //Allows the description to autosize the size of the panel
                    MaximumSize = new Size(480, 0),
                };

                panel.Controls.Add(titleLabel); //Adds title to panel
                panel.Controls.Add(descriptionLabel); //Adds description to panel
                BenefitsFlowPanel1.Controls.Add(panel); //adds panel to the BenefitsFlowLayoutPanel
            }
        }
  
        private void BenefitsFlowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
// Custom class for benefit, represents each benefit with a title and description which is then populated into the flow panel to display benefits to the user.
public class Benefit
{
    public string Title { get; set; }
    public string Description { get; set; }
}
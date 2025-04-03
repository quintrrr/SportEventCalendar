using System;
using System.Data;
using SportEventCalendar.Classes;
using static System.Net.WebRequestMethods;


namespace SportEventCalendar
{
    public partial class EventViewerWindow : Form
    {
        public EventViewerWindow(Event selectedEvent)
        {
            InitializeComponent();
            var currentEvent = selectedEvent;
            EventName.Text = currentEvent.name;
            EventDescription.Text = currentEvent.description;
            startDate.Text = currentEvent.start_date.ToString("yyyy-MM-dd HH:mm");
            finishDate.Text = currentEvent.end_date.ToString("yyyy-MM-dd HH:mm");
            timePicker.Text = currentEvent.time.ToString(@"hh\:mm");
            //sportName.Text = 
            pictureBox1.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(currentEvent.image_url)));

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventViewerWindow_Load(object sender, EventArgs e)
        {



        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            imageButton.Visible = true;
            panel2.Visible = true;
            sportName.Visible = false;
            teamsView.Visible = false;
            cancel2Button.Visible = true;
            saveButton.Visible = true;
            editButton.Visible = false;
            EventDescription.ReadOnly = false;
            EventName.ReadOnly = false;
        }

        private void cancel2Button_Click(object sender, EventArgs e)
        {
            imageButton.Visible = false;
            panel2.Visible = false;
            sportName.Visible = true;
            teamsView.Visible = true;
            cancel2Button.Visible = false;
            saveButton.Visible = false;
            editButton.Visible = true;
            EventDescription.ReadOnly = true;
            EventName.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancel1Button_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

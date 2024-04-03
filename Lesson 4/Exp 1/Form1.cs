using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _152120211106_Ex_4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> timeZoneOffsets = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            InitializeTimeZoneOffsets();
        }

        private void InitializeTimeZoneOffsets()
        {
            timeZoneOffsets.Add("GMT", 0);
            timeZoneOffsets.Add("UTC", 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var timeZone in timeZoneOffsets.Keys)
            {
                comboBox1.Items.Add(timeZone);
                checkedListBox1.Items.Add(timeZone);
            }
            comboBox1.SelectedIndex = 0;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            // Adjust current time based on selected time zone
            if (comboBox1.SelectedItem != null && timeZoneOffsets.ContainsKey(comboBox1.SelectedItem.ToString()))
            {
                int hourDifference = timeZoneOffsets[comboBox1.SelectedItem.ToString()];
                currentTime = currentTime.AddHours(hourDifference);
            }

            // Update label with current time
            label1.Text = currentTime.ToString("HH:mm:ss");
            // Change label color based on time of day
            label1.ForeColor = (currentTime.Hour >= 8 && currentTime.Hour < 20) ? button1.ForeColor : Color.Black;

            // Update DateTimePicker control
            dateTimePicker1.Value = currentTime;

        }

        private void buttonAddTimeZone_Click(object sender, EventArgs e)
        {
            string timeZoneInput = txt.Text.Trim();


            string[] timeZoneEntries = timeZoneInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var entry in timeZoneEntries)
            {
                string[] parts = entry.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2 && (parts[1].StartsWith("+") || parts[1].StartsWith("-")) && int.TryParse(parts[1].Substring(1), out int hourDifference))
                {
                    string timeZoneName = parts[0].Trim(); // Zaman dilimi adı

                    hourDifference = int.Parse(parts[1]);

                    string newTimeZone = timeZoneName + " " + hourDifference; 
                    timeZoneOffsets.Add(newTimeZone, hourDifference);

                    comboBox1.Items.Add(newTimeZone);
                    checkedListBox1.Items.Add(newTimeZone);
                }
                else
                {
                    MessageBox.Show("Invalid time zone format! Please enter a valid time zone (e.g., Turkey +3).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            txt.Clear();
        }

        private void buttonDeleteTimeZones_Click(object sender, EventArgs e)
        {
            List<string> timeZonesToDelete = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                timeZonesToDelete.Add(item.ToString());
            }

            foreach (var timeZone in timeZonesToDelete)
            {
                timeZoneOffsets.Remove(timeZone);
                comboBox1.Items.Remove(timeZone);
                checkedListBox1.Items.Remove(timeZone);
            }

            checkedListBox1.ClearSelected();
        }

        private void buttonUpdateTimeZone_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                string selectedTimeZone = checkedListBox1.CheckedItems[0].ToString();
                int hourDifference = 0;

                // Parse the new time zone entry
                string newTxt = txt.Text.Trim();
                string[] parts = newTxt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2 && (parts[1].StartsWith("+") || parts[1].StartsWith("-")) && int.TryParse(parts[1], out int newHourDifference))
                {
                    hourDifference = newHourDifference;
                }
                else
                {
                    MessageBox.Show("Invalid time zone format! Please enter a valid time zone (e.g., Turkey +3).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the time zone offset
                timeZoneOffsets[selectedTimeZone] = hourDifference;

                // Update the label with the new time zone
                DateTime currentTime = DateTime.UtcNow.AddHours(hourDifference); // Calculate current time based on the updated time zone

                label1.Text = currentTime.ToString("HH:mm:ss");
                label1.ForeColor = (currentTime.Hour >= 8 && currentTime.Hour < 20) ? button1.ForeColor : Color.Black;
            }
            else
            {
                MessageBox.Show("Please select a single time zone to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            if (comboBox1.SelectedItem != null && timeZoneOffsets.ContainsKey(comboBox1.SelectedItem.ToString()))
            {
                int hourDifference = timeZoneOffsets[comboBox1.SelectedItem.ToString()];
                currentTime = currentTime.AddHours(hourDifference);
            }

            label1.Text = currentTime.ToString("HH:mm:ss");
            label1.ForeColor = (currentTime.Hour >= 8 && currentTime.Hour < 20) ? button1.ForeColor : Color.Black;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime newTime = DateTime.Now.Date + dateTimePicker1.Value.TimeOfDay;
            label1.Text = newTime.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {

                ColorDialog Renk = new ColorDialog();
                Renk.ShowDialog();
                button1.ForeColor = Renk.Color;

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            // Get the current date and time
            DateTime currentTime = DateTime.Now;

            // Check if a time zone is selected
            if (comboBox1.SelectedItem != null && timeZoneOffsets.ContainsKey(comboBox1.SelectedItem.ToString()))
            {
                // Get the offset of the selected time zone
                int hourDifference = timeZoneOffsets[comboBox1.SelectedItem.ToString()];

                // Adjust the current time based on the time zone offset
                currentTime = currentTime.AddHours(hourDifference);
            }

            // Update the date of the dateTimePicker with the adjusted current time
            dateTimePicker1.Value = currentTime;
        }
    }
}

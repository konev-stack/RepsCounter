using System;
using System.Windows.Forms;

namespace RepsCounter
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private int totalSeconds;
        private int totalRepsNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalreps.Text = totalRepsNumber.ToString();
            for (int i = 0; i <= 60; i++)
            {
                this.metroComboBox1.Items.Add(i.ToString());
                this.metroComboBox2.Items.Add(i.ToString());
            }
            stopButton.Enabled = false;
            metroComboBox1.SelectedIndex = 10;
            metroComboBox2.SelectedIndex = 0;
        }

        private void minus1rep_Click(object sender, EventArgs e)
        {
            if (totalRepsNumber - 1 < 0)
            {
                MessageBox.Show("Try adding reps.");
            }
            else
            {
                totalRepsNumber--;
                totalreps.Text = totalRepsNumber.ToString();
            }
        }

        private void plus1rep_Click(object sender, EventArgs e)
        {
            totalRepsNumber += 1;
            totalreps.Text = totalRepsNumber.ToString();
        }

        private void plus5reps_Click(object sender, EventArgs e)
        {
            totalRepsNumber += 5;
            totalreps.Text = totalRepsNumber.ToString();
        }

        private void plus10reps_Click(object sender, EventArgs e)
        {
            totalRepsNumber += 10;
            totalreps.Text = totalRepsNumber.ToString();
        }

        private void minus5reps_Click(object sender, EventArgs e)
        {
            if (totalRepsNumber - 5 < 0)
            {
                MessageBox.Show("Try adding reps.");
            }
            else
            {
                totalRepsNumber-=5;
                totalreps.Text = totalRepsNumber.ToString();
            }
        }

        private void minus10reps_Click(object sender, EventArgs e)
        {
            if (totalRepsNumber - 10 < 0)
            {
                MessageBox.Show("Try adding reps.");
            }
            else
            {
                totalRepsNumber -= 10;
                totalreps.Text = totalRepsNumber.ToString();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            timer1.Stop();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;

            int minutes = int.Parse(this.metroComboBox1.SelectedItem.ToString());
            int seconds = int.Parse(this.metroComboBox2.SelectedItem.ToString());
            totalSeconds = (minutes * 60) + seconds;

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds - (minutes * 60);
            if (totalSeconds > 0)
            {
                if (minutes < 10 && seconds < 10)
                {
                    labelTimer.Text = "0" + minutes.ToString() + ":" + "0" + seconds.ToString();
                }

                else if (minutes < 10)
                {
                    labelTimer.Text = "0"+ minutes.ToString() + ":" + seconds.ToString();
                }

                else if (seconds < 10)
                {
                    labelTimer.Text = minutes.ToString() + ":" + "0" + seconds.ToString();
                }
                totalSeconds--;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Time's up!");
            }
        }
    }
}

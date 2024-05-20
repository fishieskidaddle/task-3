using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_3__latest_
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("C:/Users/abdul/Downloads/emoji.csv"))

            {

                string line;



                while ((line = sr.ReadLine()) != null)

                {

                    Student_Setup.emoji.Add(line);

                }
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            Start start = new Start();

            start.Owner = this;

            start.StartPosition = FormStartPosition.Manual;

            start.Location = this.Location;

            start.Show();

            this.Hide();
        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void subheading_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Student_Setup.studentname;

            if (Student_Setup.studentname != "")
            {
                welcome_label.Text = "Welcome " + Student_Setup.studentname + "! " + Student_Setup.emoji[Student_Setup.emojiValue];
            }
            else
            {
                welcome_label.Text = "Welcome!";
            }

            lblEmoji.Text = Student_Setup.emoji[Student_Setup.emojiValue];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Student_Setup.studentname = textBox1.Text;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            int value = rand.Next(Student_Setup.emoji.Count());
            Student_Setup.emojiValue = value;
            lblEmoji.Text = Student_Setup.emoji[value];
        }

        private void lblEmoji_Click(object sender, EventArgs e)
        {

        }
    }
}

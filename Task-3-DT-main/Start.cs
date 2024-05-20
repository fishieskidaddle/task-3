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
    
    public  partial class Start : Form

    {
        public static int setup = 0;
        
        public Start()
        {
            InitializeComponent();
            
        }

       

        private void start_button_Click_1(object sender, EventArgs e)
        {
            setup++;
            if (setup == 1)
            {
                Student_Setup student_setup = new Student_Setup();

                student_setup.Owner = this;

                student_setup.StartPosition = FormStartPosition.Manual;

                student_setup.Location = this.Location;

                student_setup.Show();

                this.Hide();
            }
            else if (setup != 1)
            {
                Lesson_Select lesson_select = new Lesson_Select();

                lesson_select.Owner = this;

                lesson_select.StartPosition = FormStartPosition.Manual;

                lesson_select.Location = this.Location;

                lesson_select.Show();

                this.Hide();
            }

                
        }

        private void Start_Load(object sender, EventArgs e)
        {
            if (Student_Setup.studentname == "")
            {
                welcome_label.Text = "Welcome to EDUSpark!";
            }
            else
            {
                welcome_label.Text = "Welcome " + Student_Setup.studentname + "! " + Student_Setup.emoji[Student_Setup.emojiValue];

            }

            if (setup == 0)
            {
                settings.Visible = false;
            }
            else if (setup != 0)
                {
                settings.Visible = true;
            }
        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            settings.Owner = this;

            settings.StartPosition = FormStartPosition.Manual;

            settings.Location = this.Location;

            settings.Show();

            this.Hide();
        }
    }
}

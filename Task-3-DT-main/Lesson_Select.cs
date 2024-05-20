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
    public partial class Lesson_Select : Form
    {
       
        public Lesson_Select()
        {
            InitializeComponent();

        }

       

        private void home_button_Click(object sender, EventArgs e)
        {
            Start start = new Start();

            start.Owner = this;

            start.StartPosition = FormStartPosition.Manual;

            start.Location = this.Location;

            start.Show();

            this.Hide();
        }

        private void Lesson_Select_Load(object sender, EventArgs e)
        {
            if (Algorithm_Activity.status > 0)
            {
                lesson1.BackColor = Color.Green;
            }
           
            
            if (Programming_Activity.status > 0)
            {
                lesson2.BackColor = Color.Green;
            }

            if (InternetNetworking_Activity.status > 0)
            {
                lesson5.BackColor = Color.Green;
            }

            if (digitalcitizen_activity.status > 0)
            {
                lesson6.BackColor = Color.Green;
            }
        }

        private void lesson1_Click(object sender, EventArgs e)
        {
            Algorithms lesson1 = new Algorithms();

            lesson1.Owner = this;

            lesson1.StartPosition = FormStartPosition.Manual;

            lesson1.Location = this.Location;

            lesson1.Show();

            this.Hide();
        }

        private void lesson2_Click(object sender, EventArgs e)
        {
            Lesson2 lesson2 = new Lesson2();

            lesson2.Owner = this;

            lesson2.StartPosition = FormStartPosition.Manual;

            lesson2.Location = this.Location;

            lesson2.Show();

            this.Hide();
        }

        

        

        private void lesson5_Click(object sender, EventArgs e)
        {
            InternetNetworking lesson5 = new InternetNetworking();

            lesson5.Owner = this;

            lesson5.StartPosition = FormStartPosition.Manual;

            lesson5.Location = this.Location;

            lesson5.Show();

            this.Hide();
        }

        private void lesson6_Click(object sender, EventArgs e)
        {
            DigitalCitizenship lesson6 = new DigitalCitizenship();

            lesson6.Owner = this;

            lesson6.StartPosition = FormStartPosition.Manual;

            lesson6.Location = this.Location;

            lesson6.Show();

            this.Hide();
        }
    }
}

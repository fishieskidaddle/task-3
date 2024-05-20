using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3__latest_
{
    public partial class InternetNetworking : Form
    {
        public InternetNetworking()
        {
            InitializeComponent();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Lesson_Select lesson_select = new Lesson_Select();

            lesson_select.Owner = this;

            lesson_select.StartPosition = FormStartPosition.Manual;

            lesson_select.Location = this.Location;

            lesson_select.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InternetNetworking_Activity internet_activity = new InternetNetworking_Activity();

            internet_activity.Owner = this;

            internet_activity.StartPosition = FormStartPosition.Manual;

            internet_activity.Location = this.Location;

            internet_activity.Show();

            this.Hide();
        }
    }
}

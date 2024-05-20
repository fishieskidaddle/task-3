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
    public partial class Algorithms : Form
    {
        public Algorithms()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Algorithm_Activity algorithm_activity = new Algorithm_Activity();

            algorithm_activity.Owner = this;

            algorithm_activity.StartPosition = FormStartPosition.Manual;

            algorithm_activity.Location = this.Location;

            algorithm_activity.Show();

            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

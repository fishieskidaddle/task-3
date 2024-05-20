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
    public partial class Lesson2 : Form
    {
        public Lesson2()
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

        private void content_heading_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Programming_Activity programming_Activity = new Programming_Activity();

            programming_Activity.Owner = this;

            programming_Activity.StartPosition = FormStartPosition.Manual;

            programming_Activity.Location = this.Location;

            programming_Activity.Show();

            this.Hide();
        }
    }
}

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
    public partial class DigitalCitizenship : Form
    {
        public DigitalCitizenship()
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
            digitalcitizen_activity digitalcitizen_Activity = new digitalcitizen_activity();

            digitalcitizen_Activity.Owner = this;

            digitalcitizen_Activity.StartPosition = FormStartPosition.Manual;

            digitalcitizen_Activity.Location = this.Location;

            digitalcitizen_Activity.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

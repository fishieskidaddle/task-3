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
    public partial class digitalcitizen_activity : Form
    {
        public static int scenario = 0;
        public static int status = 0;
        public digitalcitizen_activity()
        {
            InitializeComponent();
        }

        private void digitalcitizen_activity_Load(object sender, EventArgs e)
        {
            
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (((textBox2.Text.Contains("Rights")) && (textBox2.Text.Contains("Respect")) && (textBox2.Text.Contains("Responsibility"))) && scenario == 1)
            {
                status++;
                completion.Text = "Good Job!";
                completion.BackColor = Color.Green;
            }
            else
            {
                completion.Text = "Keep trying";
                completion.BackColor = Color.Yellow;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.Yellow;
            if (((textBox2.Text.Contains("Rights")) && (textBox2.Text.Contains("Respect")) && (textBox2.Text.Contains("Responsibility"))) && scenario == 1)
            {
                status++;
                completion.Text = "Good Job!";
                completion.BackColor = Color.Green;
            }
            else
            {
                completion.Text = "Keep trying";
                completion.BackColor = Color.Yellow;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Yellow;
            if (((textBox2.Text.Contains("Rights")) && (textBox2.Text.Contains("Respect")) && (textBox2.Text.Contains("Responsibility"))) && scenario == 1)
            {
                status++;
                completion.Text = "Good Job!";
                completion.BackColor = Color.Green;
            }
            else
            {
                completion.Text = "Keep trying";
                completion.BackColor = Color.Yellow;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.BackColor = Color.Yellow;
            if (((textBox2.Text.Contains("Rights")) && (textBox2.Text.Contains("Respect")) && (textBox2.Text.Contains("Responsibility"))) && scenario == 1)
            {
                status++;
                completion.Text = "Good Job!";
                completion.BackColor = Color.Green;
            }
            else
            {
                completion.Text = "Keep trying";
                completion.BackColor = Color.Yellow;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            scenario = 1;
            label4.BackColor = Color.Green;
            if (((textBox2.Text.Contains("Rights")) && (textBox2.Text.Contains("Respect")) && (textBox2.Text.Contains("Responsibility"))) && scenario == 1)
            {
                status++;
                completion.Text = "Good Job!";
                completion.BackColor = Color.Green;
            }
            else
            {
                completion.Text = "Keep trying";
                completion.BackColor = Color.Yellow;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

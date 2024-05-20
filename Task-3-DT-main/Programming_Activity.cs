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
    public partial class Programming_Activity : Form
    {
        public static int status = 0;
        public Programming_Activity()
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

        private void Programming_Activity_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            
            if (textBox3.Text.Contains("print(\"Hello World!\")") && ((textBox1.Text.Contains("instructions")) || (textBox1.Text.Contains("teaching"))) && ((textBox2.Text.Contains("Scratch")) && (textBox2.Text.Contains("Java")) && (textBox2.Text.Contains("Python")) && (textBox2.Text.Contains("C++"))))

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains("print(\"Hello World!\")") && ((textBox1.Text.Contains("instructions") || (textBox1.Text.Contains("teaching")))) && ((textBox2.Text.Contains("Scratch")) && (textBox2.Text.Contains("Java")) && (textBox2.Text.Contains("Python")) && (textBox2.Text.Contains("C++"))))

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains("print(\"Hello World!\")") && ((textBox1.Text.Contains("instructions") || (textBox1.Text.Contains("teaching")))) && ((textBox2.Text.Contains("Scratch")) && (textBox2.Text.Contains("Java")) && (textBox2.Text.Contains("Python")) && (textBox2.Text.Contains("C++"))))

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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

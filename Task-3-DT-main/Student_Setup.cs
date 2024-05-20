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
    public partial class Student_Setup : Form
    {
        public static string studentname = "";
        public static List<String> emoji = new List<string>();
        public static int emojiValue = 0;

        
        public Student_Setup()
        {
            InitializeComponent();
            
            using (StreamReader sr = new StreamReader("C:/Users/abdul/Downloads/emoji.csv"))

            {

                string line;



                while ((line = sr.ReadLine()) != null)

                {

                    emoji.Add(line);

                }





            }
        }

        private void Student_Setup_Load(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            int value = rand.Next(emoji.Count());
            emojiValue = value;
            lblEmoji.Text = emoji[value];
        }

        private void next_Click(object sender, EventArgs e)
        {
            Lesson_Select lesson_select = new Lesson_Select();

            lesson_select.Owner = this;

            lesson_select.StartPosition = FormStartPosition.Manual;

            lesson_select.Location = this.Location;

            lesson_select.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            studentname = textBox1.Text;
        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }
    }
}

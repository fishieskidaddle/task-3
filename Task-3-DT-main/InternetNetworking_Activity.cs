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
    
    public partial class InternetNetworking_Activity : Form
    {
        public static int status = 0;
        //Size holds how big our table is, x y holds our player position 

        int size = 6;

        int x = 0;

        int y = 3;



        //Generating a 2D array of picture boxes

        PictureBox[,] pictures = new PictureBox[6, 6];



        //Picture resources to simplify use later

        string picCheck = Directory.GetCurrentDirectory() + "/images/network.png";

        string picHand = Directory.GetCurrentDirectory() + "/images/data.jpg";
        public InternetNetworking_Activity()
        {
            InitializeComponent();


            //Loop for rows

            for (int i = 0; i < size; i++)

            {

                //Loop for columns

                for (int j = 0; j < size; j++)

                {

                    //Set up our picturebox to have a check mark

                    pictures[i, j] = new PictureBox();

                    pictures[i, j].Image = Image.FromFile(picCheck);

                    pictures[i, j].SizeMode = PictureBoxSizeMode.StretchImage;



                    //Add the picturebox to our table

                    table.Controls.Add(pictures[i, j]);

                }

            }

            //Starting position of our hand

            pictures[y, x].Image = Image.FromFile(picHand);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void InternetNetworking_Activity_KeyDown(object sender, KeyEventArgs e)
        {
            //Check if it's a key right

            if (e.KeyCode == Keys.Right)

            {

                //Check if we can move there, we need to be at size - 1 to move (e.g 2 so we can go to the max size of 3)

                if (x < size - 1)

                {

                    //Set our old position to be a check

                    pictures[y, x].Image = Image.FromFile(picCheck);



                    //Increment our position then set it to a hand

                    x++;

                    pictures[y, x].Image = Image.FromFile(picHand);
                    if ((y == 3 || y == 2) && x == 5)
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

            }



            //Check all the other things similarly

            if (e.KeyCode == Keys.Left)

            {

                if (x > 0)

                {

                    pictures[y, x].Image = Image.FromFile(picCheck);

                    x--;

                    pictures[y, x].Image = Image.FromFile(picHand);
                    if ((y == 3 || y == 2) && x == 5)
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

            }



            if (e.KeyCode == Keys.Up)

            {

                if (y > 0)

                {

                    pictures[y, x].Image = Image.FromFile(picCheck);

                    y--;

                    pictures[y, x].Image = Image.FromFile(picHand);
                    if ((y == 3 || y == 2) && x == 5)
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

            }



            if (e.KeyCode == Keys.Down)

            {

                if (y < size - 1)

                {

                    pictures[y, x].Image = Image.FromFile(picCheck);

                    y++;

                    pictures[y, x].Image = Image.FromFile(picHand);
                    
                    if ((y == 3 || y == 2) && x == 5)
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

            }
        }

        private void InternetNetworking_Activity_Load(object sender, EventArgs e)
        {
            
        }
    }
}

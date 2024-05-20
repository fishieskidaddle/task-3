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
    public partial class Algorithm_Activity : Form
    {
        public static int status = 0;
        PictureBox[] pictures = new PictureBox[4];
        List<String> blocks = new List<string>();
        public Algorithm_Activity()
        {
            InitializeComponent();


            //The 4 here is dependant on how many rows in the table            

            for (int i = 0; i < 4; i++)

            {

                pictures[i] = new PictureBox();

                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;

                pictures[i].AllowDrop = true;

                pictures[i].DragEnter += new DragEventHandler(pictures_DragEnter);

                pictures[i].DragDrop += new DragEventHandler(pictures_DragDrop);

                tblCodeArea.Controls.Add(pictures[i]);

            }

        }
        private void pictures_DragDrop(object sender, DragEventArgs e)

        {

            PictureBox picture = sender as PictureBox;



            picture.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            picture.Tag = e.Data.GetData(TextDataFormat.Text.ToString());



            lblList.Text = "";

            blocks.Clear();



            for (int i = 0; i < 4; i++)

            {

                blocks.Add(String.Format("{0}", pictures[i].Tag));
                if (blocks[i].Contains("Bread"))

                {

                    lblList.Text += "Take out 2 slices of Bread\n" ;
                    if (textBox1.Text.Contains("steps") || (textBox1.Text.Contains("instructions")))
                    {
                        if (lblList.Text.Contains("Take out 2 slices of Bread\nSpread Peanut Butter on Bread\nSpread Jam on Bread\nPut the slices together\n"))
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
                    else

                    {
                        completion.Text = "Keep trying";
                        completion.BackColor = Color.Yellow;
                    }


                }
                else if (blocks[i].Contains("Peanut"))

                {

                    lblList.Text += "Spread Peanut Butter on Bread\n" ;
                    if (textBox1.Text.Contains("steps") || (textBox1.Text.Contains("instructions")))
                    {
                        if (lblList.Text.Contains("Take out 2 slices of Bread\nSpread Peanut Butter on Bread\nSpread Jam on Bread\nPut the slices together\n"))
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
                    else

                    {
                        completion.Text = "Keep trying";
                        completion.BackColor = Color.Yellow;
                    }

                }
               else  if (blocks[i].Contains("Sandwhich"))

                {

                    lblList.Text += "Put the slices together\n" ;
                    if (textBox1.Text.Contains("steps") || (textBox1.Text.Contains("instructions")))
                    {
                        if (lblList.Text.Contains("Take out 2 slices of Bread\nSpread Peanut Butter on Bread\nSpread Jam on Bread\nPut the slices together\n"))
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
                    else

                    {
                        completion.Text = "Keep trying";
                        completion.BackColor = Color.Yellow;
                    }

                }
                else if (blocks[i].Contains("Jam"))

                {

                    lblList.Text += "Spread Jam on Bread\n" ;
                    if (textBox1.Text.Contains("steps") || (textBox1.Text.Contains("instructions")))
                    {
                        if (lblList.Text.Contains("Take out 2 slices of Bread\nSpread Peanut Butter on Bread\nSpread Jam on Bread\nPut the slices together\n"))
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
                    else

                    {
                        completion.Text = "Keep trying";
                        completion.BackColor = Color.Yellow;
                    }

                }

            }

        }
        private void pictures_DragEnter(object sender, DragEventArgs e)

        {

            e.Effect = e.AllowedEffect;

        }
        private void codeBlock_MouseDown(object sender, MouseEventArgs e)

        {
            
                
            
            //Defines sender as a picturebox so we can use it

            PictureBox codeBlock = sender as PictureBox;


            //Define a data object and store the image and the tag

            DataObject dragImage = new DataObject();

            dragImage.SetData(DataFormats.Bitmap, true, codeBlock.Image);

            dragImage.SetData(DataFormats.Text, true, codeBlock.Tag);



            //Copies the data object as we drag

            DoDragDrop(dragImage, DragDropEffects.Copy);

        }

        private void pbWhenClicked_Click(object sender, EventArgs e)
        {

        }

        private void lblList_Click(object sender, EventArgs e)
        {

        }

        private void Algorithm_Activity_Load(object sender, EventArgs e)
        {
            pbJam.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPeanut.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSandwhich.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBread.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("steps") || (textBox1.Text.Contains("instructions")))
            {
                if (lblList.Text.Contains("Take out 2 slices of Bread\nSpread Peanut Butter on Bread\nSpread Jam on Bread\nPut the slices together\n"))
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
            else 
            
            {
                completion.Text = "Keep trying";
                completion.BackColor = Color.Yellow;
            }
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

        private void pbSandwhich_Click(object sender, EventArgs e)
        {

        }
    }
        
    
}

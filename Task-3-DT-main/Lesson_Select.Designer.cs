namespace Task_3__latest_
{
    partial class Lesson_Select
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.content_heading = new System.Windows.Forms.Label();
            this.lesson1 = new System.Windows.Forms.Label();
            this.lesson2 = new System.Windows.Forms.Label();
            this.lesson6 = new System.Windows.Forms.Label();
            this.lesson5 = new System.Windows.Forms.Label();
            this.home_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            this.SuspendLayout();
            // 
            // content_heading
            // 
            this.content_heading.AutoSize = true;
            this.content_heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.content_heading.Font = new System.Drawing.Font("Tw Cen MT Condensed", 50F, System.Drawing.FontStyle.Bold);
            this.content_heading.Location = new System.Drawing.Point(442, 0);
            this.content_heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.content_heading.Name = "content_heading";
            this.content_heading.Size = new System.Drawing.Size(327, 117);
            this.content_heading.TabIndex = 4;
            this.content_heading.Text = "Content";
            // 
            // lesson1
            // 
            this.lesson1.AutoSize = true;
            this.lesson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lesson1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 25F, System.Drawing.FontStyle.Bold);
            this.lesson1.Location = new System.Drawing.Point(92, 252);
            this.lesson1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lesson1.Name = "lesson1";
            this.lesson1.Size = new System.Drawing.Size(262, 58);
            this.lesson1.TabIndex = 5;
            this.lesson1.Text = "1. Algorithms";
            this.lesson1.Click += new System.EventHandler(this.lesson1_Click);
            // 
            // lesson2
            // 
            this.lesson2.AutoSize = true;
            this.lesson2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lesson2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 25F, System.Drawing.FontStyle.Bold);
            this.lesson2.Location = new System.Drawing.Point(92, 394);
            this.lesson2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lesson2.Name = "lesson2";
            this.lesson2.Size = new System.Drawing.Size(306, 58);
            this.lesson2.TabIndex = 6;
            this.lesson2.Text = "2. Programming";
            this.lesson2.Click += new System.EventHandler(this.lesson2_Click);
            // 
            // lesson6
            // 
            this.lesson6.AutoSize = true;
            this.lesson6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lesson6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 25F, System.Drawing.FontStyle.Bold);
            this.lesson6.Location = new System.Drawing.Point(778, 395);
            this.lesson6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lesson6.Name = "lesson6";
            this.lesson6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lesson6.Size = new System.Drawing.Size(386, 58);
            this.lesson6.TabIndex = 8;
            this.lesson6.Text = "4. Digital Citizenship";
            this.lesson6.Click += new System.EventHandler(this.lesson6_Click);
            // 
            // lesson5
            // 
            this.lesson5.AutoSize = true;
            this.lesson5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lesson5.Font = new System.Drawing.Font("Tw Cen MT Condensed", 25F, System.Drawing.FontStyle.Bold);
            this.lesson5.Location = new System.Drawing.Point(717, 252);
            this.lesson5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lesson5.Name = "lesson5";
            this.lesson5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lesson5.Size = new System.Drawing.Size(453, 58);
            this.lesson5.TabIndex = 9;
            this.lesson5.Text = "3. Internet and Network";
            this.lesson5.Click += new System.EventHandler(this.lesson5_Click);
            // 
            // home_button
            // 
            this.home_button.BackgroundImage = global::Task_3__latest_.Properties.Resources.home_house_silhouette_icon_building__public_domain_pictures__20;
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_button.Location = new System.Drawing.Point(18, 18);
            this.home_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(72, 69);
            this.home_button.TabIndex = 11;
            this.home_button.TabStop = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // Lesson_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.lesson5);
            this.Controls.Add(this.lesson6);
            this.Controls.Add(this.lesson2);
            this.Controls.Add(this.lesson1);
            this.Controls.Add(this.content_heading);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lesson_Select";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Lesson_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label content_heading;
        private System.Windows.Forms.Label lesson1;
        private System.Windows.Forms.Label lesson2;
        private System.Windows.Forms.Label lesson6;
        private System.Windows.Forms.Label lesson5;
        private System.Windows.Forms.PictureBox home_button;
    }
}
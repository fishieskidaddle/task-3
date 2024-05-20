namespace Task_3__latest_
{
    partial class Student_Setup
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
            this.lblEmoji = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.subheading = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmoji
            // 
            this.lblEmoji.AutoSize = true;
            this.lblEmoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.5F);
            this.lblEmoji.Location = new System.Drawing.Point(388, 317);
            this.lblEmoji.Name = "lblEmoji";
            this.lblEmoji.Size = new System.Drawing.Size(0, 42);
            this.lblEmoji.TabIndex = 0;
            // 
            // btnClick
            // 
            this.btnClick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClick.Font = new System.Drawing.Font("Tw Cen MT Condensed", 25F, System.Drawing.FontStyle.Bold);
            this.btnClick.Location = new System.Drawing.Point(341, 382);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(151, 43);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "Randomise!";
            this.btnClick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.welcome_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcome_label.Font = new System.Drawing.Font("Tw Cen MT Condensed", 35F, System.Drawing.FontStyle.Bold);
            this.welcome_label.Location = new System.Drawing.Point(217, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(405, 60);
            this.welcome_label.TabIndex = 8;
            this.welcome_label.Text = "Welcome new student!";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // subheading
            // 
            this.subheading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subheading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.subheading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subheading.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.5F, System.Drawing.FontStyle.Bold);
            this.subheading.Location = new System.Drawing.Point(250, 83);
            this.subheading.Name = "subheading";
            this.subheading.Size = new System.Drawing.Size(339, 32);
            this.subheading.TabIndex = 9;
            this.subheading.Text = "Type your name, then choose an avatar.";
            this.subheading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(289, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 30);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.next.Font = new System.Drawing.Font("Tw Cen MT Condensed", 25F, System.Drawing.FontStyle.Bold);
            this.next.Location = new System.Drawing.Point(712, 400);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(76, 41);
            this.next.TabIndex = 11;
            this.next.Text = "Next";
            this.next.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Student_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.subheading);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblEmoji);
            this.Name = "Student_Setup";
            this.Text = "Student_Setup";
            this.Load += new System.EventHandler(this.Student_Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmoji;
        private System.Windows.Forms.Label btnClick;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label subheading;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label next;
    }
}
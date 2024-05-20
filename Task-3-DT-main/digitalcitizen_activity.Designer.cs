namespace Task_3__latest_
{
    partial class digitalcitizen_activity
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
            this.home_button = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.completion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            this.SuspendLayout();
            // 
            // home_button
            // 
            this.home_button.BackgroundImage = global::Task_3__latest_.Properties.Resources.home_house_silhouette_icon_building__public_domain_pictures__20;
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_button.Location = new System.Drawing.Point(740, 12);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(48, 45);
            this.home_button.TabIndex = 13;
            this.home_button.TabStop = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 56);
            this.label1.TabIndex = 20;
            this.label1.Text = "What are the 3 R\'s?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 102);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // completion
            // 
            this.completion.AutoSize = true;
            this.completion.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.completion.Location = new System.Drawing.Point(24, 243);
            this.completion.Name = "completion";
            this.completion.Size = new System.Drawing.Size(0, 25);
            this.completion.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label2.Location = new System.Drawing.Point(318, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 91);
            this.label2.TabIndex = 24;
            this.label2.Text = "You receive an embarrassing photo of your friend from someone else. What is the m" +
    "ost responsible way to handle this situation? Click your answer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label4.Location = new System.Drawing.Point(268, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 85);
            this.label4.TabIndex = 28;
            this.label4.Text = "a) Delete the photo and don\'t share it further";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label3.Location = new System.Drawing.Point(268, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 85);
            this.label3.TabIndex = 30;
            this.label3.Text = "c) Post the photo publicly to get revenge";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label5.Location = new System.Drawing.Point(545, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 85);
            this.label5.TabIndex = 32;
            this.label5.Text = "d) Threaten the sender unless they delete it";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label6.Location = new System.Drawing.Point(545, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 85);
            this.label6.TabIndex = 34;
            this.label6.Text = "b) Send the photo to other friends";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // digitalcitizen_activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.completion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.home_button);
            this.Name = "digitalcitizen_activity";
            this.Text = "digitalcitizen_activity";
            this.Load += new System.EventHandler(this.digitalcitizen_activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox home_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label completion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
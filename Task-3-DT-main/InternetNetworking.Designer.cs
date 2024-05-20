namespace Task_3__latest_
{
    partial class InternetNetworking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetNetworking));
            this.home_button = new System.Windows.Forms.PictureBox();
            this.content_heading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            this.SuspendLayout();
            // 
            // home_button
            // 
            this.home_button.BackgroundImage = global::Task_3__latest_.Properties.Resources.home_house_silhouette_icon_building__public_domain_pictures__20;
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_button.Location = new System.Drawing.Point(12, 12);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(48, 45);
            this.home_button.TabIndex = 12;
            this.home_button.TabStop = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // content_heading
            // 
            this.content_heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.content_heading.Font = new System.Drawing.Font("Tw Cen MT Condensed", 30F, System.Drawing.FontStyle.Bold);
            this.content_heading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.content_heading.Location = new System.Drawing.Point(12, 9);
            this.content_heading.Name = "content_heading";
            this.content_heading.Size = new System.Drawing.Size(776, 432);
            this.content_heading.TabIndex = 14;
            this.content_heading.Text = "Internet and Networking";
            this.content_heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(776, 296);
            this.label3.TabIndex = 18;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.button1.Location = new System.Drawing.Point(716, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 46);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lets try a quick  activity! ➤";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InternetNetworking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.content_heading);
            this.Name = "InternetNetworking";
            this.Text = "esson5";
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox home_button;
        private System.Windows.Forms.Label content_heading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
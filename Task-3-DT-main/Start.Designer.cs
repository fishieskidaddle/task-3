namespace Task_3__latest_
{
    partial class Start
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.welcome_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcome_label.Font = new System.Drawing.Font("Tw Cen MT Condensed", 45F, System.Drawing.FontStyle.Bold);
            this.welcome_label.Location = new System.Drawing.Point(145, 37);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(504, 72);
            this.welcome_label.TabIndex = 5;
            this.welcome_label.Text = "Welcome to EDUSpark!";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcome_label.UseMnemonic = false;
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.start_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.start_button.Font = new System.Drawing.Font("Tw Cen MT Condensed", 35F, System.Drawing.FontStyle.Bold);
            this.start_button.Location = new System.Drawing.Point(344, 794);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(109, 57);
            this.start_button.TabIndex = 6;
            this.start_button.Text = "Start";
            this.start_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.start_button.UseMnemonic = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click_1);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settings.Font = new System.Drawing.Font("Tw Cen MT Condensed", 35F, System.Drawing.FontStyle.Bold);
            this.settings.Location = new System.Drawing.Point(12, 794);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(161, 57);
            this.settings.TabIndex = 7;
            this.settings.Text = "Settings";
            this.settings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.settings.UseMnemonic = false;
            this.settings.Visible = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Start
            // 
            this.BackgroundImage = global::Task_3__latest_.Properties.Resources.MV5BMTU2NTYxODcwMF5BMl5BanBnXkFtZTcwNDk1NDY0Nw__1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 870);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.welcome_label);
            this.Name = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        
        
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label start_button;
        private System.Windows.Forms.Label settings;
    }
}


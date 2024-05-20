namespace Task_3__latest_
{
    partial class Algorithm_Activity
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
            this.tblCodeArea = new System.Windows.Forms.TableLayoutPanel();
            this.lblList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSandwhich = new System.Windows.Forms.PictureBox();
            this.pbPeanut = new System.Windows.Forms.PictureBox();
            this.pbJam = new System.Windows.Forms.PictureBox();
            this.pbBread = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.completion = new System.Windows.Forms.Label();
            this.home_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSandwhich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeanut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCodeArea
            // 
            this.tblCodeArea.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tblCodeArea.ColumnCount = 1;
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCodeArea.Location = new System.Drawing.Point(18, 195);
            this.tblCodeArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblCodeArea.Name = "tblCodeArea";
            this.tblCodeArea.RowCount = 4;
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.Size = new System.Drawing.Size(196, 460);
            this.tblCodeArea.TabIndex = 0;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.lblList.Location = new System.Drawing.Point(524, 169);
            this.lblList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(0, 37);
            this.lblList.TabIndex = 2;
            this.lblList.Click += new System.EventHandler(this.lblList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label1.Location = new System.Drawing.Point(465, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Steps:";
            // 
            // pbSandwhich
            // 
            this.pbSandwhich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSandwhich.Image = global::Task_3__latest_.Properties.Resources.pbandj_sandwhcih;
            this.pbSandwhich.Location = new System.Drawing.Point(268, 360);
            this.pbSandwhich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSandwhich.Name = "pbSandwhich";
            this.pbSandwhich.Size = new System.Drawing.Size(195, 92);
            this.pbSandwhich.TabIndex = 6;
            this.pbSandwhich.TabStop = false;
            this.pbSandwhich.Tag = "Sandwhich";
            this.pbSandwhich.Click += new System.EventHandler(this.pbSandwhich_Click);
            this.pbSandwhich.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbPeanut
            // 
            this.pbPeanut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPeanut.Image = global::Task_3__latest_.Properties.Resources.peanutbutter;
            this.pbPeanut.Location = new System.Drawing.Point(268, 258);
            this.pbPeanut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPeanut.Name = "pbPeanut";
            this.pbPeanut.Size = new System.Drawing.Size(195, 92);
            this.pbPeanut.TabIndex = 5;
            this.pbPeanut.TabStop = false;
            this.pbPeanut.Tag = "Peanut";
            this.pbPeanut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbJam
            // 
            this.pbJam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbJam.Image = global::Task_3__latest_.Properties.Resources.jambread1;
            this.pbJam.Location = new System.Drawing.Point(268, 563);
            this.pbJam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbJam.Name = "pbJam";
            this.pbJam.Size = new System.Drawing.Size(195, 92);
            this.pbJam.TabIndex = 3;
            this.pbJam.TabStop = false;
            this.pbJam.Tag = "Jam";
            this.pbJam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbBread
            // 
            this.pbBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBread.Image = global::Task_3__latest_.Properties.Resources.bread;
            this.pbBread.Location = new System.Drawing.Point(268, 462);
            this.pbBread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBread.Name = "pbBread";
            this.pbBread.Size = new System.Drawing.Size(195, 92);
            this.pbBread.TabIndex = 1;
            this.pbBread.TabStop = false;
            this.pbBread.Tag = "Bread";
            this.pbBread.Click += new System.EventHandler(this.pbWhenClicked_Click);
            this.pbBread.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 131);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arrange the following steps in order to make a sandwhich:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.label3.Location = new System.Drawing.Point(524, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 185);
            this.label3.TabIndex = 8;
            this.label3.Text = "Now answer the following question: What is an algorithm?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 511);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 164);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // completion
            // 
            this.completion.AutoSize = true;
            this.completion.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.completion.Location = new System.Drawing.Point(998, 100);
            this.completion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.completion.Name = "completion";
            this.completion.Size = new System.Drawing.Size(0, 37);
            this.completion.TabIndex = 10;
            // 
            // home_button
            // 
            this.home_button.BackgroundImage = global::Task_3__latest_.Properties.Resources.home_house_silhouette_icon_building__public_domain_pictures__20;
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_button.Location = new System.Drawing.Point(1110, 18);
            this.home_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(72, 69);
            this.home_button.TabIndex = 13;
            this.home_button.TabStop = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // Algorithm_Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.completion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSandwhich);
            this.Controls.Add(this.pbPeanut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbJam);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.pbBread);
            this.Controls.Add(this.tblCodeArea);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Algorithm_Activity";
            this.Text = "Algorithm_Actvity";
            this.Load += new System.EventHandler(this.Algorithm_Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSandwhich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeanut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCodeArea;
        private System.Windows.Forms.PictureBox pbBread;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.PictureBox pbJam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSandwhich;
        private System.Windows.Forms.PictureBox pbPeanut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label completion;
        private System.Windows.Forms.PictureBox home_button;
    }
}
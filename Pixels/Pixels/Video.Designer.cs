namespace Pixels
{
    partial class Video
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
            lbl_Video = new Label();
            lbl_Image = new Label();
            lbl_documentation = new Label();
            lbl_Camera = new Label();
            lbl_Home = new Label();
            pnl_Documentation = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            ltv_history = new ListView();
            panel2 = new Panel();
            panel1 = new Panel();
            ltv_filters = new ListView();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pnl_Documentation.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Video
            // 
            lbl_Video.Cursor = Cursors.Hand;
            lbl_Video.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Video.ForeColor = SystemColors.ButtonFace;
            lbl_Video.Location = new Point(615, 905);
            lbl_Video.Margin = new Padding(4, 0, 4, 0);
            lbl_Video.Name = "lbl_Video";
            lbl_Video.Size = new Size(158, 66);
            lbl_Video.TabIndex = 18;
            lbl_Video.Text = "Video";
            lbl_Video.Click += lbl_Video_Click;
            // 
            // lbl_Image
            // 
            lbl_Image.Cursor = Cursors.Hand;
            lbl_Image.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Image.Location = new Point(439, 905);
            lbl_Image.Margin = new Padding(4, 0, 4, 0);
            lbl_Image.Name = "lbl_Image";
            lbl_Image.Size = new Size(191, 66);
            lbl_Image.TabIndex = 17;
            lbl_Image.Text = "Image";
            lbl_Image.Click += lbl_Image_Click;
            // 
            // lbl_documentation
            // 
            lbl_documentation.Cursor = Cursors.Hand;
            lbl_documentation.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_documentation.Location = new Point(795, 905);
            lbl_documentation.Margin = new Padding(4, 0, 4, 0);
            lbl_documentation.Name = "lbl_documentation";
            lbl_documentation.Size = new Size(358, 76);
            lbl_documentation.TabIndex = 16;
            lbl_documentation.Text = "Documentation";
            lbl_documentation.Click += lbl_documentation_Click;
            // 
            // lbl_Camera
            // 
            lbl_Camera.Cursor = Cursors.Hand;
            lbl_Camera.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Camera.Location = new Point(240, 905);
            lbl_Camera.Margin = new Padding(4, 0, 4, 0);
            lbl_Camera.Name = "lbl_Camera";
            lbl_Camera.Size = new Size(191, 66);
            lbl_Camera.TabIndex = 15;
            lbl_Camera.Text = "Camera";
            lbl_Camera.Click += lbl_Camera_Click;
            // 
            // lbl_Home
            // 
            lbl_Home.Cursor = Cursors.Hand;
            lbl_Home.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Home.Location = new Point(65, 905);
            lbl_Home.Margin = new Padding(4, 0, 4, 0);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(191, 66);
            lbl_Home.TabIndex = 14;
            lbl_Home.Text = "Home";
            lbl_Home.Click += Home_Click;
            // 
            // pnl_Documentation
            // 
            pnl_Documentation.BackColor = SystemColors.ActiveCaption;
            pnl_Documentation.Controls.Add(button1);
            pnl_Documentation.Controls.Add(panel5);
            pnl_Documentation.Controls.Add(panel4);
            pnl_Documentation.Controls.Add(panel3);
            pnl_Documentation.Controls.Add(label2);
            pnl_Documentation.Controls.Add(ltv_history);
            pnl_Documentation.Controls.Add(panel2);
            pnl_Documentation.Controls.Add(panel1);
            pnl_Documentation.Controls.Add(pictureBox1);
            pnl_Documentation.Controls.Add(label4);
            pnl_Documentation.Controls.Add(label3);
            pnl_Documentation.Controls.Add(label1);
            pnl_Documentation.Location = new Point(44, 28);
            pnl_Documentation.Margin = new Padding(4);
            pnl_Documentation.Name = "pnl_Documentation";
            pnl_Documentation.Size = new Size(1475, 830);
            pnl_Documentation.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(526, 484);
            button1.Margin = new Padding(4, 4, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 10;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Location = new Point(1114, 565);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(341, 240);
            panel5.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Location = new Point(751, 565);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(341, 240);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Location = new Point(388, 565);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 240);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(675, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 45);
            label2.TabIndex = 8;
            label2.Text = "History";
            // 
            // ltv_history
            // 
            ltv_history.BackColor = SystemColors.ActiveCaption;
            ltv_history.Location = new Point(675, 78);
            ltv_history.Margin = new Padding(4);
            ltv_history.Name = "ltv_history";
            ltv_history.Size = new Size(279, 398);
            ltv_history.TabIndex = 7;
            ltv_history.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(21, 565);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 240);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(ltv_filters);
            panel1.Location = new Point(1036, 78);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 399);
            panel1.TabIndex = 5;
            // 
            // ltv_filters
            // 
            ltv_filters.BackColor = SystemColors.ActiveCaption;
            ltv_filters.Location = new Point(16, 21);
            ltv_filters.Margin = new Padding(4);
            ltv_filters.Name = "ltv_filters";
            ltv_filters.Size = new Size(383, 356);
            ltv_filters.TabIndex = 8;
            ltv_filters.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 78);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(622, 399);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(21, 499);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 45);
            label4.TabIndex = 3;
            label4.Text = "Histogram";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(1036, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 45);
            label3.TabIndex = 2;
            label3.Text = "Filters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(21, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 45);
            label1.TabIndex = 0;
            label1.Text = "Video";
            label1.Click += label1_Click;
            // 
            // Video
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1564, 1008);
            Controls.Add(lbl_Video);
            Controls.Add(lbl_Image);
            Controls.Add(lbl_documentation);
            Controls.Add(lbl_Camera);
            Controls.Add(lbl_Home);
            Controls.Add(pnl_Documentation);
            Margin = new Padding(4);
            Name = "Video";
            Text = "Video";
            Load += Video_Load;
            pnl_Documentation.ResumeLayout(false);
            pnl_Documentation.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Video;
        private Label lbl_Image;
        private Label lbl_documentation;
        private Label lbl_Camera;
        private Label lbl_Home;
        private Panel pnl_Documentation;
        private Button button1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private ListView ltv_history;
        private Panel panel2;
        private Panel panel1;
        private ListView ltv_filters;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}
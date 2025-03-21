namespace Pixels
{
    partial class Documentation
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
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            pnl_Documentation.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Video
            // 
            lbl_Video.Cursor = Cursors.Hand;
            lbl_Video.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Video.Location = new Point(615, 905);
            lbl_Video.Margin = new Padding(4, 0, 4, 0);
            lbl_Video.Name = "lbl_Video";
            lbl_Video.Size = new Size(158, 66);
            lbl_Video.TabIndex = 12;
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
            lbl_Image.TabIndex = 11;
            lbl_Image.Text = "Image";
            lbl_Image.Click += lbl_Image_Click;
            // 
            // lbl_documentation
            // 
            lbl_documentation.Cursor = Cursors.Hand;
            lbl_documentation.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_documentation.ForeColor = SystemColors.ButtonFace;
            lbl_documentation.Location = new Point(768, 905);
            lbl_documentation.Margin = new Padding(4, 0, 4, 0);
            lbl_documentation.Name = "lbl_documentation";
            lbl_documentation.Size = new Size(358, 76);
            lbl_documentation.TabIndex = 10;
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
            lbl_Camera.TabIndex = 9;
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
            lbl_Home.TabIndex = 8;
            lbl_Home.Text = "Home";
            lbl_Home.Click += Home_Click;
            // 
            // pnl_Documentation
            // 
            pnl_Documentation.BackColor = SystemColors.ActiveCaption;
            pnl_Documentation.Controls.Add(linkLabel1);
            pnl_Documentation.Controls.Add(label2);
            pnl_Documentation.Controls.Add(label1);
            pnl_Documentation.Location = new Point(44, 28);
            pnl_Documentation.Margin = new Padding(4);
            pnl_Documentation.Name = "pnl_Documentation";
            pnl_Documentation.Size = new Size(1475, 830);
            pnl_Documentation.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(50, 476);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(216, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Documentación completa";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 72);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(634, 355);
            label2.TabIndex = 1;
            label2.Text = "Anything you need when you need it ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Project Documentation ";
            // 
            // Documentation
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
            Name = "Documentation";
            Text = "Documentation";
            pnl_Documentation.ResumeLayout(false);
            pnl_Documentation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Video;
        private Label lbl_Image;
        private Label lbl_documentation;
        private Label lbl_Camera;
        private Label lbl_Home;
        private Panel pnl_Documentation;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
    }
}
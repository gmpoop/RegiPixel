namespace Pixels
{
    partial class ImageFilter
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
            flp_Filters = new FlowLayoutPanel();
            FilterValueTextBox = new TextBox();
            Apply = new Button();
            ValueName = new Label();
            bt_UploadImage = new Button();
            panel5 = new Panel();
            Hystogram_B = new PictureBox();
            panel4 = new Panel();
            Hystogram_R = new PictureBox();
            panel3 = new Panel();
            Hystogram_G = new PictureBox();
            panel2 = new Panel();
            Hystogram_RGB = new PictureBox();
            pb_ImageDisplay = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            bt_Download = new Button();
            pnl_Documentation.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hystogram_B).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hystogram_R).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hystogram_G).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hystogram_RGB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ImageDisplay).BeginInit();
            SuspendLayout();
            // 
            // lbl_Video
            // 
            lbl_Video.Cursor = Cursors.Hand;
            lbl_Video.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Video.Location = new Point(514, 724);
            lbl_Video.Name = "lbl_Video";
            lbl_Video.Size = new Size(126, 53);
            lbl_Video.TabIndex = 12;
            lbl_Video.Text = "Video";
            lbl_Video.Click += lbl_Video_Click;
            // 
            // lbl_Image
            // 
            lbl_Image.Cursor = Cursors.Hand;
            lbl_Image.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Image.ForeColor = SystemColors.ButtonFace;
            lbl_Image.Location = new Point(351, 724);
            lbl_Image.Name = "lbl_Image";
            lbl_Image.Size = new Size(136, 53);
            lbl_Image.TabIndex = 11;
            lbl_Image.Text = "Image";
            // 
            // lbl_documentation
            // 
            lbl_documentation.Cursor = Cursors.Hand;
            lbl_documentation.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_documentation.Location = new Point(636, 724);
            lbl_documentation.Name = "lbl_documentation";
            lbl_documentation.Size = new Size(286, 61);
            lbl_documentation.TabIndex = 10;
            lbl_documentation.Text = "Documentation";
            lbl_documentation.Click += lbl_documentation_Click;
            // 
            // lbl_Camera
            // 
            lbl_Camera.Cursor = Cursors.Hand;
            lbl_Camera.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Camera.Location = new Point(192, 724);
            lbl_Camera.Name = "lbl_Camera";
            lbl_Camera.Size = new Size(153, 53);
            lbl_Camera.TabIndex = 9;
            lbl_Camera.Text = "Camera";
            lbl_Camera.Click += lbl_Camera_Click;
            // 
            // lbl_Home
            // 
            lbl_Home.Cursor = Cursors.Hand;
            lbl_Home.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Home.Location = new Point(52, 724);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(153, 53);
            lbl_Home.TabIndex = 8;
            lbl_Home.Text = "Home";
            lbl_Home.Click += Home_Click;
            // 
            // pnl_Documentation
            // 
            pnl_Documentation.BackColor = SystemColors.ActiveCaption;
            pnl_Documentation.Controls.Add(bt_Download);
            pnl_Documentation.Controls.Add(flp_Filters);
            pnl_Documentation.Controls.Add(FilterValueTextBox);
            pnl_Documentation.Controls.Add(Apply);
            pnl_Documentation.Controls.Add(ValueName);
            pnl_Documentation.Controls.Add(bt_UploadImage);
            pnl_Documentation.Controls.Add(panel5);
            pnl_Documentation.Controls.Add(panel4);
            pnl_Documentation.Controls.Add(panel3);
            pnl_Documentation.Controls.Add(panel2);
            pnl_Documentation.Controls.Add(pb_ImageDisplay);
            pnl_Documentation.Controls.Add(label4);
            pnl_Documentation.Controls.Add(label3);
            pnl_Documentation.Controls.Add(label1);
            pnl_Documentation.Location = new Point(35, 22);
            pnl_Documentation.Name = "pnl_Documentation";
            pnl_Documentation.Size = new Size(1180, 664);
            pnl_Documentation.TabIndex = 7;
            pnl_Documentation.Paint += pnl_Documentation_Paint;
            // 
            // flp_Filters
            // 
            flp_Filters.AutoScroll = true;
            flp_Filters.Location = new Point(521, 184);
            flp_Filters.Name = "flp_Filters";
            flp_Filters.Size = new Size(640, 252);
            flp_Filters.TabIndex = 46;
            // 
            // FilterValueTextBox
            // 
            FilterValueTextBox.BackColor = SystemColors.ActiveCaption;
            FilterValueTextBox.BorderStyle = BorderStyle.None;
            FilterValueTextBox.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterValueTextBox.ForeColor = SystemColors.ControlText;
            FilterValueTextBox.Location = new Point(675, 99);
            FilterValueTextBox.Margin = new Padding(3, 4, 3, 4);
            FilterValueTextBox.Name = "FilterValueTextBox";
            FilterValueTextBox.PlaceholderText = "000";
            FilterValueTextBox.Size = new Size(150, 27);
            FilterValueTextBox.TabIndex = 44;
            FilterValueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Apply
            // 
            Apply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Apply.BackColor = SystemColors.ActiveCaption;
            Apply.FlatAppearance.BorderSize = 0;
            Apply.FlatStyle = FlatStyle.Popup;
            Apply.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Apply.ForeColor = SystemColors.ControlText;
            Apply.ImageAlign = ContentAlignment.MiddleRight;
            Apply.Location = new Point(521, 140);
            Apply.Margin = new Padding(3, 4, 3, 4);
            Apply.Name = "Apply";
            Apply.Size = new Size(304, 37);
            Apply.TabIndex = 45;
            Apply.Text = "Apply";
            Apply.UseVisualStyleBackColor = false;
            // 
            // ValueName
            // 
            ValueName.AutoSize = true;
            ValueName.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValueName.ForeColor = SystemColors.ControlText;
            ValueName.Location = new Point(533, 102);
            ValueName.Name = "ValueName";
            ValueName.Size = new Size(121, 25);
            ValueName.TabIndex = 43;
            ValueName.Text = "Value Name:";
            ValueName.Click += ValueName_Click;
            // 
            // bt_UploadImage
            // 
            bt_UploadImage.BackColor = SystemColors.ActiveBorder;
            bt_UploadImage.FlatStyle = FlatStyle.Flat;
            bt_UploadImage.Location = new Point(421, 387);
            bt_UploadImage.Margin = new Padding(3, 3, 5, 5);
            bt_UploadImage.Name = "bt_UploadImage";
            bt_UploadImage.Size = new Size(94, 29);
            bt_UploadImage.TabIndex = 10;
            bt_UploadImage.Text = "Upload";
            bt_UploadImage.UseVisualStyleBackColor = false;
            bt_UploadImage.Click += bt_UploadImage_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(Hystogram_B);
            panel5.Location = new Point(891, 452);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 192);
            panel5.TabIndex = 9;
            // 
            // Hystogram_B
            // 
            Hystogram_B.Location = new Point(0, 0);
            Hystogram_B.Margin = new Padding(3, 4, 3, 4);
            Hystogram_B.Name = "Hystogram_B";
            Hystogram_B.Size = new Size(270, 192);
            Hystogram_B.TabIndex = 38;
            Hystogram_B.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(Hystogram_R);
            panel4.Location = new Point(601, 452);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 192);
            panel4.TabIndex = 8;
            // 
            // Hystogram_R
            // 
            Hystogram_R.Location = new Point(0, 0);
            Hystogram_R.Margin = new Padding(3, 4, 3, 4);
            Hystogram_R.Name = "Hystogram_R";
            Hystogram_R.Size = new Size(270, 192);
            Hystogram_R.TabIndex = 36;
            Hystogram_R.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(Hystogram_G);
            panel3.Location = new Point(310, 452);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 192);
            panel3.TabIndex = 7;
            // 
            // Hystogram_G
            // 
            Hystogram_G.Location = new Point(0, 0);
            Hystogram_G.Margin = new Padding(3, 4, 3, 4);
            Hystogram_G.Name = "Hystogram_G";
            Hystogram_G.Size = new Size(273, 192);
            Hystogram_G.TabIndex = 37;
            Hystogram_G.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(Hystogram_RGB);
            panel2.Location = new Point(17, 452);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 192);
            panel2.TabIndex = 6;
            // 
            // Hystogram_RGB
            // 
            Hystogram_RGB.Location = new Point(0, 0);
            Hystogram_RGB.Margin = new Padding(3, 4, 3, 4);
            Hystogram_RGB.Name = "Hystogram_RGB";
            Hystogram_RGB.Size = new Size(273, 192);
            Hystogram_RGB.TabIndex = 35;
            Hystogram_RGB.TabStop = false;
            // 
            // pb_ImageDisplay
            // 
            pb_ImageDisplay.Location = new Point(17, 62);
            pb_ImageDisplay.Name = "pb_ImageDisplay";
            pb_ImageDisplay.Size = new Size(498, 274);
            pb_ImageDisplay.TabIndex = 4;
            pb_ImageDisplay.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(17, 399);
            label4.Name = "label4";
            label4.Size = new Size(141, 37);
            label4.TabIndex = 3;
            label4.Text = "Histogram";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(1074, 135);
            label3.Name = "label3";
            label3.Size = new Size(87, 37);
            label3.TabIndex = 2;
            label3.Text = "Filters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 0;
            label1.Text = "Image ";
            // 
            // bt_Download
            // 
            bt_Download.BackColor = SystemColors.ActiveBorder;
            bt_Download.FlatStyle = FlatStyle.Flat;
            bt_Download.Location = new Point(310, 387);
            bt_Download.Margin = new Padding(3, 3, 5, 5);
            bt_Download.Name = "bt_Download";
            bt_Download.Size = new Size(94, 29);
            bt_Download.TabIndex = 47;
            bt_Download.Text = "Download";
            bt_Download.UseVisualStyleBackColor = false;
            bt_Download.Click += bt_Download_Click;
            // 
            // ImageFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1251, 806);
            Controls.Add(lbl_Video);
            Controls.Add(lbl_Image);
            Controls.Add(lbl_documentation);
            Controls.Add(lbl_Camera);
            Controls.Add(lbl_Home);
            Controls.Add(pnl_Documentation);
            Name = "ImageFilter";
            Text = "Image";
            pnl_Documentation.ResumeLayout(false);
            pnl_Documentation.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Hystogram_B).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Hystogram_R).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Hystogram_G).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Hystogram_RGB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ImageDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Video;
        private Label lbl_Image;
        private Label lbl_documentation;
        private Label lbl_Camera;
        private Label lbl_Home;
        private Panel pnl_Documentation;
        private Label label4;
        private Label label3;
        private PictureBox pb_ImageDisplay;
        private Label label1;
        private Button bt_UploadImage;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox Hystogram_B;
        private PictureBox Hystogram_R;
        private PictureBox Hystogram_G;
        private PictureBox Hystogram_RGB;
        private TextBox FilterValueTextBox;
        private Button Apply;
        private Label ValueName;
        private FlowLayoutPanel flp_Filters;
        private Button bt_Download;
    }
}
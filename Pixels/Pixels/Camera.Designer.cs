namespace Pixels
{
    partial class Camera
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
            label1 = new Label();
            pb_Camera = new PictureBox();
            panel1 = new Panel();
            ColorDisplay = new PictureBox();
            label4 = new Label();
            QTextBox = new TextBox();
            HexadecimalTextBox = new TextBox();
            label2 = new Label();
            bTextBox = new TextBox();
            label5 = new Label();
            aTextBox = new TextBox();
            label6 = new Label();
            LTextBox = new TextBox();
            bt_Camera = new Button();
            pnl_Documentation = new Panel();
            cb_SelectedCamera = new ComboBox();
            button2 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_Camera).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColorDisplay).BeginInit();
            pnl_Documentation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Video
            // 
            lbl_Video.Cursor = Cursors.Hand;
            lbl_Video.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Video.Location = new Point(492, 724);
            lbl_Video.Name = "lbl_Video";
            lbl_Video.Size = new Size(126, 53);
            lbl_Video.TabIndex = 18;
            lbl_Video.Text = "Video";
            lbl_Video.Click += lbl_Video_Click;
            // 
            // lbl_Image
            // 
            lbl_Image.Cursor = Cursors.Hand;
            lbl_Image.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Image.Location = new Point(351, 724);
            lbl_Image.Name = "lbl_Image";
            lbl_Image.Size = new Size(153, 53);
            lbl_Image.TabIndex = 17;
            lbl_Image.Text = "Image";
            lbl_Image.Click += lbl_Image_Click;
            // 
            // lbl_documentation
            // 
            lbl_documentation.Cursor = Cursors.Hand;
            lbl_documentation.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_documentation.Location = new Point(614, 724);
            lbl_documentation.Name = "lbl_documentation";
            lbl_documentation.Size = new Size(286, 61);
            lbl_documentation.TabIndex = 16;
            lbl_documentation.Text = "Documentation";
            lbl_documentation.Click += lbl_documentation_Click;
            // 
            // lbl_Camera
            // 
            lbl_Camera.Cursor = Cursors.Hand;
            lbl_Camera.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Camera.ForeColor = SystemColors.ButtonFace;
            lbl_Camera.Location = new Point(192, 724);
            lbl_Camera.Name = "lbl_Camera";
            lbl_Camera.Size = new Size(153, 53);
            lbl_Camera.TabIndex = 15;
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
            lbl_Home.TabIndex = 14;
            lbl_Home.Text = "Home";
            lbl_Home.Click += Home_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 0;
            label1.Text = "Camera";
            label1.Click += lbl_Camera_Click;
            // 
            // pb_Camera
            // 
            pb_Camera.Location = new Point(35, 62);
            pb_Camera.Name = "pb_Camera";
            pb_Camera.Size = new Size(776, 512);
            pb_Camera.TabIndex = 4;
            pb_Camera.TabStop = false;
            pb_Camera.Click += pb_Camera_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ColorDisplay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(QTextBox);
            panel1.Controls.Add(HexadecimalTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(aTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(LTextBox);
            panel1.Location = new Point(829, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 512);
            panel1.TabIndex = 5;
            // 
            // ColorDisplay
            // 
            ColorDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ColorDisplay.BackColor = SystemColors.ActiveCaption;
            ColorDisplay.BackgroundImageLayout = ImageLayout.Zoom;
            ColorDisplay.Location = new Point(0, 224);
            ColorDisplay.Margin = new Padding(3, 4, 3, 4);
            ColorDisplay.Name = "ColorDisplay";
            ColorDisplay.Padding = new Padding(6, 7, 6, 7);
            ColorDisplay.Size = new Size(229, 133);
            ColorDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            ColorDisplay.TabIndex = 28;
            ColorDisplay.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1, 182);
            label4.Name = "label4";
            label4.Size = new Size(37, 32);
            label4.TabIndex = 27;
            label4.Text = "Q:";
            // 
            // QTextBox
            // 
            QTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QTextBox.BackColor = SystemColors.ActiveCaption;
            QTextBox.BorderStyle = BorderStyle.None;
            QTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            QTextBox.ForeColor = Color.White;
            QTextBox.Location = new Point(39, 180);
            QTextBox.Margin = new Padding(3, 4, 3, 4);
            QTextBox.Multiline = true;
            QTextBox.Name = "QTextBox";
            QTextBox.ReadOnly = true;
            QTextBox.Size = new Size(191, 36);
            QTextBox.TabIndex = 26;
            QTextBox.Text = "Quadrant";
            QTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // HexadecimalTextBox
            // 
            HexadecimalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HexadecimalTextBox.BackColor = SystemColors.ActiveCaption;
            HexadecimalTextBox.BorderStyle = BorderStyle.None;
            HexadecimalTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            HexadecimalTextBox.ForeColor = Color.White;
            HexadecimalTextBox.Location = new Point(3, 4);
            HexadecimalTextBox.Margin = new Padding(3, 4, 3, 4);
            HexadecimalTextBox.Multiline = true;
            HexadecimalTextBox.Name = "HexadecimalTextBox";
            HexadecimalTextBox.ReadOnly = true;
            HexadecimalTextBox.Size = new Size(226, 36);
            HexadecimalTextBox.TabIndex = 19;
            HexadecimalTextBox.Text = "#000000";
            HexadecimalTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1, 138);
            label2.Name = "label2";
            label2.Size = new Size(33, 32);
            label2.TabIndex = 25;
            label2.Text = "b:";
            // 
            // bTextBox
            // 
            bTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bTextBox.BackColor = SystemColors.ActiveCaption;
            bTextBox.BorderStyle = BorderStyle.None;
            bTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            bTextBox.ForeColor = Color.White;
            bTextBox.Location = new Point(39, 136);
            bTextBox.Margin = new Padding(3, 4, 3, 4);
            bTextBox.Multiline = true;
            bTextBox.Name = "bTextBox";
            bTextBox.ReadOnly = true;
            bTextBox.Size = new Size(191, 36);
            bTextBox.TabIndex = 20;
            bTextBox.Text = "b";
            bTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 94);
            label5.Name = "label5";
            label5.Size = new Size(31, 32);
            label5.TabIndex = 24;
            label5.Text = "a:";
            // 
            // aTextBox
            // 
            aTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aTextBox.BackColor = SystemColors.ActiveCaption;
            aTextBox.BorderStyle = BorderStyle.None;
            aTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            aTextBox.ForeColor = Color.White;
            aTextBox.Location = new Point(39, 92);
            aTextBox.Margin = new Padding(3, 4, 3, 4);
            aTextBox.Multiline = true;
            aTextBox.Name = "aTextBox";
            aTextBox.ReadOnly = true;
            aTextBox.Size = new Size(191, 36);
            aTextBox.TabIndex = 21;
            aTextBox.Text = "a";
            aTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1, 50);
            label6.Name = "label6";
            label6.Size = new Size(30, 32);
            label6.TabIndex = 23;
            label6.Text = "L:";
            // 
            // LTextBox
            // 
            LTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LTextBox.BackColor = SystemColors.ActiveCaption;
            LTextBox.BorderStyle = BorderStyle.None;
            LTextBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            LTextBox.ForeColor = Color.White;
            LTextBox.Location = new Point(39, 48);
            LTextBox.Margin = new Padding(3, 4, 3, 4);
            LTextBox.Multiline = true;
            LTextBox.Name = "LTextBox";
            LTextBox.ReadOnly = true;
            LTextBox.Size = new Size(191, 36);
            LTextBox.TabIndex = 22;
            LTextBox.Text = "L";
            LTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // bt_Camera
            // 
            bt_Camera.BackColor = SystemColors.ActiveBorder;
            bt_Camera.FlatStyle = FlatStyle.Flat;
            bt_Camera.Location = new Point(631, 607);
            bt_Camera.Margin = new Padding(3, 3, 5, 5);
            bt_Camera.Name = "bt_Camera";
            bt_Camera.Size = new Size(162, 29);
            bt_Camera.TabIndex = 10;
            bt_Camera.Text = "Open camera";
            bt_Camera.UseVisualStyleBackColor = false;
            bt_Camera.Click += bt_Camera_Click;
            // 
            // pnl_Documentation
            // 
            pnl_Documentation.BackColor = SystemColors.ActiveCaption;
            pnl_Documentation.Controls.Add(cb_SelectedCamera);
            pnl_Documentation.Controls.Add(button2);
            pnl_Documentation.Controls.Add(bt_Camera);
            pnl_Documentation.Controls.Add(panel1);
            pnl_Documentation.Controls.Add(pb_Camera);
            pnl_Documentation.Controls.Add(label3);
            pnl_Documentation.Controls.Add(label1);
            pnl_Documentation.Location = new Point(35, 22);
            pnl_Documentation.Name = "pnl_Documentation";
            pnl_Documentation.Size = new Size(1180, 664);
            pnl_Documentation.TabIndex = 13;
            // 
            // cb_SelectedCamera
            // 
            cb_SelectedCamera.FormattingEnabled = true;
            cb_SelectedCamera.Location = new Point(35, 607);
            cb_SelectedCamera.Name = "cb_SelectedCamera";
            cb_SelectedCamera.Size = new Size(220, 28);
            cb_SelectedCamera.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(457, 607);
            button2.Margin = new Padding(3, 3, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(162, 29);
            button2.TabIndex = 11;
            button2.Text = "Take picture";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(829, 22);
            label3.Name = "label3";
            label3.Size = new Size(178, 37);
            label3.TabIndex = 2;
            label3.Text = "Color capture";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(0, 379);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(6, 7, 6, 7);
            pictureBox1.Size = new Size(229, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Camera
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
            Name = "Camera";
            Text = "Camera";
            ((System.ComponentModel.ISupportInitialize)pb_Camera).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ColorDisplay).EndInit();
            pnl_Documentation.ResumeLayout(false);
            pnl_Documentation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Video;
        private Label lbl_Image;
        private Label lbl_documentation;
        private Label lbl_Camera;
        private Label lbl_Home;
        private Label label1;
        private PictureBox pb_Camera;
        private Panel panel1;
        private Button bt_Camera;
        private Panel pnl_Documentation;
        private Button button2;
        private Label label3;
        private ComboBox cb_SelectedCamera;
        private Label label4;
        private TextBox QTextBox;
        private TextBox HexadecimalTextBox;
        private Label label2;
        private TextBox bTextBox;
        private Label label5;
        private TextBox aTextBox;
        private Label label6;
        private TextBox LTextBox;
        private PictureBox ColorDisplay;
        private PictureBox pictureBox1;
    }
}
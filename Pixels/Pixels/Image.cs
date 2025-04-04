using System.Drawing;

namespace Pixels
{
    public partial class ImageFilter : Form
    {
        public Image originalImage;
        Filters filters = new Filters();

        private int[] hystogramR = new int[256];
        private int[] hystogramG = new int[256];
        private int[] hystogramB = new int[256];
        private int activeFilter;
        private int filterValue;

        public ImageFilter()
        {
            InitializeComponent();


            List<FiltersModel> filters = new List<FiltersModel>
            {
                new FiltersModel("None", Properties.Resource.None, 0),
                new FiltersModel("Inverted", Properties.Resource.Inverted, 1),
                new FiltersModel("Gray Scale", Properties.Resource.GrayScale, 2),
                new FiltersModel("Negative", Properties.Resource.Negative, 3),
                new FiltersModel("Contrast", Properties.Resource.Contrast, 4),
                new FiltersModel("Heat Map", Properties.Resource.Heatmap, 5),
                new FiltersModel("Posterize", Properties.Resource.Posterize1, 6),
                new FiltersModel("Emboss", Properties.Resource.Emboss1, 7),
                new FiltersModel("Comic", Properties.Resource.Dithering, 8),
                new FiltersModel("Pixel", Properties.Resource.Pixel, 9),
                new FiltersModel("Glitch", Properties.Resource.Glitch, 10),
                new FiltersModel("Glitch 1", Properties.Resource.Glitch_1, 11),
                new FiltersModel("Glitch 2", Properties.Resource.Glitch_2, 12),
                new FiltersModel("Glitch 3", Properties.Resource.Glitch_3, 13)
            };
            LoadFilters(filters);
        }

        public void LoadFilters(List<FiltersModel> models)
        {
            flp_Filters.Controls.Clear();

            foreach (var model in models)
            {
                Panel filterPanel = NewFilterPanel(model);
                flp_Filters.Controls.Add(filterPanel);
            }
        }

        private Panel NewFilterPanel(FiltersModel filter)
        {
            Panel panel = new Panel
            {
                Size = new Size(128, 150),
                BackColor = Color.FromArgb(36, 41, 62),
                BorderStyle = BorderStyle.None,
                Name = "FilterPanel",
                Tag = filter
            };
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(110, 110),
                Image = filter.Image,
                Name = "FIlterPicture",
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(9, 9)
            };
            Label label = new Label
            {
                Text = filter.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(75, 17),
                AutoSize = true,
                Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Name = "FilterName",
                Location = new Point(9, 125)
            };
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);

            panel.Click += FilterPanel_Click;
            pictureBox.Click += FilterPanel_Click;
            label.Click += FilterPanel_Click;

            return panel;
        }

        private void FilterPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = (Control)sender;

            Panel panel = clickedControl as Panel ?? clickedControl.Parent as Panel;

            if (panel != null && panel.Tag is FiltersModel filter)
            {
                activeFilter = filter.Value;
                ApplyFilter(activeFilter);
            }
        }

        private void ApplyFilter(int filterNumber)
        {
            try
            {
                if (originalImage == null)
                {
                    throw new InvalidOperationException("Hold on! Select an image first!");
                }
                Bitmap img = new Bitmap(originalImage);


                switch (filterNumber)
                {
                    case 0:
                        pb_ImageDisplay.Image = originalImage;
                        RGBHistorgram_Start(img);

                        break;

                    case 1:
                        pb_ImageDisplay.Image = filters.Invert(img);

                        break;

                    case 2:
                        pb_ImageDisplay.Image = filters.GrayScale(img);

                        break;

                    case 3:
                        pb_ImageDisplay.Image = filters.Negative(img);

                        break;

                    case 4:
                        flp_Filters.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 40;
                        }
                        SetValueFilter("Contrast Intensity:", filterValue);
                        pb_ImageDisplay.Image = filters.Contrast(img);
                        break;

                    case 5:
                        pb_ImageDisplay.Image = filters.HeatMap(img);

                        break;

                    case 6:
                        flp_Filters.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 4;
                        }
                        SetValueFilter("Levels:", filterValue);
                        pb_ImageDisplay.Image = filters.Posterize(img);
                        break;

                    case 7:
                        pb_ImageDisplay.Image = filters.Emboss(img);

                        break;

                    case 8:
                        pb_ImageDisplay.Image = filters.Comic(img);

                        break;

                    case 9:
                        flp_Filters.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 10;
                        }
                        SetValueFilter("Pixel Size:", filterValue);
                        pb_ImageDisplay.Image = filters.Pixel(img);
                        break;

                    case 10:
                        pb_ImageDisplay.Image = filters.Glitch(img);

                        break;

                    case 11:
                        flp_Filters.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 8;
                        }
                        SetValueFilter("Glitch Intensity:", filterValue);
                        pb_ImageDisplay.Image = filters.Glitch_1(img);
                        break;

                    case 12:
                        flp_Filters.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 8;
                        }
                        SetValueFilter("Glitch Intensity:", filterValue);
                        pb_ImageDisplay.Image = filters.Glitch_2(img);
                        break;


                    case 13:
                        flp_Filters.Visible = true;
                        if (filterValue == 0 || filterValue < 0)
                        {
                            filterValue = 8;
                        }
                        SetValueFilter("Glitch Intensity:", filterValue);
                        pb_ImageDisplay.Image = filters.Glitch_3(img);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetValueFilter(string name, int value)
        {
            ValueName.Text = name;
            FilterValueTextBox.Text = value.ToString();
        }
        private void Apply_Click(object sender, EventArgs e)
        {
            string filterValueText = FilterValueTextBox.Text;
            int value;

            if (int.TryParse(filterValueText, out value))
            {

                filterValue = value;
                ApplyFilter(activeFilter);
            }
            else
            {
                MessageBox.Show("Incorrect Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
        }
        private void lbl_Camera_Click(object sender, EventArgs e)
        {
            Redirect("camera");
        }

        private void lbl_ImageFilter_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Video_Click(object sender, EventArgs e)
        {
            Redirect("video");
        }
        private void lbl_documentation_Click(object sender, EventArgs e)
        {
            Redirect("documentation");
        }

  

        private void Redirect(string route)
        {
            if (route == "camera")
            {
                Camera cameraform = new Camera();
                this.Hide();
                cameraform.Show();
            }

            if (route == "video")
            {
                Video videoform = new Video();
                this.Hide();
                videoform.Show();
            }

            if (route == "ImageFilter")
            {
                ImageFilter ImageFilterform = new ImageFilter();
                this.Hide();
                ImageFilterform.Show();
            }

            if (route == "documentation")
            {
                Documentation docform = new Documentation();
                this.Hide();
                docform.Show();
            }

            if (route == "home")
            {
                WNDW homeform = new WNDW();
                this.Hide();
                homeform.Show();
            }
        }

        private void bt_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();

            chooseFile.Title = "Select Media Element";

            chooseFile.Filter = "ImageFilter Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif";//Filter only ImageFilter formats

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = chooseFile.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();//Gets the file extension

                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".bmp" || fileExtension == ".gif")
                {
                    pb_ImageDisplay.Image = Image.FromFile(filePath);

                    originalImage = new Bitmap(pb_ImageDisplay.Image);

                    Bitmap img = new Bitmap(originalImage);

                    RGBHistorgram_Start(img);
                }
                else
                {
                    MessageBox.Show("Ups! Unsupported file format! :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void RGBHistorgram_Start(Bitmap img)
        {
            if (pb_ImageDisplay.Image == null) return;

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);

                    hystogramR[pixel.R]++;
                    hystogramG[pixel.G]++;
                    hystogramB[pixel.B]++;
                }
            }
            Hystogram_Draw(Hystogram_RGB, hystogramR, hystogramG, hystogramB);
            Hystogram_Draw_RGB(Hystogram_R, hystogramR, Color.Red);
            Hystogram_Draw_RGB(Hystogram_G, hystogramG, Color.Green);
            Hystogram_Draw_RGB(Hystogram_B, hystogramB, Color.Blue);
        }

        private void Hystogram_Draw(PictureBox pictureBox, int[] hystogramR, int[] hystogramG, int[] hystogramB)//RGB
        {
            int pictureBoxW = pictureBox.Width;
            int pictureBoxH = pictureBox.Height;

            Bitmap hystogramImg = new Bitmap(pictureBoxW, pictureBoxH);

            Graphics g = Graphics.FromImage(hystogramImg);

            int max = Math.Max(Math.Max(hystogramR.Max(), hystogramG.Max()), hystogramB.Max());

            if (max == 0) return;

            float scaleX = pictureBoxW / 256f;

            for (int i = 0; i < 256; i++)
            {
                int valueH_R = (int)((hystogramR[i] / (float)max) * pictureBoxH);
                int valueH_G = (int)((hystogramG[i] / (float)max) * pictureBoxH);
                int valueH_B = (int)((hystogramB[i] / (float)max) * pictureBoxH);

                int PosX = (int)(i * scaleX);

                g.DrawLine(new Pen(Color.Red), PosX, pictureBoxH, PosX, pictureBoxH - valueH_R);
                g.DrawLine(new Pen(Color.Green), PosX, pictureBoxH, PosX, pictureBoxH - valueH_G);
                g.DrawLine(new Pen(Color.Blue), PosX, pictureBoxH, PosX, pictureBoxH - valueH_B);
            }

            pictureBox.Image = hystogramImg;
        }

        private void Hystogram_Draw_RGB(PictureBox pictureBox, int[] hystogram, Color color)//RGB
        {
            int pictureBoxW = pictureBox.Width;
            int pictureBoxH = pictureBox.Height;

            Bitmap hystogramImg = new Bitmap(pictureBoxW, pictureBoxH);

            Graphics g = Graphics.FromImage(hystogramImg);

            int max = Math.Max(Math.Max(hystogramR.Max(), hystogramG.Max()), hystogramB.Max());

            if (max == 0) return;

            float scaleX = pictureBoxW / 256f;

            for (int i = 0; i < 256; i++)
            {
                int valueH = (int)((hystogram[i] / (float)max) * pictureBoxH);

                int PosX = (int)(i * scaleX);

                g.DrawLine(new Pen(color), PosX, pictureBoxH, PosX, pictureBoxH - valueH);
            }

            pictureBox.Image = hystogramImg;
        }

        private void pnl_Documentation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ValueName_Click(object sender, EventArgs e)
        {

        }

        private void bt_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif";//Filter only image formats
            Image img = pb_ImageDisplay.Image;

            if (img != null)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    img.Save(save.FileName);
                    MessageBox.Show("Image saved succesfully", "Image Saved", MessageBoxButtons.OK, MessageBoxIcon.None);
                }  
            }
            else
            {
                MessageBox.Show("No image loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

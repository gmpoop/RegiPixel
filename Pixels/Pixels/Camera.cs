using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace Pixels
{
    public partial class Camera : Form
    {

        public Camera()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Redirect("home");

        }
        private void lbl_Camera_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Image_Click(object sender, EventArgs e)
        {
            Redirect("image");
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
            if (route == "home")
            {
                WNDW homeform = new WNDW();
                this.Hide();
                homeform.Show();
            }

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

            if (route == "image")
            {
                Image imageform = new Image();
                this.Hide();
                imageform.Show();
            }

            if (route == "documentation")
            {
                Documentation docform = new Documentation();
                this.Hide();
                docform.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CameraManager.Instance.FrameUpdated += UpdateFrame;
        }

        private void UpdateFrame(Mat frame)
        {
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new Action(() => pictureBox1.Image = ConvertMatToBitmap(frame)));
            }
            else
            {
                pictureBox1.Image = ConvertMatToBitmap(frame);
            }
        }

        private Bitmap ConvertMatToBitmap(Mat frame)
        {
            try
            {
                if (frame == null || frame.IsEmpty)
                    return null;

                Mat convertedFrame = new Mat();
                CvInvoke.CvtColor(frame, convertedFrame, ColorConversion.Bgr2Rgb); // Ensure correct color format

                return convertedFrame.ToBitmap(); // Convert Mat to Bitmap
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error converting Mat to Bitmap: " + ex.Message);
                return null;
            }
        }

    }
}

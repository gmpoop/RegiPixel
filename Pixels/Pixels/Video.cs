using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixels
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
        }
        private void lbl_Camera_Click(object sender, EventArgs e)
        {
            Redirect("camera");
        }

        private void lbl_Image_Click(object sender, EventArgs e)
        {
            Redirect("image");
        }

        private void lbl_Video_Click(object sender, EventArgs e)
        {
        }
        private void lbl_documentation_Click(object sender, EventArgs e)
        {
            Redirect("documentation");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Video_Load(object sender, EventArgs e)
        {

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

            if (route == "home")
            {
                WNDW homeform = new WNDW();
                this.Hide();
                homeform.Show();
            }
        }

    
    }
}

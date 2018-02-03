using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Threading;

namespace IpCameraViewerEmguCV
{
    public partial class Form1 : Form
    {
        //private const int MAX_LENGTH_OF_ARRAY = 2;

        private Capture capture1 = null;
        private Capture capture2 = null;

        //private int counter = 1;
        private DateTime date = new DateTime();

        public Form1()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
        }


        private void ProcessFrame1(object sender, EventArgs arg)
        {
            int height = imageBox1.Height;
            int width = imageBox1.Width;
            Mat frame = new Mat();

            capture1.Retrieve(frame, 0);
            CvInvoke.Resize(frame, frame, new Size(width, height), 0, 0, Inter.Linear);

            imageBox1.Image = frame;
        }

        private void ProcessFrame2(object sender, EventArgs arg)
        {
            int height = imageBox2.Height;
            int width = imageBox2.Width;
            Mat frame = new Mat();

            capture2.Retrieve(frame, 0);
            CvInvoke.Resize(frame, frame, new Size(width, height), 0, 0, Inter.Linear);

            imageBox2.Image = frame;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                capture1.Start();
                capture2.Start();
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            
            // Init capture 1
            try
            {
                capture1 = new Emgu.CV.Capture("rtsp://admin:Parking123@10.0.0.100:554/Streaming/Channels/101");
                capture1.ImageGrabbed += ProcessFrame1;
            }
            catch
            {
                MessageBox.Show("Fail!");
            }

            // Init capture 2
            try
            {
                capture2 = new Emgu.CV.Capture("rtsp://admin:optimusprime242@10.0.0.120:554/Streaming/Channels/101");
                capture2.ImageGrabbed += ProcessFrame2;
            }
            catch
            {
                MessageBox.Show("Fail!");
            }

        }

        // Save the image with the direct times in the system
        private void btTakePhoto_Click(object sender, EventArgs e)
        {
            GetImageFromImageBox(imageBox1, "Cam1");
            GetImageFromImageBox(imageBox2, "Cam2");            
        }

        private void GetImageFromImageBox(ImageBox ib, String camName)
        {
            DateTime date = DateTime.Now;
            String hour = DateTime.Now.Hour.ToString();
            String minute = DateTime.Now.Minute.ToString();
            String second = DateTime.Now.Second.ToString();

            String saveName = camName + "_" + hour + "_" + minute + "_" + second + "_" + date.ToShortDateString() + ".jpg";

            ib.Image.Save(saveName);
        }

        // Compare - show the images were saved in database to imagebox
        private void btCompare_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        private const int MAX_LENGTH_OF_ARRAY = 2;

        private Capture capture1 = null;
        private Capture capture2 = null;

        private int counter = 0;
        private DateTime date = new DateTime();

        /* Test: using the array */
        private Capture[] listCapture = new Emgu.CV.Capture[MAX_LENGTH_OF_ARRAY];
        private ImageBox[] listImage = new ImageBox[MAX_LENGTH_OF_ARRAY];

        public Form1()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;

            btReset.Enabled = false;
        }

        #region Using the array to store the variables
        /// <summary>
        /// Initialize of the capture in the array
        /// </summary>
        /// <param name="index">The index of the item in the array</param>
        private void InitCapture(int index, String url)
        {
            try
            {
                // Config the url stream
                listCapture[index] = new Emgu.CV.Capture(url);
                listCapture[index].ImageGrabbed += ProcessFrame;
                counter = index;
            }
            catch
            {
                MessageBox.Show("Fail!");
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            int height = imageBox1.Height;
            int width = imageBox1.Width;
            Mat frame = new Mat();

            listCapture[counter].Retrieve(frame, 0);
            CvInvoke.Resize(frame, frame, new Size(width, height), 0, 0, Inter.Linear);

            listImage[counter].Image = frame;
        }
        #endregion

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

        /// <summary>
        /// The event when click the start button in form to show the images got form camera
        /// </summary>
        /// <param name="sender">The clicked button</param>
        /// <param name="e"></param>
        private void btStart_Click(object sender, EventArgs e)
        {
            btReset.Enabled = true;

            try
            {
                
                capture1.Start();
                capture2.Start();

                // TODO: using the array and lamda for the array with serveral item.
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Using multithread if needed
            CheckForIllegalCrossThreadCalls = false;

            InitListCapture();
        }


        /// <summary>
        /// Init a capture to image from the camera with a url stream
        /// </summary>
        /// <param name="cap">The capture</param>
        /// <param name="e">Image Grabbed event</param>
        /// <param name="url">The url stream</param>
        private void InitCapture(Capture cap, EventHandler e, String url)
        {
            // Init capture
            try
            {
                // Config the url stream
                cap = new Emgu.CV.Capture(url);
                cap.ImageGrabbed += e;
            }
            catch
            {
                MessageBox.Show("Fail: " + url);
            }
        }


        /// <summary>
        /// Init the multi capture for each camera
        /// </summary>
        private void InitListCapture()
        {
            /*
            InitCapture(capture1, ProcessFrame1, "rtsp://admin:Parking123@10.0.0.100:554/Streaming/Channels/101");
            InitCapture(capture2, ProcessFrame2, "rtsp://admin:optimusprime242@10.0.0.120:554/Streaming/Channels/101");
            */

            capture1 = null;
            capture2 = null;

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

        /// <summary>
        /// Save the image with the direct times in the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btTakePhoto_Click(object sender, EventArgs e)
        {
            // Get image from camera 1
            GetImageFromImageBox(imageBox1, "Cam1");

            // Get image from camera 2
            GetImageFromImageBox(imageBox2, "Cam2");            
        }

        /// <summary>
        /// The function process the getting image from image box when appear the Take photo button clicked event
        /// </summary>
        /// <param name="ib">The imagebox which get image from</param>
        /// <param name="camName">The name of camare which imagebox show the image from</param>
        /// <values> The saved image to direct folder (running process foler)</values>
        private void GetImageFromImageBox(ImageBox ib, String camName)
        {
            /*
             RULE: the saving name of the image
             <camera name>_<direct hour>_<direct minute>_<direct second>_<direct date>.jpg
             */

            // Get the direct time in system
            DateTime date = DateTime.Now;
            String hour = DateTime.Now.Hour.ToString();
            String minute = DateTime.Now.Minute.ToString();
            String second = DateTime.Now.Second.ToString();

            // Create the saving name of image file
            String saveName = camName + "_" + hour + "_" + minute + "_" + second + "_" + date.ToShortDateString() + ".jpg";

            // -- This below line that save the image got from imagebox and store in the current-directory
            ib.Image.Save(saveName);

            // TODO: change and store all got image to a unique folder
            Bitmap bmp = ib.Image.Bitmap;
            //((Image)bmp).Save()
        }

        // Compare - show the images were saved in database to imagebox
        private void btCompare_Click(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            InitListCapture();
            btStart.Enabled = true;
            btReset.Enabled = false;
        }
    }
}

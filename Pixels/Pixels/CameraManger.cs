using System;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Pixels
{
    public class CameraManager
    {
        private static CameraManager _instance;
        private static readonly object _lock = new object();

        private VideoCapture _capture;
        private Mat _latestFrame;
        private Thread _captureThread;
        private bool _isRunning;

        // Event to notify subscribers of new frames
        public event Action<Mat> FrameUpdated;

        private CameraManager()
        {
            _capture = new VideoCapture(0); // Open default camera
            _isRunning = true;
            _captureThread = new Thread(CaptureLoop) { IsBackground = true };
            _captureThread.Start();
        }

        // Singleton Instance
        public static CameraManager Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new CameraManager();
                }
            }
        }

        private void CaptureLoop()
        {
            while (_isRunning)
            {
                _latestFrame = _capture.QueryFrame(); // Get frame from camera

                if (_latestFrame != null)
                {
                    FrameUpdated?.Invoke(_latestFrame); // Send Mat frame to subscribers
                }

                Thread.Sleep(33); // ~30 FPS
            }
        }

        public Mat GetCurrentFrame()
        {
            return _latestFrame;
        }

        public void StopCamera()
        {
            _isRunning = false;
            _captureThread.Join(); // Wait for the thread to finish
            _capture.Dispose();
        }
    }
}

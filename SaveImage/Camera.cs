using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveImage
{
    class Camera
    {
        private PictureBox frame;
        VideoCaptureDevice videoSource;

        public delegate void SavePicture(MemoryStream ms);
        public delegate void SetPicture(Bitmap bitmap);
        public delegate void StopSignal(VideoCaptureDevice dev);


        public Camera(PictureBox _frame)
        {
            frame = _frame;
        }

        public void TurnOn()
        {
            FilterInfo videoDevice = null;
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                Common.ShowErrorMessage("Не найдено ни одного источника видео");
            }
            else if (videoDevices.Count == 1)
            {
                videoDevice = videoDevices[0];
            }
            else if (videoDevices.Count > 1)
            {
                foreach (FilterInfo dev in videoDevices)
                {
                    if (dev.Name == Common.cameraName)
                    {
                        videoDevice = dev;
                        break;
                    }
                }
            }

            if (videoDevice != null)
            {
                videoSource = new VideoCaptureDevice(videoDevice.MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
                videoSource.Start();
            }
        }

        public void TurnOff()
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            frame.Image = bitmap;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace C_Sharp
{
    class VideoPost:Post
    {

        protected bool isVideoPlaying = false;
        protected int currentDuration = 0;
        Timer timer;
        
        public int VideoLength { get; set; }
        public string VideoURL { get; set; }

        public VideoPost()
        {

        }
        public VideoPost(string title,string sendByUserName,string videoURL,bool isPublic,int videoLength)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            this.VideoLength = videoLength;
            this.VideoURL = videoURL;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} of {3} mins- by {4}", ID, Title, VideoURL, VideoLength,SendByUserName);
        }

        public void PlayVideo()
        {
            if (!isVideoPlaying)
            {
                isVideoPlaying = true;
                Console.WriteLine("Video is playing ...");
                timer = new Timer(TimerCallBack, null, 0,600);
            }
        }

        private void TimerCallBack(object o)
        {
            //timer method accepts the timer call back
            //this call method is used to execute when each time specified period is over
            //in our case it is 600ms  = 1s 
            if(currentDuration < this.VideoLength)
            {
                currentDuration++;
                Console.WriteLine("Video is at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                StopVideo();
            }
        }

        public void StopVideo()
        {
            if (isVideoPlaying)
            {
                isVideoPlaying = false;
                Console.WriteLine("Video is stopped at {0}s", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }
        }



    }
}

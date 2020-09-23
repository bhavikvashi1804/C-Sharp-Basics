using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class VideoPost:Post
    {
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



    }
}

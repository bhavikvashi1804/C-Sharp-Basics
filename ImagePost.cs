using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class ImagePost: Post
    {
        //member variable 
        public string ImageURL { get; set; }


        //constructor
        public ImagePost()
        {

        }
        public ImagePost(string title,string sendByUserName,bool isPublic,string imageURL)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            this.ImageURL = imageURL;
            //by mistake I forget to set sendByUserName then this select the user name which is present in Post Default Constructor
            //hence Default constructor in Parent class is required
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - by {3}", ID, Title,ImageURL, SendByUserName);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp
{
    class Post
    {
        private static int currentPostId;


        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }


        //default constructor
        public Post()
        {
            ID = 0;
            Title = "This is first post";
            SendByUserName = "Bhavik Vashi";
            IsPublic = true;
        }
        //parameterized constructor
        public Post(string title,bool isPublic,string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }


        public void UpdatePost(string title,bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //override the ToString method
        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2}",ID,Title,SendByUserName);
        }

    }
}

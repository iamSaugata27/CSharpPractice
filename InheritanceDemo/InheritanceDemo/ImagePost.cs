using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class ImagePost:Post
    {
        private string ImageURL { get; set; }
        public ImagePost()
        {

        }
        public ImagePost(string title,string sendByUsername,string imageUrl,bool isPublic)
        {
            this.Id = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = imageUrl;
        }
        public override string ToString()
        {
            return String.Format($"{this.Id} - {this.ImageURL} - {this.Title} by {this.SendByUsername}");
        }
    }
}

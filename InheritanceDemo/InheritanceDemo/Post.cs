using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Post
    {
        private static int currentPostId;
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }
        public Post()
        {
            Id = 0;
            Title = "My First Post";
            SendByUsername = "Saugata Shee";
            IsPublic = true;
        }
        public Post(string title,string sendByUsername,bool isPublic)
        {
            this.Id = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }
        protected int GetNextID()
        {
            return ++currentPostId;
        }
        public void Update(string title,bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            return String.Format($"{this.Id} - {this.Title} by {this.SendByUsername}");
        }
    }
}

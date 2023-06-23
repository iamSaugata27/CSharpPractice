using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class VideoPost:Post
    {
        private string VideoURL { get; set; }
        private int Length { get; set; }
        private bool isPlaying = false;
        private int currDuration = 0;
        Timer time;
        public VideoPost()
        {
            
        }
        public VideoPost(string title,string sendByUsername,string videoUrl,bool isPublic,int length)
        {
            this.Id = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.VideoURL = videoUrl;
            this.Length = length;
        }
        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing...");
                time = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        private void TimerCallback(object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration}sec");
            }
            else
                Stop();
        }
        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {currDuration}sec");
                currDuration = 0;
                time.Dispose();
            }
        }
        public override string ToString()
        {
            return String.Format($"{this.Id} - {this.VideoURL} - {this.Length} - {this.Title} by {this.SendByUsername}");
        }
    }
}

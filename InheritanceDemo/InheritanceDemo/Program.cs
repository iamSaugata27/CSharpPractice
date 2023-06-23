using System;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Thank you", "Saugata Shee", true);
            Console.WriteLine(post.ToString());
            post.Update("This is not done", false);
            Console.WriteLine(post.ToString());
            ImagePost imgpost = new ImagePost("my image", "Saugata Shee", "https://img.com", true);
            Console.WriteLine(imgpost.ToString());
            VideoPost videoPost = new VideoPost("My Private video", "Saugaata Shee", "https://myvideo.com", false,5);
            Console.WriteLine(videoPost.ToString());
            videoPost.Play();
            Console.WriteLine("Press any key to stop video...");
            Console.ReadLine();
            videoPost.Stop();
        }
    }
}

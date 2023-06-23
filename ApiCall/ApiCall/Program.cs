using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace ApiCall
{
    internal class Program
    {
        public class Post
        {
            public string Title { get; set; }
            public string Body { get; set; }
            public int UserId { get; set; }
        }
        static void Main(string[] args)
        {
            using(var client=new HttpClient())
            {
                var endPoint = new Uri("https://jsonplaceholder.typicode.com/posts");
                // For Get Request
                var result = client.GetAsync(endPoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                //Console.WriteLine(json);
                // For Post Request
                var post = new Post()
                {
                    Title = "My experiment title",
                    Body = "my Post Body",
                    UserId = 105
                };
                var postJson = JsonConvert.SerializeObject(post);
                var payload = new StringContent(postJson, Encoding.UTF8,"application/json");
                var postResult = client.PostAsync(endPoint, payload).Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(postResult);
            }
        }
    }
}

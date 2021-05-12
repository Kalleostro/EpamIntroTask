using System;
using System.Collections.Generic;
using System.Threading;

namespace EpamIntroTask
{
    public class OfficeGai : IOfficeGai
    {
        public string Status { get; private set; } = "default";
        
        public List<IPostGai> posts = new List<IPostGai>();

        public void Sub(IPostGai post)
        {
            Console.WriteLine("Office: post " + post.GetName() + " has been subscribed to the office updates.");
            this.posts.Add(post);
        }

        public void Unsub(IPostGai post)
        {
            this.posts.Remove(post);
            Console.WriteLine("Office: post " + post.GetName() + " has been unsubscribed from the office updates.");
        }
        public void Notify()
        {
            Console.WriteLine("Office: Sending information to the posts...");

            foreach (var post in posts)
            {
                post.Update(this);
            }
        }
        
        public void NotifyingLogic()
        {
            Console.WriteLine("\nCalculating status.");
            
            var randomizer = new Random().Next(0, 2);
            Status = randomizer switch
            {
                0 => "default",
                1 => "emergency",
                _ => Status
            };

            Thread.Sleep(15);

            Console.WriteLine("The current status is: " + this.Status);
            this.Notify();
        }
    }
}

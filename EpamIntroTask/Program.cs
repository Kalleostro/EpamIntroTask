using System;
using System.Collections.Generic;

namespace EpamIntroTask
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var officeGai = new OfficeGai();
            Console.WriteLine("Enter the number of posts");
            var postCurrentNumber = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < postCurrentNumber; i++)
            {
                Console.WriteLine("Enter the name of the post #" + (i+1));
                officeGai.Sub(new PostGai(Console.ReadLine())); 
            }
            Console.WriteLine("Enter the number of requests: ");
            var requestUpdateNumber = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < requestUpdateNumber; i++)
                officeGai.NotifyingLogic();
        }
    }
}
using System;

namespace EpamIntroTask
{
    public class PostGai:IPostGai
    {
        private string PostName { get; set; }
        public void Update(IOfficeGai officeGai)
        {
            if (((OfficeGai) officeGai).Status.Equals("emergency"))
            {
                Console.WriteLine("Answer from the post " + PostName + ": reaction called.");
            }
            else Console.WriteLine("Answer from the post " + PostName + ": status default. Doing nothing.");
        }
        public string GetName()
        {
            return PostName;
        }
        public PostGai(string name)
        {
            PostName = name;
        }
    }
}
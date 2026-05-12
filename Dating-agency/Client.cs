using System;

namespace Dating_agency
{
    public class Client
    {
        private static int nextId = 1;

        public string RegNumber { get; set; }
        public DateTime RegDate { get; set; }
        public string Gender { get; set; }
        public string AboutMe { get; set; }
        public string Requirements { get; set; }
        public bool IsArchived { get; set; }

        public Client(string gender, string about, string req)
        {
            RegNumber = nextId.ToString("D4");
            nextId++;

            Gender = gender;
            AboutMe = about;
            Requirements = req;
            RegDate = DateTime.Now;
            IsArchived = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    public class Post
    {

        public DateTime TimeCreated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }



        public Post(string title, string description)
        {
            this.TimeCreated = DateTime.Now;
            this.Votes = 0;
            this.Title = title;
            this.Description = description;
        }


        public void UpVote()
        {
            Votes++;
        }


        public void DownVote()
        {
            Votes--;
        }
    }
}

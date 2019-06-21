using System;
using System.Collections.Generic;
using System.Text;

namespace cholericdev.model
{
    public class Post
    {
        public int PostId { get; private set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public string Content { get; set; }

        private DateTime creationDay;
        public DateTime CreationDay
        {
            get => creationDay;
            set => creationDay = value;
        }

        private DateTime lastUpdate;
        public DateTime LastUpdate
        {
            get => lastUpdate;
            set => lastUpdate = value;
        }

        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}

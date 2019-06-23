using System;

namespace cholericdev.model
{
    public class User
    {
        public int UserId { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
    }
}

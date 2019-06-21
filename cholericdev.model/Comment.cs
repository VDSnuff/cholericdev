namespace cholericdev.model
{
    public class Comment
    {
        public int CommentId { get; private set; }
        public string Content { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
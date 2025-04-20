using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public abstract class Interaction
    {
        public User User { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ScoreValue { get; set; }
    }

    public class Like : Interaction
    {
        public Like()
        {
            ScoreValue = 1;
        }
    }

    public class Comment : Interaction
    {
        public Comment()
        {
            ScoreValue = 3;
        }
        public string Message { get; set; }
    }

    public class Share : Interaction
    {
        public Share()
        {
            ScoreValue = 5;
        }
    }
}
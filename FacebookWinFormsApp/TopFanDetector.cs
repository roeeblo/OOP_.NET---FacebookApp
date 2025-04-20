using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class TopFanDetector
    {
        private string m_UserID;

        public TopFanDetector(string i_UserID)
        {
            m_UserID = i_UserID;
        }

        public Leaderboard DetectTopFans(User i_User)
        {
            List<Interaction> interactions = getAllInteractions(i_User);
            Leaderboard leaderboard = new Leaderboard(interactions);

            return leaderboard;
        }

        private List<Interaction> getAllInteractions(User i_User)
        {
            List<Interaction> interactions = new List<Interaction>();

            if (i_User.Posts != null)
            {
                foreach (Post post in i_User.Posts)
                {
                    try
                    {
                        if (post.LikedBy != null)
                        {
                            foreach (User likeUser in post.LikedBy)
                            {
                                interactions.Add(new Like() { User = likeUser, CreatedTime = (DateTime)post.CreatedTime });
                            }
                        }
                    }
                    catch (Facebook.FacebookOAuthException) { }

                    try
                    {
                        if (post.Comments != null)
                        {
                            foreach (FacebookWrapper.ObjectModel.Comment comment in post.Comments)
                            {
                                interactions.Add(new Comment() { User = comment.From, CreatedTime = (DateTime)comment.CreatedTime, Message = comment.Message });
                            }
                        }
                    }
                    catch (Facebook.FacebookOAuthException) { }
                }
            }

            return interactions;
        }
    }
}
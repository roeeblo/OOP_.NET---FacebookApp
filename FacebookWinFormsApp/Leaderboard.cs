using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{
    public class Leaderboard
    {
        public List<FanRanking> Rankings { get; set; } = new List<FanRanking>();

        public Leaderboard(List<Interaction> i_Interactions)
        {
            var userInteractions = i_Interactions.GroupBy(interaction => interaction.User.Id)
                                                .Select(group => new { UserId = group.Key, Interactions = group.ToList() });

            foreach (var userInteraction in userInteractions)
            {
                FanRanking ranking = new FanRanking() { UserId = userInteraction.UserId, Score = calculateUserScore(userInteraction.Interactions), UserName = userInteraction.Interactions.First().User.Name };
                Rankings.Add(ranking);
            }

            Rankings = Rankings.OrderByDescending(ranking => ranking.Score).ToList();
        }

        private int calculateUserScore(List<Interaction> i_Interactions)
        {
            return i_Interactions.Sum(interaction => interaction.ScoreValue);
        }
    }

    public class FanRanking
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
    }
}
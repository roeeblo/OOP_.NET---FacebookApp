using System.Drawing;

namespace BasicFacebookFeatures
{
    public class FacebookGame
    {
        public string Name { get; }
        public string Url { get; }
        public Image Icon { get; }
        public string Category { get; }

        public FacebookGame(string i_Name, string i_Url, Image i_Icon, string i_Category = "Other")
        {
            Name = i_Name;
            Url = i_Url;
            Icon = i_Icon;
            Category = i_Category;
        }
    }
}
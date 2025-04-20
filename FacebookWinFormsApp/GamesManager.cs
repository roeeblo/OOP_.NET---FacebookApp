using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class GamesManager
    {
        private const int k_CardWidth = 180;
        private const int k_CardHeight = 220;
        private const int k_IconWidth = 160;
        private const int k_IconHeight = 140;
        private static readonly Color sr_FacebookBlue = Color.FromArgb(24, 119, 242);

        private readonly List<FacebookGame> m_AllGames;
        private FlowLayoutPanel m_GamesPanel;
        private TextBox m_SearchBox;
        private ComboBox m_CategoriesCombo;
        private TabPage m_GamesTabPage;
        private Panel m_FilterPanel;

        public GamesManager(LoginResult i_LoginResult)
        {
            m_AllGames = initializeGameCollection();

            m_GamesPanel = new FlowLayoutPanel();
            m_SearchBox = new TextBox();
            m_CategoriesCombo = new ComboBox();
            m_GamesTabPage = new TabPage();
            m_FilterPanel = new Panel();
        }

        private List<FacebookGame> initializeGameCollection()
        {
            return new List<FacebookGame>
            {
                // Puzzle Games
                new FacebookGame("Candy Crush Saga", "https://apps.facebook.com/candycrush",
                    Properties.Resources.CandyCrushIcon, "Puzzle"),
                new FacebookGame("Angry Birds", "https://www.facebook.com/gaming/play/1825153594465039",
                    Properties.Resources.AngryBirdsIcon, "Puzzle"),
                new FacebookGame("Jewel Blitz", "https://www.facebook.com/gaming/play/363232067418034",
                    Properties.Resources.JewelBlitzIcon, "Puzzle"),
                new FacebookGame("Candy Riddles", "https://www.facebook.com/gaming/play/169228177248519",
                    Properties.Resources.CandyRiddlesIcon, "Puzzle"),
                new FacebookGame("Mahjong Story", "https://www.facebook.com/gaming/play/1869354289823409",
                    Properties.Resources.MahjongIcon, "Puzzle"),

                // Arcade Games
                new FacebookGame("8 Ball Pool", "https://www.facebook.com/gaming/play/1829935823906294",
                    Properties.Resources.EightBallPoolIcon, "Arcade"),
                new FacebookGame("SnakeMania", "https://www.facebook.com/gaming/play/1766150917023645",
                    Properties.Resources.SnakeManiaIcon, "Arcade"),
                new FacebookGame("Fishing Hunter", "https://www.facebook.com/gaming/play/1169463851403788",
                    Properties.Resources.FishingHunterIcon, "Arcade"),
                new FacebookGame("WaterMelon Merge", "https://www.facebook.com/gaming/play/1990469004524614",
                    Properties.Resources.WatermelonIcon, "Arcade"),
                new FacebookGame("FruitNinja", "https://www.facebook.com/gaming/play/1331614800685579",
                    Properties.Resources.FruitNinjaIcon, "Arcade"),

                // Word Games
                new FacebookGame("Words With Friends", "https://apps.facebook.com/wordswithfriends",
                    Properties.Resources.WordsWithFriendsIcon, "Word"),
                new FacebookGame("Daily word", "https://www.facebook.com/gaming/play/257462376576358",
                    Properties.Resources.DailyWordIcon, "Word"),
                new FacebookGame("Word Farm", "https://www.facebook.com/gaming/play/444134890588331",
                    Properties.Resources.WordFarmIcon, "Word"),
                new FacebookGame("Word Cake", "https://www.facebook.com/gaming/play/1676535456204380",
                    Properties.Resources.WordCakeIcon, "Word"),
                new FacebookGame("Wordle", "https://www.facebook.com/gaming/play/687106612630078",
                    Properties.Resources.WordleIcon, "Word"),

                // Card Games
                new FacebookGame("Uno", "https://www.facebook.com/gaming/play/1939015149698140",
                    Properties.Resources.UnoIcon, "Card"),
                new FacebookGame("Hearts", "https://www.facebook.com/gaming/play/1491119467589898",
                    Properties.Resources.HeartsIcon, "Card"),
                new FacebookGame("Solitaire", "https://www.facebook.com/gaming/play/3364301470380751",
                    Properties.Resources.SolitareIcon, "Card"),
                new FacebookGame("Merge cards", "https://www.facebook.com/gaming/play/1566682163726549",
                    Properties.Resources.MergeCardIcon, "Card"),
                new FacebookGame("Poker Solitare", "https://www.facebook.com/gaming/play/812876490867939",
                    Properties.Resources.PokerSolitareIcon, "Card"),

                // Casino Games
                new FacebookGame("Texas Holdem", "https://www.facebook.com/gaming/play/1648839595642856",
                    Properties.Resources.TexasHoldemIcon, "Casino"),
                new FacebookGame("MoneyParty", "https://www.facebook.com/gaming/play/moneypartyslots",
                    Properties.Resources.MoneyPartyIcon, "Casino"),
                new FacebookGame("Golden City", "https://www.facebook.com/gaming/play/269590853708002",
                    Properties.Resources.GoldenCityIcon, "Casino"),
                new FacebookGame("VegasCraze", "https://www.facebook.com/gaming/play/482319382327095",
                    Properties.Resources.VegasCrazeIcon, "Casino"),
                new FacebookGame("Bingo", "https://www.facebook.com/gaming/play/668910237718447",
                    Properties.Resources.BingoIcon, "Casino")
            };
        }

        public void CreateGamesTab(TabControl i_TabControl)
        {
            m_GamesTabPage.Text = "Facebook Games";

            m_FilterPanel.Dock = DockStyle.Top;
            m_FilterPanel.Height = 50;
            m_FilterPanel.BackColor = Color.White;

            m_SearchBox.Width = 200;
            m_SearchBox.Location = new Point(20, 10);
            m_SearchBox.Text = "Search games...";
            m_SearchBox.ForeColor = Color.Gray;
            m_SearchBox.GotFocus += removeSearchPlaceholder;
            m_SearchBox.LostFocus += addSearchPlaceholder;
            m_SearchBox.TextChanged += onSearchTextChanged;

            m_CategoriesCombo.Width = 150;
            m_CategoriesCombo.Location = new Point(240, 10);
            m_CategoriesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            m_CategoriesCombo.Items.AddRange(new[] { "All Categories", "Puzzle", "Arcade", "Word", "Card", "Casino" });
            m_CategoriesCombo.SelectedIndex = 0;
            m_CategoriesCombo.SelectedIndexChanged += onCategoryChanged;

            m_FilterPanel.Controls.Add(m_SearchBox);
            m_FilterPanel.Controls.Add(m_CategoriesCombo);
            m_GamesTabPage.Controls.Add(m_FilterPanel);

            m_GamesPanel.Dock = DockStyle.Fill;
            m_GamesPanel.AutoScroll = true;
            m_GamesPanel.Padding = new Padding(20);
            m_GamesPanel.BackColor = Color.FromArgb(240, 242, 245);
            renderAllGames();
            m_GamesTabPage.Controls.Add(m_GamesPanel);

            i_TabControl.TabPages.Add(m_GamesTabPage);
        }

        private void removeSearchPlaceholder(object i_Sender, EventArgs i_EventArgs)
        {
            if (m_SearchBox.Text == "Search games...")
            {
                m_SearchBox.Text = "";
                m_SearchBox.ForeColor = Color.Black;
            }
        }

        private void addSearchPlaceholder(object i_Sender, EventArgs i_EventArgs)
        {
            if (string.IsNullOrWhiteSpace(m_SearchBox.Text))
            {
                m_SearchBox.Text = "Search games...";
                m_SearchBox.ForeColor = Color.Gray;
            }
        }

        private void onSearchTextChanged(object i_Sender, EventArgs i_EventArgs)
        {
            if (m_SearchBox.Text == "Search games..." && m_SearchBox.ForeColor == Color.Gray)
                return;

            filterGames();
        }

        private void onCategoryChanged(object i_Sender, EventArgs i_EventArgs)
        {
            filterGames();
        }

        private void filterGames()
        {
            string searchTerm = m_SearchBox.ForeColor == Color.Gray ? "" : m_SearchBox.Text.ToLower();
            string category = m_CategoriesCombo.SelectedItem.ToString();

            List<FacebookGame> filteredGames = m_AllGames.Where(i_Game =>
                (category == "All Categories" || i_Game.Category == category) &&
                (string.IsNullOrEmpty(searchTerm) || i_Game.Name.ToLower().Contains(searchTerm))
            ).ToList();

            renderGames(filteredGames);
        }

        private void renderAllGames()
        {
            renderGames(m_AllGames);
        }

        private void renderGames(List<FacebookGame> i_GamesToRender)
        {
            m_GamesPanel.Controls.Clear();
            m_GamesPanel.Padding = new Padding(30, 30, 30, 30);
            m_GamesPanel.AutoScroll = true;

            foreach (FacebookGame Game in i_GamesToRender)
            {
                Panel gamePanel = new Panel
                {
                    Width = k_CardWidth,
                    Height = k_CardHeight,
                    Margin = new Padding(15),
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };

                gamePanel.Click += (i_Sender, i_EventArgs) => launchGame(Game);

                PictureBox pictureBox = new PictureBox
                {
                    Image = Game.Icon,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = k_IconWidth,
                    Height = k_IconHeight,
                    Top = 10,
                    Left = 10,
                    Cursor = Cursors.Hand
                };
                pictureBox.Click += (i_Sender, i_EventArgs) => launchGame(Game);

                Label label = new Label
                {
                    Text = Game.Name,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = sr_FacebookBlue,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = k_IconWidth,
                    Top = 160,
                    Left = 10,
                    Cursor = Cursors.Hand
                };
                label.Click += (i_Sender, i_EventArgs) => launchGame(Game);

                gamePanel.Controls.Add(pictureBox);
                gamePanel.Controls.Add(label);
                m_GamesPanel.Controls.Add(gamePanel);
            }

            m_GamesPanel.PerformLayout();
            m_GamesPanel.AutoScrollPosition = new Point(0, 0);
        }

        private void launchGame(FacebookGame i_Game)
        {
            try
            {
                System.Diagnostics.Process.Start(i_Game.Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to launch {i_Game.Name}: {ex.Message}");
            }
        }
    }
}
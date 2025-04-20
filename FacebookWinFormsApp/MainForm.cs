using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Controllers;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private TabPage m_AlbumsTabPage;
        private FlowLayoutPanel m_AlbumsFlowLayoutPanel;
        private GamesManager m_GamesManager;

        public MainForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            initializeBtnDayInHistory();
        }

        private void initializeBtnDayInHistory()
        {
            btnDayInHistory.Enabled = false;
            btnDayInHistory.Visible = false;
            btnDayInHistory.FlatStyle = FlatStyle.Flat;
            btnDayInHistory.BackColor = Color.LightBlue;
            btnDayInHistory.FlatAppearance.BorderSize = 0;
            btnDayInHistory.Font = new Font("Segoe UI", 9);

            btnDayInHistory.Click += btnDayInHistory_Click;
        }

        private void btnDayInHistory_Click(object sender, EventArgs e)
        {
            ThisDayInHistoryForm historyForm = new ThisDayInHistoryForm(m_LoggedInUser);
            historyForm.ShowDialog();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {

            TopFanDetector detector = new TopFanDetector(m_LoggedInUser.Id);
            Leaderboard leaderboard = detector.DetectTopFans(m_LoggedInUser);

            LeaderboardForm leaderboardForm = new LeaderboardForm(leaderboard);
            leaderboardForm.ShowDialog();
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                "1660469414858664",
                "public_profile",
                "user_photos",
                "user_location",
                "user_gender",
                "user_birthday",
                "user_friends",
                "user_photos",
                "user_posts",
                "user_likes",
                "email"
            );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) && m_LoginResult.LoggedInUser != null)
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                updateLoginUI();
                populateProfile();
            }
            else
            {
                m_LoginResult = null;
            }
        }

        private void updateLoginUI()
        {
            buttonLogin.BackColor = Color.LightGreen;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            btnDayInHistory.Enabled = true;
            btnDayInHistory.Visible = true;
        }

        private async void populateProfile()
        {
            pictureBoxLoading.Visible = true;

            setProfileInfo();
            initializeLists();
            await loadAlbums();
            initializeGamesTab();

            setProfilePicture();
            toggleUIElements(true);
        }

        private void setProfileInfo()
        {
            labelName.Text = m_LoggedInUser.Name;
            labelHouse.Text = m_LoggedInUser?.Location?.Name ?? "Not specified";
            labelGender.Text = m_LoggedInUser?.Gender?.ToString() ?? "Not specified";
            labelRelationship.Text = m_LoggedInUser?.RelationshipStatus?.ToString() ?? "Not specified";
            labelBirthDay.Text = m_LoggedInUser?.Birthday ?? "Not specified";
        }

        private void initializeLists()
        {
            initializeFriendsList();
            initializeLikedPagesList();
            initializePostsList();
        }

        private void initializeFriendsList()
        {
            listboxFriends.Items.Clear();
            if (m_LoggedInUser.Friends != null)
            {
                int amount = m_LoggedInUser.Friends.Count;
                labelFriends.Text = $"Friends: ({amount})";
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listboxFriends.Items.Add(friend.Name);
                }
            }
        }

        private void initializeLikedPagesList()
        {
            listboxLikedPages.Items.Clear();
            if (m_LoggedInUser.LikedPages != null)
            {
                int amount = m_LoggedInUser.LikedPages.Count;
                labelLikedPages.Text = $"Liked Pages: ({amount})";
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listboxLikedPages.Items.Add(page.Name);
                }
            }
        }

        private void initializePostsList()
        {
            flowLayoutPanelPosts.Controls.Clear();

            if (m_LoggedInUser?.Posts != null)
            {
                int amount = m_LoggedInUser.Posts.Count;
                labelPosts.Text = $"Posts: ({amount})";

                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.Message != null || post.PictureURL != null)
                    {
                        FacebookPostControl postControl = new FacebookPostControl();
                        postControl.SetPostData(post);
                        flowLayoutPanelPosts.Controls.Add(postControl);
                    }
                }
            }
        }

        private void initializeGamesTab()
        {
            m_GamesManager = new GamesManager(m_LoginResult);
            m_GamesManager.CreateGamesTab(tabControl);
        }

        private void setProfilePicture()
        {
            pictureBoxProfile.Image = !string.IsNullOrEmpty(m_LoggedInUser.PictureLargeURL)
                ? loadImageFromUrl(m_LoggedInUser.PictureLargeURL)
                : Properties.Resources.blank_face;
        }

        private Image loadImageFromUrl(string i_Url)
        {
            try
            {
                var request = System.Net.WebRequest.Create(i_Url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
            catch
            {
                return Properties.Resources.blank_face;
            }
        }

        private void toggleUIElements(bool i_Visible)
        {
            aboutPanel.Visible = i_Visible;
            profilePanel.Visible = i_Visible;
            pictureBoxLoading.Visible = !i_Visible;
        }

        private async Task loadAlbums()
        {
            initializeAlbumsTab();

            if (m_LoggedInUser?.Albums != null)
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    await addAlbumToFlowLayoutPanel(album);
                }
                m_AlbumsTabPage.Enabled = true;
            }
        }

        private void initializeAlbumsTab()
        {
            m_AlbumsTabPage = new TabPage("Albums");
            m_AlbumsTabPage.Enabled = false;
            tabControl.TabPages.Add(m_AlbumsTabPage);
            m_AlbumsFlowLayoutPanel = new FlowLayoutPanel();
            m_AlbumsFlowLayoutPanel.Dock = DockStyle.Fill;
            m_AlbumsFlowLayoutPanel.AutoScroll = true;
            m_AlbumsTabPage.Controls.Add(m_AlbumsFlowLayoutPanel);
        }

        private async Task addAlbumToFlowLayoutPanel(Album i_Album)
        {
            Panel albumPanel = new Panel();
            albumPanel.Width = 150;
            albumPanel.Height = 180;
            albumPanel.BorderStyle = BorderStyle.FixedSingle;
            albumPanel.Tag = i_Album;
            albumPanel.Click += albumPanel_Click;

            PictureBox albumThumbnailPictureBox = new PictureBox();
            albumThumbnailPictureBox.Width = 140;
            albumThumbnailPictureBox.Height = 140;
            albumThumbnailPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            albumThumbnailPictureBox.Dock = DockStyle.Top;

            Label albumNameLabel = new Label();
            albumNameLabel.Text = i_Album.Name;
            albumNameLabel.Dock = DockStyle.Bottom;
            albumNameLabel.TextAlign = ContentAlignment.MiddleCenter;

            if (!string.IsNullOrEmpty(i_Album.PictureAlbumURL))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        byte[] imageBytes = await client.GetByteArrayAsync(i_Album.PictureAlbumURL);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            albumThumbnailPictureBox.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading album image: {ex.Message}");
                    albumThumbnailPictureBox.Image = null;
                }
            }

            albumPanel.Controls.Add(albumThumbnailPictureBox);
            albumPanel.Controls.Add(albumNameLabel);
            m_AlbumsFlowLayoutPanel.Controls.Add(albumPanel);
        }

        private void albumPanel_Click(object i_Sender, EventArgs i_EventArgs)
        {
            Panel clickedPanel = (Panel)i_Sender;
            Album album = clickedPanel.Tag as Album;

            if (album != null)
            {
                AlbumPhotosForm albumPhotosForm = new AlbumPhotosForm(album);
                albumPhotosForm.Show();
            }
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_EventArgs)
        {
            FacebookService.Logout();
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            btnDayInHistory.Enabled = false;
            btnDayInHistory.Visible = false;
            formCleanUp();
        }

        private void formCleanUp()
        {
            labelName.Text = string.Empty;
            labelHouse.Text = string.Empty;
            labelGender.Text = string.Empty;
            labelRelationship.Text = string.Empty;
            labelBirthDay.Text = string.Empty;
            pictureBoxProfile.Image = Properties.Resources.blank_face;
            aboutPanel.Visible = false;
            profilePanel.Visible = false;
            listboxFriends.Items.Clear();
            listboxLikedPages.Items.Clear();
            flowLayoutPanelPosts.Controls.Clear();
            if (m_AlbumsFlowLayoutPanel != null)
            {
                m_AlbumsFlowLayoutPanel.Controls.Clear();
            }
            if (tabControl.TabPages.Contains(m_AlbumsTabPage))
            {
                tabControl.TabPages.Remove(m_AlbumsTabPage);
            }
            m_LoggedInUser = null;
        }
    }
}
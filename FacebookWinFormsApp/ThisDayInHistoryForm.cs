using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Controllers;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class ThisDayInHistoryForm : Form
    {
        private readonly User m_LoggedInUser;
        private readonly DateTime m_Today;
        private TabControl m_TabControl;
        private TabPage m_PostsTab;
        private FlowLayoutPanel m_PostsFlowPanel;
        private TabPage m_PhotosTab;
        private FlowLayoutPanel m_PhotosFlowPanel;
        private bool m_FoundPosts;
        private bool m_FoundPhotos;

        public ThisDayInHistoryForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_Today = DateTime.Today;
            m_TabControl = new TabControl();
            m_PostsTab = new TabPage("Posts");
            m_PostsFlowPanel = new FlowLayoutPanel();
            m_PhotosTab = new TabPage("Photos");
            m_PhotosFlowPanel = new FlowLayoutPanel();
            m_FoundPosts = false;
            m_FoundPhotos = false;

            initializeUIComponents();
            loadHistoryData();
        }

        private void initializeUIComponents()
        {
            this.Text = $"This Day in History - {m_Today:MMMM d}";
            this.Size = new Size(900, 700);

            m_TabControl.Dock = DockStyle.Fill;
            this.Controls.Add(m_TabControl);

            // Posts Tab

            m_TabControl.TabPages.Add(m_PostsTab);
            m_PostsFlowPanel.Dock = DockStyle.Fill;
            m_PostsFlowPanel.AutoScroll = true;
            m_PostsTab.Controls.Add(m_PostsFlowPanel);

            // Photos Tab

            m_TabControl.TabPages.Add(m_PhotosTab);
            m_PhotosFlowPanel.Dock = DockStyle.Fill;
            m_PhotosFlowPanel.AutoScroll = true;
            m_PhotosTab.Controls.Add(m_PhotosFlowPanel);
        }

        private void loadHistoryData()
        {
            try
            {
                loadHistoricalPosts();
                loadHistoricalPhotos();
            }
            catch (Exception i_Ex)
            {
                MessageBox.Show($"Error loading history data: {i_Ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadHistoricalPosts()
        {
            m_PostsFlowPanel.Controls.Clear();
            m_FoundPosts = false;

            if (m_LoggedInUser?.Posts == null)
            {
                showNoContentMessage(m_PostsFlowPanel, "No posts data available");
                return;
            }


            foreach (Post i_Post in m_LoggedInUser.Posts)
            {
                if (i_Post?.CreatedTime.HasValue == true &&
                    i_Post.CreatedTime.Value.Month == m_Today.Month &&
                    i_Post.CreatedTime.Value.Day == m_Today.Day)
                {
                    try
                    {
                        FacebookPostControl i_PostControl = new FacebookPostControl();
                        i_PostControl.SetPostData(i_Post);
                        m_PostsFlowPanel.Controls.Add(i_PostControl);
                        i_PostControl.Width = 600;
                        m_FoundPosts = true;
                    }
                    catch (Exception i_Ex)
                    {
                        Console.WriteLine($"Error loading post: {i_Ex.Message}");
                    }
                }
            }

            if (!m_FoundPosts)
            {
                showNoContentMessage(m_PostsFlowPanel, "No posts found for this date in previous years");
            }
        }

        private void loadHistoricalPhotos()
        {
            m_PhotosFlowPanel.Controls.Clear();
            m_FoundPhotos = false;

            if (m_LoggedInUser?.Albums == null)
            {
                showNoContentMessage(m_PhotosFlowPanel, "No albums data available");
                return;
            }


            foreach (Album i_Album in m_LoggedInUser.Albums)
            {
                if (i_Album?.Photos == null) continue;

                foreach (Photo i_Photo in i_Album.Photos)
                {
                    if (i_Photo?.CreatedTime.HasValue == true &&
                        i_Photo.CreatedTime.Value.Month == m_Today.Month &&
                        i_Photo.CreatedTime.Value.Day == m_Today.Day)
                    {
                        try
                        {
                            PictureBox i_PhotoBox = new PictureBox();
                            i_PhotoBox.SizeMode = PictureBoxSizeMode.Zoom;
                            i_PhotoBox.Width = 300;
                            i_PhotoBox.Height = 200;
                            i_PhotoBox.LoadAsync(i_Photo.PictureNormalURL);
                            m_PhotosFlowPanel.Controls.Add(i_PhotoBox);
                            m_FoundPhotos = true;
                        }
                        catch (Exception i_Ex)
                        {
                            Console.WriteLine($"Error loading photo: {i_Ex.Message}");
                        }
                    }
                }
            }

            if (!m_FoundPhotos)
            {
                showNoContentMessage(m_PhotosFlowPanel, "No photos found for this date in previous years");
            }
        }

        private void showNoContentMessage(Control i_ParentControl, string i_Message)
        {
            Label i_NoContentLabel = new Label();
            i_NoContentLabel.Text = i_Message;
            i_NoContentLabel.AutoSize = true;
            i_NoContentLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            i_NoContentLabel.TextAlign = ContentAlignment.MiddleCenter;
            i_NoContentLabel.Dock = DockStyle.Fill;
            i_ParentControl.Controls.Add(i_NoContentLabel);
        }
    }
}
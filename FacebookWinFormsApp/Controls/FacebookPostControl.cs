using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Controllers
{
    public partial class FacebookPostControl : UserControl
    {
        public FacebookPostControl()
        {
            InitializeComponent();
        }

        public void SetPostData(Post i_Post)
        {
            UserNameLabel.Text = i_Post.Name ?? "Unknown User";
            PostContentLabel.Text = i_Post.Message ?? "";
            CreatedTimeLabel.Text = i_Post.CreatedTime.ToString();

            if (!string.IsNullOrEmpty(i_Post.PictureURL))
            {
                try
                {
                    pictureBoxPost.Load(i_Post.PictureURL);
                    pictureBoxPost.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading post image: {ex.Message}");
                    pictureBoxPost.Image = null;
                    pictureBoxPost.Visible = false;
                }
            }
            else
            {
                pictureBoxPost.Image = null;
                pictureBoxPost.Visible = false;
            }

            AdjustLayout();
        }

        private void AdjustLayout()
        {
            if (!pictureBoxPost.Visible)
            {
                this.Height = UserNameLabel.Height + PostContentLabel.Height + 10;
            }
            else
            {
                this.Height = UserNameLabel.Height + PostContentLabel.Height + pictureBoxPost.Height + 3;
            }
        }
    }
}

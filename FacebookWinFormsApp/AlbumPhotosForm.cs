using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class AlbumPhotosForm : Form
    {
        private FacebookWrapper.ObjectModel.Album m_SelectedAlbum;

        public AlbumPhotosForm(FacebookWrapper.ObjectModel.Album i_Album)
        {
            InitializeComponent();
            m_SelectedAlbum = i_Album;
            labelAlbum.Text = $"{i_Album.Name} ({i_Album.Count}):";
            LoadPhotos();
        }

        private async Task LoadPhotos()
        {
            if (m_SelectedAlbum?.Photos != null)
            {

                foreach (Photo photo in m_SelectedAlbum.Photos)
                {
                    Panel photoPanel = new Panel();
                    photoPanel.Width = 150;
                    photoPanel.Height = 180;
                    photoPanel.BorderStyle = BorderStyle.FixedSingle;

                    PictureBox photoPictureBox = new PictureBox();
                    photoPictureBox.Width = 140;
                    photoPictureBox.Height = 140;
                    photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    photoPictureBox.Dock = DockStyle.Top;

                    if (!string.IsNullOrEmpty(photo.PictureNormalURL))
                    {
                        try
                        {
                            using (HttpClient client = new HttpClient())
                            {
                                byte[] imageBytes = await client.GetByteArrayAsync(photo.PictureNormalURL);
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    photoPictureBox.Image = Image.FromStream(ms);
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading photo image: {ex.Message}");
                            photoPictureBox.Image = null;
                        }
                    }

                    photoPanel.Controls.Add(photoPictureBox);
                    flowLayoutPanel.Controls.Add(photoPanel);
                }
            }
        }
    }
}
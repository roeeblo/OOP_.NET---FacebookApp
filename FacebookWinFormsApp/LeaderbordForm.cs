using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm(Leaderboard i_Leaderboard)
        {
            InitializeComponent();
            this.ClientSize = new Size(500, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = SystemColors.Control;

            PictureBox trophyPic = new PictureBox
            {
                Image = Properties.Resources.Trophy,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(64, 64),
                Location = new Point(20, 20),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            this.Controls.Add(trophyPic);

            Label title = new Label
            {
                Text = "My Facebook Friends Leaderboard",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(100, 30),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            this.Controls.Add(title);

            dataGridViewLeaderboard.Location = new Point(20, 100);
            dataGridViewLeaderboard.Size = new Size(460, 400);
            dataGridViewLeaderboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLeaderboard.BackgroundColor = SystemColors.Window;
            dataGridViewLeaderboard.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewLeaderboard.RowHeadersVisible = false;

            Label pointsLabel = new Label
            {
                Text = "Points: Like=1 • Comment=3 • Share=5",
                Font = new Font("Arial", 8),
                ForeColor = Color.Gray,
                Location = new Point(20, 510),
                AutoSize = true,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            this.Controls.Add(pointsLabel);

            displayLeaderboard(i_Leaderboard);
        }

        private void displayLeaderboard(Leaderboard i_Leaderboard)
        {
            dataGridViewLeaderboard.DataSource = i_Leaderboard.Rankings;
            dataGridViewLeaderboard.Columns["UserId"].Visible = false;
            dataGridViewLeaderboard.Columns["UserName"].HeaderText = "Fan Name";
            dataGridViewLeaderboard.Columns["Score"].HeaderText = "Points";
        }
    }
}
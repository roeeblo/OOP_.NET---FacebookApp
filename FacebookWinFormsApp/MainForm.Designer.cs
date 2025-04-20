namespace BasicFacebookFeatures
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelRelationship = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.btnDayInHistory = new System.Windows.Forms.Button();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listboxLikedPages = new System.Windows.Forms.ListBox();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.listboxFriends = new System.Windows.Forms.ListBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1243, 697);
            this.tabControl.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxLoading);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.aboutPanel);
            this.tabPage1.Controls.Add(this.profilePanel);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(1149, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Roee Bloch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(1133, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Oren Ilutowich";
            // 
            // aboutPanel
            // 
            this.aboutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutPanel.Controls.Add(this.labelName);
            this.aboutPanel.Controls.Add(this.labelBirthDay);
            this.aboutPanel.Controls.Add(this.labelRelationship);
            this.aboutPanel.Controls.Add(this.labelGender);
            this.aboutPanel.Controls.Add(this.labelHouse);
            this.aboutPanel.Controls.Add(this.pictureBox4);
            this.aboutPanel.Controls.Add(this.pictureBox3);
            this.aboutPanel.Controls.Add(this.pictureBox2);
            this.aboutPanel.Controls.Add(this.pictureBox1);
            this.aboutPanel.Location = new System.Drawing.Point(19, 220);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(236, 424);
            this.aboutPanel.TabIndex = 58;
            this.aboutPanel.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelName.Location = new System.Drawing.Point(3, -1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 24);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDay.ForeColor = System.Drawing.Color.Black;
            this.labelBirthDay.Location = new System.Drawing.Point(47, 193);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(107, 24);
            this.labelBirthDay.TabIndex = 8;
            this.labelBirthDay.Text = "Unavaliable";
            // 
            // labelRelationship
            // 
            this.labelRelationship.AutoSize = true;
            this.labelRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelationship.ForeColor = System.Drawing.Color.Black;
            this.labelRelationship.Location = new System.Drawing.Point(47, 143);
            this.labelRelationship.Name = "labelRelationship";
            this.labelRelationship.Size = new System.Drawing.Size(107, 24);
            this.labelRelationship.TabIndex = 7;
            this.labelRelationship.Text = "Unavaliable";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(47, 95);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(107, 24);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Unavaliable";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHouse.ForeColor = System.Drawing.Color.Black;
            this.labelHouse.Location = new System.Drawing.Point(47, 46);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(107, 24);
            this.labelHouse.TabIndex = 5;
            this.labelHouse.Text = "Unavaliable";
            // 
            // profilePanel
            // 
            this.profilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePanel.Controls.Add(this.btnLeaderboard);
            this.profilePanel.Controls.Add(this.btnDayInHistory);
            this.profilePanel.Controls.Add(this.flowLayoutPanelPosts);
            this.profilePanel.Controls.Add(this.labelPosts);
            this.profilePanel.Controls.Add(this.listboxLikedPages);
            this.profilePanel.Controls.Add(this.labelLikedPages);
            this.profilePanel.Controls.Add(this.labelFriends);
            this.profilePanel.Controls.Add(this.listboxFriends);
            this.profilePanel.Location = new System.Drawing.Point(278, 20);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(760, 624);
            this.profilePanel.TabIndex = 57;
            this.profilePanel.Visible = false;
            // 
            // btnDayInHistory
            // 
            this.btnDayInHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayInHistory.Location = new System.Drawing.Point(345, 401);
            this.btnDayInHistory.Name = "btnDayInHistory";
            this.btnDayInHistory.Size = new System.Drawing.Size(180, 27);
            this.btnDayInHistory.TabIndex = 61;
            this.btnDayInHistory.Text = "This Day In Your History!";
            this.btnDayInHistory.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.AutoScroll = true;
            this.flowLayoutPanelPosts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(22, 38);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(503, 357);
            this.flowLayoutPanelPosts.TabIndex = 5;
            this.flowLayoutPanelPosts.WrapContents = false;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.Location = new System.Drawing.Point(18, 11);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(77, 24);
            this.labelPosts.TabIndex = 4;
            this.labelPosts.Text = "Posts ():";
            // 
            // listboxLikedPages
            // 
            this.listboxLikedPages.FormattingEnabled = true;
            this.listboxLikedPages.ItemHeight = 18;
            this.listboxLikedPages.Location = new System.Drawing.Point(22, 434);
            this.listboxLikedPages.Name = "listboxLikedPages";
            this.listboxLikedPages.Size = new System.Drawing.Size(503, 166);
            this.listboxLikedPages.TabIndex = 3;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikedPages.Location = new System.Drawing.Point(18, 407);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(135, 24);
            this.labelLikedPages.TabIndex = 2;
            this.labelLikedPages.Text = "Liked Pages ():";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(540, 11);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(96, 24);
            this.labelFriends.TabIndex = 1;
            this.labelFriends.Text = "Friends ():";
            // 
            // listboxFriends
            // 
            this.listboxFriends.FormattingEnabled = true;
            this.listboxFriends.ItemHeight = 18;
            this.listboxFriends.Location = new System.Drawing.Point(544, 38);
            this.listboxFriends.Name = "listboxFriends";
            this.listboxFriends.Size = new System.Drawing.Size(196, 562);
            this.listboxFriends.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(1067, 79);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(159, 51);
            this.buttonLogout.TabIndex = 56;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(1067, 20);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(159, 51);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.Location = new System.Drawing.Point(642, 11);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(98, 24);
            this.btnLeaderboard.TabIndex = 62;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::BasicFacebookFeatures.Properties.Resources.loading;
            this.pictureBoxLoading.Location = new System.Drawing.Point(1062, 137);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(167, 154);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 6;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BasicFacebookFeatures.Properties.Resources.cake;
            this.pictureBox4.Location = new System.Drawing.Point(7, 187);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BasicFacebookFeatures.Properties.Resources.heart;
            this.pictureBox3.Location = new System.Drawing.Point(7, 137);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BasicFacebookFeatures.Properties.Resources.gender;
            this.pictureBox2.Location = new System.Drawing.Point(7, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.house;
            this.pictureBox1.Location = new System.Drawing.Point(7, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::BasicFacebookFeatures.Properties.Resources.blank_face;
            this.pictureBoxProfile.InitialImage = global::BasicFacebookFeatures.Properties.Resources.blank_face;
            this.pictureBoxProfile.Location = new System.Drawing.Point(19, 20);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(236, 179);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelHouse;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label labelRelationship;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.ListBox listboxFriends;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.ListBox listboxLikedPages;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Button btnDayInHistory;
        private System.Windows.Forms.Button btnLeaderboard;
    }
}


namespace BasicFacebookFeatures.Controllers
{
    partial class FacebookPostControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PostContentLabel = new System.Windows.Forms.Label();
            this.CreatedTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Location = new System.Drawing.Point(0, 43);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(283, 177);
            this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPost.TabIndex = 0;
            this.pictureBoxPost.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.UserNameLabel.Location = new System.Drawing.Point(0, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(95, 22);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "UserName";
            // 
            // PostContentLabel
            // 
            this.PostContentLabel.AutoSize = true;
            this.PostContentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostContentLabel.Location = new System.Drawing.Point(0, 22);
            this.PostContentLabel.Name = "PostContentLabel";
            this.PostContentLabel.Size = new System.Drawing.Size(91, 18);
            this.PostContentLabel.TabIndex = 2;
            this.PostContentLabel.Text = "PostContent";
            // 
            // CreatedTimeLabel
            // 
            this.CreatedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedTimeLabel.AutoSize = true;
            this.CreatedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedTimeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CreatedTimeLabel.Location = new System.Drawing.Point(224, 0);
            this.CreatedTimeLabel.Name = "CreatedTimeLabel";
            this.CreatedTimeLabel.Size = new System.Drawing.Size(93, 18);
            this.CreatedTimeLabel.TabIndex = 3;
            this.CreatedTimeLabel.Text = "TimeCreated";
            // 
            // FacebookPostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.CreatedTimeLabel);
            this.Controls.Add(this.PostContentLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.pictureBoxPost);
            this.Name = "FacebookPostControl";
            this.Size = new System.Drawing.Size(317, 219);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PostContentLabel;
        private System.Windows.Forms.Label CreatedTimeLabel;
    }
}

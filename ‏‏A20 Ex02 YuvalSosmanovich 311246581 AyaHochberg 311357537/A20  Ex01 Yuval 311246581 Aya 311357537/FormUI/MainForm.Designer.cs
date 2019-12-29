namespace FormsUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label religionLabel;
            this.friendsList = new System.Windows.Forms.ListBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.textForPost = new System.Windows.Forms.TextBox();
            this.postSubmitButton = new System.Windows.Forms.Button();
            this.postsList = new System.Windows.Forms.ListBox();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.mostLikedPicture = new System.Windows.Forms.PictureBox();
            this.linkFavoritePicture = new System.Windows.Forms.LinkLabel();
            this.postStatus = new System.Windows.Forms.Label();
            this.linkEvents = new System.Windows.Forms.LinkLabel();
            this.eventsList = new System.Windows.Forms.ListBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.pictureBoxSymbol = new System.Windows.Forms.PictureBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.checkInList = new System.Windows.Forms.ListBox();
            this.linkCheckIn = new System.Windows.Forms.LinkLabel();
            this.pagesList = new System.Windows.Forms.ListBox();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.gamePhoto = new System.Windows.Forms.PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.religionLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostLikedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePhoto)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // friendsList
            // 
            this.friendsList.BackColor = System.Drawing.Color.SkyBlue;
            this.friendsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friendsList.FormattingEnabled = true;
            this.friendsList.ItemHeight = 20;
            this.friendsList.Location = new System.Drawing.Point(421, 285);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(248, 182);
            this.friendsList.TabIndex = 3;
            this.friendsList.SelectedIndexChanged += new System.EventHandler(this.friendsList_SelectedIndexChanged);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(675, 283);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(129, 134);
            this.pictureBoxFriends.TabIndex = 4;
            this.pictureBoxFriends.TabStop = false;
            // 
            // textForPost
            // 
            this.textForPost.Location = new System.Drawing.Point(675, 39);
            this.textForPost.Name = "textForPost";
            this.textForPost.Size = new System.Drawing.Size(311, 26);
            this.textForPost.TabIndex = 5;
            // 
            // postSubmitButton
            // 
            this.postSubmitButton.BackColor = System.Drawing.Color.DimGray;
            this.postSubmitButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postSubmitButton.Location = new System.Drawing.Point(992, 33);
            this.postSubmitButton.Name = "postSubmitButton";
            this.postSubmitButton.Size = new System.Drawing.Size(99, 36);
            this.postSubmitButton.TabIndex = 6;
            this.postSubmitButton.Text = "post";
            this.postSubmitButton.UseVisualStyleBackColor = false;
            this.postSubmitButton.Click += new System.EventHandler(this.postSubmitButton_OnClick);
            // 
            // postsList
            // 
            this.postsList.BackColor = System.Drawing.Color.SkyBlue;
            this.postsList.DisplayMember = "Message";
            this.postsList.FormattingEnabled = true;
            this.postsList.ItemHeight = 20;
            this.postsList.Location = new System.Drawing.Point(31, 283);
            this.postsList.Name = "postsList";
            this.postsList.Size = new System.Drawing.Size(384, 184);
            this.postsList.TabIndex = 8;
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFriends.LinkColor = System.Drawing.Color.White;
            this.linkFriends.Location = new System.Drawing.Point(417, 257);
            this.linkFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(132, 23);
            this.linkFriends.TabIndex = 10;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends ➔";
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPosts.LinkColor = System.Drawing.Color.White;
            this.linkPosts.Location = new System.Drawing.Point(27, 257);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(114, 23);
            this.linkPosts.TabIndex = 12;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts ➔";
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // mostLikedPicture
            // 
            this.mostLikedPicture.Location = new System.Drawing.Point(810, 728);
            this.mostLikedPicture.Margin = new System.Windows.Forms.Padding(2);
            this.mostLikedPicture.Name = "mostLikedPicture";
            this.mostLikedPicture.Size = new System.Drawing.Size(273, 308);
            this.mostLikedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mostLikedPicture.TabIndex = 14;
            this.mostLikedPicture.TabStop = false;
            // 
            // linkFavoritePicture
            // 
            this.linkFavoritePicture.AutoSize = true;
            this.linkFavoritePicture.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFavoritePicture.LinkColor = System.Drawing.Color.White;
            this.linkFavoritePicture.Location = new System.Drawing.Point(808, 703);
            this.linkFavoritePicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkFavoritePicture.Name = "linkFavoritePicture";
            this.linkFavoritePicture.Size = new System.Drawing.Size(199, 23);
            this.linkFavoritePicture.TabIndex = 16;
            this.linkFavoritePicture.TabStop = true;
            this.linkFavoritePicture.Text = "My Most Liked Picture ➔";
            this.linkFavoritePicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFavoritePicture_LinkClicked);
            // 
            // postStatus
            // 
            this.postStatus.AutoSize = true;
            this.postStatus.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postStatus.Location = new System.Drawing.Point(671, 13);
            this.postStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postStatus.Name = "postStatus";
            this.postStatus.Size = new System.Drawing.Size(109, 23);
            this.postStatus.TabIndex = 17;
            this.postStatus.Text = "Post Status:";
            // 
            // linkEvents
            // 
            this.linkEvents.AutoSize = true;
            this.linkEvents.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEvents.LinkColor = System.Drawing.Color.White;
            this.linkEvents.Location = new System.Drawing.Point(419, 485);
            this.linkEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkEvents.Name = "linkEvents";
            this.linkEvents.Size = new System.Drawing.Size(125, 23);
            this.linkEvents.TabIndex = 19;
            this.linkEvents.TabStop = true;
            this.linkEvents.Text = "Fetch Events ➔";
            this.linkEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEvents_LinkClicked);
            // 
            // eventsList
            // 
            this.eventsList.BackColor = System.Drawing.Color.SkyBlue;
            this.eventsList.FormattingEnabled = true;
            this.eventsList.ItemHeight = 20;
            this.eventsList.Location = new System.Drawing.Point(421, 510);
            this.eventsList.Margin = new System.Windows.Forms.Padding(2);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(250, 184);
            this.eventsList.TabIndex = 20;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(675, 510);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(129, 111);
            this.pictureBoxEvent.TabIndex = 22;
            this.pictureBoxEvent.TabStop = false;
            // 
            // pictureBoxSymbol
            // 
            this.pictureBoxSymbol.BackColor = System.Drawing.Color.White;
            this.pictureBoxSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSymbol.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSymbol.Image")));
            this.pictureBoxSymbol.Location = new System.Drawing.Point(24, 27);
            this.pictureBoxSymbol.Name = "pictureBoxSymbol";
            this.pictureBoxSymbol.Size = new System.Drawing.Size(90, 86);
            this.pictureBoxSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSymbol.TabIndex = 23;
            this.pictureBoxSymbol.TabStop = false;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Gold;
            this.startGameButton.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.Black;
            this.startGameButton.Location = new System.Drawing.Point(31, 728);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(638, 53);
            this.startGameButton.TabIndex = 36;
            this.startGameButton.Text = "Click here and start playing";
            this.startGameButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_OnClick);
            // 
            // checkInList
            // 
            this.checkInList.BackColor = System.Drawing.Color.SkyBlue;
            this.checkInList.FormattingEnabled = true;
            this.checkInList.ItemHeight = 20;
            this.checkInList.Location = new System.Drawing.Point(810, 510);
            this.checkInList.Margin = new System.Windows.Forms.Padding(2);
            this.checkInList.Name = "checkInList";
            this.checkInList.Size = new System.Drawing.Size(258, 184);
            this.checkInList.TabIndex = 36;
            // 
            // linkCheckIn
            // 
            this.linkCheckIn.AutoSize = true;
            this.linkCheckIn.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCheckIn.LinkColor = System.Drawing.Color.White;
            this.linkCheckIn.Location = new System.Drawing.Point(811, 485);
            this.linkCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkCheckIn.Name = "linkCheckIn";
            this.linkCheckIn.Size = new System.Drawing.Size(140, 23);
            this.linkCheckIn.TabIndex = 37;
            this.linkCheckIn.TabStop = true;
            this.linkCheckIn.Text = "Fetch Checkins ➔";
            this.linkCheckIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCheckIn_OnClick);
            // 
            // pagesList
            // 
            this.pagesList.BackColor = System.Drawing.Color.SkyBlue;
            this.pagesList.FormattingEnabled = true;
            this.pagesList.ItemHeight = 20;
            this.pagesList.Location = new System.Drawing.Point(31, 510);
            this.pagesList.Margin = new System.Windows.Forms.Padding(2);
            this.pagesList.Name = "pagesList";
            this.pagesList.Size = new System.Drawing.Size(384, 184);
            this.pagesList.TabIndex = 38;
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPages.LinkColor = System.Drawing.Color.White;
            this.linkPages.Location = new System.Drawing.Point(27, 485);
            this.linkPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(161, 23);
            this.linkPages.TabIndex = 39;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "Fetch Liked Pages ➔";
            this.linkPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPages_OnClick);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.White;
            this.logOutButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.Black;
            this.logOutButton.Location = new System.Drawing.Point(3, 159);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(145, 39);
            this.logOutButton.TabIndex = 40;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_OnClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(170, 4);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(130, 23);
            this.descriptionLabel.TabIndex = 41;
            this.descriptionLabel.Text = "My Information";
            // 
            // gamePhoto
            // 
            this.gamePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePhoto.Image = ((System.Drawing.Image)(resources.GetObject("gamePhoto.Image")));
            this.gamePhoto.Location = new System.Drawing.Point(31, 728);
            this.gamePhoto.Name = "gamePhoto";
            this.gamePhoto.Size = new System.Drawing.Size(640, 304);
            this.gamePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamePhoto.TabIndex = 44;
            this.gamePhoto.TabStop = false;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(birthdayLabel);
            this.panelInfo.Controls.Add(this.birthdayLabel1);
            this.panelInfo.Controls.Add(emailLabel);
            this.panelInfo.Controls.Add(this.emailLabel1);
            this.panelInfo.Controls.Add(this.imageNormalPictureBox);
            this.panelInfo.Controls.Add(nameLabel);
            this.panelInfo.Controls.Add(this.nameLabel1);
            this.panelInfo.Controls.Add(religionLabel);
            this.panelInfo.Controls.Add(this.religionLabel1);
            this.panelInfo.Controls.Add(this.descriptionLabel);
            this.panelInfo.Controls.Add(this.logOutButton);
            this.panelInfo.Location = new System.Drawing.Point(120, 27);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(499, 207);
            this.panelInfo.TabIndex = 45;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(170, 41);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(71, 20);
            birthdayLabel.TabIndex = 41;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(247, 41);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(202, 23);
            this.birthdayLabel1.TabIndex = 42;
            this.birthdayLabel1.Text = "label1";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(170, 68);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 43;
            emailLabel.Text = "Email:";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(247, 66);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(214, 28);
            this.emailLabel1.TabIndex = 44;
            this.emailLabel1.Text = "label1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(145, 150);
            this.imageNormalPictureBox.TabIndex = 46;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(170, 97);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 47;
            nameLabel.Text = "Name:";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(247, 94);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(214, 23);
            this.nameLabel1.TabIndex = 48;
            this.nameLabel1.Text = "label1";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.Location = new System.Drawing.Point(171, 125);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(70, 20);
            religionLabel.TabIndex = 49;
            religionLabel.Text = "Religion:";
            // 
            // religionLabel1
            // 
            this.religionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true));
            this.religionLabel1.Location = new System.Drawing.Point(247, 125);
            this.religionLabel1.Name = "religionLabel1";
            this.religionLabel1.Size = new System.Drawing.Size(225, 25);
            this.religionLabel1.TabIndex = 50;
            this.religionLabel1.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1431, 1036);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.linkPages);
            this.Controls.Add(this.pagesList);
            this.Controls.Add(this.linkCheckIn);
            this.Controls.Add(this.checkInList);
            this.Controls.Add(this.pictureBoxSymbol);
            this.Controls.Add(this.gamePhoto);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.eventsList);
            this.Controls.Add(this.linkEvents);
            this.Controls.Add(this.postStatus);
            this.Controls.Add(this.linkFavoritePicture);
            this.Controls.Add(this.mostLikedPicture);
            this.Controls.Add(this.linkPosts);
            this.Controls.Add(this.linkFriends);
            this.Controls.Add(this.postsList);
            this.Controls.Add(this.postSubmitButton);
            this.Controls.Add(this.textForPost);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.friendsList);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostLikedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePhoto)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox friendsList;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.TextBox textForPost;
        private System.Windows.Forms.Button postSubmitButton;
        private System.Windows.Forms.ListBox postsList;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.PictureBox mostLikedPicture;
        private System.Windows.Forms.LinkLabel linkFavoritePicture;
        private System.Windows.Forms.Label postStatus;
        private System.Windows.Forms.LinkLabel linkEvents;
        private System.Windows.Forms.ListBox eventsList;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.PictureBox pictureBoxSymbol;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.ListBox checkInList;
        private System.Windows.Forms.LinkLabel linkCheckIn;
        private System.Windows.Forms.ListBox pagesList;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox gamePhoto;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label religionLabel1;
    }
}


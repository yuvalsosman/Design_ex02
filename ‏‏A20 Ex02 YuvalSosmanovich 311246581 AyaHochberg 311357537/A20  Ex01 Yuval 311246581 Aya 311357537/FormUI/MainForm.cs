using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FormsUI.FacebookAppLogic;

namespace FormsUI
{
    public partial class MainForm : Form
    {
        public static AppSettings s_AppSettings;
        private FormFactory formFactory;
        private MainFormFacade mainFormFacade;

        public MainForm()
        {
            InitializeComponent();
            mainFormFacade = new MainFormFacade();
            formFactory = new FormFactory();
            userBindingSource.DataSource = MainFormFacade.s_LoginUser;
            initializeForm();
        }

        private void initializeForm()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Size = s_AppSettings.LastWindowSize;
            this.Location = s_AppSettings.LastWindowLocation;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            saveAppSettingsBeforeFormClosing();
        }

        private void friendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainFormFacade.fetchFriendsList();
            friendsBindingSource.DataSource = mainFormFacade.friendList;
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainFormFacade.fetchPosts();
            postBindingSource.DataSource = mainFormFacade.postsList;
        }

        private void linkFavoritePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainFormFacade.fetchFavoritePicture();
            photoBindingSource.DataSource = mainFormFacade.favoritePicture;
        }

        private void LinkCheckIn_OnClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainFormFacade.fetchCheckIn();
            checkinsBindingSource.DataSource = mainFormFacade.checkinList;
        }

        private void LinkPages_OnClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainFormFacade.fetchPages();
            likedPagesBindingSource.DataSource = mainFormFacade.pagesList;
        }

        private void linkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainFormFacade.fetchEvents();
            eventBindingSource.DataSource = mainFormFacade.eventList;
        }

        private void startGameButton_OnClick(object sender, EventArgs e)
        {
            startGame();
        }

        private void logOutButton_OnClick(object sender, EventArgs e)
        {
            logOut();
        }

        private void displaySelectedFriend()
        {
            if (userListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = userListBox.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriends.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriends.Image = pictureBoxFriends.ErrorImage;
                }
            }
            userListBox.SelectedItems.Clear();
        }

        private void eventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventListBox.SelectedItems.Count == 1)
            {
                Event selectedEvent = eventListBox.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
            }
        }

        private void postSubmitButton_OnClick(object sender, EventArgs e)
        {
            postSubmit();
        }

        private void postSubmit()
        {
            try
            {
                Status postedStatus = MainFormFacade.s_LoginUser.PostStatus(textForPost.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Somthing went wrong... error message: {0}", e.Message));
            }
        }

        private void startGame()
        {
            if (mainFormFacade.friendList.Count > 0)
            {
                Form gameForm = formFactory.createForm(Utils.eFormName.Game);
                if (gameForm != null)
                {
                    gameForm.Show();
                }
            }
            else
            {
                MessageBox.Show(MainFormFacade.k_EmptyFriendListMessage);
            }
        }

        private void logOut()
        {
            s_AppSettings.LastAccessToken = string.Empty;
            s_AppSettings.RememberUser = false;
            s_AppSettings.SaveToFile();
            Application.Exit();
        }

        private void saveAppSettingsBeforeFormClosing()
        {
            s_AppSettings.LastWindowLocation = this.Location;
            s_AppSettings.LastWindowSize = this.Size;
            s_AppSettings.SaveToFile();
            Application.Exit();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FormsUI.FacebookAppLogic;

namespace FormsUI
{
    public partial class MainForm : Form
    {
        private const string k_EmptyFriendListMessage = "Your friend list is empty, please return to the main page and fetch friend list:)";
        private const string k_NoDataToFetchMessage = "No data to retrieve :(";
        private const string k_FetchPerrmissionDenyMessage = "You dont have permmissions for fetching this Item - we are sorry :( , message error: {0}";
        public static User s_LoginUser;
        public static List<User> s_FriendList = new List<User>();
        public static AppSettings s_AppSettings;
        private FormFactory formFactory;

        public MainForm()
        {
            formFactory = new FormFactory();
            InitializeComponent();
            userBindingSource.DataSource = s_LoginUser;
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
            fetchFriendsList();
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void linkFavoritePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFavoritePicture();
        }

        private void LinkCheckIn_OnClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchCheckIn();
        }

        private void LinkPages_OnClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPages();
        }

        private void linkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void postSubmitButton_OnClick(object sender, EventArgs e)
        {
            postSubmit();
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
            if (friendsList.SelectedItems.Count == 1)
            {
                User selectedFriend = friendsList.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriends.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriends.Image = pictureBoxFriends.ErrorImage;
                }
            }
            friendsList.SelectedItems.Clear();
        }

        private void eventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsList.SelectedItems.Count == 1)
            {
                Event selectedEvent = eventsList.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
            }
        }

        private void fetchFriendsList()
        {
            friendsList.Items.Clear();
            friendsList.DisplayMember = "Name";
            try
            {
                foreach (User friend in s_LoginUser.Friends)
                {
                    friendsList.Items.Add(friend);
                    s_FriendList.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
                if (s_LoginUser.Friends.Count == 0)
                {
                    MessageBox.Show(k_NoDataToFetchMessage);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        private void fetchPosts()
        {
            try
            {

                foreach (Post post in s_LoginUser.Posts)
                {
                    if (!string.IsNullOrEmpty(post.Message))
                    {
                        postsList.Items.Add(post.Message);
                    }
                    else if (!string.IsNullOrEmpty(post.Caption))
                    {
                        postsList.Items.Add(post.Caption);
                    }
                }
                if (s_LoginUser.Posts.Count == 0)
                {
                    MessageBox.Show(k_NoDataToFetchMessage);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        private void fetchFavoritePicture()
        {
            Photo mostLikedPhoto = s_LoginUser.PhotosTaggedIn.First();
            try
            {
                foreach (Photo photo in s_LoginUser.PhotosTaggedIn)
                {
                    if (photo.LikedBy.Count > mostLikedPhoto.LikedBy.Count)
                    {
                        mostLikedPhoto = photo;
                    }
                }
                mostLikedPicture.LoadAsync(mostLikedPhoto.PictureNormalURL);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        private void fetchCheckIn()
        {
            try
            {
                foreach (Checkin checkin in s_LoginUser.Checkins)
                {
                    checkInList.Items.Add(checkin.Place.Name);
                }
                if (s_LoginUser.Checkins.Count == 0)
                {
                    MessageBox.Show(k_NoDataToFetchMessage);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        private void fetchPages()
        {
            pagesList.Items.Clear();
            pagesList.DisplayMember = "Name";
            try
            {
                foreach (Page page in s_LoginUser.LikedPages)
                {
                    pagesList.Items.Add(page);
                }
                if (s_LoginUser.LikedPages.Count == 0)
                {
                    MessageBox.Show(k_NoDataToFetchMessage);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        private void fetchEvents()
        {
            try
            {
                eventsList.Items.Clear();
                eventsList.DisplayMember = "Name";
                FacebookObjectCollection<Event> Events = s_LoginUser.Events;
                foreach (Event fbEvent in Events)
                {
                    eventsList.Items.Add(fbEvent);
                }
                if (s_LoginUser.Events.Count == 0)
                {
                    MessageBox.Show(k_NoDataToFetchMessage);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        private void postSubmit()
        {
            Status postedStatus = s_LoginUser.PostStatus(textForPost.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void startGame()
        {
            if (s_FriendList.Count > 0)
            {
                Form gameForm = formFactory.createForm(Utils.eFormName.Game);
                if(gameForm != null)
                {
                    gameForm.Show();
                }
            }
            else
            {
                MessageBox.Show(k_EmptyFriendListMessage);
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
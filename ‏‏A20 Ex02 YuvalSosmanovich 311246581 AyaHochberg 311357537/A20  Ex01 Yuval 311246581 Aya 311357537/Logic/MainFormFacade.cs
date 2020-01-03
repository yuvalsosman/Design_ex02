using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormsUI.FacebookAppLogic
{
    internal class MainFormFacade
    {
        internal const string k_EmptyFriendListMessage = "Your friend list is empty, please return to the main page and fetch friend list:)";
        private const string k_NoDataToFetchMessage = "No data to retrieve :(";
        private const string k_FetchPerrmissionDenyMessage = "You dont have permmissions for fetching this Item - we are sorry :( , message error: {0}";
        public static User s_LoginUser { get; set; }
        public static List<User> s_FriendList = new List<User>();

        public FacebookObjectCollection<Event> eventList { get; set; }
        public FacebookObjectCollection<User> friendList { get; set; }
        public FacebookObjectCollection<Post> postsList { get; set; }
        public FacebookObjectCollection<Checkin> checkinList { get; set; }
        public FacebookObjectCollection<Page> pagesList { get; set; }
        public Photo favoritePicture { get; set; }

        internal void fetchFriendsList()
        {
            friendList = new FacebookObjectCollection<User>();
            try
            {
                foreach (User friend in s_LoginUser.Friends)
                {
                    friendList.Add(friend);
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

        internal void fetchPosts()
        {
            postsList = new FacebookObjectCollection<Post>();
            try
            {
                foreach (Post post in s_LoginUser.Posts)
                {
                    if (!string.IsNullOrEmpty(post.Message) || !string.IsNullOrEmpty(post.Caption))
                    {
                        postsList.Add(post);
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

        internal void fetchFavoritePicture()
        {
            favoritePicture = s_LoginUser.PhotosTaggedIn.First();
            try
            {
                foreach (Photo photo in s_LoginUser.PhotosTaggedIn)
                {
                    if (photo.LikedBy.Count > favoritePicture.LikedBy.Count)
                    {
                        favoritePicture = photo;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        internal void fetchCheckIn()
        {
            checkinList = new FacebookObjectCollection<Checkin>();
            try
            {
                foreach (Checkin checkin in s_LoginUser.Checkins)
                {
                    checkinList.Add(checkin);
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

        internal void fetchPages()
        {
            pagesList = new FacebookObjectCollection<Page>();
            try
            {
                foreach (Page page in s_LoginUser.LikedPages)
                {
                    pagesList.Add(page);
                }
                if (s_LoginUser.LikedPages.Count == 0)
                {
                    MessageBox.Show(k_NoDataToFetchMessage);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        internal void fetchEvents()
        {
            eventList = new FacebookObjectCollection<Event>();
            try
            {
                FacebookObjectCollection<Event> Events = s_LoginUser.Events;
                foreach (Event fbEvent in Events)
                {
                    eventList.Add(fbEvent);
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

        //TODO: CALL FETCH ALL WITH NEW BUTTON
        internal void fetchAll()
        {
            fetchFriendsList();
            fetchPosts();
            fetchFavoritePicture();
            fetchCheckIn();
            fetchPages();
            fetchEvents();
        }

    }
}

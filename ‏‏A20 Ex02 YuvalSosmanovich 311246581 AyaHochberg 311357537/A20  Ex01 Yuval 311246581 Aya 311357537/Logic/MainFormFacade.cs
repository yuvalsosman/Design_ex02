using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormsUI.FacebookAppLogic
{
    internal class MainFormFacade
    {
        private const string k_NoDataToFetchMessage = "No data to retrieve :(";
        private const string k_FetchPerrmissionDenyMessage = "You dont have permmissions for fetching this Item - we are sorry :( , message error: {0}";
        internal const string k_EmptyFriendListMessage = "Your friend list is empty, please return to the main page and fetch friend list:)";
        internal static User s_LoginUser { get; set; }
        internal static List<User> s_FriendList { get; set; }
        internal FacebookObjectCollection<Event> m_EventList { get; set; }
        internal FacebookObjectCollection<User> m_FriendList { get; set; }
        internal FacebookObjectCollection<Post> m_PostsList { get; set; }
        internal FacebookObjectCollection<Checkin> m_CheckinList { get; set; }
        internal FacebookObjectCollection<Page> m_PagesList { get; set; }
        internal Photo m_FavoritePicture { get; set; }

        internal MainFormFacade()
        {
            s_FriendList = new List<User>();
        }

        internal void fetchFriendsList()
        {
            s_FriendList = new List<User>();
            m_FriendList = new FacebookObjectCollection<User>();
            try
            {
                if (s_LoginUser.Friends.Count == 0)
                {
                    MessageBox.Show(k_NoDataToFetchMessage);
                }
                else
                {
                    foreach (User friend in s_LoginUser.Friends)
                    {
                        m_FriendList.Add(friend);
                        s_FriendList.Add(friend);
                        friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        internal void fetchPosts()
        {
            m_PostsList = new FacebookObjectCollection<Post>();
            try
            {
                foreach (Post post in s_LoginUser.Posts)
                {
                    if (!string.IsNullOrEmpty(post.Message) || !string.IsNullOrEmpty(post.Caption))
                    {
                        m_PostsList.Add(post);
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
            m_FavoritePicture = s_LoginUser.PhotosTaggedIn.First();
            try
            {
                foreach (Photo photo in s_LoginUser.PhotosTaggedIn)
                {
                    if (photo.LikedBy.Count > m_FavoritePicture.LikedBy.Count)
                    {
                        m_FavoritePicture = photo;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        internal void fetchPages()
        {
            m_PagesList = new FacebookObjectCollection<Page>();
            try
            {
                foreach (Page page in s_LoginUser.LikedPages)
                {
                    m_PagesList.Add(page);
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
            m_EventList = new FacebookObjectCollection<Event>();
            try
            {
                FacebookObjectCollection<Event> Events = s_LoginUser.Events;
                foreach (Event fbEvent in Events)
                {
                    m_EventList.Add(fbEvent);
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

    }
}

﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormsUI.FacebookAppLogic
{
    internal sealed class MainFormFacade
    {
        private static readonly object sr_InstanceLockContext = new object();
        private static MainFormFacade s_MainFormFacadeInstance = null;
        internal User m_LoginUser { get; set; }
        internal static List<User> s_FriendList { get; set; }
        internal FacebookObjectCollection<Event> m_EventList { get; set; }
        internal FacebookObjectCollection<User> m_FriendList { get; set; }
        internal FacebookObjectCollection<Post> m_PostsList { get; set; }
        internal FacebookObjectCollection<Checkin> m_CheckinList { get; set; }
        internal FacebookObjectCollection<Page> m_PagesList { get; set; }
        internal Photo m_FavoritePicture { get; set; }

        private MainFormFacade()
        {
        }

        public static MainFormFacade GetInstance()
        {
            s_FriendList = new List<User>();
            if (s_MainFormFacadeInstance == null)
            {
                lock (sr_InstanceLockContext)
                {
                    if (s_MainFormFacadeInstance == null)
                    {
                        s_MainFormFacadeInstance = new MainFormFacade();
                    }
                }
            }
            return s_MainFormFacadeInstance;
        }

        internal void fetchFriendsList()
        {
            s_FriendList = new List<User>();
            m_FriendList = new FacebookObjectCollection<User>();
            try
            {
                if (m_LoginUser.Friends.Count == 0)
                {
                    MessageBox.Show(Utils.k_NoDataToFetchMessage);
                }
                else
                {
                    foreach (User friend in m_LoginUser.Friends)
                    {
                        m_FriendList.Add(friend);
                        s_FriendList.Add(friend);
                        friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(Utils.k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        internal void fetchPosts()
        {
            m_PostsList = new FacebookObjectCollection<Post>();
            try
            {
                foreach (Post post in m_LoginUser.Posts)
                {
                    if (!string.IsNullOrEmpty(post.Message) || !string.IsNullOrEmpty(post.Caption))
                    {
                        m_PostsList.Add(post);
                    }
                }
                if (m_LoginUser.Posts.Count == 0)
                {
                    MessageBox.Show(Utils.k_NoDataToFetchMessage);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(Utils.k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        internal void fetchFavoritePicture()
        {
            m_FavoritePicture = m_LoginUser.PhotosTaggedIn.First();
            try
            {
                foreach (Photo photo in m_LoginUser.PhotosTaggedIn)
                {
                    if (photo.LikedBy.Count > m_FavoritePicture.LikedBy.Count)
                    {
                        m_FavoritePicture = photo;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(Utils.k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        internal void fetchPages()
        {
            m_PagesList = new FacebookObjectCollection<Page>();
            try
            {
                foreach (Page page in m_LoginUser.LikedPages)
                {
                    m_PagesList.Add(page);
                }
                if (m_LoginUser.LikedPages.Count == 0)
                {
                    MessageBox.Show(Utils.k_NoDataToFetchMessage);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(Utils.k_FetchPerrmissionDenyMessage, e.Message));
            }
        }

        internal void fetchEvents()
        {
            m_EventList = new FacebookObjectCollection<Event>();
            try
            {
                FacebookObjectCollection<Event> Events = m_LoginUser.Events;
                foreach (Event fbEvent in Events)
                {
                    m_EventList.Add(fbEvent);
                }
                if (m_LoginUser.Events.Count == 0)
                {
                    MessageBox.Show(Utils.k_NoDataToFetchMessage);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format(Utils.k_FetchPerrmissionDenyMessage, e.Message));
            }
        }
    }
}

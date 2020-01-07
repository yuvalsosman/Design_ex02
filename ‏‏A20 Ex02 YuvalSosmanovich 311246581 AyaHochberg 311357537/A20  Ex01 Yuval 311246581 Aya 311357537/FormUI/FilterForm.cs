using FacebookWrapper.ObjectModel;
using FormsUI.FacebookAppLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class FilterForm : Form
    {

        private static HashSet<User> s_LikedList = new HashSet<User>();

        public FilterForm()
        {
            InitializeComponent();
        }

        private void filterSubmitButton_Click(object sender, EventArgs e)
        {
            filterFriendList();
        }

        private void filteredListOfFreinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayMatchPicture();
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            if (filteredListOfFreinds.SelectedItems.Count == 1)
            {
                User selectedFriend = filteredListOfFreinds.SelectedItem as User;
                s_LikedList.Add(selectedFriend);
            }
            else
            {
                MessageBox.Show(Utils.k_FetchBeforeClickLikeMessage);
            }
            filteredListOfFreinds.SelectedItems.Clear();
        }

        private void likedListButton_Click(object sender, EventArgs e)
        {
            this.filteredListOfFreinds.Items.Clear();
            this.filteredListOfFreinds.DisplayMember = "Name";
            if(s_LikedList.Count > 0)
            {
                foreach (User friend in s_LikedList)
                {
                    this.filteredListOfFreinds.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            else
            {
                MessageBox.Show(Utils.k_EmptyMatchListMessage);
            }


        }

        private void filterFriendList()
        {
            List<User> filteredListOfFreinds = new List<User>();
            filteredListOfFreinds = FilterFriendsLogic.FilterFriendLists(MainFormFacade.s_FriendList, maleCheckBox, femaleCheckBox, singleStatusCheckBox, relationshipStatusCheckBox, complicatedStatusCheckBox);
            this.filteredListOfFreinds.Items.Clear();
            this.filteredListOfFreinds.DisplayMember = "Name";

            if (filteredListOfFreinds.Count == 0)
            {
                MessageBox.Show(Utils.k_EmptyFilteredFriendListMessage);
            }
            if (MainFormFacade.s_FriendList.Count > 0)
            {
                foreach (User friend in filteredListOfFreinds)
                {
                    this.filteredListOfFreinds.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            else
            {
                MessageBox.Show(Utils.k_FetchBeforeFilterMessage);
            }
        }

        private void displayMatchPicture()
        {
            if (filteredListOfFreinds.SelectedItems.Count == 1)
            {
                User selectedFriend = filteredListOfFreinds.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    matchPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    matchPictureBox.Image = matchPictureBox.ErrorImage;
                }
            }
        }
    }
}

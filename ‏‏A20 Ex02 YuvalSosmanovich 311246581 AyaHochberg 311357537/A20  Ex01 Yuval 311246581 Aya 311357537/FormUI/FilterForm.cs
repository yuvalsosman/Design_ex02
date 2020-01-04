﻿using FacebookWrapper.ObjectModel;
using FormsUI.FacebookAppLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class FilterForm : Form
    {
        private const string k_EmptyFilteredFriendListMessage = "Your filtered friend list is empty, please change you filterparameters:)";
        private const string k_FetchBeforeFilterMessage = "You dont have friends in you friend list , please try to fecth firends to your friend list first and than try to filter again...";

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
            DisplayMatchPicture();
        }

        private void filterFriendList()
        {
            List<User> filteredListOfFreinds = new List<User>();
            filteredListOfFreinds = FilterFriendsLogic.FilterFriendLists(MainFormFacade.s_FriendList, maleCheckBox, femaleCheckBox, singleStatusCheckBox, relationshipStatusCheckBox, complicatedStatusCheckBox);
            this.filteredListOfFreinds.Items.Clear();
            this.filteredListOfFreinds.DisplayMember = "Name";

            if (filteredListOfFreinds.Count == 0)
            {
                MessageBox.Show(k_EmptyFilteredFriendListMessage);
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
                MessageBox.Show(k_FetchBeforeFilterMessage);
            }
        }

        private void DisplayMatchPicture()
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
            filteredListOfFreinds.SelectedItems.Clear();
        }
    }
}

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormsUI.FacebookAppLogic;

namespace FormsUI
{
    public partial class GameForm : Form
    {
        private const string k_WorngGuessMessage = "Worng guess, the name of the friend in the photo is: {0} ,try again or raffle to change photo..";
        private const string k_CorrectGuessMessage = "Great, You are a fantastic friend!!! :) , click raffle to keep gueesing";
        private const string k_EmptyFriendListMessage = "Your friend list is empty, please return to the main page and fetch friend list, than enter the game again :)";
        private GameFormLogic m_GameFormLogic = new GameFormLogic();
        private List<string> m_OptionListOfFriendsNames = new List<string>();
        private User m_CurrentUserToGuess;

        public GameForm()
        {
            InitializeComponent();
        }

        private void pickRandomFriendButton_OnClick(object sender, EventArgs e)
        {
            pickRandomFriendFromFriendList();
        }

        private void submitChosenNameButton_OnClick(object sender, EventArgs e)
        {
            selectFriendNameFromList();
        }

        private void pickRandomFriendFromFriendList()
        {
            resetForm();
            m_CurrentUserToGuess = m_GameFormLogic.GetCurrentUserToGuess();
            friendPhoto.LoadAsync(m_CurrentUserToGuess.PictureLargeURL);
            m_OptionListOfFriendsNames = m_GameFormLogic.CreateListOfOptionFromFriendsList();
            foreach (string name in m_OptionListOfFriendsNames)
            {
                nameOptionsList.Items.Add(name);
            }
        }

        private void selectFriendNameFromList()
        {
            bool isCorrect = m_GameFormLogic.CheckAnswerOfTheUser((string)nameOptionsList.SelectedItem);

            if (isCorrect)
            {
                MessageBox.Show(k_CorrectGuessMessage);
            }
            else
            {
                MessageBox.Show(String.Format(k_WorngGuessMessage, m_CurrentUserToGuess.Name));
            }

            resetForm();
        }

        private void resetForm()
        {
            foreach (String name in m_OptionListOfFriendsNames)
            {
                nameOptionsList.Items.Remove(name);
            }
            nameOptionsList.SelectedItems.Clear();
            m_OptionListOfFriendsNames = new List<string>();
        }
    }
}

namespace FormsUI.FacebookAppLogic
{ 
    internal static class Utils
    {
        public const string k_WelcomeMessage = "Hey {0} ! Welcome to our facebook v2.0 app. Enjoy your time here with us!";
        public const string k_LoginProblemMessage = "Sorry, somthing went worng, please ty again to login to your facebook account";
        public const string k_NoDataToFetchMessage = "No data to retrieve :(";
        public const string k_FetchPerrmissionDenyMessage = "You dont have permmissions for fetching this Item - we are sorry :( , message error: {0}";
        public const string k_EmptyFriendListMessage = "Your friend list is empty, please return to the main page and fetch friend list :)";
        public const string k_AlreadyLoggedInMessage = "You are already login to facebook , you first need to log out before log in again :)";
        public enum eFormName
        {
            Game,
            Filter
        }  
    }
}

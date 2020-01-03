using FacebookWrapper;

namespace FormsUI.FacebookAppLogic
{
    public static class FacebookLogin
    {

        public static LoginResult Login(bool isButtonLoginPressed)
        {
            LoginResult loginResult = null;

            if (!string.IsNullOrEmpty(MainForm.s_AppSettings.LastAccessToken))
            {
                loginResult = AutoLoginWithCertificates();
            }
            if (isButtonLoginPressed)
            {
                loginResult = ManualLoginWithUserDetails();
            }

            return loginResult;
        }

        private static LoginResult ManualLoginWithUserDetails()
        {
            LoginResult loginResult = FacebookService.Login("2146465275649682",

                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown",
                "manage_pages",
                "publish_pages"
                );

            MainFormFacade.s_LoginUser = loginResult.LoggedInUser;

            return loginResult;
        }

        private static LoginResult AutoLoginWithCertificates()
        {
            LoginResult loginResult = FacebookService.Connect(MainForm.s_AppSettings.LastAccessToken);
            MainFormFacade.s_LoginUser = loginResult.LoggedInUser;
            MainForm.s_AppSettings.RememberUser = true;

            return loginResult;
        }
    }

    
}

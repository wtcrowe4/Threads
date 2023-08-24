using Threads.Models;

namespace Threads.Pages
{

    public partial class ProfilePage : ContentPage
    {
        private User _currentUser;
        public ProfilePage()
        {
            InitializeComponent();
            _currentUser = GetCurrentUser();
            CurrentUserDisplay.Text = _currentUser.DisplayName;
            CurrentUserImage.Source = _currentUser.Image;
            CurrentUserUN.Text = _currentUser.UserName;
            FollowersDisplay.Text = _currentUser.FollowersDisplay;

        }


        private static User GetCurrentUser()
        {
            return new User
            {
                UserName = "ME864",
                DisplayName = "John Smith",
                Followers = 100,
                Image = "default_user.png",
                IsVerified = true,
                IsFollowing = false,
                HasSimiliarFollowers = true
            };
        }

    }

}




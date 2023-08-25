using System.Diagnostics;
using System.Xml.Serialization;
using Threads.Models;

namespace Threads.Pages
{

    public partial class ProfilePage : ContentPage
    {
        private readonly User _currentUser;
        public ProfilePage()
        {
            InitializeComponent();
            _currentUser = GetCurrentUser();
            CurrentUserDisplay.Text = _currentUser.DisplayName;
            CurrentUserImage.Source = _currentUser.Image;
            CurrentUserUN.Text = _currentUser.UserName;
            FollowersDisplay.Text = _currentUser.FollowersDisplay;
            FollowersImage.Source = _currentUser.Image;
            FollowersImage2.Source = _currentUser.Image;
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

        private void ThreadsSelected(object sender, EventArgs e)
        {
            Debug.WriteLine("Threads Selected");
        }

        private void RepliesSelected(object sender, EventArgs e)
        {
            Debug.WriteLine("Replies Selected");
        }

        private void RepostsSelected(object sender, EventArgs e)
        {
            Debug.WriteLine("Reposts Selected");
        }

    }

}




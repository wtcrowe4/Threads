using CallKit;
using CommunityToolkit.Maui.Converters;
using System.Diagnostics;
using System.Xml.Serialization;
using Threads.Models;




namespace Threads.Pages
{

    public partial class ProfilePage : ContentPage
    {
        private readonly User _currentUser;
        private List<Models.Activity> _activity;
        private List<Models.Thread> _threads;
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
            ActivityLV.ItemsSource =  _threads;
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
            ThreadsLabel.TextColor = Color.FromArgb("#1DA1F2");
            UnderlineThreads.BackgroundColor = Color.FromArgb("#1DA1F2");

            //Get Threads
            //Dummy Data
            _threads = new List<Models.Thread>
             {
                new Models.Thread
                {
                   User = _currentUser,
                   Message = "This is a test message",
                   Likes = 10,
                   Replies = 5,
                   TimeAgo = "1h"

                },
                new Models.Thread
                {
                   User = _currentUser,
                   Message = "This is a test message",
                   Likes = 10,
                   Replies = 5,
                   TimeAgo = "2h"

                },
                new Models.Thread
                {
                   User = _currentUser,
                   Message = "This is a test message",
                   Likes = 10,
                   Replies = 5,
                   TimeAgo = "4h"
                }
             };
        }

        private void RepliesSelected(object sender, EventArgs e)
        {
            Debug.WriteLine("Replies Selected");
            RepliesLabel.TextColor = Color.FromArgb("#1DA1F2");
            UnderlineReplies.BackgroundColor = Color.FromArgb("#1DA1F2");

            //Get Replies

        }

        private void RepostsSelected(object sender, EventArgs e)
        {
            Debug.WriteLine("Reposts Selected");
            RepostsLabel.TextColor = Color.FromArgb("#1DA1F2");
            UnderlineReposts.BackgroundColor = Color.FromArgb("#1DA1F2");

            //Get Reposts

        }

    }

}




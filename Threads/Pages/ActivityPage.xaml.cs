using Threads.Models;

namespace Threads.Pages
{
    public partial class ActivityPage : ContentPage
    {
        public ActivityPage()
        {
            InitializeComponent();
            ActivityListView.ItemsSource = GetActivities();
            
        }

        private void FollowButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var user = button?.BindingContext as User;
            user.IsFollowing = !user.IsFollowing;
        }

        private static List<User> GetActivities()
        {
            return new List<User>()
            {
                new User()
                {
                    UserName = "User 1",
                    DisplayName = "John Smith",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 2",
                    DisplayName = "John Smith",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = false,
                    IsFollowing = false,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 3",
                    DisplayName = "John Smith",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = false,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 4",
                    DisplayName = "John Smith",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = false,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 5",
                    DisplayName = "John Smith",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = false,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 6",
                    DisplayName = "John Smith",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = false,
                    IsFollowing = false,
                    HasSimiliarFollowers = true

                },
            };
        }
    }
}

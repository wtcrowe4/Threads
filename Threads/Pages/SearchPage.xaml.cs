using Threads.Helpers;
using Threads.Controls;
using Threads.Models;

namespace Threads.Pages
{
    public partial class SearchPage : ContentPage
    {
        private readonly string _searchPlaceholder = "Search";
        public SearchPage()
        {
            InitializeComponent();
            SearchEntry.Placeholder = "\U0001F50E" + " Search";
            UsersLV.ItemsSource = GetUsers();
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }

        protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
        {
            base.OnNavigatedFrom(args);
        }

        //SearchEntry_TextChanged
        private void SearchEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                SearchEntry.Placeholder = _searchPlaceholder;
            }
            else
            {
                SearchEntry.Placeholder = string.Empty;
            }
        }

        private static List<User> GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    UserName = "User 1",
                    DisplayName = "User 1",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 2",
                    DisplayName = "User 2",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 3",
                    DisplayName = "User 3",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 4",
                    DisplayName = "User 4",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 5",
                    DisplayName = "User 5",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                new User()
                {
                    UserName = "User 6",
                    DisplayName = "User 6",
                    Followers = 100,
                    Image = "default_user.png",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
            };
        }
    }
}

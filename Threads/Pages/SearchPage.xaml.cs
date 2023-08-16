using Threads.Helpers;
using Threads.Controls;
using Threads.Models;


namespace Threads.Pages
{
    public partial class SearchPage : ContentPage
    {
        
        private readonly string _searchPlaceholder = "\U0001F50E" + "   Search";
        public SearchPage()
        {
            InitializeComponent();
            
            SearchEntry.Placeholder = _searchPlaceholder;
            UsersLV.ItemsSource = GetUsers();
            //\U0001F50E
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

        //FollowButton_Clicked
        private void FollowButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var user = button?.BindingContext as User;
            user.IsFollowing = !user.IsFollowing;
        }

        private static List<User> GetUsers()
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

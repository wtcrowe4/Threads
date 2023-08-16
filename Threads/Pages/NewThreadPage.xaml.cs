using System.Windows.Input;
using Threads.Models;

namespace Threads.Pages
{
    public partial class NewThreadPage : ContentPage
    {
        private readonly User currentUser;
        public NewThreadPage()
        {
            InitializeComponent();
            currentUser = GetCurrentUser();
            CurrentUserImage.Source = currentUser.Image;
            CurrentUserName.Text = currentUser.UserName;

            

        }

        private static User GetCurrentUser()
        {
            return new User()
            {
                UserName = "User 1",
                DisplayName = "John Smith",
                Followers = 100,
                Image = "default_user.png",
                IsVerified = true,
                IsFollowing = true,
                HasSimiliarFollowers = true

            };
        }

        public ICommand GoBackCommand => new Command(async () => await Navigation.PopAsync());
    }
       

    
}

using System.Diagnostics;
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
            CurrentUserImageSmall.Source = currentUser.Image;
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

        //method for tapped gobackcommand event
        static void GoBackTapped(object sender, TappedEventArgs args)
        {
            Debug.WriteLine("GoBack");
            
            Application.Current.MainPage = new AppShell();
        }

        public Command AttachCommand => new(() => Attach());
    
    
        public Command PostCommand => new(() => Post());
    
    
        public void Attach()
        {
            Debug.WriteLine("Attach");
        }

        public void Post()
        {
            Debug.WriteLine("Post");
        }

    }
       


    
}

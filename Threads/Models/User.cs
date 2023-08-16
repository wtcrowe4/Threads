using Humanizer;
using CommunityToolkit.Mvvm.ComponentModel;
using Threads.Helpers;

namespace Threads.Models
{
    public partial class User : ObservableObject
    {
        [ObservableProperty]
        string userName;

        [ObservableProperty]
        string displayName;

        [ObservableProperty]
        int followers;

        [ObservableProperty]
        string image;

        [ObservableProperty]
        bool isVerified;

        [ObservableProperty]
        bool isFollowing;

        [ObservableProperty]
        bool hasSimiliarFollowers;

        public string FollowersDisplay => $"{Followers.ToMetric().ToUpper()} Followers"; 
        public string IsFollowingDisplay => IsFollowing ? "Following" : "Follow";
        public string IsVerifiedDisplay => IsVerified ? FontAwesomeIcons.CircleCheck : string.Empty;
    }
}

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

        [ObservableProperty]
        List<Activity> activity;

        [ObservableProperty]
        DateTime joined;

        public List<Activity> GetRecentActivities()
        {
            return Activity.AllActivity.Where(activity => activity.User == this).OrderByDescending(activity => activity.Timestamp).Take(3).ToList();
        }

        List <Activity> recentActivity = GetRecentActivities().Take(3).ToList();
        public string UserName { get => userName; set => SetProperty(ref userName, value); }
        public string FollowersDisplay => $"{Followers.ToMetric().ToUpper()} Followers"; 
        public string IsFollowingDisplay => IsFollowing ? "Following" : "Follow";
        public string IsVerifiedDisplay => IsVerified ? FontAwesomeIcons.CircleCheck : string.Empty;
    }
}

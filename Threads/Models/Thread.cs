using CommunityToolkit.Mvvm.ComponentModel;
using Java.Security;

namespace Threads.Models
{
    public partial class Thread : ObservableObject
    {

        [ObservableProperty]
        User user;

        [ObservableProperty]
        string imageUrl;

        [ObservableProperty]
        string message;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(HasLikes))]
        int likes;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(HasReplies))]
        int replies;

        [ObservableProperty]
        int views;

        [ObservableProperty]
        DateTime timestamp;

        
        public string GetTimeAgo()
        {
            DateTime timeAgo = Timestamp - DateTime.UtcNow.ToLocalTime();
            return timeAgo.ToString();
        }


        //Linking activity by Thread
        List<Activity> activityList;

        public List<Activity> GetMatchingActivities()
        {
            return Activity.AllActivity.Where(activity => activity.Thread == this).ToList();
        }


        public bool HasReplies => Replies > 0;
        public bool HasLikes => Likes > 0;
        public string LikesRepliesDisplay => $"{Replies} Replies ✯ {Likes} Likes";

        public string TimeAgo { get; internal set; }
    }
}


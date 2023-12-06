using CommunityToolkit.Mvvm.ComponentModel;

namespace Threads.Models
{
    public partial class Thread : ObservableObject
    {

        [ObservableProperty]
        User user;

        [ObservableProperty]
        string message;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(HasLikes))]
        int likes;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(HasReplies))]
        int replies;

        [ObservableProperty]
        string timeAgo;


        //Linking activity by Thread
        List<Activity> activityList;

        public List<Activity> GetMatchingActivities()
        {
            List<Activity> matchingActivities = new List<Activity>();
            foreach (Activity activity in AllActivity)
            {
                if (activity.thread == this)
                {
                    matchingActivities.Add(activity);
                }
            }
            return matchingActivities;
        }

       
        public bool HasReplies => Replies > 0;
        public bool HasLikes => Likes > 0;
        public string LikesRepliesDisplay => $"{Replies} Replies ✯ {Likes} Likes";
    }
}


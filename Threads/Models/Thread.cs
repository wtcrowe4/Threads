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

        public bool HasReplies => Replies > 0;
        public bool HasLikes => Likes > 0;
        public string LikesRepliesDisplay => $"{Replies} Replies ✯ {Likes} Likes";

    
        

    
    }
}


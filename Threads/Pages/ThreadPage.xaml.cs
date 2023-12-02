using Threads.Models;
using Thread = Threads.Models.Thread;
namespace Threads.Pages;


public partial class ThreadPage : ContentPage
{
	public ThreadPage(Thread thread)
	{
		InitializeComponent();

        ThreadList = new List<Activity>
        {
            new Activity
            {
                Action = Activity.ActionType.Reply,
                Message = "This is a reply",
                Thread = new Thread
                {
                    User = new User
                    {
                        UserName = "User1"

                    },
                    Message = "This is a thread 1",
                    TimeAgo = "1h",
                    Likes = 5,
                    Replies = 1
                },
                UserAct = new User { UserName = "User2" },
                UserRec = thread.User,
                TimeAgo = "1h"
            },
            new Activity
            {
                Action = Activity.ActionType.Repost,
                Message = "This is a repost",
                Thread = new Thread
                {

                    User = new User
                    {
                        UserName = "User1"

                    },
                    Message = "This is a thread 2",
                    TimeAgo = "1h",
                    Likes = 5,
                    Replies = 1
                },
                UserAct = new User { UserName = "User2" },
                UserRec = thread.User,
                TimeAgo = "18m"
            },
            new Activity
            {
                Action = Activity.ActionType.Follow,
                Message = "This is a follow",
                Thread = new Thread
                {
                    User = new User
                    {
                        UserName = "User1"

                    },
                    Message = "This is a thread 3",
                    TimeAgo = "1h",
                    Likes = 5,
                    Replies = 1
                },
                UserAct = new User { UserName = "User2" },
                UserRec = thread.User,
                TimeAgo = "5m"
            },



        }
        ;
        BindingContext = this;
        }



    public List<Activity> ThreadList { get; }
}

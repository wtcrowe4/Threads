using Threads.Models;
using Thread = Threads.Models.Thread;
namespace Threads.Pages;


public partial class ThreadPage : ContentPage
{
	public ThreadPage()
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
					Content = "This is a thread",
					Author = new User
					{
						Username = "User1"

					}
				},
				UserAct = new User { Username = "User2" },
				UserRec = new User { Username = "User3" },
				TimeAgo = "1h"
				},
			new Activity
			{
                Action = Activity.ActionType.Repost,
                Message = "This is a repost",
                Thread = new Thread
				{
                    Content = "This is a thread",
                    Author = new User
					{
                        Username = "User1"

                    }
                },
                UserAct = new User { Username = "User2" },
                UserRec = new User { Username = "User3" },
                TimeAgo = "1h"
                },	
			new Activity
			{
                Action = Activity.ActionType.Follow,
                Message = "This is a follow",
                Thread = new Thread
				{
                    Content = "This is a thread",
                    Author = new User
					{
                        Username = "User1"

                    }
                },
                UserAct = new User { Username = "User2" },
                UserRec = new User { Username = "User3" },
                TimeAgo = "1h"
                },

	}
}

    public List<Activity> ThreadList { get; }
}

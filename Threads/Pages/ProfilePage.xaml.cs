using CommunityToolkit.Maui.Converters;
using System.Diagnostics;
using Threads.Models;

namespace Threads.Pages
{
    
    public partial class ProfilePage : ContentPage
    {
        private readonly User _currentUser;
        //private List<Models.Activity> _activity;
        private List<Models.Activity> _threads;
        private List<Models.Activity> _replies; 
        private List<Models.Activity> _reposts; 

        public ProfilePage()
        {
            InitializeComponent();
            _currentUser = GetCurrentUser();
            CurrentUserDisplay.Text = _currentUser.DisplayName;
            CurrentUserImage.Source = _currentUser.Image;
            CurrentUserUN.Text = _currentUser.UserName;
            FollowersDisplay.Text = _currentUser.FollowersDisplay;
            FollowersImage.Source = _currentUser.Image;
            FollowersImage2.Source = _currentUser.Image;
            //initally threads selected
            ThreadsLabel.TextColor = Color.FromArgb("#1DA1F2");
            UnderlineThreads.BackgroundColor = Color.FromArgb("#1DA1F2");
            _threads =
                [
                    new Models.Activity
                    {
                        Icon = "reply.png",
                        Action = Models.Activity.ActionType.Reply,
                        UserAct = new Models.User { UserName = "ME864", Image = "default_user.png" },
                        UserRec = _currentUser,
                        Message = "This is a test message",
                        Thread = new Models.Thread
                        {
                            User = _currentUser,
                            Message = "This is a test message",
                            Likes = 10,
                            Replies = 5,
                            TimeAgo = "1h"
                        }

                    },
                    new Models.Activity
                    {
                        Icon = "reply.png",
                        Action = Models.Activity.ActionType.Reply,
                        UserAct = new Models.User { UserName = "ME864", Image = "default_user.png" },
                        UserRec = _currentUser,
                        Message = "This is a test message",
                        Thread = new Models.Thread
                        {
                            User = _currentUser,
                            Message = "This is a test message",
                            Likes = 10,
                            Replies = 5,
                            TimeAgo = "2h"
                        }

                    },
                    new Models.Activity
                    {
                        Icon = "reply.png",
                        Action = Models.Activity.ActionType.Reply,
                        UserAct = new Models.User { UserName = "ME864", Image = "default_user.png" },
                        UserRec = _currentUser,
                        Message = "This is a test message",
                        Thread = new Models.Thread
                        {
                            User = _currentUser,
                            Message = "This is a test message",
                            Likes = 10,
                            Replies = 5,
                            TimeAgo = "4h"
                        }

                    },
                    new Models.Activity
                    {
                        Icon = "reply.png",
                        Action = Models.Activity.ActionType.Reply,
                        UserAct = new Models.User { UserName = "ME864", Image = "default_user.png" },
                        UserRec = _currentUser,
                        Message = "This is a test message",
                        Thread = new Models.Thread
                        {
                            User = _currentUser,
                            Message = "This is a test message",
                            Likes = 20,
                            Replies = 7,
                            TimeAgo = "5h"
                        }

                    },
                ];
            //             [
            //                new Models.Thread
            //                {
            //                   User = _currentUser,
            //                   Message = "This is a test message",
            //                   Likes = 10,
            //                   Replies = 5,
            //                   TimeAgo = "1h"

            //                },
            //                new Models.Thread
            //                {
            //                   User = _currentUser,
            //                   Message = "This is a test message",
            //                   Likes = 10,
            //                   Replies = 5,
            //                   TimeAgo = "2h"

            //                },
            //                new Models.Thread
            //                {
            //                   User = _currentUser,
            //                   Message = "This is a test message",
            //                   Likes = 10,
            //                   Replies = 5,
            //                   TimeAgo = "4h"
            //                },
            //                new Models.Thread
            //                {
            //                   User = _currentUser,
            //                   Message = "This is a test message",
            //                   Likes = 10,
            //                   Replies = 5,
            //                   TimeAgo = "4h"
            //                },
            //                new Models.Thread
            //                {
            //                   User = _currentUser,
            //                   Message = "This is a test message",
            //                   Likes = 20,
            //                   Replies = 3,
            //                   TimeAgo = "5h"
            //                },
            //                new Models.Thread
            //                {
            //                   User = _currentUser,
            //                   Message = "This is a test message",
            //                   Likes = 15,
            //                   Replies = 5,
            //                   TimeAgo = "6h"
            //                },
            //];
            ActivityLV.ItemsSource = _threads;
        }


        private static User GetCurrentUser()
        {
            return new User
            {
                UserName = "ME864",
                DisplayName = "John Smith",
                Followers = 100,
                Image = "default_user.png",
                IsVerified = true,
                IsFollowing = false,
                HasSimiliarFollowers = true
            };
        }

        private void ThreadsSelected(object sender, EventArgs e)
        {
            Debug.WriteLine("Threads Selected");
            ThreadsLabel.TextColor = Color.FromArgb("#1DA1F2");
            UnderlineThreads.BackgroundColor = Color.FromArgb("#1DA1F2");
            //undo other selections
            RepliesLabel.TextColor = Color.FromArgb("#657786");
            UnderlineReplies.BackgroundColor = Color.FromArgb("#657786");
            RepostsLabel.TextColor = Color.FromArgb("#657786");
            UnderlineReposts.BackgroundColor = Color.FromArgb("#657786");

            //Populate LV
            ActivityLV.ItemsSource = _threads;

            //Get Threads
            //activity threads

            //Dummy Data
            _threads =
                [
                    new Models.Activity
                    {
                        Icon = "reply.png",
                        Action = Models.Activity.ActionType.Reply,
                        UserAct = new Models.User { UserName = "ME864", Image = "default_user.png" },
                        UserRec = _currentUser,
                        Message = "This is a test message",
                        Thread = new Models.Thread
                        {
                            User = _currentUser,
                            Message = "This is a test message",
                            Likes = 10,
                            Replies = 5,
                            TimeAgo = "1h"
                        }

                    },
                    new Models.Activity
                    {
                        Icon = "reply.png",
                        Action = Models.Activity.ActionType.Reply,
                        UserAct = new Models.User { UserName = "ME864", Image = "default_user.png" },
                        UserRec = _currentUser,
                        Message = "This is a test message",
                        Thread = new Models.Thread
                        {
                            User = _currentUser,
                            Message = "This is a test message",
                            Likes = 10,
                            Replies = 5,
                            TimeAgo = "2h"
                        }

                    },
                    new Models.Activity
                    {
                        Icon = "reply.png",
                        Action = Models.Activity.ActionType.Reply,
                        UserAct = new Models.User { UserName = "ME864", Image = "default_user.png" },
                        UserRec = _currentUser,
                        Message = "This is a test message",
                        Thread = new Models.Thread
                        {
                            User = _currentUser,
                            Message = "This is a test message",
                            Likes = 10,
                            Replies = 5,
                            TimeAgo = "4h"
                        }

                    },
                    new Models.Activity
                    {
                        Icon = "reply.png",
                        Action = Models.Activity.ActionType.Reply,
                        UserAct = new Models.User { UserName = "ME864", Image = "default_user.png" },
                        UserRec = _currentUser,
                        Message = "This is a test message",
                        Thread = new Models.Thread
                        {
                            User = _currentUser,
                            Message = "This is a test message",
                            Likes = 20,
                            Replies = 7,
                            TimeAgo = "5h"
                        }

                    },
                ];
            //[
            //   new Models.Thread
            //   {
            //      User = _currentUser,
            //      Message = "This is a test message",
            //      Likes = 10,
            //      Replies = 5,
            //      TimeAgo = "1h"

            //   },
            //   new Models.Thread
            //   {
            //      User = _currentUser,
            //      Message = "This is a test message",
            //      Likes = 10,
            //      Replies = 5,
            //      TimeAgo = "2h"

            //   },
            //   new Models.Thread
            //   {
            //      User = _currentUser,
            //      Message = "This is a test message",
            //      Likes = 10,
            //      Replies = 5,
            //      TimeAgo = "4h"
            //   },
            //   new Models.Thread
            //   {
            //      User = _currentUser,
            //      Message = "This is a test message",
            //      Likes = 20,
            //      Replies = 7,
            //      TimeAgo = "5h"
            //   },
            //   new Models.Thread
            //   {
            //      User = _currentUser,
            //      Message = "This is a test message",
            //      Likes = 25,
            //      Replies = 12,
            //      TimeAgo = "6h"
            //   }
            //];
        }

        private void RepliesSelected(object sender, EventArgs e)
        {
            Debug.WriteLine("Replies Selected");
            RepliesLabel.TextColor = Color.FromArgb("#1DA1F2");
            UnderlineReplies.BackgroundColor = Color.FromArgb("#1DA1F2");
            //undo other selections
            ThreadsLabel.TextColor = Color.FromArgb("#657786");
            UnderlineThreads.BackgroundColor = Color.FromArgb("#657786");
            RepostsLabel.TextColor = Color.FromArgb("#657786");
            UnderlineReposts.BackgroundColor = Color.FromArgb("#657786");

            //Get Replies
            _replies =
                        // Modified this line to initialize _replies list
                        [
                            new Models.Activity
                            {
                                //Icon = "reply.png",
                                Action = Models.Activity.ActionType.Reply,
                                UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                                UserRec = _currentUser,
                                Message = "This is a test message",
                            },
                            new Models.Activity
                            {
                                //Icon = "reply.png",
                                Action = Models.Activity.ActionType.Reply,
                                UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                                UserRec = _currentUser,
                                Message = "This is a test message",
                            },
                            new Models.Activity
                            {
                                //Icon = "reply.png",
                                Action = Models.Activity.ActionType.Reply,
                                UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                                UserRec = _currentUser,
                                Message = "This is a test message",
                            },
                            new Models.Activity
                            {
                                //Icon = "reply.png",
                                Action = Models.Activity.ActionType.Reply,
                                UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                                UserRec = _currentUser,
                                Message = "This is a test message",
                            },
                            new Models.Activity
                            {
                                //Icon = "reply.png",
                                Action = Models.Activity.ActionType.Reply,
                                UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                                UserRec = _currentUser,
                                Message = "This is a test message",
                            }
                        ];
            //populate LV
            ActivityLV.ItemsSource = _replies; 

            //get activities where action = reply
        }

        private void RepostsSelected(object sender, EventArgs e)
        {
            Debug.WriteLine("Reposts Selected");
            RepostsLabel.TextColor = Color.FromArgb("#1DA1F2");
            UnderlineReposts.BackgroundColor = Color.FromArgb("#1DA1F2");
            //undo other selections
            ThreadsLabel.TextColor = Color.FromArgb("#657786");
            UnderlineThreads.BackgroundColor = Color.FromArgb("#657786");
            RepliesLabel.TextColor = Color.FromArgb("#657786");
            UnderlineReplies.BackgroundColor = Color.FromArgb("#657786");

            //Get Reposts
            //get activities where action = repost
            _reposts =
                        [
                            new() {
                               //Icon = "repost.png",
                               Action = Models.Activity.ActionType.Repost,
                               UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                               UserRec = _currentUser,
                               Thread = new Models.Thread
                               {
                                   User = _currentUser,
                                   Message = "This is a test message",
                                   Likes = 20,
                                   Replies = 7,
                                   TimeAgo = "5h"
                               }
                            },
                            new Models.Activity
                            {
                               //Icon = "repost.png",
                               Action = Models.Activity.ActionType.Repost,
                               UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                               UserRec = _currentUser,
                               Thread = new Models.Thread
                               {
                                   User = _currentUser,
                                   Message = "This is a test message",
                                   Likes = 20,
                                   Replies = 7,
                                   TimeAgo = "5h"
                               }
                            },
                            new Models.Activity
                            {
                               //Icon = "repost.png",
                               Action = Models.Activity.ActionType.Repost,
                               UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                               UserRec = _currentUser,
                               Thread = new Models.Thread
                               {
                                   User = _currentUser,
                                   Message = "This is a test message",
                                   Likes = 20,
                                   Replies = 7,
                                   TimeAgo = "5h"
                               }
                            },
                            new Models.Activity
                            {
                               //Icon = "repost.png",
                               Action = Models.Activity.ActionType.Repost,
                               UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                               UserRec = _currentUser,
                               Thread = new Models.Thread
                               {
                                   User = _currentUser,
                                   Message = "This is a test message",
                                   Likes = 20,
                                   Replies = 7,
                                   TimeAgo = "5h"
                               }
                            },
                            new Models.Activity
                            {
                               //Icon = "repost.png",
                               Action = Models.Activity.ActionType.Repost,
                               UserAct = new Models.User{UserName = "ME864", Image = "default_user.png"},
                               UserRec = _currentUser,
                               Thread = new Models.Thread
                               {
                                   User = _currentUser,
                                   Message = "This is a test message",
                                   Likes = 20,
                                   Replies = 7,
                                   TimeAgo = "5h"
                               }
                            }
                        ];
            //populate LV
            ActivityLV.ItemsSource = _reposts; 

        }

        //Thread Command to link to thread page
        private void ThreadCommand(object sender, EventArgs e)
        {
            Debug.WriteLine("Thread Command");
            //Navigate to thread page
            Navigation.PushAsync(new ThreadPage(Thread));


        }

    }

}




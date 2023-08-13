﻿using Threads.Helpers;
using Threads.Controls;
using Threads.Models;
using Thread = Threads.Models.Thread;

namespace Threads.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        HomeThreadsLV.ItemsSource = GetThreads();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);
    }



    public static List<Thread> GetThreads()
    {
        return new List<Thread>()
        {
            new Thread()
            {
                User = new User()
                {
                    UserName = "User 1",
                    DisplayName = "User 1",
                    Followers = 100,
                    Image = "https://picsum.photos/200",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                Message = "Thread 1 content is here",
                Likes = 4,
                Replies = 2,
                TimeAgo = "2h",
            
            },
            new Thread()
            {
                User = new User()
                {
                    UserName = "User 2",
                    DisplayName = "User 2",
                    Followers = 100,
                    Image = "https://picsum.photos/200",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                Message = "Thread 2 content is here",
                Likes = 5,
                Replies = 6,
                TimeAgo = "4h",

            },
            new Thread()
            {
                User = new User()
                {
                    UserName = "User 3",
                    DisplayName = "User 3",
                    Followers = 100,
                    Image = "https://picsum.photos/200",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                Message = "Thread 3 content is here",
                Likes = 5,
                Replies = 6,
                TimeAgo = "4h",
            },

            
            new Thread()
            {
                User = new User()
                {
                    UserName = "User 1",
                    DisplayName = "User 1",
                    Followers = 100,
                    Image = "https://picsum.photos/200",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                Message = "Thread 4 content is here",
                Likes = 4,
                Replies = 2,
                TimeAgo = "2h",
            },

            new Thread()
            {
                User = new User()
                {
                    UserName = "User 2",
                    DisplayName = "User 2",
                    Followers = 100,
                    Image = "https://picsum.photos/200",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                Message = "Thread 5 content is here",
                Likes = 5,
                Replies = 6,
                TimeAgo = "5h",
            },

            new Thread()
            {
                User = new User()
                {
                    UserName = "User 2",
                    DisplayName = "User 2",
                    Followers = 100,
                    Image = "https://picsum.photos/200",
                    IsVerified = true,
                    IsFollowing = true,
                    HasSimiliarFollowers = true

                },
                Message = "Thread 6 content is here",
                Likes = 5,
                Replies = 6,
                TimeAgo = "6h",

            },  
        };
    }

}


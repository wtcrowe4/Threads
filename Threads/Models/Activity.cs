using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threads.Models;

namespace Threads.Models
{
    public partial class Activity : ObservableObject
    {

        public string Icon { get; set; }
        public enum ActionType
        {
            Reply,
            Repost,
            Follow,
            Like,
            Mention
        }

        //[ObservableProperty]
        public ActionType Action { get; set; }

        //[ObservableProperty]
        public string Message { get; set; }

        //[ObservableProperty]
        
        public Thread Thread { get; set; }
        //[ObservableProperty]
        public User UserAct { get; set; }
        //[ObservableProperty]
        public User UserRec { get; set; }
        //[ObservableProperty]
        public string TimeAgo { get; set; }

        public static List<Activity> AllActivity;
        //on creatation of activity, add to list
        public Activity()
        {
            AllActivity = new List<Activity>();
            
        }

        public void AddToActivityList(Activity activity)
        {
            AllActivity.Add(activity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threads.Models;

namespace Threads.Models
{
    public class Activity
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
        public ActionType Action { get; set; } 
        public string Message { get; set; }
        public Thread Thread { get; set; }
        public User UserAct { get; set; }
        public User UserRec { get; set; }
        public string TimeAgo { get; set; }
    }
}

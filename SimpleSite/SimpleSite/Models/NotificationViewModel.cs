using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleSite.Models
{
    public class NotificationViewModel
    {
        public int Count { get; set; }
        public string NotificationType { get; set; }
        public string BadgeClass { get; set; }
    }
}
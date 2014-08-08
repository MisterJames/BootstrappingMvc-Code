using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleSite.Models
{
    public enum NotificationType
    {
        Registration,
        Email
    }

    public class Notification
    {
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public NotificationType NotificationType { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string UserId { get; set; }
        public bool IsDismissed { get; set; }

    }
}
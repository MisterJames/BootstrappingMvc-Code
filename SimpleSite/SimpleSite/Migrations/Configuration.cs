using SimpleSite.Models;

namespace SimpleSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleSite.Models.SiteDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleSite.Models.SiteDataContext context)
        {
            // we won't need this any more...
            // 
            //context.Notifications.AddOrUpdate(notification => notification.Title,
            //    new Notification
            //    {
            //        Title = "John Smith was added to the system.",
            //        NotificationType = NotificationType.Registration
            //    },
            //    new Notification
            //    {
            //        Title = "Susan Peters was added to the system.",
            //        NotificationType = NotificationType.Registration
            //    },
            //    new Notification
            //    {
            //        Title = "Just an FYI on Thursday's meeting",
            //        NotificationType = NotificationType.Email
            //    });
        }
    }
}

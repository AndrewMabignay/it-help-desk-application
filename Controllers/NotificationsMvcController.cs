using ITHelpDeskApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITHelpDeskApplication.Controllers;

public class NotificationsMvcController : Controller
{
    public IActionResult Index()
    {
        var notifications = new List<NotificationViewModel>
    {
        new()
        {
            Id = 1,
            Title = "New Ticket Submitted",
            Message = "A new ticket has been submitted by Anna Reyes.",
            Type = "Ticket",
            CreatedAt = DateTime.Now.AddMinutes(-10),
            IsRead = false
        },
        new()
        {
            Id = 2,
            Title = "Ticket Assigned",
            Message = "Ticket #1025 has been assigned to you.",
            Type = "Assignment",
            CreatedAt = DateTime.Now.AddHours(-1),
            IsRead = false
        },
        new()
        {
            Id = 3,
            Title = "Ticket Resolved",
            Message = "Ticket #1022 has been marked as resolved.",
            Type = "Status",
            CreatedAt = DateTime.Now.AddHours(-3),
            IsRead = true
        },
        new()
        {
            Id = 4,
            Title = "New Comment",
            Message = "Mark Santos added a comment to Ticket #1018.",
            Type = "Comment",
            CreatedAt = DateTime.Now.AddDays(-1),
            IsRead = true
        },
        new()
        {
            Id = 5,
            Title = "System Maintenance",
            Message = "Scheduled maintenance will take place this weekend.",
            Type = "System",
            CreatedAt = DateTime.Now.AddDays(-2),
            IsRead = false
        }
    };

        var model = new NotificationsPageViewModel
        {
            TotalNotifications = notifications.Count,
            UnreadNotifications = notifications.Count(n => !n.IsRead),
            Notifications = notifications
        };

        return View(model);
    }
}

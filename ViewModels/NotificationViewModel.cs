namespace ITHelpDeskApplication.ViewModels;

public class NotificationViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool IsRead { get; set; }
}

public class NotificationsPageViewModel
{
    public int TotalNotifications { get; set; }
    public int UnreadNotifications { get; set; }

    public List<NotificationViewModel> Notifications { get; set; } = new();
}

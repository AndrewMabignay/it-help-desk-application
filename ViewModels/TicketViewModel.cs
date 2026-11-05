namespace ITHelpDeskApplication.ViewModels;

public class TicketViewModel
{
    public int Id { get; set; }
    public string Subject { get; set; } = string.Empty;
    public string Requester { get; set; } = string.Empty;
    public string Priority { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}

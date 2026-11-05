namespace ITHelpDeskApplication.ViewModels;

public class TicketCommentViewModel
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string Author { get; set; } = string.Empty;

    public string Comment { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
}

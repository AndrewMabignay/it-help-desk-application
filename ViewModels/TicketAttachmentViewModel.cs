namespace ITHelpDeskApplication.ViewModels;

public class TicketAttachmentViewModel
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string FileName { get; set; } = string.Empty;

    public string FilePath { get; set; } = string.Empty;

    public string UploadedBy { get; set; } = string.Empty;

    public DateTime UploadedAt { get; set; }
}

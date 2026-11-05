using System.ComponentModel.DataAnnotations;

namespace ITHelpDeskApplication.ViewModels;

public class UpdateTicketStatusViewModel
{
    public int TicketId { get; set; }

    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a status.")]
    public string Status { get; set; } = string.Empty;

    public string UpdatedBy { get; set; } = string.Empty;

    public DateTime UpdatedAt { get; set; }
}

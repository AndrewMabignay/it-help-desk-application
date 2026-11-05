using System.ComponentModel.DataAnnotations;

namespace ITHelpDeskApplication.ViewModels;

public class CreateTicketViewModel
{
    [Required]
    public string Subject { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    [Required]
    public string Requester { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string RequesterEmail { get; set; } = string.Empty;

    [Required]
    public string Department { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    [Required]
    public string Priority { get; set; } = string.Empty;
}

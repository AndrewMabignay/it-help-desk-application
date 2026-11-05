using System.ComponentModel.DataAnnotations;

namespace ITHelpDeskApplication.ViewModels;

public class TicketAssignmentViewModel
{
    public int TicketId { get; set; }

    public string TicketSubject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select an IT staff member.")]
    public string AssignedTo { get; set; } = string.Empty;

    public string AssignedBy { get; set; } = string.Empty;

    public DateTime AssignedAt { get; set; }
}

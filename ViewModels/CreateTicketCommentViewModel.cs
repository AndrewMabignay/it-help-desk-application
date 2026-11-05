using System.ComponentModel.DataAnnotations;

namespace ITHelpDeskApplication.ViewModels;

public class CreateTicketCommentViewModel
{
    public int TicketId { get; set; }

    [Required(ErrorMessage = "Comment is required.")]
    [StringLength(1000, MinimumLength = 3)]
    public string Comment { get; set; } = string.Empty;
}

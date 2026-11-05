using System.ComponentModel.DataAnnotations;

namespace ITHelpDeskApplication.ViewModels;

public class UploadTicketAttachmentViewModel
{
    public int TicketId { get; set; }

    [Required(ErrorMessage = "Please select a file.")]
    public IFormFile? File { get; set; }
}

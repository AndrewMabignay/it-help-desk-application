namespace ITHelpDeskApplication.ViewModels
{
    public class RecentTicketViewModel
    {
        public string TicketNumber { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string RequestedBy { get; set; } = string.Empty;
        
        public string Priority { get; set; } = string.Empty;
        
        public string Status { get; set; } = string.Empty;
    }
}

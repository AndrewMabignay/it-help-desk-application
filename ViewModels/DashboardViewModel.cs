namespace ITHelpDeskApplication.ViewModels;

public class DashboardViewModel
{
    public int TotalTickets { get; set; }

    public int OpenTickets { get; set; }

    public int InProgressTickets { get; set; }

    public int ResolvedTickets { get; set; }

    public List<RecentTicketViewModel> RecentTickets { get; set; } = new();
}

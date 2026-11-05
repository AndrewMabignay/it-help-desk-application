namespace ITHelpDeskApplication.ViewModels;

public class ReportsViewModel
{
    public int TotalTickets { get; set; }
    public int OpenTickets { get; set; }
    public int InProgressTickets { get; set; }
    public int ResolvedTickets { get; set; }

    public List<ReportItemViewModel> StatusReports { get; set; } = new();
    public List<ReportItemViewModel> PriorityReports { get; set; } = new();
    public List<ReportItemViewModel> CategoryReports { get; set; } = new();
    public List<MonthlyReportViewModel> MonthlyReports { get; set; } = new();
}

public class ReportItemViewModel
{
    public string Name { get; set; } = string.Empty;
    public int Count { get; set; }
    public int Percentage { get; set; }
}

public class MonthlyReportViewModel
{
    public string Month { get; set; } = string.Empty;
    public int TotalTickets { get; set; }
}

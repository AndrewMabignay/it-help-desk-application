using ITHelpDeskApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITHelpDeskApplication.Controllers;

public class ReportsMvcController : Controller
{
    public IActionResult Index()
    {
        var model = new ReportsViewModel
        {
            TotalTickets = 128,
            OpenTickets = 24,
            InProgressTickets = 18,
            ResolvedTickets = 86,

            StatusReports = new List<ReportItemViewModel>
        {
            new() { Name = "Open", Count = 24, Percentage = 19 },
            new() { Name = "In Progress", Count = 18, Percentage = 14 },
            new() { Name = "Resolved", Count = 86, Percentage = 67 }
        },

            PriorityReports = new List<ReportItemViewModel>
        {
            new() { Name = "Critical", Count = 12, Percentage = 9 },
            new() { Name = "High", Count = 28, Percentage = 22 },
            new() { Name = "Medium", Count = 50, Percentage = 39 },
            new() { Name = "Low", Count = 38, Percentage = 30 }
        },

            CategoryReports = new List<ReportItemViewModel>
        {
            new() { Name = "Hardware", Count = 35, Percentage = 27 },
            new() { Name = "Software", Count = 42, Percentage = 33 },
            new() { Name = "Network", Count = 28, Percentage = 22 },
            new() { Name = "Account Issues", Count = 23, Percentage = 18 }
        },

            MonthlyReports = new List<MonthlyReportViewModel>
        {
            new() { Month = "June", TotalTickets = 15 },
            new() { Month = "July", TotalTickets = 22 },
            new() { Month = "August", TotalTickets = 18 },
            new() { Month = "September", TotalTickets = 25 },
            new() { Month = "October", TotalTickets = 20 },
            new() { Month = "November", TotalTickets = 28 }
        }
        };

        return View(model);
    }
}

using ITHelpDeskApplication.Models;
using ITHelpDeskApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITHelpDeskApplication.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var dashboard = new DashboardViewModel
        {
            TotalTickets = 128,
            OpenTickets = 24,
            InProgressTickets = 18,
            ResolvedTickets = 86,

            RecentTickets = new List<RecentTicketViewModel>
            {
                 new()
                {
                    TicketNumber = "TKT-0001",
                    Title = "Computer Not Working",
                    RequestedBy = "John Smith",
                    Priority = "High",
                    Status = "Pending"
                },
                new()
                {
                    TicketNumber = "TKT-0002",
                    Title = "Internet Connection Issue",
                    RequestedBy = "Anna Reyes",
                    Priority = "Medium",
                    Status = "In Progress"
                },
                new()
                {
                    TicketNumber = "TKT-0003",
                    Title = "Microsoft Office Installation",
                    RequestedBy = "Mark Santos",
                    Priority = "Low",
                    Status = "Completed"
                },
                new()
                {
                    TicketNumber = "TKT-0004",
                    Title = "Printer Not Responding",
                    RequestedBy = "James Cruz",
                    Priority = "High",
                    Status = "Pending"
                }
            }
        };

        return View(dashboard);
    }
}

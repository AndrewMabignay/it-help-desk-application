using ITHelpDeskApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITHelpDeskApplication.Controllers;

public class PrioritiesMvcController : Controller
{
    public IActionResult Index()
    {
        var priorities = new List<PriorityViewModel>
        {
            new()
            {
                Id = "PRI-001",
                Name = "Low",
                Description = "Minor issue with minimal impact.",
                ResponseTime = "Within 3 business days",
                Status = "Active"
            },
            new()
            {
                Id = "PRI-002",
                Name = "Medium",
                Description = "Issue affecting normal work operations.",
                ResponseTime = "Within 2 business days",
                Status = "Active"
            },
            new()
            {
                Id = "PRI-003",
                Name = "High",
                Description = "Major issue affecting productivity.",
                ResponseTime = "Within 8 hours",
                Status = "Active"
            },
            new()
            {
                Id = "PRI-004",
                Name = "Critical",
                Description = "Urgent issue affecting critical operations.",
                ResponseTime = "Within 1 hour",
                Status = "Active"
            }
        };

        return View(priorities);
    }
}

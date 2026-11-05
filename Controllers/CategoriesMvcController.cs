using ITHelpDeskApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITHelpDeskApplication.Controllers;

public class CategoriesMvcController : Controller
{
    public IActionResult Index()
    {
        var categories = new List<CategoryViewModel>
        {
            new()
            {
                Id = "CAT-001",
                Name = "Hardware",
                Description = "Physical computer equipment and peripherals.",
                Status = "Active"
            },
            new()
            {
                Id = "CAT-002",
                Name = "Software",
                Description = "Software installation and application issues.",
                Status = "Active"
            },
            new()
            {
                Id = "CAT-003",
                Name = "Network",
                Description = "Internet and network connectivity issues.",
                Status = "Active"
            },
            new()
            {
                Id = "CAT-004",
                Name = "Account Issues",
                Description = "User accounts, passwords, and access concerns.",
                Status = "Active"
            },
            new()
            {
                Id = "CAT-005",
                Name = "Other",
                Description = "Other technical support concerns.",
                Status = "Inactive"
            }
        };

        return View(categories);
    }
}

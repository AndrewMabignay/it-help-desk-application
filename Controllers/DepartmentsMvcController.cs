using ITHelpDeskApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITHelpDeskApplication.Controllers;

public class DepartmentsMvcController : Controller
{
    public IActionResult Index()
    {
        var departments = new List<DepartmentViewModel>
        {
            new()
            {
                Id = "DEPT-001",
                Name = "IT Department",
                Description = "Handles technical support and IT infrastructure.",
                DepartmentHead = "John Smith",
                Status = "Active"
            },
            new()
            {
                Id = "DEPT-002",
                Name = "Human Resources",
                Description = "Manages employee relations and recruitment.",
                DepartmentHead = "Anna Reyes",
                Status = "Active"
            },
            new()
            {
                Id = "DEPT-003",
                Name = "Finance",
                Description = "Handles financial operations and accounting.",
                DepartmentHead = "Mark Santos",
                Status = "Active"
            },
            new()
            {
                Id = "DEPT-004",
                Name = "Marketing",
                Description = "Handles marketing and promotional activities.",
                DepartmentHead = "Maria Garcia",
                Status = "Inactive"
            },
            new()
            {
                Id = "DEPT-005",
                Name = "Operations",
                Description = "Oversees daily business operations.",
                DepartmentHead = "James Cruz",
                Status = "Active"
            }
        };

        return View(departments);
    }
}

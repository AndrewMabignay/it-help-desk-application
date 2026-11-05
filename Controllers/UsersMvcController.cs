using ITHelpDeskApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITHelpDeskApplication.Controllers;

public class UsersMvcController : Controller
{
    public IActionResult Index()
    {
        var users = new List<UserViewModel>
        {
            new()
            {
                Id = "USR-001",
                FullName = "John Smith",
                Email = "john.smith@gmail.com",
                Role = "Admin",
                Department = "IT Department",
                Status = "Active"
            },
            new()
            {
                Id = "USR-002",
                FullName = "Anna Reyes",
                Email = "anna.reyes@gmail.com",
                Role = "Staff",
                Department = "Human Resources",
                Status = "Active"
            },
            new()
            {
                Id = "USR-003",
                FullName = "Mark Santos",
                Email = "mark.santos@gmail.com",
                Role = "Technician",
                Department = "IT Department",
                Status = "Active"
            },
            new()
            {
                Id = "USR-004",
                FullName = "James Cruz",
                Email = "james.cruz@gmail.com",
                Role = "Staff",
                Department = "Finance",
                Status = "Inactive"
            },
            new()
            {
                Id = "USR-005",
                FullName = "Maria Garcia",
                Email = "maria.garcia@gmail.com",
                Role = "Technician",
                Department = "IT Department",
                Status = "Active"
            }
        };

        return View(users);
    }
}

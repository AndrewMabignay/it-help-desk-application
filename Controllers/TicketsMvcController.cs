using ITHelpDeskApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITHelpDeskApplication.Controllers;

public class TicketsMvcController : Controller
{
    public IActionResult Index()
    {
        var tickets = new List<TicketViewModel>
        {
            new()
            {
                Id = 1025,
                Subject = "Computer Cannot Connect to Wi-Fi",
                Requester = "Anna Reyes",
                Priority = "High",
                Status = "In Progress",
                Category = "Network",
                CreatedAt = DateTime.Now.AddDays(-1)
            },
            new()
            {
                Id = 1022,
                Subject = "Microsoft Office Installation",
                Requester = "James Cruz",
                Priority = "Medium",
                Status = "Resolved",
                Category = "Software",
                CreatedAt = DateTime.Now.AddDays(-3)
            },
            new()
            {
                Id = 1018,
                Subject = "Keyboard Not Working",
                Requester = "Maria Garcia",
                Priority = "Low",
                Status = "Open",
                Category = "Hardware",
                CreatedAt = DateTime.Now.AddDays(-2)
            }
        };

        return View(tickets);
    }

    public IActionResult Details(int id)
    {
        var tickets = new List<TicketDetailsViewModel>
        {
            new()
            {
                Id = 1025,
                Subject = "Computer Cannot Connect to Wi-Fi",
                Description = "The computer cannot detect the office Wi-Fi network. The user has already restarted the computer, but the issue persists.",
                Requester = "Anna Reyes",
                RequesterEmail = "anna.reyes@example.com",
                Department = "Human Resources",
                AssignedTechnician = "Mark Santos",
                Priority = "High",
                Category = "Network",
                Status = "In Progress",
                CreatedAt = DateTime.Now.AddDays(-1)
            },
            new()
            {
                Id = 1022,
                Subject = "Microsoft Office Installation",
                Description = "Microsoft Office needs to be installed on the employee's workstation.",
                Requester = "James Cruz",
                RequesterEmail = "james.cruz@example.com",
                Department = "Finance",
                AssignedTechnician = "John Smith",
                Priority = "Medium",
                Category = "Software",
                Status = "Resolved",
                CreatedAt = DateTime.Now.AddDays(-3),
                ResolvedAt = DateTime.Now.AddDays(-2)
            },
            new()
            {
                Id = 1018,
                Subject = "Keyboard Not Working",
                Description = "Several keys on the keyboard are not responding properly.",
                Requester = "Maria Garcia",
                RequesterEmail = "maria.garcia@example.com",
                Department = "Marketing",
                AssignedTechnician = "Mark Santos",
                Priority = "Low",
                Category = "Hardware",
                Status = "Open",
                CreatedAt = DateTime.Now.AddDays(-2)
            }
        };

        var ticket = tickets.FirstOrDefault(t => t.Id == id);

        if (ticket == null)
        {
            return NotFound();
        }

        return View(ticket);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CreateTicketViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        return View("Created", model);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var ticket = new EditTicketViewModel
        {
            Id = 1025,
            Subject = "Computer Cannot Connect to Wi-Fi",
            Description = "The computer cannot detect the office Wi-Fi network.",
            Requester = "Anna Reyes",
            RequesterEmail = "anna.reyes@example.com",
            Department = "Human Resources",
            Category = "Network",
            Priority = "High",
            Status = "In Progress"
        };

        if (ticket.Id != id)
        {
            return NotFound();
        }

        return View(ticket);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, EditTicketViewModel model)
    {
        if (id != model.Id)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        return View("Edited", model);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var ticket = new TicketViewModel
        {
            Id = 1025,
            Subject = "Computer Cannot Connect to Wi-Fi",
            Requester = "Anna Reyes",
            Priority = "High",
            Status = "In Progress",
            Category = "Network",
            CreatedAt = DateTime.Now.AddDays(-1)
        };

        if (ticket.Id != id)
        {
            return NotFound();
        }

        return View(ticket);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        if (id != 1025)
        {
            return NotFound();
        }

        return View("Deleted", id);
    }


    [HttpGet]
    public IActionResult Comments(int id)
    {
        if (id != 1025)
        {
            return NotFound();
        }

        var comments = new List<TicketCommentViewModel>
    {
        new()
        {
            Id = 1,
            TicketId = 1025,
            Author = "Anna Reyes",
            Comment = "I already restarted my computer, but the issue still persists.",
            CreatedAt = DateTime.Now.AddHours(-5)
        },
        new()
        {
            Id = 2,
            TicketId = 1025,
            Author = "John Smith",
            Comment = "Our IT team is currently investigating the network connection.",
            CreatedAt = DateTime.Now.AddHours(-3)
        }
    };

        ViewBag.TicketId = id;
        ViewBag.Subject = "Computer Cannot Connect to Wi-Fi";

        return View(comments);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddComment(CreateTicketCommentViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Comments",
                new { id = model.TicketId });
        }

        if (model.TicketId != 1025)
        {
            return NotFound();
        }

        return View("CommentAdded", model);
    }


    [HttpGet]
    public IActionResult Attachments(int id)
    {
        if (id != 1025)
        {
            return NotFound();
        }

        var attachments = new List<TicketAttachmentViewModel>
    {
        new()
        {
            Id = 1,
            TicketId = 1025,
            FileName = "network-error-screenshot.png",
            FilePath = "/uploads/network-error-screenshot.png",
            UploadedBy = "Anna Reyes",
            UploadedAt = DateTime.Now.AddHours(-4)
        },
        new()
        {
            Id = 2,
            TicketId = 1025,
            FileName = "system-report.pdf",
            FilePath = "/uploads/system-report.pdf",
            UploadedBy = "John Smith",
            UploadedAt = DateTime.Now.AddHours(-2)
        }
    };

        ViewBag.TicketId = id;
        ViewBag.Subject = "Computer Cannot Connect to Wi-Fi";

        return View(attachments);
    }

    [HttpGet]
    public IActionResult UploadAttachment(int id)
    {
        if (id != 1025)
        {
            return NotFound();
        }

        return View(new UploadTicketAttachmentViewModel
        {
            TicketId = id
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UploadAttachment(
        UploadTicketAttachmentViewModel model)
    {
        if (model.TicketId != 1025)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var allowedExtensions = new[]
        {
        ".pdf", ".png", ".jpg", ".jpeg",
        ".doc", ".docx", ".xls", ".xlsx", ".txt"
    };

        var extension = Path.GetExtension(model.File!.FileName);

        if (!allowedExtensions.Contains(
            extension, StringComparer.OrdinalIgnoreCase))
        {
            ModelState.AddModelError(
                "File",
                "This file type is not allowed.");

            return View(model);
        }

        const long maxFileSize = 5 * 1024 * 1024;

        if (model.File.Length > maxFileSize)
        {
            ModelState.AddModelError(
                "File",
                "Maximum file size is 5 MB.");

            return View(model);
        }

        var uploadFolder = Path.Combine(
            Directory.GetCurrentDirectory(),
            "wwwroot",
            "uploads"
        );

        Directory.CreateDirectory(uploadFolder);

        var uniqueFileName = $"{Guid.NewGuid()}{extension}";

        var filePath = Path.Combine(
            uploadFolder,
            uniqueFileName
        );

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await model.File.CopyToAsync(stream);
        }

        ViewBag.FileName = Path.GetFileName(model.File.FileName);
        ViewBag.SavedFileName = uniqueFileName;

        return View("AttachmentUploaded", model);
    }


    [HttpGet]
    public IActionResult Assign(int id)
    {
        if (id != 1025)
        {
            return NotFound();
        }

        ViewBag.StaffList = new List<string>
    {
        "John Smith",
        "Michael Santos",
        "David Cruz",
        "Robert Garcia"
    };

        var model = new TicketAssignmentViewModel
        {
            TicketId = 1025,
            TicketSubject = "Computer Cannot Connect to Wi-Fi",
            AssignedTo = "John Smith",
            AssignedBy = "Admin",
            AssignedAt = DateTime.Now
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Assign(TicketAssignmentViewModel model)
    {
        if (model.TicketId != 1025)
        {
            return NotFound();
        }

        ViewBag.StaffList = new List<string>
    {
        "John Smith",
        "Michael Santos",
        "David Cruz",
        "Robert Garcia"
    };

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var staffList = ViewBag.StaffList as List<string>;

        if (!staffList!.Contains(model.AssignedTo))
        {
            ModelState.AddModelError(
                "AssignedTo",
                "Invalid staff selection.");

            return View(model);
        }

        model.TicketSubject = "Computer Cannot Connect to Wi-Fi";
        model.AssignedBy = "Admin";
        model.AssignedAt = DateTime.Now;

        return View("Assigned", model);
    }


    [HttpGet]
    public IActionResult UpdateStatus(int id)
    {
        if (id != 1025)
        {
            return NotFound();
        }

        ViewBag.StatusList = new List<string>
    {
        "Open",
        "In Progress",
        "Resolved",
        "Closed"
    };

        var model = new UpdateTicketStatusViewModel
        {
            TicketId = 1025,
            Subject = "Computer Cannot Connect to Wi-Fi",
            Status = "In Progress",
            UpdatedBy = "Admin",
            UpdatedAt = DateTime.Now
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult UpdateStatus(
        UpdateTicketStatusViewModel model)
    {
        if (model.TicketId != 1025)
        {
            return NotFound();
        }

        ViewBag.StatusList = new List<string>
    {
        "Open",
        "In Progress",
        "Resolved",
        "Closed"
    };

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var statusList = ViewBag.StatusList as List<string>;

        if (!statusList!.Contains(model.Status))
        {
            ModelState.AddModelError(
                "Status",
                "Invalid status selected.");

            return View(model);
        }

        model.Subject = "Computer Cannot Connect to Wi-Fi";
        model.UpdatedBy = "Admin";
        model.UpdatedAt = DateTime.Now;

        return View("StatusUpdated", model);
    }

}

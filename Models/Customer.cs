using System.ComponentModel.DataAnnotations;

namespace ExpressRepairAssessment.Models;

public class Customer
{
    public int Id { get; set; }

    [Display(Name = "Full Name")]
    public string FullName { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; } = true;

    public string GetSummary() =>
        $"#{Id} — {FullName} | {Email} | {Phone} | Created {CreatedAt:yyyy-MM-dd} | {(IsActive ? "Active" : "Inactive")}";
}

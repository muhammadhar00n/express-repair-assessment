using ExpressRepairAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpressRepairAssessment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var customers = SampleCustomers();
        var activeCustomers = customers.Where(c => c.IsActive).OrderBy(c => c.FullName).ToList();
        var firstGmailCustomer = customers.FirstOrDefault(c => c.Email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase));
        var currentYearCount = customers.Count(c => c.CreatedAt.Year == DateTime.Now.Year);

        return View(new HomeViewModel
        {
            FeaturedCustomers = customers.Take(2).ToList(),
            ActiveCustomers = activeCustomers,
            FirstGmailCustomer = firstGmailCustomer,
            CurrentYearCustomerCount = currentYearCount
        });
    }

    private static List<Customer> SampleCustomers() => new()
    {
        new() { Id = 1, FullName = "Aisha Khan", Email = "aisha@gmail.com", Phone = "+92 300 1111111", CreatedAt = DateTime.Now.AddDays(-10), IsActive = true },
        new() { Id = 2, FullName = "Bilal Ahmed", Email = "bilal@company.com", Phone = "+92 301 2222222", CreatedAt = DateTime.Now.AddMonths(-2), IsActive = false },
        new() { Id = 3, FullName = "Sara Malik", Email = "sara@gmail.com", Phone = "+92 302 3333333", CreatedAt = DateTime.Now.AddYears(-1), IsActive = true },
        new() { Id = 4, FullName = "Usman Raza", Email = "usman@company.com", Phone = "+92 303 4444444", CreatedAt = DateTime.Now.AddMonths(-4), IsActive = true },
        new() { Id = 5, FullName = "Zainab Ali", Email = "zainab@example.com", Phone = "+92 304 5555555", CreatedAt = DateTime.Now.AddYears(-2), IsActive = false }
    };
}

public class HomeViewModel
{
    public List<Customer> FeaturedCustomers { get; set; } = new();
    public List<Customer> ActiveCustomers { get; set; } = new();
    public Customer? FirstGmailCustomer { get; set; }
    public int CurrentYearCustomerCount { get; set; }
}

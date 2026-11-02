using ExpressRepairAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpressRepairAssessment.Controllers;

public class CustomersController : Controller
{
    private static readonly List<Customer> Customers = new()
    {
        new() { Id = 1, FullName = "Aisha Khan", Email = "aisha@gmail.com", Phone = "+92 300 1111111", CreatedAt = DateTime.Now.AddDays(-10), IsActive = true },
        new() { Id = 2, FullName = "Bilal Ahmed", Email = "bilal@company.com", Phone = "+92 301 2222222", CreatedAt = DateTime.Now.AddMonths(-2), IsActive = false },
        new() { Id = 3, FullName = "Sara Malik", Email = "sara@gmail.com", Phone = "+92 302 3333333", CreatedAt = DateTime.Now.AddMonths(-3), IsActive = true },
        new() { Id = 4, FullName = "Usman Raza", Email = "usman@company.com", Phone = "+92 303 4444444", CreatedAt = DateTime.Now.AddMonths(-4), IsActive = true }
    };

    public IActionResult Index() => View(Customers);

    [HttpGet]
    public IActionResult Create() => View(new Customer());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Customer customer)
    {
        if (string.IsNullOrWhiteSpace(customer.FullName))
            ModelState.AddModelError(nameof(customer.FullName), "Full Name is required.");

        if (!ModelState.IsValid) return View(customer);
        customer.Id = Customers.Count == 0 ? 1 : Customers.Max(c => c.Id) + 1;
        customer.CreatedAt = DateTime.Now;
        customer.IsActive = true;
        Customers.Add(customer);
        return RedirectToAction(nameof(Index));
    }
}

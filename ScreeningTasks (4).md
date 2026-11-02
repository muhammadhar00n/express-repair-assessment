# Screening Tasks
**Role:** CRM Developer (ASP.NET Core MVC / C#)  
**Tools:** Visual Studio 2022, .NET 6 SDK  

Create one **ASP.NET Core MVC** project in Visual Studio and complete all 5 tasks within it. No database is required — use in-memory data throughout.

---

## Task 1 — C# Model

In the `Models/` folder, create a `Customer` class with the following properties: `Id` (int), `FullName` (string), `Email` (string), `Phone` (string), `CreatedAt` (DateTime), `IsActive` (bool, default true).

Add a `GetSummary()` method that returns a single formatted string containing all the customer's key details.

Display two hardcoded customers on the Home page, each showing their summary string.

---

## Task 2 — LINQ

Using a list of at least 5 customers (mix of active and inactive), write LINQ queries to produce the following and display each result on the Home page:

1. Active customers sorted alphabetically by full name
2. The first customer with a Gmail address (null if none)
3. A count of customers created in the current year

---

## Task 3 — Customers List Page

Create a `CustomersController` with an `Index` action that passes a hardcoded list of at least 4 customers to a Razor view.

The view should display the customers in a Bootstrap 5 table with columns for Name, Email, Phone, and Status (Active / Inactive). Add a link to this page in the navigation menu.

---

## Task 4 — Create Form with Validation

Add a Create page for customers with a Bootstrap 5 form (fields: Full Name, Email, Phone).

On submission, validate that Full Name is not empty — if it is, show an inline error message and return the form. If valid, redirect to the customers list. Add a button on the list page that opens the Create form.

---

## Task 5 — Real-Time Notifications with SignalR

Add a Notifications page with a text input and a Send button. When a user types a message and clicks Send, that message must appear on all open browser tabs immediately — without any page refresh.

Use ASP.NET Core SignalR for the real-time connection. The result should be verifiable by opening the Notifications page in two browser tabs and confirming a message sent in one tab appears in the other instantly.

---

## Submission

Upload the completed project to a GitHub repository and add **MrAndreyG** as a collaborator so we can review your code.

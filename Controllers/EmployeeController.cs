using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

public class EmployeeController(DataContext db) : Controller
{
     private readonly DataContext _dataContext = db;
    [Authorize(Roles = "northwind-employee")]
    public IActionResult Index() => View(_dataContext.Products);
}
  
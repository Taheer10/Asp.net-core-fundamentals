using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        //Known as Dependency Injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public string Index()
        {

            return _employeeRepository.GetEmployee(1).Name;
        }
        public ViewResult Details()
        {

            Employee model = _employeeRepository.GetEmployee(1);
            //Passing data from view Using ViewData,ViewBag and Strongly Typed View
            ViewData["Employee"] = model;
            ViewData["PageTitle"] = "Employee Details";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Collections.Generic;
using System.Web.Mvc;
using MechAccessToolMVCProject.Models;
using MechAccessToolMVCProject.ViewModels;

namespace MechAccessToolMVCProject.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return "Name : " + CustomerName + " | Address : " + Address;
        }
    }

    public class TestController : Controller
    {
        public Customer GetCustomer()
        {
            var cust = new Customer();
            cust.CustomerName = "Dumb Dumb McGee";
            cust.Address = "Up your butt.";
            return cust;
        }

        public ActionResult GetView()
{
    EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

    EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
    List<Employee> employees = empBal.GetEmployees();

    List<EmployeeViewModel>empViewModels = new List<EmployeeViewModel>();

    foreach (Employee emp in employees)
    {
        EmployeeViewModel empViewModel = new EmployeeViewModel();
        empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
        empViewModel.Salary = emp.Salary.ToString("C");
        if (emp.Salary > 15000)
        {
            empViewModel.SalaryColor = "yellow";
        }
        else
        {
            empViewModel.SalaryColor = "green";
        }
        empViewModels.Add(empViewModel);
    }
    employeeListViewModel.Employees = empViewModels;
    employeeListViewModel.UserName = "Admin";
    return View("MyView", employeeListViewModel);
}

    }
}
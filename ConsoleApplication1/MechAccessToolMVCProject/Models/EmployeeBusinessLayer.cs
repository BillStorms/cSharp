using System.Collections.Generic;
using MechAccessToolMVCProject.Models;

namespace MechAccessToolMVCProject.Models
{
    public class EmployeeBusinessLayer
{
    public List<Employee> GetEmployees()
        {
            List <Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "Bill";
            emp.LastName = "Storms";
            emp.Salary = 14000;
            employees.Add(emp);
            Employee emp2 = new Employee();
            emp2.FirstName = "Lyle";
            emp2.LastName = "Ricketts";
            emp2.Salary = 16000;
            employees.Add(emp2);


        return employees;
        }
    }
}
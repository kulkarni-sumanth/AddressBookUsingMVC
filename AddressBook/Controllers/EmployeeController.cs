using AddressBook.Models;
using AddressBook.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployeeRepository EmployeeRepository { get; set; }
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.EmployeeRepository = employeeRepository;
        }

        public async Task<IActionResult> Index(Employee employee)
        {
            ViewBag.employees = await GetAll();
            if (ViewBag.employees.Count > 0 && employee.Id == 0)
                employee = ViewBag.employees[0];
            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> DisplayPartialView(int id)
        {
            Employee employee = await EmployeeRepository.GetEmployeeByIdAsync(id);
            return PartialView("_EmployeeDetails", employee);
        }
        [HttpGet]
        public async Task<IActionResult> DisplayEmployeeDetails(int id)
        {
            Employee employee = await EmployeeRepository.GetEmployeeByIdAsync(id);
            return RedirectToAction("Index", employee);
        }

        [HttpGet]
        public async Task<IActionResult> AddEmployee()
        {
            ViewBag.employees = await GetAll();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            ViewBag.employees = await GetAll();
            if (ModelState.IsValid)
            {
                var record = await EmployeeRepository.AddEmployeeAsync(employee);
                return RedirectToAction("Index", record);

            }
            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            ViewBag.employees = await GetAll();
            Employee employee = await EmployeeRepository.GetEmployeeByIdAsync(id);
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await EmployeeRepository.EditEmployeeAsync(employee);
                employee = await EmployeeRepository.GetEmployeeByIdAsync(employee.Id);
                return RedirectToAction("Index", employee);
            }
            return View(employee);
        }

        [HttpGet, HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await EmployeeRepository.DeleteEmployeeAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<List<Employee>> GetAll()
        {
            IEnumerable<Employee> employees = await EmployeeRepository.GetAllAsync();
            return employees.ToList();
        }
    }
}
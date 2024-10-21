using Employee_Management.Data;
using Employee_Management.Models;
using Employee_Management.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext )
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add( AddEmployeeViewModel viewModel )
        {
            var employee = new Employee
            {
                FirstName = viewModel.FirstName,
                MiddleName = viewModel.MiddleName,
                LastName = viewModel.LastName,
                FullName = viewModel.FullName,
                Designation = viewModel.Designation,
                Joining_Date = viewModel.Joining_Date,
                Phone = viewModel.Phone

            };

            await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var employees =  await dbContext.Employees.ToListAsync();

            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var employee = await dbContext.Employees.FindAsync(id);
            return View(employee);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Employee viewmodel)
        {
            var employee = await dbContext.Employees.FindAsync(viewmodel.Id);
            if(employee is not null)
            {
                employee.FirstName = viewmodel.FirstName;
                employee.MiddleName = viewmodel.MiddleName;
                employee.LastName = viewmodel.LastName;
                employee.FullName = viewmodel.FullName;
                employee.Designation = viewmodel.Designation;
                employee.Joining_Date = viewmodel.Joining_Date;
                employee.Phone = viewmodel.Phone;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Employees");
        }

        [HttpPost]

        public async Task<IActionResult> Delete(Employee viewmodel)
        {
            var employee = await dbContext.Employees
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == viewmodel.Id);
            if(employee is not null)
            {
                dbContext.Employees.Remove(viewmodel);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Employees");
        }

    }
}

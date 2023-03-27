using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee { FirstName = "Kasia" });
employeeRepository.Add(new Employee { FirstName = "Domcia" });
employeeRepository.Add(new Employee { FirstName = "Darek" });
employeeRepository.Save();
using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee, int>();
employeeRepository.Add(new Employee { FirstName = "Kasia" });
employeeRepository.Add(new Employee { FirstName = "Domcia" });
employeeRepository.Add(new Employee { FirstName = "Darek" });
employeeRepository.Add(new Employee { FirstName = "Bimbasiorra" });
employeeRepository.Save();

// var bukkake = "6c301cba-cc81-430d-8cc5-e92dde12001d";

// var guid = Guid.NewGuid().ToString();

// Console.WriteLine(guid);
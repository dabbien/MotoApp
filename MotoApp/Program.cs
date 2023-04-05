using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

var sqlRepository = new SqlRepository(new MotoAppDbContext());
sqlRepository.Add(new Employee { FirstName = "Majkel" });
sqlRepository.Save();
var employee = sqlRepository.GetById(1);
Console.WriteLine(employee.ToString());

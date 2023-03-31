﻿namespace MotoApp.Repositories
{
    using MotoApp.Entities;
    public class EmployeeRepository
    {
        private readonly List<Employee> _employees = new();
        public void Add(Employee employee)
        {
            employee.ID = _employees.Count + 1;
            _employees.Add(employee);
        }

        public void Save()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine(employee);
            }
        }

        public Employee GetById(int id)
        {
            return _employees.Single(item => item.ID == id);
        }
    }
}

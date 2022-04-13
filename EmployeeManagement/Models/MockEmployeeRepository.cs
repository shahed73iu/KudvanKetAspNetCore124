﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Shahed", Department = "HR",Email = "Shahedimamuddin@gmail.com"},
                new Employee() {Id = 2, Name = "Ishaal", Department = "Love",Email = "IshaalNoor@gmail.com"},
                new Employee() {Id = 3, Name = "Samanta", Department = "Batpari",Email = "Samanta@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
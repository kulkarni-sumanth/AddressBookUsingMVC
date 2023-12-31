﻿using AddressBook.Models;

namespace AddressBook.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<Employee> AddEmployeeAsync(Employee employee);
        public Task EditEmployeeAsync(Employee employee);
        public Task DeleteEmployeeAsync(int id);
        public Task<List<Employee>> GetAllAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);
    }
}
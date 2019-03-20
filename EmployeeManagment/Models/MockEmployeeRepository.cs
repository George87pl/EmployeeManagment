using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagment.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Grzegorz", Department = "IT", Email = "gpolomicz@gmail.com"},
                new Employee() { Id = 2, Name = "Magda", Department = "HR", Email = "magda@gmail.com"},
                new Employee() { Id = 3, Name = "Sylwia", Department = "IT", Email = "sylwia@gmail.com"}
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(n => n.Id == Id);
        }
    }
}

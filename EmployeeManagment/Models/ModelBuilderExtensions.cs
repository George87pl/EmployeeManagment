using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Marry",
                    Department = Dept.IT,
                    Email = "marry@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    Department = Dept.IT,
                    Email = "john@gmail.com"
                }
            );
        }
    }
}

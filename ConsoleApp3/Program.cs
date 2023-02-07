using System;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // obtain dataSource 
            var context = new ApplicationDbContext();

            Employee employee = new Employee 
            {
             Name= "Ahmed",
             City = "Cairo",
             Address = "nasr city"
            };

            context.employees.Add(employee);
            context.SaveChanges();
        }
    }
}

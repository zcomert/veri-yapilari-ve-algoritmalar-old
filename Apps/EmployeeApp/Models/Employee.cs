using System.Security.Principal;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;    
        public Decimal Salary { get; set; } = Decimal.Zero;
        public String Title { get; set; } = String.Empty;
    } 
}

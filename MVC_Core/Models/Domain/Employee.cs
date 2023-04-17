using System.ComponentModel.DataAnnotations;

namespace MVC_Core.Models.Domain
{
    public class Employee
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}

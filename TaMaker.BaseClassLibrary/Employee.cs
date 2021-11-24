using System.ComponentModel.DataAnnotations;

namespace TaMaker.BaseClassLibrary
{
    public class Employee
    {
        [Required]
        [Range(10000, 99999999)]
        public int EmpNumber { get; set; }
        [Required]
        public string EmpDesignation { get; set; }
        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter valid name")]
        public string EmpName { get; set; }
        [Required]
        [Range(27000, 990000)]
        public double EmpSalary { get; set; }
        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter valid Station")]
        public string EmpStation { get; set; }
        [Required]
        [Range(1, 15)]
        public int EmpShort { get; set; }
        public string EmpGroup { get; set; }
        public string EmpStatus { get; set; }
    }
}

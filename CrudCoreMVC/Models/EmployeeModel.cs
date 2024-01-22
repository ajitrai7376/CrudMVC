using System;
using System.ComponentModel.DataAnnotations;

namespace CrudCoreMVC.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Employee Name!")]
        [Display(Name = "Employee Name")]
        public string Employee { get; set; }

        [Required(ErrorMessage = "Enter Email!")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Employee Age!")]
        [Display(Name = "Age")]
        [Range(20, 50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Salary!")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}

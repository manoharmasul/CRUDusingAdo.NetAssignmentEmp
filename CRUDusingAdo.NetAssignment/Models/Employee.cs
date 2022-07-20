using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDusingAdo.NetAssignment.Models
{
    [Table("Enployee")]
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Employee name is required")]
        
        [DataType(DataType.Text)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Salary is require")]
        [Display(Name="Employee Salary")]
            [Range(minimum:5000,maximum:100000)]
        public double Salary { get; set; }
    }
}

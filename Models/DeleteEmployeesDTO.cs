using System.ComponentModel.DataAnnotations;

namespace EE.Models
{
    public class DeleteEmployeesDTO
    {
        [Required]
        public int Emp_Id {get; set;}
      
        public string ActionPerformedBy {get; set;}
        
    }
}
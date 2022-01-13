using System.ComponentModel.DataAnnotations;

namespace EE.Models
{
    public class DeleteEmployeesDTO
    {
        public int Emp_Id {get; set;}
        public string ActionPerformedBy {get; set;}
        
    }
}
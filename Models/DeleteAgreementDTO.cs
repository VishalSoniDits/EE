using System.ComponentModel.DataAnnotations;

namespace EE.Models
{
    public class DeleteAgreementDTO
    {
        [Required]
        public int Agreement_Id {get; set;}
        [Required]
        public string ActionPerformedBy {get; set;}
    }
}
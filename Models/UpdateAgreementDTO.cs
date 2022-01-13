namespace EE.Models
{
    public class UpdateAgreementDTO
    {   
        public int Agreement_Id {get; set;}         
        public string Agreement_Name {get; set;}
        public bool IsActive {get; set;}
        public string ActionPerformedBy {get; set;} 
    }
}
namespace EE.Models
{
    public class UpdateQuestiontypeDTO
    { 
        public int Question_Type_Id{get;set;}
        public string Question_Type_Name{get;set;}
        public bool IsActive {get; set;}
        public string ActionPerformedBy {get; set;}
    }
}
namespace EE.Models
{
    public class AddQuestionDTO
    {
        public string Question_Name{get;set;}
        public int Question_Type_Id{get;set;}
        public int Lable_Id{get;set;}
        public bool IsActive {get; set;}
        public string ActionPerformedBy {get; set;}   
    }
}
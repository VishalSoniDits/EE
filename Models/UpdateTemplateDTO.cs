namespace EE.Models
{
    public class UpdateTemplateDTO
    {
        public int Temp_Id{get;set;}
        public string Temp_Name{get;set;}
        public int Question_Id{get;set;}
        public int Signature_Id{get;set;}
        public int Material_Id{get;set;}
        public bool IsActive {get; set;}
        public string ActionPerformedBy {get; set;}   
    }
}
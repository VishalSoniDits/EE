namespace EE.Models
{
    public class AddCommServiceRequestDTO
    {
        //public int Res_Service_Req_Id{get;set;}
    
        public decimal Labour_Rate{get;set;}
        public decimal Travel_Rate{get;set;}
        public string Addition_Travel{get;set;}
        public string Minimum_On_Site{get;set;}
        public string Short_Description{get;set;}
        public string Medium_Description{get;set;}
        public string Work_Description{get;set;}
        public int Agreement_Id{get;set;}
        public int Folder_Id{get;set;}
        public bool IsActive{get;set;}
        public string ActionPerformedBy{get;set;}
    }
}
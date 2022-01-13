namespace EE.Models
{
    public class GetCommServiceRequestDTO
    {
        public int Res_Service_Req_Id{get;set;}
        public decimal Labour_Rate{get;set;}
        public decimal Travel_Rate{get;set;}
        public string Addition_Travel{get;set;}
        public string Minimum_On_Site{get;set;}
        public string Short_Description{get;set;}
        public string Medium_Description{get;set;}
        public string Work_Detail{get;set;}
        public string Agreement_Name{get;set;}
        public string Job_Folder_Name{get;set;}
        public bool IsActive{get;set;}
    }
}
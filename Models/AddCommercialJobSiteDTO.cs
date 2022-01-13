namespace EE.Models
{
    public class AddCommercialJobSiteDTO
    {
        public string Site_Property_Name{get;set;}
        public string Email {get;set;}
        public string Phone_Number{get;set;} 
        public string Address{get;set;}
        public string City{get;set;}
        public string State{get;set;}
        public int Zip_Code {get;set;}
        public bool IsActive{get;set;}
        public string ActionPerformedBy{get;set;}
    }
}
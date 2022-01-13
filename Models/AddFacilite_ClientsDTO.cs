namespace EE.Models
{
    public class AddFacilite_ClientsDTO
    {
        public string Facilitie_Name{get;set;}
        public string Phone_Number{get;set;}
        public string Address{get;set;}
        public string State{get;set;}
        public string City{get;set;}
        public int Zip_Code {get;set;}
        public int Job_Side_Id{get;set;}
        public bool IsActive{get;set;}
        public string ActionPerformedBy {get; set;}   
    }
}
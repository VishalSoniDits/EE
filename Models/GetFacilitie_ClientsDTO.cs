namespace EE.Models
{
    public class GetFacilitie_ClientsDTO
    {
        public int Facilitie_Client_Id{get;set;}
        public string Facilitie_Name{get;set;}
        public string Phone_Number{get;set;}
        public string Address{get;set;}
        public string State{get;set;}
        public string City{get;set;}
        public int Zip_Code {get;set;}
        public string Job_Side_Name{get;set;}
        public bool IsActive{get;set;}
    }
}
namespace EE.Models
{
    public class AddZipcodeDTO
    {
        public string Zone_Name{get;set;}
        public string State{get;set;}
        public string City{get;set;}
        public int Zip_Code{get;set;}
        public string Status{get;set;}
        public bool IsActive{get;set;}
        public string ActionPerformedBy {get;set;}
    }
}
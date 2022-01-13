namespace EE.Models
{
    public class GetSubCategorysDTO
    {
        public int Sub_Category_Id{get;set;}
        public string Sub_Category_Name{get;set;}
        public decimal First_Hour_Price{get;set;}
        public decimal Each_Addition_Hour_Price{get;set;}
        public string Category_Name{get;set;}
        public bool IsActive {get;set;}
    }
}
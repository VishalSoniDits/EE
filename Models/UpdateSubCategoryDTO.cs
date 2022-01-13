namespace EE.Models
{
    public class UpdateSubCategoryDTO
    {
        public int Sub_Category_Id {get;set;}
        public string Sub_Category_Name{get;set;}
        public decimal First_Hour_Price{get;set;}
        public decimal Each_Addition_Hour_Price{get;set;}
        public int Category_Id{get;set;}
        public bool IsActive {get;set;}
         public string ActionPerformedBy {get;set;}
    }
}
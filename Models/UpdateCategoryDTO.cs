namespace EE.Models
{
    public class UpdateCategoryDTO
    {
        public int Category_Id{get;set;}
        public string Category_Name{get;set;}
        public bool IsActive{get;set;}
        public string ActionPerformedBy {get;set;}
    }
}
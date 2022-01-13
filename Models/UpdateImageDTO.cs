namespace EE.Models
{
    public class UpdateImageDTO
    {
        public int Image_Id{get;set;}
        public string Image_File{get;set;}
        public string Image_Type{get;set;}
        public bool IsActive{get;set;}
        public string ActionPerformedBy{get;set;}
    }
}
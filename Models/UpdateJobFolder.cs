namespace EE.Models
{
    public class UpdateJobFolderDTO
    {
        public int Folder_Id {get; set;}
     public int Agreement_Id {get; set;} 
     public string Folder_Name {get; set;} 
     public bool IsActive {get; set;}
     public string ActionPerformedBy {get; set;}  
    }
}
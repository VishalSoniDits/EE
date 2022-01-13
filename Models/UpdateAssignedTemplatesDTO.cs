namespace EE.Models
{
    public class UpdateAssignedTemplatesDTO
    {
     public int Assigned_Template_Id{get;set;}   
     public int Temp_Id{get;set;}
     public int Emp_Id{get;set;}
     public bool IsActive {get;set;}
     public string ActionPerformedBy {get;set;}
    }
}
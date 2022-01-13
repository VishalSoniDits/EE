namespace EE.Models
{
    public class GetAssignedTemplatesDTO
    {
     public int Assigned_Template_Id{get;set;}   
     public string Temp_Name{get;set;}
     public string Technician_Name{get;set;}
     public bool IsActive {get;set;}
    }
}
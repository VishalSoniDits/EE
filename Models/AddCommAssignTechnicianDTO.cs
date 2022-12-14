//test
namespace EE.Models
{
    public class AddCommAssignTechnicianDTO
    {
        public int Category_Id{get;set;}
        public decimal First_Hour{get;set;}
        public decimal Each_Additional_Hour{get;set;}
        public int Emp_Id{get;set;}
        public string Start_Time{get;set;} 
        public string Length_Of_Time {get;set;}
        public string Length_Of_Arrival {get;set;}
        public bool IsActive{get;set;}
        public string ActionPerformedBy{get;set;} 
    }
}
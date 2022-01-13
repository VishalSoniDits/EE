namespace EE.Models
{
    public class UpdateEmployeesDTO
    {   
        public int Emp_Id {get; set;}         
        public string First_Name {get; set;}        
        public string Last_Name {get; set;}               
        public string Email {get; set;}      
        public string Phone_Number {get; set;}                     
        public string Image {get; set;}
        public int Role_Id {get; set;}       
        public bool IsActive {get; set;}
        public string ActionPerformedBy {get; set;}       
    }
}
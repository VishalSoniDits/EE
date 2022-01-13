namespace EE.Models
{
    public class AddEmployeesDTO
    {             
        public string First_Name {get; set;}        
        public string Last_Name {get; set;}               
        public string Email {get; set;}      
        public string Phone_Number {get; set;}                     
        public string Image {get; set;}
        public string User_Name {get; set;} 
        public int Role_Id {get; set;}
        public string Password {get; set;}        
        public bool IsActive {get; set;}
        public string ActionPerformedBy {get; set;}       
    }
}
namespace EE.Models
{
    public class GetEmployeesDTO
    {
        public int Emp_Id {get; set;}
        public string First_Name {get; set;}
        public string Last_Name{get;set;}
        public string Email {get; set;}
        public string Phone_Number {get; set;}
        public string User_Name {get; set;}
        public string Role_Name {get; set;}
        public bool IsActive {get; set;}
    }
}
namespace EE.Models
{
    public class GetSupplierDTO
    {
        public int Supplier_Id{get;set;}
        public string First_Name{get;set;}
        public string Last_Name{get;set;}
        public string Phone_Number{get;set;}
        public string Category_Name{get;set;}
         
        public string Company_Name{get;set;}
        public string Company_Address{get;set;}
        public bool IsActive{get;set;}
    }
}
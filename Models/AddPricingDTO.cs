namespace EE.Models
{
    public class AddPricingDTO
    {
    // public int Pricing_Id{get;set;}
     public int Zip_Code_Id{get;set;}
     public int Emp_Id 	{get;set;}
     public decimal First_Hour {get;set;}
     public decimal Additional_Hour{get;set;}
     public bool IsActive {get;set;}
     public string ActionPerformedBy {get; set;} 
    }
}
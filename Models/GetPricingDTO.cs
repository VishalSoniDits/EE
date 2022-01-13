namespace EE.Models
{
    public class GetPricingDTO
    {
     public int Pricing_Id{get;set;}
     public string Zone_Name{get;set;}
     public string Name{get;set;}
     public decimal First_Hour {get;set;}
     public decimal Additional_Hour{get;set;}
     public bool IsActive {get;set;}

    }
}
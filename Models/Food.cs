using VendingMachine.interfaces;

namespace VendingMachine.Models
{
  class Food : Consumable, Ipurchasable
  {
    // public Food(string type, string expiration) : base(type, expiration)
    // {
    // }

    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }
    public float GetPrice(int q)
    {
      return Price * q;
    }
    public Food(float price, int quantity, string brand, string type, string expiration) : base(type, expiration)
    {
      Price = price;
      Quantity = quantity;
      Brand = brand;
      Type = type;
      Expiration = Expiration;
    }

  }
}
using VendingMachine.interfaces;

namespace VendingMachine.Models
{
  class Drink : Consumable, Ipurchasable
  {
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }

    public float GetPrice(int q)
    {
      return Price * q;
    }

    //constructor
    public Drink(float price, int quantity, string brand, string type, string expiration) : base(type, expiration)
    {
      Price = price;
      Quantity = quantity;
      Brand = brand;
      Type = type;
      Expiration = Expiration;
    }
  }
}
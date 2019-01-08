using VendingMachine.interfaces;

namespace VendingMachine.Models
{
  class Electronic : Ipurchasable
  {
    public string Name { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }
    public float GetPrice(int q)
    {
      return Price * q;
    }

    public Electronic(string name, float price, int quantity, string brand, string type)
    {
      Name = name;
      Price = price;
      Quantity = quantity;
      Brand = brand;
    }

  }
}

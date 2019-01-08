namespace VendingMachine.interfaces
{
  interface Ipurchasable
  {
    float Price { get; set; }
    int Quantity { get; set; }
    float GetPrice(int q);
    string Brand { get; set; }
  }
}
namespace VendingMachine.Models
{
  abstract class Consumable
  {
    public string Type { get; set; }
    public string Expiration { get; set; }

    public Consumable(string type, string expiration)
    {
      Type = type;
      Expiration = expiration;
    }
  }
}
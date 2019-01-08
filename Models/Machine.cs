using System.Collections.Generic;
using VendingMachine.interfaces;

namespace VendingMachine.Models
{
  class Machine
  {
    public string Name { get; set; }
    // public Dictionary<string, List<Ipurchasable>>
    public Dictionary<string, Ipurchasable> Inventory { get; set; }
    //constructor below must be within the class defintion
    public Machine(string name)
    {
      Name = name;
      Inventory = new Dictionary<string, Ipurchasable>();
    }
  }
}
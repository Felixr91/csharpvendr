using System;
using System.Collections.Generic;
using VendingMachine.Models;

namespace VendingMachine
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Machine myMachine = new Machine("Felix's Nourishment Bot");
      Food snickers = new Food(1f, 10, "Snickers", "Chocolate Bar", "04/2022");
      Food kitkat = new Food(1f, 9, "KitKat", "Chocolate Bar", "04/2025");
      Drink aqua = new Drink(1.75f, 10, "Aquafina", "beverage", "02/3000");
      Drink coke = new Drink(1.25f, 10, "Coke can", "beverage", "02/2022");
      Electronic earbuds = new Electronic("Earbuds", 20f, 5, "SONY", "Music Accesory");
      Electronic usb = new Electronic("USB Flash Drive", 10f, 8, "EMTEC", "Storage Device");

      myMachine.Inventory.Add("A1", snickers);
      myMachine.Inventory.Add("A2", kitkat);
      myMachine.Inventory.Add("A3", aqua);
      myMachine.Inventory.Add("A4", coke);
      myMachine.Inventory.Add("B1", earbuds);
      myMachine.Inventory.Add("B2", usb);

      //Print Available Items
      Console.WriteLine("Available Items:");
      foreach (var pair in myMachine.Inventory)
      {
        System.Console.WriteLine($"{pair.Key}, {pair.Value.Brand}, {pair.Value.Price}, {pair.Value.Quantity}");
      }
      Console.WriteLine("What would you like to buy? Enter Item code");
      string selection = Console.ReadLine();


      //Take item location
      foreach (var pair in myMachine.Inventory)
      {
        if (selection == pair.Key)
        {
          pair.Value.Quantity = pair.Value.Quantity - 1;
          System.Console.WriteLine("Yum!" + $"{pair.Value.Brand}");
        }
      }
      foreach (var pair in myMachine.Inventory)
      {
        System.Console.WriteLine($"{pair.Key}, {pair.Value.Brand}, {pair.Value.Price}, {pair.Value.Quantity}");
      }
    }
  }
}

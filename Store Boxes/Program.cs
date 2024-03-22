using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForABox { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Box> boxes = new List<Box>();
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] data = input.Split();
            string serialNumber = data[0];
            string itemName = data[1];
            int itemQuantity = int.Parse(data[2]);
            decimal itemPrice = decimal.Parse(data[3]);

            Item item = new Item { Name = itemName, Price = itemPrice };
            Box box = new Box
            {
                SerialNumber = serialNumber,
                Item = item,
                ItemQuantity = itemQuantity,
                PriceForABox = itemQuantity * itemPrice
            };

            boxes.Add(box);
        }

        foreach (var box in boxes.OrderByDescending(b => b.PriceForABox))
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.PriceForABox:F2}");
        }
    }
}

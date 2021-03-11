﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();
            while (input!="end")
            {
                string[] inputInfo = input.Split();
                string serialNumber = inputInfo[0];
                string itemName = inputInfo[1];
                int itemQuantity = int.Parse(inputInfo[2]);
                decimal itemPrice = decimal.Parse(inputInfo[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;
                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.Item = item;

                boxes.Add(box);
                input = Console.ReadLine();
            }

            foreach (var currentBox in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:f2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForABox:f2}");
            }
        }
    }

    class Item
    {
        
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox 
            => Item.Price*ItemQuantity;
    }
}

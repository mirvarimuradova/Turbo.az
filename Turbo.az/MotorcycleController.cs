using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    internal class MotorcycleController: IVehicleController
    {
        ArrayList Motos;
        public MotorcycleController() { 
          
            Motos = new ArrayList();
        }
        public void   Add(IVehicle vehicle)            
        {
           Motos.Add(vehicle);
        }
        public void ShowProduct()
        {
            int id = 0;
            Console.WriteLine("\nMotorcycles:");
            foreach (Motorcycle item in Motos)
            {
                id++;
                Console.WriteLine($"Product {id}");
                Console.WriteLine($"Brand: {item.Brand}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Color: {item.Color}");
                Console.WriteLine($"Engine: {item.Engine}");
                Console.WriteLine($"Price: {item.Price}");
              

            }
        }
        public void UpdateVehicle(int id, int property, string newvalue)
        {
            int Id = 0;
            foreach (Motorcycle item in Motos)
            {
                Id++;
                if (Id == id)
                {
                    if (property == 1)
                    {
                        item.Brand = newvalue;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                    else if (property == 2) { 
                        item.Model = newvalue;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                    else if (property == 3)
                    {

                        decimal newprice = decimal.Parse(newvalue);
                        item.Price = newprice;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                    else if (property == 4)
                    {
                        item.Color = newvalue;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                    else if (property == 5)
                    {

                        item.Engine = newvalue;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                }
            }
        }
        public void RemoveVehicle(int id)
        {

        }
      public   void SearchByPrice(decimal price) { }
      public   void SearchByBrand(string brand) {

            foreach (Motorcycle item in Motos)
            {
                if (item.Brand == brand)
                {
                    Console.WriteLine($"Brand: {item.Brand}");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Color: {item.Color}");
                    Console.WriteLine($"Engine: {item.Engine}");

                }
                else
                {
                    Console.WriteLine("Not found... ");

                }
            }
        }
      public  void SearchByModel(string model) {
            foreach (Motorcycle item in Motos)
            {
                if (item.Model == model)
                {
                    Console.WriteLine($"Brand: {item.Brand}");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Color: {item.Color}");
                    Console.WriteLine($"Engine: {item.Engine}");

                }
                else
                {
                    Console.WriteLine("Not found... ");

                }
            }
        }

        public void PriceLow(decimal price) {

            int id = 0;
            foreach (Motorcycle item in Motos)
            {
                decimal maxprice = (price + 10000);
                decimal minprice = price - 5000;
                if (minprice > 0)
                {
                    if (item.Price < maxprice && item.Price > minprice)
                    {
                        id++;
                        Console.WriteLine($"\nId: {id}");
                        Console.WriteLine($"Brand: {item.Brand}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Engine: {item.Engine}");
                    }
                }
                else if (item.Price < maxprice && item.Price > price)
                {

                    id++;
                    Console.WriteLine($"\nId: {id}");
                    Console.WriteLine($"Brand: {item.Brand}");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Color: {item.Color}");
                    Console.WriteLine($"Engine: {item.Engine}");
                }

                else
                {
                    Console.WriteLine("Truck not found...");
                }
            }
        }
    }
}

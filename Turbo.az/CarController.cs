using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    internal class CarController : IVehicleController
    {

        ArrayList Cars;
        public CarController()
        {

            Cars = new ArrayList();

        }
        int id = 0;
        public void Add(IVehicle vehicle)
        {

            Cars.Add(vehicle);

           

        }

        public void ShowProduct()
        {
            int id = 0;
            foreach (Car item in Cars)
            {

                id++;
                Console.WriteLine("\nCars:");
                Console.WriteLine($"\nProduct {id}");
                Console.WriteLine($"Brand: {item.Brand}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Color: {item.Color}");
                Console.WriteLine($"Engine: {item.Engine}");
                Console.WriteLine($"Price: {item.Price}");

            }
        }

        public void SearchByPrice(decimal price)
        {
            foreach (Car item in Cars)
            {
                if (item.Price == price)
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
        public void SearchByBrand(string brand)
        {
            foreach (Car item in Cars)
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
        public void SearchByModel(string model)
        {
            int id = 0;
            foreach (Car item in Cars)
            {
                if (item.Model == model)
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
                    Console.WriteLine("Not found... ");

                }
            }

        }

        public void UpdateVehicle(int id, int property, string newvalue)
        {
            int Id = 0;
            foreach(Car item in Cars)
            {
                Id++;
                if (Id == id)
                {
                    if (property == 1)
                    {
                        item.Brand = newvalue;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                    else if (property == 2) { item.Model = newvalue; }
                    else if(property == 3) { 
                        
                        decimal newprice = decimal.Parse(newvalue);
                        item.Price = newprice;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                    else if(property == 4)
                    {
                        item.Color = newvalue;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                    else if(property == 5){

                        item.Engine= newvalue;
                        Console.WriteLine(" The property succesfully updated!");
                    }
                }
            }
        }

        public void RemoveVehicle(int id)
        {
            foreach (Car item in Cars) { 
            
                   Cars.Remove(item);
            }
        }
        public void PriceLow(decimal price)
        {
            int id = 0;
            foreach (Car item in Cars)
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
                else if(item.Price < maxprice && item.Price > price)
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

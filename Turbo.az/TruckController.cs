using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    internal class TruckController: IVehicleController
    {
        ArrayList Trucks;
        public TruckController() { 


            Trucks = new ArrayList();
        
        }
        public void Add(IVehicle  truck)
        {
            Trucks.Add(truck);
            Console.WriteLine("Truck succesfully added!");

        }

        public void ShowProduct() {
            Console.WriteLine("\nTrucks:");
            int id = 0;
            foreach (Truck item in Trucks)
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

       public  void SearchByPrice(decimal price)
        {
            int id= 0;
            foreach (Truck item in Trucks)
            {
                id++;
                if (item.Price == price)
                {
                    Console.WriteLine($"Id: {id}");
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
            foreach (Truck item in Trucks)
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
        public void RemoveVehicle(int idd)
        {
           int  id= 0;
            foreach (Truck item in Trucks) {
                id++;
                if(id== idd)
                {

                    
                }
            
            }
        }


       public  void SearchByBrand(string brand) {

            foreach (Truck item in Trucks)
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
       public void SearchByModel(string model) {
            foreach (Truck item in Trucks)
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
            foreach (Truck item in Trucks)
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

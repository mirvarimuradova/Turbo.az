using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    internal class Truck : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
       
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }

        ArrayList Trucks= new ArrayList();
        public Truck(string brand, string model, decimal price, string color, string engine)
        {
            
            Brand = brand;
            Model = model;
        
            Price = price;
            Color = color;
            Engine = engine;

            
            
        } 
    }
}

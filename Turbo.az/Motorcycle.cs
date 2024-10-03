using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    internal class Motorcycle: IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
      
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Engine {  get; set; }

        public Motorcycle(string brand, string model,decimal price,string olor, string engine)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Color = olor;
            Engine = engine;

        }
    }
}

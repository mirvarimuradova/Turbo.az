using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
  interface  IVehicleController 
    {

        void Add(IVehicle vehicle);
        void ShowProduct();

      public  void SearchByPrice(decimal price );
        void SearchByBrand(string brand);
        void SearchByModel(string model);

        void UpdateVehicle(int id, int property, string newvalue);
        void RemoveVehicle(int id);
         
    }
}

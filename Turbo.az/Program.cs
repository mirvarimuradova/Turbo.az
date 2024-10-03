// Sign In 
// Sign Up
// Show All Vehicles 
// Search By Price
// Search By Brand
// Search By Model
// Search By Price Low 
// Search By Price Hight
// Search By Km 
// Add Vehicle 
// Update Vehicle
// Remove Vehicle 
// Exit 

using System.Text.RegularExpressions;
using Turbo.az;

Motorcycle moto1 = new Motorcycle("Kawasaki", "Ninja 650" , 20999, "green", "0.7 L / 68 a.g./ fuel");

MotorcycleController motoController = new MotorcycleController();
motoController.Add(moto1);


Car car1 = new Car("Dodge", "Challenger", 64600, "white", "3.6 L/305 a.g./Benzin");
CarController carController = new CarController();
carController.Add(car1);

Truck truck1 = new Truck("Volvo", "FH 460",  35000, "yellow", "13 L/460 a.g./Dizel");
TruckController truckController = new TruckController();

truckController.Add(truck1);

truckController.ShowProduct();


User user1 = new User("Mirvari", "Muradova", "mirvarimuradova@gmail.com", "mirvari2003", UserRole.User);

user1.AddUser(user1);


restart:
Console.WriteLine("please enter true value:");
Console.Clear();
Console.WriteLine("1.Sign in\n" +
    "2.Sign up\n" +
    "3.Guess");

var login = Console.ReadLine();
int log;

bool check = int.TryParse(login, out log);
int loginn;

if (check && login!="")
{
    loginn = Convert.ToInt32(login);


    if (loginn == 1)
    {
    label1:
        Console.Clear();
        Console.Write("Email: ");
        string email = Console.ReadLine() ?? "";

        Console.WriteLine("Passsword: ");
        string password = Console.ReadLine() ?? "";

        if (User.GetUSer(email, password))
        {
        ReMethod:
            Console.WriteLine("1.Show All Vehicles \n" +
                "2.Search By Price\n" +
                "3.Search By Brand\n" +
                "4.Search By Model\n" +
                "5.Search By Price Low \n" +
               
                "6.Add Vehicle \n" +
                "7. Update Vehicle\n" +
                "8.Remove Vehicle \n" +
                "9.Exit ");

            var func = Console.ReadLine() ;

            int f;
            bool checkfunc = int.TryParse(func, out f);

            int funcc;
            if (checkfunc && func!="")
            {
                funcc = Convert.ToInt32(func);

                if (funcc == 1)
                {
                    carController.ShowProduct();
                    motoController.ShowProduct();
                    truckController.ShowProduct();

                    Console.ReadLine();
                    Console.Clear() ;
                    goto ReMethod;
                }
                else if (funcc ==2)
                {// pricce e gore filtr
                reChoice:
                    Console.Clear();
                    Console.WriteLine("Please choose a section:\n" +
                        "1.Car\n" +
                        "2.Truck\n" +
                        "3.Motorcycle");

                    var choiceCategoryForPrice = Console.ReadLine();

                    int a;

                    bool checkchoice = int.TryParse(choiceCategoryForPrice, out a);
                    int choicee;
                    if (checkchoice)
                    {
                       
                        choicee = Convert.ToInt32(choiceCategoryForPrice);
                        if (choicee == 1)//Car-i secib demeli 
                        {
                        rePrice:
                            Console.Write("Pleace enter the price:");
                            var price = Console.ReadLine();

                            decimal b;

                            bool checkprice = decimal.TryParse(price, out b);

                            if (checkprice)
                            {
                                b = Convert.ToInt32(price);
                                carController.SearchByPrice(b);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The type of price is not true, pleace enter again:");
                                goto rePrice;

                            }
                        }
                        else if (choicee == 2)//Truck
                        {
                        rePrice:
                            Console.Write("Pleace enter the price:");
                            var price = Console.ReadLine();

                            decimal b;

                            bool checkprice = decimal.TryParse(price, out b);

                            if (checkprice)
                            {
                                b= Convert.ToInt32(price);
                                truckController.SearchByPrice(b);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The type of price is not true, pleace enter again:");
                                goto rePrice;

                            }

                        }
                        else if (choicee == 3)//Moto
                        {

                        rePrice:
                            Console.Write("Pleace enter the price:");
                            var price = Console.ReadLine();

                            decimal b;

                            bool checkprice = decimal.TryParse(price, out b);

                            if (checkprice)
                            {
                                b= Convert.ToInt32(price);
                                motoController.SearchByPrice(b);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The type of price is not true, pleace enter again:");
                                goto rePrice;

                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Value is not true!");
                            goto reChoice;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" The type of section is not true, please enter again : \n");
                        goto reChoice;
                    }

                }

                else if (funcc == 3)
                {
                // brand e gore filtr
                reChoice:
                    Console.Clear();
                    Console.WriteLine("Please choose a section:\n" +
                        "1.Car\n" +
                        "2.Truck\n" +
                        "3.Motorcycle");

                    var choiceCategoryForPrice = Console.ReadLine();

                    int a;

                    bool checkchoice = int.TryParse(choiceCategoryForPrice, out a);
                    int choicee;
                    if (checkchoice)
                    {
                        choicee = Convert.ToInt32(choiceCategoryForPrice);
                        if (choicee == 1)//Car-i secib demeli 
                        {
                       
                            Console.Write("Pleace enter the brand:");
                            string brand = Console.ReadLine()??"";

                                carController.SearchByBrand(brand);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;
                            
                        }
                        else if (choicee == 2)//Truck
                        {
                        
                            Console.Write("Pleace enter the brand:");
                            string brand = Console.ReadLine()??"";

                            truckController.SearchByBrand(brand);
                            Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;


                        }
                        else if (choicee == 3)//Moto
                        {

                        
                            Console.Write("Pleace enter the brand:");
                            var price = Convert.ToDecimal(Console.ReadLine());

                            string brand = Console.ReadLine()??"";

                            motoController.SearchByBrand(brand);
                            Console.ReadLine();
                            Console.Clear();
                            goto ReMethod;

                           
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Value is not true!");
                            goto reChoice;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" The type of section is not true, please enter again : \n");
                        goto reChoice;
                    }


                }
                else if(funcc== 4)
                {
                // modele gore filtr
                reChoice:
                    Console.Clear();
                    Console.WriteLine("Please choose a section:\n" +
                        "1.Car\n" +
                        "2.Truck\n" +
                        "3.Motorcycle");

                    var choiceCategoryForPrice = Console.ReadLine();

                    int a;

                    bool checkchoice = int.TryParse(choiceCategoryForPrice, out a);
                    int choicee;
                    if (checkchoice)
                    {
                        choicee = Convert.ToInt32(choiceCategoryForPrice);
                        if (choicee == 1)//Car-i secib demeli 
                        {

                            Console.Write("Pleace enter the model:");
                            string model = Console.ReadLine() ?? "";



                            carController.SearchByModel(model);
                            Console.ReadLine();
                            Console.Clear();
                            goto ReMethod;


                        }
                        else if (choicee == 2)//Truck
                        {

                            Console.Write("Pleace enter the model:");
                            string model = Console.ReadLine() ?? "";

                            truckController.SearchByModel(model);
                            Console.ReadLine();
                            Console.Clear();
                            goto ReMethod;


                        }
                        else if (choicee == 3)//Moto
                        {


                            Console.Write("Pleace enter the model:");
                            string model = Console.ReadLine() ?? "";

                            motoController.SearchByModel(model);
                            Console.ReadLine();
                            Console.Clear();
                            goto ReMethod;


                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Value is not true!");
                            goto reChoice;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" The type of section is not true, please enter again : \n");
                        goto reChoice;
                    }
                }

                else if(funcc== 5)
                {
                // price low filtr

                reChoice:
                    Console.Clear();
                    Console.WriteLine("Please choose a section:\n" +
                        "1.Car\n" +
                        "2.Truck\n" +
                        "3.Motorcycle");

                    var choiceCategoryForPrice = Console.ReadLine();

                    int a;

                    bool checkchoice = int.TryParse(choiceCategoryForPrice, out a);
                    int choicee;
                    if (checkchoice)
                    {
                        choicee = Convert.ToInt32(choiceCategoryForPrice);
                        if (choicee == 1)//Car-i secib demeli 
                        {
                        rePrice:
                            Console.Write("Pleace enter the price:");
                            var price = Console.ReadLine();

                            decimal b;

                            bool checkprice = decimal.TryParse(price, out b);

                            if (checkprice)
                            {
                                b= Convert.ToInt32(price);
                                carController.PriceLow(b);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The type of price is not true, pleace enter again:");
                                goto rePrice;

                            }
                        }
                        else if (choicee == 2)//Truck
                        {
                        rePrice:
                            Console.Write("Pleace enter the price:");
                            var price = Console.ReadLine();

                            decimal b;

                            bool checkprice = decimal.TryParse(price, out b);

                            if (checkprice)
                            {
                                b= Convert.ToInt32(price);
                                truckController.PriceLow(b);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The type of price is not true, pleace enter again:");
                                goto rePrice;

                            }

                        }
                        else if (choicee == 3)//Moto
                        {

                        rePrice:
                            Console.Write("Pleace enter the price:");
                            var price = Console.ReadLine();

                            decimal b;

                            bool checkprice = decimal.TryParse(price, out b);

                            if (checkprice)
                            {
                                b= Convert.ToInt32(price);
                                motoController.PriceLow(b);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("The type of price is not true, pleace enter again:");
                                goto rePrice;

                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Value is not true!");
                            goto reChoice;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" The type of section is not true, please enter again : \n");
                        goto reChoice;
                    }
                }
                else if (funcc == 6)
                {
                    // add vehicle
                label3:
                    Console.WriteLine("Please choose the section of vehicle: ");
                    Console.WriteLine("1.Car\n" +
                        "2.Truck\n" +
                        "3.Motorcycle");

                    var choice = Console.ReadLine();

                    int c;

                    bool checkk = int.TryParse(choice, out c);

                    int choicee;
                    if (checkk)
                    {

                        choicee = Convert.ToInt32(choice);

                        if (choicee == 1)
                        {
                            Console.Write("Brand: ");
                            string brand = Console.ReadLine() ?? "unknown";

                            Console.Write("Model: ");
                            string model = Console.ReadLine() ?? "unknown";

                            Console.Write("Color: ");
                            string color = Console.ReadLine() ?? "unknown";

                            Console.Write("Engine: ");
                            string engine = Console.ReadLine() ?? "unknown";

                        label2:
                            Console.Write("Price: ");
                            var price = Console.ReadLine();

                            decimal pricee;

                             checkk = decimal.TryParse(price, out pricee);


                            if (checkk)
                            {

                                pricee = Convert.ToDecimal(price);

                                Car car = new Car(brand, model, pricee, color, engine);

                                carController.Add(car);
                                Console.WriteLine("The vehicle succesfully added!");
                                Console.ReadLine();
                                goto ReMethod;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong value");
                                goto label2;
                            }



                        }
                        else if (choicee == 2)
                        {
                            Console.Write("Brand: ");
                            string brand = Console.ReadLine() ?? "unknown";

                            Console.Write("Model: ");
                            string model = Console.ReadLine() ?? "unknown";

                            Console.Write("Color: ");
                            string color = Console.ReadLine() ?? "unknown";

                            Console.Write("Engine: ");
                            string engine = Console.ReadLine() ?? "unknown";

                        label2:
                            Console.Write("Price: ");
                            var price = Console.ReadLine();

                            decimal pricee;

                             checkk = decimal.TryParse(price, out pricee);


                            if (checkk)
                            {

                                pricee = Convert.ToDecimal(price);

                                Truck truck = new Truck(brand, model, pricee, color, engine);

                                truckController.Add(truck);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong value");
                                goto label2;
                            }


                        }
                        else if (choicee == 3)
                        {

                            Console.Write("Brand: ");
                            string brand = Console.ReadLine() ?? "unknown";

                            Console.Write("Model: ");
                            string model = Console.ReadLine() ?? "unknown";

                            Console.Write("Color: ");
                            string color = Console.ReadLine() ?? "unknown";

                            Console.Write("Engine: ");
                            string engine = Console.ReadLine() ?? "unknown";

                        label2:
                            Console.Write("Price: ");
                            var price = Console.ReadLine();

                            decimal pricee;

                             checkk = decimal.TryParse(price, out pricee);


                            if (checkk)
                            {

                                pricee = Convert.ToDecimal(price);

                                Motorcycle moto = new Motorcycle(brand, model, pricee, color, engine);

                                carController.Add(moto);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong value");
                                goto label2;
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong value");
                            goto label3;
                        }

                    }

                }

                else if (funcc == 7)
                {
                label3:
                    Console.WriteLine("Please choose the section of vehicle:\n" +
                        "1.Car\n" +
                        "2.Truck\n" +
                        "3.Motorcycle");

                    var section = Console.ReadLine();

                    int c;
                    bool checksection = int.TryParse(section, out c);

                    int choicee;
                    if (checksection)
                    {
                        choicee = Convert.ToInt32(section);

                        if (choicee == 1)
                        {
                        // car  ucun update
                        againCarId:
                            carController.ShowProduct();
                            Console.WriteLine("Please choose car:\n");
                            var id = Console.ReadLine();
                            int e;
                            bool chechtype = int.TryParse(id, out e);

                            if (chechtype)
                            {
                            ReProperty:
                                e = Convert.ToInt32(id);
                                Console.WriteLine("Which property do you want to change:\n" +
                                    "1.Brand\n" +
                                    "2.Model\n" +
                                    "3.Price\n" +
                                    "4.Color\n" +
                                    "5.Engine");

                                var property = Console.ReadLine();
                                int g;
                                bool checkproperty = int.TryParse(property, out g);


                                if (checkproperty)
                                {

                                    g = Convert.ToInt32(id);

                                    if (g == 3)
                                    {
                                        newPrice:
                                        Console.Write("New value:");
                                        var newprice =  Console.ReadLine()??"" ;
                                        decimal i;
                                         
                                        bool checkPriceType = decimal.TryParse(newprice, out i);

                                        if (checkPriceType)
                                        {
                                            string newpriceStringtype = newprice;
                                            carController.UpdateVehicle(e, g, newpriceStringtype);

                                            Console.ReadLine();
                                            Console.Clear();
                                            goto ReMethod;
                                        }

                                       else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("The  price can not become this type!");
                                            goto newPrice;
                                        }
                                    }


                                    if (g < 1 || g > 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not such a property: ");
                                        goto ReProperty;
                                    }
                                    Console.Write("New value:");
                                    string newvalue = Console.ReadLine() ?? "";
                                    carController.UpdateVehicle(e, g, newvalue);

                                    Console.ReadLine();
                                    Console.Clear();
                                    goto ReMethod;

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(" Car property can not be this type, please enter true value:");
                                    goto ReProperty;
                                }

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Car id can not be this type, please enter true value:");
                                goto againCarId;
                            }

                        }

                        else if (choicee == 2)
                        {
                        // truck ucun update 
                        againTruckId:
                       
                            carController.ShowProduct();
                            Console.WriteLine("Please choose Truck:\n");
                            var id = Console.ReadLine();
                            int e;
                            bool chechtype = int.TryParse(id, out e);

                            if (chechtype)
                            {
                            ReProperty:
                                e = Convert.ToInt32(id);
                                Console.WriteLine("Which property do you want to change:\n" +
                                    "1.Brand\n" +
                                    "2.Model\n" +
                                    "3.Price\n" +
                                    "4.Color\n" +
                                    "5.Engine");

                                var property = Console.ReadLine();
                                int g;
                                bool checkproperty = int.TryParse(property, out g);


                                if (checkproperty)
                                {

                                    g = Convert.ToInt32(id);

                                    if (g == 3)
                                    {
                                    newPrice:
                                        Console.Write("New value:");
                                        var newprice = Console.ReadLine() ?? "";
                                        decimal i;

                                        bool checkPriceType = decimal.TryParse(newprice, out i);

                                        if (checkPriceType)
                                        {
                                            string newpriceStringtype = newprice;
                                            truckController.UpdateVehicle(e, g, newpriceStringtype);

                                            Console.ReadLine();
                                            Console.Clear();
                                            goto ReMethod;
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("The  price can not become this type!");
                                            goto newPrice;
                                        }
                                    }
                                    if (g < 1 || g > 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not such a property: ");
                                        goto ReProperty;
                                    }

                                    Console.Write("New value:");
                                    string newvalue = Console.ReadLine() ?? "";
                                    truckController.UpdateVehicle(e, g, newvalue);

                                    Console.ReadLine();
                                    Console.Clear();
                                    goto ReMethod;


                                    

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(" Truck property can not be this type, please enter true value:");
                                    goto ReProperty;
                                }

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Truck id can not be this type, please enter true value:");
                                goto againTruckId;
                            }
                        }

                        else if (choicee == 3)
                        {
                        // moto ucun update
                        againMotoId:
                            carController.ShowProduct();
                            Console.WriteLine("Please choose Motorcycle:\n");
                            var id = Console.ReadLine();
                            int e;
                            bool chechtype = int.TryParse(id, out e);

                            if (chechtype)
                            {
                            ReProperty:
                                e = Convert.ToInt32(id);
                                Console.WriteLine("Which property do you want to change:\n" +
                                    "1.Brand\n" +
                                    "2.Model\n" +
                                    "3.Price\n" +
                                    "4.Color\n" +
                                    "5.Engine");

                                var property = Console.ReadLine();
                                int g;
                                bool checkproperty = int.TryParse(property, out g);


                                if (checkproperty)
                                {

                                    g = Convert.ToInt32(id);

                                    if (g == 3)
                                    {
                                    newPrice:
                                        Console.Write("New value:");
                                        var newprice = Console.ReadLine() ?? "";
                                        decimal i;

                                        bool checkPriceType = decimal.TryParse(newprice, out i);

                                        if (checkPriceType)
                                        {
                                            string newpriceStringtype = newprice;
                                            motoController.UpdateVehicle(e, g, newpriceStringtype);

                                            Console.ReadLine(); 
                                            Console.Clear();
                                            goto ReMethod;
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("The  price can not become this type!");
                                            goto newPrice;
                                        }
                                    }
                                    if (g < 1 || g > 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not such a property: ");
                                        goto ReProperty;
                                    }
                                    Console.Write("New value:");
                                    string newvalue = Console.ReadLine() ?? "";
                                    motoController.UpdateVehicle(e, g, newvalue);
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto ReMethod;

                                   

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(" Motorcycle property can not be this type, please enter true value:");
                                    goto ReProperty;
                                }

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Car id can not be this type, please enter true value:");
                                goto againMotoId;
                            }
                        }

                        else
                        {

                            Console.Clear();
                            Console.WriteLine("Wrong value");
                            goto label3;

                        }

                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong value");
                        goto label3;
                    }


                }
                else if (funcc == 8)
                {

                label4:
                    Console.WriteLine("Please choose the section of vehicle:\n" +
                        "1.Car\n" +
                        "2.Truck\n" +
                        "3.Motorcycle");

                    var section = Console.ReadLine();

                    int c;
                    bool checksection = int.TryParse(section, out c);

                    int choicee;
                    if (checksection)
                    {
                        choicee = Convert.ToInt32(section);

                        if (choicee == 1)
                        {
                        // car  ucun remove
                        againCarId:
                            carController.ShowProduct();
                            Console.WriteLine("Please choose car:\n");
                            var id = Console.ReadLine();
                            int e;
                            bool chechtype = int.TryParse(id, out e);

                            if (chechtype)
                            {
                            ReProperty:
                                e = Convert.ToInt32(id);
                                Console.WriteLine("Which property do you want to change:\n" +
                                    "1.Brand\n" +
                                    "2.Model\n" +
                                    "3.Price\n" +
                                    "4.Color\n" +
                                    "5.Engine");

                                var property = Console.ReadLine();
                                int g;
                                bool checkproperty = int.TryParse(property, out g);


                                if (checkproperty)
                                {

                                    g = Convert.ToInt32(id);

                                    if (g == 3)
                                    {
                                    newPrice:
                                        Console.Write("New value:");
                                        var newprice = Console.ReadLine() ?? "";
                                        decimal i;

                                        bool checkPriceType = decimal.TryParse(newprice, out i);

                                        if (checkPriceType)
                                        {
                                            string newpriceStringtype = newprice;
                                            carController.UpdateVehicle(e, g, newpriceStringtype);

                                            Console.ReadLine();
                                            Console.Clear();
                                            goto ReMethod;
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("The  price can not become this type!");
                                            goto newPrice;
                                        }
                                    }


                                    if (g < 1 || g > 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not such a property: ");
                                        goto ReProperty;
                                    }
                                    Console.Write("New value:");
                                    string newvalue = Console.ReadLine() ?? "";
                                    carController.UpdateVehicle(e, g, newvalue);

                                    Console.ReadLine();
                                    Console.Clear();
                                    goto ReMethod;

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(" Car property can not be this type, please enter true value:");
                                    goto ReProperty;
                                }

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Car id can not be this type, please enter true value:");
                                goto againCarId;
                            }

                        }

                        else if (choicee == 2)
                        {
                        // truck ucun remove
                        againTruckId:

                            carController.ShowProduct();
                            Console.WriteLine("Please choose Truck:\n");
                            var id = Console.ReadLine();
                            int e;
                            bool chechtype = int.TryParse(id, out e);

                            if (chechtype)
                            {
                            ReProperty:
                                e = Convert.ToInt32(id);
                                Console.WriteLine("Which property do you want to change:\n" +
                                    "1.Brand\n" +
                                    "2.Model\n" +
                                    "3.Price\n" +
                                    "4.Color\n" +
                                    "5.Engine");

                                var property = Console.ReadLine();
                                int g;
                                bool checkproperty = int.TryParse(property, out g);


                                if (checkproperty)
                                {

                                    g = Convert.ToInt32(id);

                                    if (g == 3)
                                    {
                                    newPrice:
                                        Console.Write("New value:");
                                        var newprice = Console.ReadLine() ?? "";
                                        decimal i;

                                        bool checkPriceType = decimal.TryParse(newprice, out i);

                                        if (checkPriceType)
                                        {
                                            string newpriceStringtype = newprice;
                                            truckController.UpdateVehicle(e, g, newpriceStringtype);

                                            Console.ReadLine();
                                            Console.Clear();
                                            goto ReMethod;
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("The  price can not become this type!");
                                            goto newPrice;
                                        }
                                    }
                                    if (g < 1 || g > 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not such a property: ");
                                        goto ReProperty;
                                    }

                                    Console.Write("New value:");
                                    string newvalue = Console.ReadLine() ?? "";
                                    truckController.UpdateVehicle(e, g, newvalue);

                                    Console.ReadLine();
                                    Console.Clear();
                                    goto ReMethod;




                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(" Truck property can not be this type, please enter true value:");
                                    goto ReProperty;
                                }

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Truck id can not be this type, please enter true value:");
                                goto againTruckId;
                            }
                        }

                        else if (choicee == 3)
                        {
                        // moto ucun remove
                        againMotoId:
                            carController.ShowProduct();
                            Console.WriteLine("Please choose Motorcycle:\n");
                            var id = Console.ReadLine();
                            int e;
                            bool chechtype = int.TryParse(id, out e);

                            if (chechtype)
                            {
                            ReProperty:
                                e = Convert.ToInt32(id);
                                Console.WriteLine("Which property do you want to change:\n" +
                                    "1.Brand\n" +
                                    "2.Model\n" +
                                    "3.Price\n" +
                                    "4.Color\n" +
                                    "5.Engine");

                                var property = Console.ReadLine();
                                int g;
                                bool checkproperty = int.TryParse(property, out g);


                                if (checkproperty)
                                {

                                    g = Convert.ToInt32(id);

                                    if (g == 3)
                                    {
                                    newPrice:
                                        Console.Write("New value:");
                                        var newprice = Console.ReadLine() ?? "";
                                        decimal i;

                                        bool checkPriceType = decimal.TryParse(newprice, out i);

                                        if (checkPriceType)
                                        {
                                            string newpriceStringtype = newprice;
                                            motoController.UpdateVehicle(e, g, newpriceStringtype);

                                            Console.ReadLine();
                                            Console.Clear();
                                            goto ReMethod;
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("The  price can not become this type!");
                                            goto newPrice;
                                        }
                                    }
                                    if (g < 1 || g > 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not such a property: ");
                                        goto ReProperty;
                                    }
                                    Console.Write("New value:");
                                    string newvalue = Console.ReadLine() ?? "";
                                    motoController.UpdateVehicle(e, g, newvalue);
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto ReMethod;



                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(" Motorcycle property can not be this type, please enter true value:");
                                    goto ReProperty;
                                }

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Car id can not be this type, please enter true value:");
                                goto againMotoId;
                            }
                        }

                        else
                        {

                            Console.Clear();
                            Console.WriteLine("Wrong value");
                            goto label4;

                        }

                    }


                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong value");
                        goto label4;
                    }

                }

            }

        }
        else
        {
            Console.WriteLine("email or password is not correct!");

            goto label1;
        }

    }
    else if (loginn == 2)
    {
        resignup:
        Console.WriteLine("Please enter your infos: ");

        Console.Write("Name: ");
        string name = Console.ReadLine()??"";

        Console.Write("Surname: ");
        string surname = Console.ReadLine() ?? "";

        reEmail:
        Console.Write("Email: ");
        string email = Console.ReadLine()??"";
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
       bool IsValidEmail=  Regex.IsMatch(email, emailPattern);

        if (!IsValidEmail)
        {
            Console.WriteLine("Email format is not true:");
            goto reEmail;
        }

        Console.Write("Password: ");
        string password = Console.ReadLine()??"";

        rrepassword:
        Console.Write("Repeat password: ");
        string repassword = Console.ReadLine() ?? "";

        if (password == repassword) { 

            if(password =="" || email=="" || name ==""|| surname == "")
            {
                Console.Clear() ;
                Console.WriteLine("infos can not be empty!");
                goto resignup;
            }
        else
            {
                User newuser = new User(name, surname, email, password, UserRole.User);

                newuser.AddUser(newuser);

                Console.WriteLine("Your registration succesfully completed!");
                Console.ReadLine();
                goto restart;
            }
         

        }
        else
        {
            Console.WriteLine("Password is not same!");
            Console.ReadLine();
            goto rrepassword;
        }

    }
    else if (loginn == 3)
    {
        ReMethod:

        Console.WriteLine("1.Show All Vehicles \n" +
              "2.Search By Price\n" +
              "3.Search By Brand\n" +
              "4.Search By Model\n" +
              "5.Search By Price Low \n" +
              "6.Exit ");

        var func = Console.ReadLine();

        int f;
        bool checkfunc = int.TryParse(func, out f);

        int funcc;
        if (checkfunc)
        {

            funcc = Convert.ToInt32(func);

            if (funcc == 1)
            {
                carController.ShowProduct();
                motoController.ShowProduct();
                truckController.ShowProduct();

                Console.ReadLine();
                Console.Clear();
                goto ReMethod;
            }
            else if (funcc == 2)
            {// pricce e gore filtr
            reChoice:
                Console.Clear();
                Console.WriteLine("Please choose a section:\n" +
                    "1.Car\n" +
                    "2.Truck\n" +
                    "3.Motorcycle");

                var choiceCategoryForPrice = Console.ReadLine();

                int a;

                bool checkchoice = int.TryParse(choiceCategoryForPrice, out a);
                int choicee;
                if (checkchoice)
                {
                    choicee = Convert.ToInt32(choiceCategoryForPrice);
                    if (choicee == 1)//Car-i secib demeli 
                    {
                    rePrice:
                        Console.Write("Pleace enter the price:");
                        var price = Console.ReadLine();

                        decimal b;

                        bool checkprice = decimal.TryParse(price, out b);

                        if (checkprice)
                        {
                            b = Convert.ToDecimal(price);
                            carController.SearchByPrice(b);
                            Console.Clear();
                            goto ReMethod;

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The type of price is not true, pleace enter again:");
                            goto rePrice;

                        }
                    }
                    else if (choicee == 2)//Truck
                    {
                    rePrice:
                        Console.Write("Pleace enter the price:");
                        var price = Console.ReadLine();

                        decimal b;

                        bool checkprice = decimal.TryParse(price, out b);

                        if (checkprice)
                        {
                            b = Convert.ToDecimal(price);
                            truckController.SearchByPrice(b);
                            Console.Clear();
                            goto ReMethod;

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The type of price is not true, pleace enter again:");
                            goto rePrice;

                        }

                    }
                    else if (choicee == 3)//Moto
                    {

                    rePrice:
                        Console.Write("Pleace enter the price:");
                        var price = Console.ReadLine();

                        decimal b;

                        bool checkprice = decimal.TryParse(price, out b);

                        if (checkprice)
                        {

                            b = Convert.ToDecimal(price);
                            motoController.SearchByPrice(b);
                            Console.Clear();
                            goto ReMethod;

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The type of price is not true, pleace enter again:");
                            goto rePrice;

                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Value is not true!");
                        goto reChoice;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" The type of section is not true, please enter again : \n");
                    goto reChoice;
                }

            }

            else if (funcc == 3)
            {
            // brand e gore filtr
            reChoice:
                Console.Clear();
                Console.WriteLine("Please choose a section:\n" +
                    "1.Car\n" +
                    "2.Truck\n" +
                    "3.Motorcycle");

                var choiceCategoryForPrice = Console.ReadLine();

                int a;

                bool checkchoice = int.TryParse(choiceCategoryForPrice, out a);
                int choicee;
                if (checkchoice)
                {
                    choicee = Convert.ToInt32(choiceCategoryForPrice);
                    if (choicee == 1)//Car-i secib demeli 
                    {

                        Console.Write("Pleace enter the brand:");
                        string brand = Console.ReadLine() ?? "";



                        carController.SearchByBrand(brand);
                        Console.Clear();
                        goto ReMethod;


                    }
                    else if (choicee == 2)//Truck
                    {

                        Console.Write("Pleace enter the brand:");
                        string brand = Console.ReadLine() ?? "";

                        truckController.SearchByBrand(brand);
                        Console.Clear();
                        goto ReMethod;


                    }
                    else if (choicee == 3)//Moto
                    {


                        Console.Write("Pleace enter the brand:");
                        var price = Convert.ToDecimal(Console.ReadLine());

                        string brand = Console.ReadLine() ?? "";

                        motoController.SearchByBrand(brand);
                        Console.Clear();
                        goto ReMethod;


                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Value is not true!");
                        goto reChoice;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" The type of section is not true, please enter again : \n");
                    goto reChoice;
                }


            }
            else if (funcc == 4)
            {
            // modele gore filtr
            reChoice:
                Console.Clear();
                Console.WriteLine("Please choose a section:\n" +
                    "1.Car\n" +
                    "2.Truck\n" +
                    "3.Motorcycle");

                var choiceCategoryForPrice = Console.ReadLine();

                int a;

                bool checkchoice = int.TryParse(choiceCategoryForPrice, out a);
                int choicee;
                if (checkchoice)
                {
                    choicee = Convert.ToInt32(choiceCategoryForPrice);
                    if (choicee == 1)//Car-i secib demeli 
                    {

                        Console.Write("Pleace enter the model:");
                        string model = Console.ReadLine() ?? "";



                        carController.SearchByModel(model);
                        Console.ReadLine();
                        Console.Clear();
                        goto ReMethod;


                    }
                    else if (choicee == 2)//Truck
                    {

                        Console.Write("Pleace enter the model:");
                        string model = Console.ReadLine() ?? "";

                        truckController.SearchByModel(model);
                        Console.ReadLine();
                        Console.Clear();
                        goto ReMethod;


                    }
                    else if (choicee == 3)//Moto
                    {


                        Console.Write("Pleace enter the model:");
                        string model = Console.ReadLine() ?? "";

                        motoController.SearchByModel(model);
                        Console.ReadLine();
                        Console.Clear();
                        goto ReMethod;


                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Value is not true!");
                        goto reChoice;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" The type of section is not true, please enter again : \n");
                    goto reChoice;
                }
            }

            else if (funcc == 5)
            {
            // price low filtr

            reChoice:
                Console.Clear();
                Console.WriteLine("Please choose a section:\n" +
                    "1.Car\n" +
                    "2.Truck\n" +
                    "3.Motorcycle");

                var choiceCategoryForPrice = Console.ReadLine();

                int a;

                bool checkchoice = int.TryParse(choiceCategoryForPrice, out a);
                int choicee;
                if (checkchoice)
                {
                    choicee = Convert.ToInt32(choiceCategoryForPrice);
                    if (choicee == 1)//Car-i secib demeli 
                    {
                    rePrice:
                        Console.Write("Pleace enter the price:");
                        var price = Console.ReadLine();

                        decimal b;

                        bool checkprice = decimal.TryParse(price, out b);

                        if (checkprice)
                        {
                            b = Convert.ToDecimal(price);
                            carController.PriceLow(b);
                            Console.ReadLine();
                            Console.Clear();
                            goto ReMethod;

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The type of price is not true, pleace enter again:");
                            goto rePrice;

                        }
                    }
                    else if (choicee == 2)//Truck
                    {
                    rePrice:
                        Console.Write("Pleace enter the price:");
                        var price = Console.ReadLine();

                        decimal b;

                        bool checkprice = decimal.TryParse(price, out b);

                        if (checkprice)
                        {
                            b = Convert.ToDecimal(price);
                            truckController.PriceLow(b);
                            Console.ReadLine();
                            Console.Clear();
                            goto ReMethod;

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The type of price is not true, pleace enter again:");
                            goto rePrice;

                        }

                    }
                    else if (choicee == 3)//Moto
                    {

                    rePrice:
                        Console.Write("Pleace enter the price:");
                        var price = Console.ReadLine();

                        decimal b;

                        bool checkprice = decimal.TryParse(price, out b);

                        if (checkprice)
                        {
                            b = Convert.ToDecimal(price);
                            motoController.PriceLow(b);
                            Console.ReadLine();
                            Console.Clear();
                            goto ReMethod;

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The type of price is not true, pleace enter again:");
                            goto rePrice;

                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Value is not true!");
                        goto reChoice;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" The type of section is not true, please enter again : \n");
                    goto reChoice;
                }
            }
            else if (funcc == 6)
            {
            // add vehicle
            label3:
                Console.WriteLine("Please choose the section of vehicle: ");
                Console.WriteLine("1.Car\n" +
                    "2.Truck\n" +
                    "3.Motorcycle");

                var choice = Console.ReadLine();

                int c;

                bool checkk = int.TryParse(choice, out c);

                int choicee;
                if (checkk)
                {

                    choicee = Convert.ToInt32(choice);

                    if (choicee == 1)
                    {
                        Console.Write("Brand: ");
                        string brand = Console.ReadLine() ?? "unknown";

                        Console.Write("Model: ");
                        string model = Console.ReadLine() ?? "unknown";

                        Console.Write("Color: ");
                        string color = Console.ReadLine() ?? "unknown";

                        Console.Write("Engine: ");
                        string engine = Console.ReadLine() ?? "unknown";

                    label2:
                        Console.Write("Price: ");
                        var price = Console.ReadLine();

                        decimal pricee;

                        checkk = decimal.TryParse(price, out pricee);


                        if (checkk)
                        {

                            pricee = Convert.ToDecimal(price);

                            Car car = new Car(brand, model, pricee, color, engine);

                            carController.Add(car);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong value");
                            goto label2;
                        }



                    }
                    else if (choicee == 2)
                    {
                        Console.Write("Brand: ");
                        string brand = Console.ReadLine() ?? "unknown";

                        Console.Write("Model: ");
                        string model = Console.ReadLine() ?? "unknown";

                        Console.Write("Color: ");
                        string color = Console.ReadLine() ?? "unknown";

                        Console.Write("Engine: ");
                        string engine = Console.ReadLine() ?? "unknown";

                    label2:
                        Console.Write("Price: ");
                        var price = Console.ReadLine();

                        decimal pricee;

                        checkk = decimal.TryParse(price, out pricee);


                        if (checkk)
                        {

                            pricee = Convert.ToDecimal(price);

                            Truck truck = new Truck(brand, model, pricee, color, engine);

                            truckController.Add(truck);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong value");
                            goto label2;
                        }


                    }
                    else if (choicee == 3)
                    {

                        Console.Write("Brand: ");
                        string brand = Console.ReadLine() ?? "unknown";

                        Console.Write("Model: ");
                        string model = Console.ReadLine() ?? "unknown";

                        Console.Write("Color: ");
                        string color = Console.ReadLine() ?? "unknown";

                        Console.Write("Engine: ");
                        string engine = Console.ReadLine() ?? "unknown";

                    label2:
                        Console.Write("Price: ");
                        var price = Console.ReadLine();

                        decimal pricee;

                        checkk = decimal.TryParse(price, out pricee);


                        if (checkk)
                        {

                            pricee = Convert.ToDecimal(price);

                            Motorcycle moto = new Motorcycle(brand, model, pricee, color, engine);

                            carController.Add(moto);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong value");
                            goto label2;
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong value");
                        goto label3;
                    }

                }

            }

            else if (funcc == 7)
            {
            label3:
                Console.WriteLine("Please choose the section of vehicle:\n" +
                    "1.Car\n" +
                    "2.Truck\n" +
                    "3.Motorcycle");

                var section = Console.ReadLine();

                int c;
                bool checksection = int.TryParse(section, out c);

                int choicee;
                if (checksection)
                {
                    choicee = Convert.ToInt32(section);

                    if (choicee == 1)
                    {
                    // car  ucun update
                    againCarId:
                        carController.ShowProduct();
                        Console.WriteLine("Please choose car:\n");
                        var id = Console.ReadLine();
                        int e;
                        bool chechtype = int.TryParse(id, out e);

                        if (chechtype)
                        {
                        ReProperty:
                            e = Convert.ToInt32(id);
                            Console.WriteLine("Which property do you want to change:\n" +
                                "1.Brand\n" +
                                "2.Model\n" +
                                "3.Price\n" +
                                "4.Color\n" +
                                "5.Engine");

                            var property = Console.ReadLine();
                            int g;
                            bool checkproperty = int.TryParse(property, out g);


                            if (checkproperty)
                            {

                                g = Convert.ToInt32(id);

                                if (g == 3)
                                {
                                newPrice:
                                    Console.Write("New value:");
                                    var newprice = Console.ReadLine() ?? "";
                                    decimal i;

                                    bool checkPriceType = decimal.TryParse(newprice, out i);

                                    if (checkPriceType)
                                    {
                                        string newpriceStringtype = newprice;
                                        carController.UpdateVehicle(e, g, newpriceStringtype);


                                        Console.ReadLine();
                                        Console.Clear();
                                        goto ReMethod;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("The  price can not become this type!");
                                        goto newPrice;
                                    }
                                }


                                if (g < 1 || g > 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is not such a property: ");
                                    goto ReProperty;
                                }
                                Console.Write("New value:");
                                string newvalue = Console.ReadLine() ?? "";
                                carController.UpdateVehicle(e, g, newvalue);

                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Car property can not be this type, please enter true value:");
                                goto ReProperty;
                            }

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" Car id can not be this type, please enter true value:");
                            goto againCarId;
                        }

                    }

                    else if (choicee == 2)
                    {
                    // truck ucun update 
                    againTruckId:

                        carController.ShowProduct();
                        Console.WriteLine("Please choose Truck:\n");
                        var id = Console.ReadLine();
                        int e;
                        bool chechtype = int.TryParse(id, out e);

                        if (chechtype)
                        {
                        ReProperty:
                            e = Convert.ToInt32(id);
                            Console.WriteLine("Which property do you want to change:\n" +
                                "1.Brand\n" +
                                "2.Model\n" +
                                "3.Price\n" +
                                "4.Color\n" +
                                "5.Engine");

                            var property = Console.ReadLine();
                            int g;
                            bool checkproperty = int.TryParse(property, out g);


                            if (checkproperty)
                            {

                                g = Convert.ToInt32(id);

                                if (g == 3)
                                {
                                newPrice:
                                    Console.Write("New value:");
                                    var newprice = Console.ReadLine() ?? "";
                                    decimal i;

                                    bool checkPriceType = decimal.TryParse(newprice, out i);

                                    if (checkPriceType)
                                    {
                                        string newpriceStringtype = newprice;
                                        truckController.UpdateVehicle(e, g, newpriceStringtype);

                                        Console.ReadLine();
                                        Console.Clear();
                                        goto ReMethod;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("The  price can not become this type!");
                                        goto newPrice;
                                    }
                                }
                                if (g < 1 || g > 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is not such a property: ");
                                    goto ReProperty;
                                }

                                Console.Write("New value:");
                                string newvalue = Console.ReadLine() ?? "";
                                truckController.UpdateVehicle(e, g, newvalue);

                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;




                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Truck property can not be this type, please enter true value:");
                                goto ReProperty;
                            }

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" Truck id can not be this type, please enter true value:");
                            goto againTruckId;
                        }
                    }

                    else if (choicee == 3)
                    {
                    // moto ucun update
                    againMotoId:
                        carController.ShowProduct();
                        Console.WriteLine("Please choose Motorcycle:\n");
                        var id = Console.ReadLine();
                        int e;
                        bool chechtype = int.TryParse(id, out e);

                        if (chechtype)
                        {
                        ReProperty:
                            e = Convert.ToInt32(id);
                            Console.WriteLine("Which property do you want to change:\n" +
                                "1.Brand\n" +
                                "2.Model\n" +
                                "3.Price\n" +
                                "4.Color\n" +
                                "5.Engine");

                            var property = Console.ReadLine();
                            int g;
                            bool checkproperty = int.TryParse(property, out g);


                            if (checkproperty)
                            {

                                g = Convert.ToInt32(id);

                                if (g == 3)
                                {
                                newPrice:
                                    Console.Write("New value:");
                                    var newprice = Console.ReadLine() ?? "";
                                    decimal i;

                                    bool checkPriceType = decimal.TryParse(newprice, out i);

                                    if (checkPriceType)
                                    {
                                        string newpriceStringtype = newprice;
                                        motoController.UpdateVehicle(e, g, newpriceStringtype);

                                        Console.ReadLine();
                                        Console.Clear();
                                        goto ReMethod;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("The  price can not become this type!");
                                        goto newPrice;
                                    }
                                }
                                if (g < 1 || g > 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is not such a property: ");
                                    goto ReProperty;
                                }
                                Console.Write("New value:");
                                string newvalue = Console.ReadLine() ?? "";
                                motoController.UpdateVehicle(e, g, newvalue);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;



                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Motorcycle property can not be this type, please enter true value:");
                                goto ReProperty;
                            }

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" Car id can not be this type, please enter true value:");
                            goto againMotoId;
                        }
                    }

                    else
                    {

                        Console.Clear();
                        Console.WriteLine("Wrong value");
                        goto label3;

                    }

                }


                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong value");
                    goto label3;
                }


            }
            else if (funcc == 8)
            {

            label4:
                Console.WriteLine("Please choose the section of vehicle:\n" +
                    "1.Car\n" +
                    "2.Truck\n" +
                    "3.Motorcycle");

                var section = Console.ReadLine();

                int c;
                bool checksection = int.TryParse(section, out c);

                int choicee;
                if (checksection)
                {
                    choicee = Convert.ToInt32(section);

                    if (choicee == 1)
                    {
                    // car  ucun remove
                    againCarId:
                        carController.ShowProduct();
                        Console.WriteLine("Please choose car:\n");
                        var id = Console.ReadLine();
                        int e;
                        bool chechtype = int.TryParse(id, out e);

                        if (chechtype)
                        {
                        ReProperty:
                            e = Convert.ToInt32(id);
                            Console.WriteLine("Which property do you want to change:\n" +
                                "1.Brand\n" +
                                "2.Model\n" +
                                "3.Price\n" +
                                "4.Color\n" +
                                "5.Engine");

                            var property = Console.ReadLine();
                            int g;
                            bool checkproperty = int.TryParse(property, out g);


                            if (checkproperty)
                            {

                                g = Convert.ToInt32(id);

                                if (g == 3)
                                {
                                newPrice:
                                    Console.Write("New value:");
                                    var newprice = Console.ReadLine() ?? "";
                                    decimal i;

                                    bool checkPriceType = decimal.TryParse(newprice, out i);

                                    if (checkPriceType)
                                    {
                                        string newpriceStringtype = newprice;
                                        carController.UpdateVehicle(e, g, newpriceStringtype);

                                        Console.ReadLine();
                                        Console.Clear();
                                        goto ReMethod;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("The  price can not become this type!");
                                        goto newPrice;
                                    }
                                }


                                if (g < 1 || g > 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is not such a property: ");
                                    goto ReProperty;
                                }
                                Console.Write("New value:");
                                string newvalue = Console.ReadLine() ?? "";
                                carController.UpdateVehicle(e, g, newvalue);

                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Car property can not be this type, please enter true value:");
                                goto ReProperty;
                            }

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" Car id can not be this type, please enter true value:");
                            goto againCarId;
                        }

                    }

                    else if (choicee == 2)
                    {
                    // truck ucun remove
                    againTruckId:

                        carController.ShowProduct();
                        Console.WriteLine("Please choose Truck:\n");
                        var id = Console.ReadLine();
                        int e;
                        bool chechtype = int.TryParse(id, out e);

                        if (chechtype)
                        {
                        ReProperty:
                            e = Convert.ToInt32(id);
                            Console.WriteLine("Which property do you want to change:\n" +
                                "1.Brand\n" +
                                "2.Model\n" +
                                "3.Price\n" +
                                "4.Color\n" +
                                "5.Engine");

                            var property = Console.ReadLine();
                            int g;
                            bool checkproperty = int.TryParse(property, out g);


                            if (checkproperty)
                            {

                                g = Convert.ToInt32(id);

                                if (g == 3)
                                {
                                newPrice:
                                    Console.Write("New value:");
                                    var newprice = Console.ReadLine() ?? "";
                                    decimal i;

                                    bool checkPriceType = decimal.TryParse(newprice, out i);

                                    if (checkPriceType)
                                    {
                                        string newpriceStringtype = newprice;
                                        truckController.UpdateVehicle(e, g, newpriceStringtype);

                                        Console.ReadLine();
                                        Console.Clear();
                                        goto ReMethod;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("The  price can not become this type!");
                                        goto newPrice;
                                    }
                                }
                                if (g < 1 || g > 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is not such a property: ");
                                    goto ReProperty;
                                }

                                Console.Write("New value:");
                                string newvalue = Console.ReadLine() ?? "";
                                truckController.UpdateVehicle(e, g, newvalue);

                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;




                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Truck property can not be this type, please enter true value:");
                                goto ReProperty;
                            }

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" Truck id can not be this type, please enter true value:");
                            goto againTruckId;
                        }
                    }

                    else if (choicee == 3)
                    {
                    // moto ucun remove
                    againMotoId:
                        carController.ShowProduct();
                        Console.WriteLine("Please choose Motorcycle:\n");
                        var id = Console.ReadLine();
                        int e;
                        bool chechtype = int.TryParse(id, out e);

                        if (chechtype)
                        {
                        ReProperty:
                            e = Convert.ToInt32(id);
                            Console.WriteLine("Which property do you want to change:\n" +
                                "1.Brand\n" +
                                "2.Model\n" +
                                "3.Price\n" +
                                "4.Color\n" +
                                "5.Engine");

                            var property = Console.ReadLine();
                            int g;
                            bool checkproperty = int.TryParse(property, out g);


                            if (checkproperty)
                            {

                                g = Convert.ToInt32(id);

                                if (g == 3)
                                {
                                newPrice:
                                    Console.Write("New value:");
                                    var newprice = Console.ReadLine() ?? "";
                                    decimal i;

                                    bool checkPriceType = decimal.TryParse(newprice, out i);

                                    if (checkPriceType)
                                    {
                                        string newpriceStringtype = newprice;
                                        motoController.UpdateVehicle(e, g, newpriceStringtype);

                                        Console.ReadLine();
                                        Console.Clear();
                                        goto ReMethod;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("The  price can not become this type!");
                                        goto newPrice;
                                    }
                                }
                                if (g < 1 || g > 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is not such a property: ");
                                    goto ReProperty;
                                }
                                Console.Write("New value:");
                                string newvalue = Console.ReadLine() ?? "";
                                motoController.UpdateVehicle(e, g, newvalue);
                                Console.ReadLine();
                                Console.Clear();
                                goto ReMethod;



                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Motorcycle property can not be this type, please enter true value:");
                                goto ReProperty;
                            }

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" Car id can not be this type, please enter true value:");
                            goto againMotoId;
                        }
                    }

                    else
                    {

                        Console.Clear();
                        Console.WriteLine("Wrong value");
                        goto label4;

                    }

                }


                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong value");
                    goto label4;
                }

            }


        }

    }
    else
    {
        goto restart;
    }

}
else
{
    Console.Clear() ;
    goto restart;

}
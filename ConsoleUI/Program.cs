using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            var vehicles = new List<Vehicle>();

            Car Accord = new Car() {HasTrunk = true, Make = "Honda", Model = "Accord", Year = 2001 };
            Motorcycle myMotorcycle = new Motorcycle() { HasSideCart = true, Year = 1999,Model = "HD", Make = "Chopper"};
            Vehicle sedan = new Car () {HasTrunk = true, Make = "VW", Model = "Cabriolet", Year = 1985};
            Vehicle sportsCar = new Car() { HasTrunk = false, Year = 1993, Make = "Porsche", Model = "Something" };

            vehicles.Add(sedan);
            vehicles.Add(Accord);
            vehicles.Add(myMotorcycle);
            vehicles.Add(sportsCar);

            foreach (var auto in vehicles)
            {
                Console.WriteLine($"{auto.Make}");
                Console.WriteLine($"{auto.Model}");
                Console.WriteLine($"{auto.Year}");
                auto.DriveAbstract();
                auto.DriveVirtual();
                Console.WriteLine("");

            }



            //*Create an abstract class called Vehicle - DONE
            //*The vehicle class shall have three string properties Year, Make, and Model - DONE
            //*Set the defaults to something generic in the Vehicle class - DONE
            //*Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
            //* Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for 
             *      Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles - DONE

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit 
             * typing)  - DONE
             * but use constuctors from derived classes - DONE 
             * - new it up as one of each derived class - 
             * Set the properties with object initializer syntax - DONE
             */

            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties - DONE
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}

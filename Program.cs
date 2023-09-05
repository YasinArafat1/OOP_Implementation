using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int temp = 0;
                while (temp == 0)
                {
                    Console.Write("which info do u want.\n[hints:]\n1.car \n2.Motorcycle\nEnter sl no : \t");
                    VehicleType vehicleType =(VehicleType)int.Parse( Console.ReadLine());
                    if (vehicleType == (VehicleType)1 || vehicleType ==(VehicleType)2 )
                    {
                        if (vehicleType ==(VehicleType)1)
                        {
                            CarInfo();
                        }
                        else
                        {
                            MotorCycleInfo();
                        }
                        temp = 1;
                    }
                    else 
                    {
                        Console.WriteLine("Enter Valid no ");
                        temp = 0;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            Console.ReadKey();
        }

        
        private static void MotorCycleInfo()
        {
            Console.Write("Model NO \t: ");
            string modelNo =Console.ReadLine();

            Console.Write("Year Make \t: ");
            int yearmake = int.Parse( Console.ReadLine());

            Console.Write("No of Gear\t: ");
            int noofgear = int.Parse( Console.ReadLine());

            Console.Write("Engine Capacity\t: ");
            int enginecapacity = int.Parse( Console.ReadLine());

            Console.Write("Max power in BPH\t: ");
            int maxpower = int.Parse( Console.ReadLine());

            Console.Write("Max torque in NM \t: ");
            int maxtorque = int.Parse( Console.ReadLine());

            Console.Write("Rear Brake\t: ");
            string rearbreak = Console.ReadLine();

            Console.Write("Colling System\t: ");
            string collingSystem = Console.ReadLine();

            Console.Write("Starting Method\t: ");
            string startingMethod = Console.ReadLine();

            Console.Write("Mileage\t: ");
            double mileage = double.Parse( Console.ReadLine());

            Console.Write("Front Brake\t: ");
            string frontbrake = Console.ReadLine();

            MotorCycle m = new MotorCycle(modelNo,yearmake,noofgear,enginecapacity,maxpower,maxtorque, startingMethod, mileage,collingSystem,frontbrake,rearbreak);

            string specification = "";
            while (specification.ToLower()!="0")
            {
                Console.Write("Add Exterior Design");
                specification = Console.ReadLine();

                if (specification.ToLower()!="0")
                {
                    m.AddSpecification(specification);
                }

                Console.WriteLine();
                Console.WriteLine("**********");
                Console.WriteLine($"Model NO\t: {modelNo} ");
                Console.WriteLine($"Year make\t: {yearmake} ");
                Console.WriteLine($"No of Gear\t: {noofgear} ");
                Console.WriteLine($"Engine Capacity\t: {enginecapacity} ");
                Console.WriteLine($"Max Torque\t: {maxtorque} ");
               
                Console.WriteLine($"ExteriorDesign\t: {m.ShowSpecification()} ");

            }
            


        }
        private static void CarInfo()//if user will press 1 this method will be shown 
        {
            Console.Write("Model NO \t: ");
            string modelNo = Console.ReadLine();

            Console.Write("Year Make \t: ");
            int yearmake = int.Parse(Console.ReadLine());

            Console.Write("No of Gear\t: ");
            int noofgear = int.Parse(Console.ReadLine());

            Console.Write("Engine Capacity\t: ");
            int enginecapacity = int.Parse(Console.ReadLine());

            Console.Write("No of seat\t: ");
            int NoofSeat = int.Parse(Console.ReadLine());

            Console.Write("No of Doors \t: ");
            int NOofdoor = int.Parse(Console.ReadLine());

            Console.Write("Stearing System\t: ");
            string StearingSystem = Console.ReadLine();

            Car  c = new Car(modelNo,yearmake,noofgear,enginecapacity,NoofSeat,NOofdoor,StearingSystem);

            string specification = "";
            while (specification.ToLower()!="0")
            {
                Console.Write("Add Interior Design");
                specification = Console.ReadLine();

                if (specification.ToLower() != "0")
                { 
                c.AddSpecification(specification);
                }


                Console.WriteLine();
                Console.WriteLine("**********");
                Console.WriteLine($"Model NO\t: {modelNo} ");
                Console.WriteLine($"Year make\t: {yearmake} ");
                Console.WriteLine($"No of Gear\t: {noofgear} ");
                Console.WriteLine($"Engine Capacity\t: {enginecapacity} ");
                Console.WriteLine($"No of Seat\t: {NoofSeat} ");
                Console.WriteLine($"No of Gear\t: {noofgear} ");
                Console.WriteLine($"Stearing System\t: {StearingSystem} ");

                Console.WriteLine($"Interior Design\t: {c.ShowSpecification()} ");
            }
        }


    }
}

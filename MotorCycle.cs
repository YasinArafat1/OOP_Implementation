using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    public sealed class MotorCycle : TwoWheeler
    {
        public MotorCycle()//defauolt constructor
        {
            
        }

        public MotorCycle(string modelno,int yearmake, int numberofGear,int enginecapacityincc, int maxpower, int maxtorque, string startingmethod, double mileage,string colling,string frontbrake,string rearbrake)//overload constructor
        { 
            ModelNo = modelno;
            YearMake = yearmake;
            NumberOfGear = numberofGear;
            EngineCapacity = enginecapacityincc;
            Maxpower = maxpower;
            MaxTorque = maxtorque; 
            StartingMethod = startingmethod;
            Mileage = maxtorque; 
            Cooling = colling;
            Frontbrake = frontbrake;
            Rearbrake = rearbrake;





        
        }

        public int Maxpower { get; set; }
        public int MaxTorque { get; set; }

        public string StartingMethod {get; set;}
        public double Mileage { get; set;}
        public string Cooling { get; set; }
        public string Frontbrake { get; set;}
        public string Rearbrake { get; set;}

    }
}

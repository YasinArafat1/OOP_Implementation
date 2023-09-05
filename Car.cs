using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    public sealed class Car:FourWheeler
    {
        public Car() //default constructor
        {
        
        }

        public Car(string modelno, int yearmake, int numberofGear, int enginecapacityincc, int noofSeat, int noofdoor,string steartingsystem)//overload constructor
        {
            ModelNo = modelno;
            YearMake = yearmake;
            NumberOfGear = numberofGear;
            EngineCapacity = enginecapacityincc;
            Noofseat = noofSeat;
            NoofDoor = noofdoor;
            stearingSystem = steartingsystem;


        }


        public int Noofseat { get; set; }
        public int NoofDoor { get; set; }
        public string stearingSystem { get; set; }

    }
}

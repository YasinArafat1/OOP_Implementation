using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    public abstract class FourWheeler : Vehicle, IInterior
    {
        List<string> specification = new List<string>();
        public void AddSpecification(string specification)
        { 
            this.specification.Add(specification);
        }

        public string ShowSpecification()
        {
            return string.Join(",", this.specification);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum13
{
    public class BuildingContainer
    {
        Buiding[] buidings = new Buiding[10];
        public Buiding this[int index]
        {
            get => buidings[index];
            set => buidings[index] = value;
        }
        public BuildingContainer(Buiding[] buidings)
        {
            this.buidings = buidings;
        }
    }
}
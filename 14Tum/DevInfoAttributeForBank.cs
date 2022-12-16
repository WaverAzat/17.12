using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Tum
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor)]
    class DevInfoAttributeForBank : Attribute
    {
        public string Developer;
        public string Organization
        {
            get;
            set;
        }
        public DevInfoAttributeForBank(string developer)
        {
            Developer = developer;
        }
    }
}

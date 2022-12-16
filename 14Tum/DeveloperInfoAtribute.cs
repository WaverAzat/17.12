using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Tum
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor)]
    class DeveloperInfoAttribute : Attribute
    {
        public string Developer;
        public string Date
        {
            get;
            set;
        }
        public DeveloperInfoAttribute(string developer)
        {
            Developer = developer;
        }
    }
}

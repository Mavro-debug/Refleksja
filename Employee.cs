using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refleksja
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Positions Position { get; set; }
        public ContactInfo ContactInformation { get; set; }
    }
}

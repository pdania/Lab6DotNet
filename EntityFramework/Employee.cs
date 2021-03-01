using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Employee
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string surname, string middlename)
        {

        }
    }
}

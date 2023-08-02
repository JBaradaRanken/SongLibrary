using System;
using System.Collections.Generic;

namespace EmployeeLibrary
{
    public class Employee
    {
        public string Name { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }

        public Employee() { }

        public override string ToString()
        {
            return "Employee: " + Name + "\n"
                                + SSN + "\n"
                                + Address + "\n";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary
{
    public class EmployeeManager
    {
        public static List<Employee> LoadData()
        {
            var empList = new List<Employee>();

            empList.Add(new Employee { Name = "John Smith", SSN = "1234567890", Address = "1 O'Fallon Rd, O'Fallon MO, 63366" });
            empList.Add(new Employee { Name = "John Doe", SSN = "0987654321", Address = "2 Gutermuth Rd, O'Fallon MO, 63366" });
            empList.Add(new Employee { Name = "Jane Doe", SSN = "2468101214", Address = "3 Highway K, O'Fallon MO, 63366" });
            empList.Add(new Employee { Name = "Jada Jones", SSN = "0135791113", Address = "1 Mid Rivers Mall Dr., St. Peter's MO, 63303" });
            empList.Add(new Employee { Name = "Jon Jones", SSN = "1491625364", Address = "2 Suemandy Dr, St. Peter's MO, 63303" });
            empList.Add(new Employee { Name = "James Smith", SSN = "8888888888", Address = "3 Towers Dr, St. Peter's MO, 63303" });
            empList.Add(new Employee { Name = "Julio Lopez", SSN = "9999999999", Address = "4 Highway 94, St. Peter's MO, 63303" });
            empList.Add(new Employee { Name = "Juan Gonzalez", SSN = "1010101010", Address = "5 S St. Peters Pkwy, St. Peter's MO, 63303" });
            empList.Add(new Employee { Name = "Jaime Rodriguez", SSN = "1111111111", Address = "6 N St. Peters Pkwy, St. Peter's MO, 63303" });
            empList.Add(new Employee { Name = "Jackson Oliver", SSN = "1212121212", Address = "1 Hemsath Rd, St. Charles MO, 63301" });
            empList.Add(new Employee { Name = "Julia Oliver", SSN = "1313131313", Address = "2 Bates Rd, St. Charles MO, 63301" });
            empList.Add(new Employee { Name = "Jared Muegge", SSN = "1414141414", Address = "3 First Capitol Dr, St. Charles MO, 63301" });
            empList.Add(new Employee { Name = "Jim Cruz", SSN = "1515151515", Address = "4 West Clay Dr, St. Charles MO, 63301" });
            empList.Add(new Employee { Name = "Johnny Rocket", SSN = "0000000000", Address = "1 Highway A, Wentzville MO, 63385" });
            empList.Add(new Employee { Name = "Julius Brown", SSN = "1231231234", Address = "2 Wentzville Pkwy, Wentzville MO, 63385" });
            empList.Add(new Employee { Name = "Jordan Belfort", SSN = "3212313210", Address = "3 Hillshire Dr, Wentzville MO, 63385" });
            empList.Add(new Employee { Name = "Justin Green", SSN = "4324324321", Address = "4 Roberts Dr, Wentzville MO, 63385" });
            empList.Add(new Employee { Name = "Johnson Johnson", SSN = "5432154321", Address = "5 Perry Pl, Wentzville MO, 63385" });
            empList.Add(new Employee { Name = "Jimi Hendrix", SSN = "6543265432", Address = "6 Salon Ave, Wentzville MO, 63385" });
            empList.Add(new Employee { Name = "James Rutkowski", SSN = "7654376543", Address = "7 Liberty Ln, Wentzville MO, 63385" });

            return empList;
        }
    }
}


using EmployeeLibrary;
using System;
using System.Collections.Generic;
using static System.Console;

namespace Lab02Console_JohnBarada
{
    public class Program02
    {
        const string NOTHINGINPUTTED = "No Value Input for Search Criteria";
        const string NOOUTPUTFOUND = "No Data Matching Search Criteria";

        static List<Employee> employees = EmployeeManager.LoadData();

        static void Main(string[] args)
        {
            string zip;
            bool runAgain = true;

            while (runAgain)
            {
                zip = ShowMenu();
                ShowEmployee(zip);
                runAgain = AnotherTime();

            }
            static string ShowMenu()
            {
                int optionChosenInt = 0;
                string optionChosenStr = "";
                bool result;

                string menuStr = "Please Enter Employee Zip Code\n:";
                Write(menuStr);
                optionChosenStr = ReadLine();
                optionChosenInt = Convert.ToInt32(optionChosenStr);

                result = Int32.TryParse(optionChosenStr, out optionChosenInt);
                if (!result)
                {
                    Write("\n\nYou MUST Enter A Number");
                    ReadLine();
                    ShowMenu();
                }
                else if (optionChosenInt < 0 || (optionChosenInt > 1000000))
                {
                    Write("\n\n You MUST enter a valid number");
                    ReadLine();
                    ShowMenu();
                }

                return optionChosenStr;
            }
            static void ShowEmployee(string zip)
            {
                Employee employee = employees.FirstOrDefault();

                var empOut = from e in employees
                                     orderby e.Name ascending
                             where e.Address.Contains(zip)
                                     select e;

                WriteLine("Here are the employees matching the ZIP Code");
                foreach (var e in empOut)
                {
                    WriteLine(e);
                }
                ReadLine();
            }
            static bool AnotherTime()
            {
                bool retVal = true;
                string again = "";
                char firstChar = ' ';

                Write("Run Program Again? (Y/N): ");
                again = ReadLine().ToUpper();
                firstChar = again[0];

                if (firstChar != 'Y')
                {
                    retVal = false;
                }
                return retVal;
            }
        }
    }
}

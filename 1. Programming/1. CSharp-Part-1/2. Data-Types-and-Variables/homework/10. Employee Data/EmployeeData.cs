using System;

namespace _10.Employee_Data
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string lastName = "Ivanov";
            byte age = 31;
            char gender = 'm';
            long idNum = 8306112507;
            int uniqeEmployeeNumber = 27560000;

            Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nId Num: {4}\nEmployee Number: {5}", firstName, lastName, age, gender, idNum, uniqeEmployeeNumber);
        }
    }
}

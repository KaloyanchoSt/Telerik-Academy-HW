using System;

namespace _02.Company_Info
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhone = Console.ReadLine();
            string companyFax = Console.ReadLine();

            if (companyFax == "")
            {
                companyFax = "(no fax)";
            }

            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine(" {0}\n Address: {1}\n Tel. {2}\n Fax: {3}\n Web site: {4}\n Manager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, companyPhone, companyFax, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}

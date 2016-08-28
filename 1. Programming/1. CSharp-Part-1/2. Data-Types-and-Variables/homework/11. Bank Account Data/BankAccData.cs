using System;

namespace _11.Bank_Account_Data
{
    class BankAccData
    {
        static void Main()
        {
            string firstName = "Nikola";
            string middleName = "Ivanov";
            string lastName = "Petkov";
            byte avaliableMoney = 254;
            string bankName = "OBB Bank";
            string IBAN = "BG80 BNBG 9661 1020 3456 78";
            string creditCard1 = "7634 4376 4325 6523";
            string creditCard2 = "8956 8952 2957 0742";
            string creditCard3 = "8535 1904 8594 3832";

            Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", firstName, middleName, lastName, avaliableMoney, bankName, IBAN, creditCard1, creditCard2, creditCard3);

        }
    }
}
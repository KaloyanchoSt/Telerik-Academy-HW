using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class ParseURL
    {
        static void Main()
        {
            string inputURL = Console.ReadLine();

            /* Searching for the respective splitters – two slashes for a protocol and 
             * one slash as a separator between the server and the resource            */

            //the start index of the substring "://" in uRL by its first occurrences
            int indexOfProtocol = inputURL.IndexOf("://");

            // the substring from 0 with length=indexOfProtocol
            // string string.Substring(int startIndex, int length);
            string protocol = inputURL.Substring(0, indexOfProtocol);

            //the start index of the substring "/" starting from (indexOfProtocol + 3) in uRL by its first occurrences => int string.IndexOf(String value, int startIndex);
            int indexOfServer = inputURL.IndexOf("/", indexOfProtocol + 3);

            // string string.Substring(int startIndex, int length);
            string server = inputURL.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3);

            // string string.Substring(int startIndex);
            string resource = inputURL.Substring(indexOfServer);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}

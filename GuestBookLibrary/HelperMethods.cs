using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuestBookLibrary
{
    public class HelperMethods
    {
        
        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }

        public static int convertStringToInteger(string value)
        {
            bool isValidNumber = int.TryParse(value,out int output);

            return output;
 
        }

    
        public static void Greetings(string message)
        {
            Console.WriteLine(message);
        }


    }
}

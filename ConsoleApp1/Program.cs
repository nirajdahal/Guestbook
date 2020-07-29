using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using GuestBookLibrary;
using GuestBookLibrary.Models;

namespace ConsoleApp1
{
    class Program
    {
        /*  Ask The user for thier name
            Ask How many are at their parties
            print the guest list and the total number of guest
           
         */


        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {
            UserInquiry();
            PrintFinalMessage();
        }

        public static void UserInquiry()
        {

            string finalMessage = "";
            do
            {
                //GreetUsers
                HelperMethods.Greetings("Hello! Please Enter Your Details");

                //Method to ask user for the name
                string guestFirstName = HelperMethods.GetInput("What is your First Name");
                string guestLastName = HelperMethods.GetInput("What is your Last Name");

                //Ask guest about number of  people  joining with them at the party
                string guestTotalMembers = HelperMethods.GetInput("How many people are coming with you in the party");
                int guestTotalMembersNumber = HelperMethods.convertStringToInteger(guestTotalMembers);

                //Initialize Guest
                GuestModel guest = new GuestModel();
                guest.FirstName = guestFirstName;
                guest.LastName = guestLastName;
                guest.TotalMembers = guestTotalMembersNumber;

                //Store Guest to list

                guests.Add(guest);
                HelperMethods.Greetings($"Thank you for your time {guest.FullName}. Enjoy the party");
                //Ask to print final message after guest stops coming
                finalMessage = HelperMethods.GetInput("Should I Print Final Message ?");


            } while (finalMessage.ToLower() != "yes");
        }


        public static void PrintFinalMessage()
        {
            Console.WriteLine("The Guest Lists are");
            int guestNumber = 0;
            int TotalGuest = 0;
            foreach (GuestModel guest in guests)
            {
                guestNumber = guestNumber + 1;
                Console.WriteLine($"******Guest No: {guestNumber}******");
                Console.WriteLine($"Name: {guest.FullName}");
                Console.WriteLine($"No of People Coming: {guest.TotalMembers}");
                TotalGuest = guest.TotalMembers + TotalGuest;
            }

            Console.WriteLine($"TotalGuest : {TotalGuest}");
        }
    }
}

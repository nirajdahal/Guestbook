using System;
using System.Collections.Generic;
using System.Text;

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string FirstName{ get; set; }

        public string LastName { get; set; }


        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
                
            
        }

        public int TotalMembers { get; set; }

    }
}

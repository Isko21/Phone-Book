using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBanTheory_Project4
{
    public class Contact
    {
        public string Name, Last_Name, Email, Number, Address, Gender;
        public Contact(string name, string surname, string email, string number, string address, string gender)
        {
            this.Name = name;
            this.Last_Name = surname;
            this.Email = email;
            this.Number = number;
            this.Address = address;
            this.Gender = gender;
        }
    }
}

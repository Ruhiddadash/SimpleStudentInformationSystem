using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudentInformationSystem
{
    class User
    {
        public string Name;
        public string Surname;
        public string Email;
        public string Number;
        public string Address;
        public string Birthday;

        public User(string Name,string Surname,string Email,string Number,string Address,string Birthday) {
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Number = Number;
            this.Address = Address;
            this.Birthday = Birthday;
        }

            
    }
    
}

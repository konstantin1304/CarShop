using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{   /// <summary>
    /// Client data
    /// </summary>
    class Person
    {
        
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Email { get; private set; }
        public ulong TelNumber { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="patronymic">Patronymic</param>
        /// <param name="dateOfBirth">Date of birth</param>
        /// <param name="email">Email</param>
        /// <param name="telNumber">Phone number</param>
        public Person(string name, string surname, string patronymic, DateTime dateOfBirth, string email, ulong telNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.TelNumber = telNumber;
        }
        
    }
}

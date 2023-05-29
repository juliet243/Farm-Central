using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmCentral
{
    public class Users
    {
        private string name;     //Variable to store user (employee/farmer) name
        private string surname;  //Variable to store user (employee/farmer) surname
        private string email;    //Variable to store user (employee/farmer) email
        private string password; //Variable to store user (employee/farmer) password

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Get and set methods
        /// </summary>
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Default constructor
         /// </summary>
         /// <param name="name"></param>
         /// <param name="surname"></param>
         /// <param name="email"></param>
         /// <param name="password"></param>
        public Users(string name, string surname, string email,string password) 
        {
            this.name = name;
            this.surname = surname;
           // this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.password = password;
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Default constructor
         /// </summary>
        public Users()
        {
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    internal class User:IProfile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Passsword { get; set; }
        public UserRole Role { get; set; }
         public static ArrayList Users = new  ArrayList();

        public User(string name, string surname, string email, string password, UserRole role)
        {
          
            Name = name;
                
            Surname = surname;
            Email = email;
            Passsword = password;
            Role = role;

        }

        public  void AddUser(User user)
        {
            Users.Add(user);
        }
        public static bool GetUSer(string email, string password)
        {
            foreach (User item in Users)
            {
                if(item.Email == email && item.Passsword == password)
                {
                    return true;
                }
               
            }
            return false;
        }
      
    }
}

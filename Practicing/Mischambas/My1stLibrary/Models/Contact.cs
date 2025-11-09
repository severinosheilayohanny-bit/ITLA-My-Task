//Sheila Y. Severino (2024-1693)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My1stLibrary.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool IsBestFriend { get; set; }
        public Contact(int id, string name, string lastname, string address, string telephone, string email, int age, bool isBestFriend)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Address = address;
            Telephone = telephone;
            Email = email;
            Age = age;
            IsBestFriend = isBestFriend;
        }
        public override string ToString()
        {
            string favorite = IsBestFriend ? "Yes" : "No";
            return $"{Id,-4} {Name,-12} {Lastname,-15} {Address,-18} {Telephone,-14} {Email,-32} {Age,-5} {favorite,-12}";
        }

    }
    
    }

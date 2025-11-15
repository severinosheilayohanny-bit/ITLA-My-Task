//Sheila Y. Severino (2024-1693)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHospitalLibrary.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Illness { get; set; }
        public bool IsEmergency { get; set; }

        public Patient(
            int id, string firstname, string lastname, int age,
            string gender, string telephone, string address,
            string illness, bool isEmergency)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Gender = gender;
            Telephone = telephone;
            Address = address;
            Illness = illness;
            IsEmergency = isEmergency;
        }

        public override string ToString()
        {
            string emergency = IsEmergency ? "Yes" : "No";
            return $"{Id,-4} {Firstname,-12} {Lastname,-15} {Age,-5} {Gender,-10} {Telephone,-14} {Address,-20} {Illness,-20} {emergency,-10}";
        }
    }
}
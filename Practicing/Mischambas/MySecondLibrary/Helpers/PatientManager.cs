//Sheila Y. Severino (2024-1693)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHospitalLibrary.Models;

namespace MyHospitalLibrary.Helpers
{
    public class PatientManager
    {
        private readonly List<Patient> patients = new();

        public void AddPatient()
        {
            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();

            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                    break;
                Console.WriteLine("Please enter a valid age...");
            }

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Telephone: ");
            string phone = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Illness / Diagnosis: ");
            string illness = Console.ReadLine();

            Console.Write("Is Emergency? (1. Yes / 2. No): ");
            bool isEmergency = Console.ReadLine() == "1";

            int id = patients.Count + 1;
            Patient newPatient = new(id, firstname, lastname, age, gender, phone, address, illness, isEmergency);
            patients.Add(newPatient);

            Console.WriteLine("\nPatient registered successfully...\n");
        }

        public void ListPatients()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("\nThere are no registered patients...\n");
                return;
            }

            Console.WriteLine(new string('_', 130));
            Console.WriteLine($"\n{"ID",-4} {"Firstname",-12} {"Lastname",-15} {"Age",-5} {"Gender",-10} {"Phone",-14} {"Address",-20} {"Illness",-20} {"Emergency",-10}");

            foreach (var p in patients)
            {
                Console.WriteLine($"\n{p}");
                Console.WriteLine(new string('_', 130));
            }
        }

        public void SearchPatient()
        {
            Console.Write("\nEnter firstname, lastname or telephone: ");
            string term = Console.ReadLine().ToLower();

            bool found = false;

            foreach (var p in patients)
            {
                if (p.Firstname.ToLower().Contains(term) ||
                    p.Lastname.ToLower().Contains(term) ||
                    p.Telephone.Contains(term))
                {
                    Console.WriteLine($"\nID: {p.Id}");
                    Console.WriteLine($"Name: {p.Firstname} {p.Lastname}");
                    Console.WriteLine($"Age: {p.Age}");
                    Console.WriteLine($"Gender: {p.Gender}");
                    Console.WriteLine($"Telephone: {p.Telephone}");
                    Console.WriteLine($"Address: {p.Address}");
                    Console.WriteLine($"Illness: {p.Illness}");
                    Console.WriteLine($"Emergency?: {(p.IsEmergency ? "Yes" : "No")}\n");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("\nNo patient found with that information...\n");
        }

        public void EditPatient()
        {
            Console.Write("\nEnter patient ID to edit: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("\nInvalid ID...\n");
                return;
            }

            Patient p = patients.Find(x => x.Id == id);
            if (p == null)
            {
                Console.WriteLine("\nPatient not found...\n");
                return;
            }

            Console.WriteLine("Leave it empty if you don't want to change that field.");

            Console.Write($"New Firstname ({p.Firstname}): ");
            string firstname = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(firstname)) p.Firstname = firstname;

            Console.Write($"New Lastname ({p.Lastname}): ");
            string lastname = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(lastname)) p.Lastname = lastname;

            Console.Write($"New Age ({p.Age}): ");
            if (int.TryParse(Console.ReadLine(), out int newAge)) p.Age = newAge;

            Console.Write($"New Gender ({p.Gender}): ");
            string gender = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(gender)) p.Gender = gender;

            Console.Write($"New Phone ({p.Telephone}): ");
            string phone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(phone)) p.Telephone = phone;

            Console.Write($"New Address ({p.Address}): ");
            string address = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(address)) p.Address = address;

            Console.Write($"New Illness ({p.Illness}): ");
            string illness = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(illness)) p.Illness = illness;

            Console.Write("Is Emergency? (1. Yes / 2. No): ");
            string em = Console.ReadLine();
            if (em == "1") p.IsEmergency = true;
            else if (em == "2") p.IsEmergency = false;

            Console.WriteLine("\nPatient updated successfully...\n");
        }

        public void DeletePatient()
        {
            Console.Write("\nEnter patient ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("\nInvalid ID...\n");
                return;
            }

            Patient p = patients.Find(x => x.Id == id);
            if (p == null)
            {
                Console.WriteLine("\nPatient not found...\n");
                return;
            }

            patients.Remove(p);
            Console.WriteLine("\nPatient removed successfully...\n");
        }
    }
}

//Sheila Y. Severino (2024-1693)

using My1stLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My1stLibrary.Helpers
{
    public class Manager
    {
        private readonly List<Contact> contacts = new();

        public void AddContact()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Telephone: ");
            string telephone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            int age;
            while (true)
            {
                Console.Write("Age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                    break;
                else
                    Console.WriteLine("Please enter a valid number for age...");
            }
            Console.Write("Is favorite? (1. Yes / 2. No): ");
            bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

            int id = contacts.Count + 1;
            Contact newContact = new(id, name, lastname, address, telephone, email, age, isBestFriend);
            contacts.Add(newContact);

            Console.WriteLine("\nContact added successfully...\n");
        }

        public void ListContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nThere's no registered contact...\n");
                return;
            }

            Console.WriteLine(new string('_', 115));
            Console.WriteLine($"\n{"ID",-4} {"Name",-12} {"Lastname",-15} {"Address",-18} {"Telephone",-14} {"Email",-32} {"Age",-5} {"Favorite",-12}");

            foreach (var contact in contacts)
            {
                Console.WriteLine($"\n{contact}");
                Console.WriteLine(new string('_', 115));
            }
            Console.WriteLine();
        }

        public void SearchContact()
        {
            Console.Write("\nEnter the name, lastname or telephone to search: ");
            string term = Console.ReadLine().ToLower();
            bool found = false;

            foreach (var contact in contacts)
            {
                if (contact.Name.ToLower().Contains(term) ||
                    contact.Lastname.ToLower().Contains(term) ||
                    contact.Telephone.Contains(term))
                {
                    Console.WriteLine($"\nID: {contact.Id}");
                    Console.WriteLine($"Name: {contact.Name} {contact.Lastname}");
                    Console.WriteLine($"Telephone: {contact.Telephone}");
                    Console.WriteLine($"Email: {contact.Email}");
                    Console.WriteLine($"Address: {contact.Address}");
                    Console.WriteLine($"Age: {contact.Age}");
                    Console.WriteLine($"Favorite?: {(contact.IsBestFriend ? "Yes" : "No")}\n");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("\nNo contacts found with that information...\n");
        }

        public void EditContact()
        {
            Console.Write("\nEnter the contact ID you want to modify: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID...\n");
                return;
            }

            Contact contact = contacts.Find(c => c.Id == id);
            if (contact == null)
            {
                Console.WriteLine("Contact not found...\n");
                return;
            }

            Console.WriteLine("Leave it empty if you don't want to change that field.");

            Console.Write($"New Name ({contact.Name}): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name)) contact.Name = name;

            Console.Write($"New Lastname ({contact.Lastname}): ");
            string lastname = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(lastname)) contact.Lastname = lastname;

            Console.Write($"New Address ({contact.Address}): ");
            string address = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(address)) contact.Address = address;

            Console.Write($"New Telephone ({contact.Telephone}): ");
            string phone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(phone)) contact.Telephone = phone;

            Console.Write($"New Email ({contact.Email}): ");
            string email = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(email)) contact.Email = email;

            Console.Write($"New Age ({contact.Age}): ");
            string ageStr = Console.ReadLine();
            if (int.TryParse(ageStr, out int newAge)) contact.Age = newAge;

            Console.Write("Is Favorite? (1. Yes / 2. No): ");
            string favStr = Console.ReadLine();
            if (favStr == "1") contact.IsBestFriend = true;
            else if (favStr == "2") contact.IsBestFriend = false;

            Console.WriteLine("\nContact modified successfully...\n");
        }

        public void DeleteContact()
        {
            Console.Write("\nEnter the ID of the contact to remove: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("\nInvalid ID...\n");
                return;
            }

            Contact contact = contacts.Find(c => c.Id == id);
            if (contact == null)
            {
                Console.WriteLine("\nContact not found...\n");
                return;
            }

            contacts.Remove(contact);
            Console.WriteLine("\nContact removed successfully...\n");
        }
    }
  
    }

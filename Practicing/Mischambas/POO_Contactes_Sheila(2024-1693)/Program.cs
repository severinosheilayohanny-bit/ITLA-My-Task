//Sheila Y. Severino (2024-1693)

using My1stLibrary.Helpers;
namespace POO_Contactes_Sheila_2024_1693_
{
    class Program
    {
        static void Main()
        {
            Manager manager = new();
            bool running = true;

            Console.WriteLine("Welcome to my Contact List\n");

            while (running)
            {
                Console.WriteLine(@"
    |  1. Add Contact        |
    |  2. View Contacts      |
    |  3. Search Contact     |
    |  4. Modify Contact     |
    |  5. Remove Contact     |
    |  6. Exit               |
                ");

                Console.Write("\nEnter the number of the option you want: ");
                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine("\nInvalid Option...\n");
                    continue;
                }

                switch (option)
                {
                    case 1: manager.AddContact(); break;
                    case 2: manager.ListContacts(); break;
                    case 3: manager.SearchContact(); break;
                    case 4: manager.EditContact(); break;
                    case 5: manager.DeleteContact(); break;
                    case 6: running = false; break;
                    default: Console.WriteLine("\nInvalid Option...\n"); break;
                }
            }

            Console.WriteLine("\nByeBye...");
            Console.ReadKey();
        }
    }
}
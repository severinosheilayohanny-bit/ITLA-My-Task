//Sheila Y. Severino (2024-1693)

using MyHospitalLibrary.Helpers;

namespace Patient_Registry_Sheila20241693
{
    class Program
    {
        static void Main()
        {
            PatientManager manager = new();
            bool running = true;

            Console.WriteLine("Welcome to the Patient Register System\n");

            while (running)
            {
                Console.WriteLine(@"
    |  1. Add Patient        |
    |  2. List Patients      |
    |  3. Search Patient     |
    |  4. Edit Patient       |
    |  5. Remove Patient     |
    |  6. Exit               |
                ");

                Console.Write("Choose an option: ");
                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine("\nInvalid option...\n");
                    continue;
                }

                switch (option)
                {
                    case 1: manager.AddPatient(); break;
                    case 2: manager.ListPatients(); break;
                    case 3: manager.SearchPatient(); break;
                    case 4: manager.EditPatient(); break;
                    case 5: manager.DeletePatient(); break;
                    case 6: running = false; break;
                    default: Console.WriteLine("\nInvalid option...\n"); break;
                }
            }

            Console.WriteLine("\nByeBye...");
            Console.ReadKey();
        }
    }
}

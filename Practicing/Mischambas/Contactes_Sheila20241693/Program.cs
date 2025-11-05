// Sheila Severino (2024-1693)
// Project: Contactes List

Console.WriteLine("Welcome to my contact List\n");

bool runing = true;
List<int> ids = new();
Dictionary<int, string> names = new();
Dictionary<int, string> lastnames = new();
Dictionary<int, string> addresses = new();
Dictionary<int, string> telephones = new();
Dictionary<int, string> emails = new();
Dictionary<int, int> ages = new();
Dictionary<int, bool> bestFriends = new();

while (runing)
{
    Console.WriteLine(@"
    |  1. Add Contacts         |  
    |  2. View Contacts        |  
    |  3. Search Contacts      |  
    |  4. Modified Contacts    |  
    |  5. Remove Contacts      |  
    |  6. Exit                 |
    ");

    Console.Write("\nEnter the number of the option you want: ");
    if (!int.TryParse(Console.ReadLine(), out int option))

    {
        Console.WriteLine("Invalid Option.\n");
        continue;
    }

    switch (option)
    {
        case 1:
            AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 2:
            ListAllContacts(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 3:
            SearchContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 4:
            EditContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 5:
            DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;
        case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("Invalid Option...\n");
            break;
    }
}

static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
    Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails,
    Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Lastname: ");
    string lastname = Console.ReadLine();
    Console.Write("Address: ");
    string address = Console.ReadLine();
    Console.Write("Telephone: ");
    string phone = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Is favorite? (1. Yes / 2. No): ");
    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    int id = ids.Count + 1;
    ids.Add(id);
    names[id] = name;
    lastnames[id] = lastname;
    addresses[id] = address;
    telephones[id] = phone;
    emails[id] = email;
    ages[id] = age;
    bestFriends[id] = isBestFriend;

    Console.WriteLine("\nContact added successfully...\n");
}

static void ListAllContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
    Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails,
    Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    if (ids.Count == 0)
    {
        Console.WriteLine("There's no registered contact...\n");
        return;
    }
    Console.WriteLine(new string('_', 115));
    Console.WriteLine($"\n{"ID",-4} {"Name",-12} {"Lastname",-15} {"Address",-18} {"Telephone",-14} {"Email",-22} {"Age",-5} {"Favorite",-12}");

    foreach (var id in ids)
    {
        string best = bestFriends[id] ? "Yes" : "No";
        Console.WriteLine($"\n{id,-4} {names[id],-12} {lastnames[id],-15} {addresses[id],-18} {telephones[id],-14} {emails[id],-22} {ages[id],-5} {best,-12}\n");
        Console.WriteLine(new string('_', 115));
    }
    Console.WriteLine();
}

static void SearchContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
    Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails,
    Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.Write("Enter the name, lastname or telephone that you want to search for: ");
    string term = Console.ReadLine().ToLower();
    bool found = false;

    foreach (var id in ids)
    {
        if (names[id].ToLower().Contains(term) ||
            lastnames[id].ToLower().Contains(term) ||
            telephones[id].Contains(term))
        {
            string best = bestFriends[id] ? "Yes" : "No";
            Console.WriteLine($"\nID: {id}");
            Console.WriteLine($"Name: {names[id]} {lastnames[id]}");
            Console.WriteLine($"Telephone: {telephones[id]}");
            Console.WriteLine($"Email: {emails[id]}");
            Console.WriteLine($"Address: {addresses[id]}");
            Console.WriteLine($"Age: {ages[id]}");
            Console.WriteLine($"Favorite?: {best}\n");
            found = true;
        }
    }

    if (!found)
        Console.WriteLine("No contacts found with that information...\n");
}

static void EditContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
    Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails,
    Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.Write("Enter the contact ID that you want to modify: ");
    if (!int.TryParse(Console.ReadLine(), out int id) || !ids.Contains(id))
    {
        Console.WriteLine("ID not found...\n");
        return;
    }

    Console.WriteLine("Leave it empty if you dont want to change that part. ");

    Console.Write($"New name ({names[id]}): ");
    string name = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(name)) names[id] = name;

    Console.Write($"New Lastname ({lastnames[id]}): ");
    string lastname = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(lastname)) lastnames[id] = lastname;

    Console.Write($"New Address ({addresses[id]}): ");
    string address = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(address)) addresses[id] = address;

    Console.Write($"New telephone ({telephones[id]}): ");
    string phone = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(phone)) telephones[id] = phone;

    Console.Write($"New email ({emails[id]}): ");
    string email = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(email)) emails[id] = email;

    Console.Write($"New age ({ages[id]}): ");
    string ageStr = Console.ReadLine();
    if (int.TryParse(ageStr, out int newAge)) ages[id] = newAge;

    Console.Write("Is Favorite? (1. Yes / 2. No / : ");
    string bestStr = Console.ReadLine();
    if (bestStr == "1") bestFriends[id] = true;
    else if (bestStr == "2") bestFriends[id] = false;

    Console.WriteLine("\nContact modified successfully...\n");
}

static void DeleteContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames,
    Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails,
    Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.Write("Enter the ID of the contact you want to remove: ");
    if (!int.TryParse(Console.ReadLine(), out int id) || !ids.Contains(id))
    {
        Console.WriteLine("ID not found...\n");
        return;
    }

    ids.Remove(id);
    names.Remove(id);
    lastnames.Remove(id);
    addresses.Remove(id);
    telephones.Remove(id);
    emails.Remove(id);
    ages.Remove(id);
    bestFriends.Remove(id);

    Console.WriteLine("Contact Removed successfully... \n");

    Console.ReadKey();
}

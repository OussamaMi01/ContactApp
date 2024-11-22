
class Contacts
{
    static List<Contact> contacts = new List<Contact>();
    
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Contacts");
            Console.WriteLine("1. View Contacts");
            Console.WriteLine("2. Add Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Exit");
            Console.WriteLine(""); 
            
            Console.WriteLine("Please enter your choice below: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewContacts();
                    break;
                case "2":
                    AddContact();
                    break;
                case "3":
                    EditContact();
                    break;
                case "4":
                    DeleteContact();
                    break;
                case "5":
                    exit = true;
                    break;
            }
        }
    }

    static void ViewContacts()
{
    Console.Clear();
    if (contacts.Count == 0)
    {
        Console.WriteLine("No contacts found.");
        Console.WriteLine("Press ENTER to return to the main menu...");
        while (Console.ReadKey(intercept: true).Key != ConsoleKey.Enter)
        {
            // Do nothing, just wait for Enter
        }
    }
    else
    {
        Console.WriteLine("Your contacts:");
        Console.WriteLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            var contact = contacts[i];
            Console.WriteLine("{0}. {1} {2} (Phone: {3}, Email: {4})", 
                i + 1, 
                contact.FirstName, 
                contact.LastName, 
                contact.Phone == 0 ? "N/A" : contact.Phone.ToString(), 
                string.IsNullOrWhiteSpace(contact.Email) ? "N/A" : contact.Email);
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}


    static void AddContact()
{
    try
    {
        Console.Clear();
        Console.WriteLine("Enter contact details below:");
        Console.WriteLine("");
        Console.WriteLine("Note: if you want to skip an option just press ENTER...");
        Console.WriteLine("");
           
        Console.Write("FirstName: ");
        string FirstName = Console.ReadLine();

        Console.Write("LastName: ");
        string LastName = Console.ReadLine();

        Console.Write("Phone: ");
        string phoneInput = Console.ReadLine(); // Read as string
        long Phone = 0;
        // Validate phone input
        if (!string.IsNullOrWhiteSpace(phoneInput))
        {
            if (!long.TryParse(phoneInput, out Phone))
            {
                Console.WriteLine("Invalid phone number. Please enter digits only.");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                return; // Exit the function
            }
        }

        Console.Write("Email: ");
        string Email = Console.ReadLine();

        // Validate that at least one required field is filled
        if (string.IsNullOrWhiteSpace(FirstName) &&
            string.IsNullOrWhiteSpace(LastName) &&
            Phone == 0 &&
            string.IsNullOrWhiteSpace(Email))
        {
            Console.WriteLine("You must provide at least one required field!");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            return;
        }
        
        // Add the contact if validation passes
        contacts.Add(new Contact(FirstName, LastName, Phone, Email));

        Console.WriteLine();
        Console.WriteLine("Contact added successfully!");
        
        Console.WriteLine();
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        
    
    }catch (IOException)
    {
        Console.WriteLine("An error occurred while processing your input. Please try again.");
    }
}


    static void EditContact()
    {
        Console.Clear();
        Console.WriteLine("Your Contact list:");
        
        if (contacts.Count != 0)
           for (int i = 0; i < contacts.Count; i++)
        {
            var contact = contacts[i];
            Console.WriteLine("{0}. {1} {2} (Phone: {3}, Email: {4})", 
                i + 1, 
                contact.FirstName, 
                contact.LastName, 
                contact.Phone == 0 ? "N/A" : contact.Phone.ToString(), 
                string.IsNullOrWhiteSpace(contact.Email) ? "N/A" : contact.Email);
        
                Console.WriteLine();
                Console.WriteLine("Note: if you want to skip an option just press any key...");
                Console.WriteLine("");
                Console.Write("Enter contact number to edit: ");
                Console.WriteLine("");
                int index = int.Parse(Console.ReadLine()) - 1;
       
        Console.Write("FirstName: ");
        string FirstName = Console.ReadLine();
        
        Console.Write("LasttName: ");
        string LastName = Console.ReadLine();
        
       Console.Write("Phone(TN):+216 ");
        string phoneInput = Console.ReadLine(); // Read as string
        long Phone = 0;
        
        // Validate phone input
        if (!string.IsNullOrWhiteSpace(phoneInput))
        {
            if (!long.TryParse(phoneInput, out Phone))
            {
                Console.WriteLine("Invalid phone number. Please enter digits only.");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                return; // Exit the function
            }
        }
        


        Console.Write("Email: ");
        string Email = Console.ReadLine();

        // Check if there is no changes or edition
        if (string.IsNullOrWhiteSpace(FirstName) || FirstName == "" &&
            string.IsNullOrWhiteSpace(LastName) || LastName == "" &&
            Phone == 0 &&
            string.IsNullOrWhiteSpace(Email))
        {
            Console.WriteLine("No changes were made.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            return;
        }
        
        contacts[index] = new Contact(FirstName, LastName, Phone, Email);
            
        Console.WriteLine("Contact edited successfully!");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    
            else{
                Console.Clear();
            Console.WriteLine("Oops! No contacts found.");
            
            Console.WriteLine("Press ENTER to return to the main menu and add a contact in the \"Add Contact\" ...");
           var key = Console.ReadKey(intercept: true); 
           while (key.Key != ConsoleKey.Enter)       
           {
            key = Console.ReadKey(intercept: true);
            }

            }
    }
            
            
         
            
      
    

    static void DeleteContact()
    {
        Console.Clear();
        Console.WriteLine("Your Contact list:");
        
        if (contacts.Count != 0)
           for (int i = 0; i < contacts.Count; i++)
        {
            var contact = contacts[i];
            Console.WriteLine("{0}. {1} {2} ", 
                i + 1, 
                contact.FirstName, 
                contact.LastName);
        
                Console.WriteLine();
                Console.Write("Enter contact number to delete: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                contacts.RemoveAt(index);
                Console.WriteLine();

        Console.WriteLine("Contact deleted successfully!");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        }
        
            else{
                Console.Clear();
            Console.WriteLine("Oops! No contacts found.");
            
            Console.WriteLine("Press ENTER to return to the main menu and add a contact in the \"Add Contact\" section...");
           var key = Console.ReadKey(intercept: true); 
           while (key.Key != ConsoleKey.Enter)        
           {
            key = Console.ReadKey(intercept: true);
            }

            }
        
    
}

class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long Phone { get; set; }
    
    public string Email { get; set; }

    public Contact(string firstName,string lastName, long phone, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Email = email;
         
    }
}

}

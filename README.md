

# ContactApp

**ContactApp** is a simple and intuitive console-based application designed to manage a contact list. The app allows users to add, view, edit, and delete contacts, providing a user-friendly command-line interface to handle these tasks efficiently.

## Features

- **View Contacts**: View a list of all saved contacts along with their details.
- **Add Contact**: Add new contacts by entering their first name, last name, phone number, and email.
- **Edit Contact**: Update details of an existing contact.
- **Delete Contact**: Delete a contact from the list.
- **User-Friendly Interface**: Clear and simple menu navigation, with real-time feedback for each action.

## Requirements

- **C#**: This application is built using C#. You will need a compatible runtime to run the app.
- **.NET SDK**: This application requires the .NET SDK to build and run. You can download it from the official .NET website: [Download .NET](https://dotnet.microsoft.com/download/dotnet).
- **C# Compiler**: The C# compiler is part of the .NET SDK.
- **Git**: To clone the repository, Git must be installed. You can get it from [Git Downloads](https://git-scm.com/downloads).

## Getting Started

Follow these steps to clone and run the project:

### 1. Clone the Repository

Start by cloning the repository to your local machine:

```bash
git clone https://github.com/OussamaMi01/ContactApp.git
```

Then navigate to the project directory:

```bash
cd ContactApp
```

### 2. Compile and Run the Application

Use the .NET Core CLI to compile and run the app:

```bash
dotnet run
```

### 3. Follow On-Screen Instructions

Once the application is running, you can follow the on-screen instructions to:

- View contacts
- Add a new contact
- Edit an existing contact
- Delete a contact

## File Structure

- **Program.cs**: Contains the main logic of the ContactApp, including the user interface and operations.

## Example Usage

1. **Add a Contact**: 
   - Enter the contact's first name, last name, phone number, and email. All fields are optional, but at least one field should be provided.
   
```bash
Enter first name: John
Enter last name: Doe
Enter phone number: 123-456-7890
Enter email: johndoe@example.com
```

2. **View Contacts**: 
   - View a list of all contacts stored in the app.
   
```bash
1. John Doe - 123-456-7890 - johndoe@example.com
```

3. **Edit a Contact**: 
   - Select a contact from the list and modify its details.
   
```bash
Enter the index of the contact you want to edit: 1
Enter new first name (leave empty to keep current): John
Enter new last name (leave empty to keep current): Doe
Enter new phone number (leave empty to keep current): 987-654-3210
Enter new email (leave empty to keep current): johndoe@newdomain.com
```

4. **Delete a Contact**: 
   - Select a contact by its index number and remove it from the list.

```bash
Enter the index of the contact you want to delete: 1
```

## Contributing

Contributions to improve the app are welcome! Feel free to fork the repository, open issues, or submit pull requests.

## License

This project is licensed under the [MIT License](LICENSE).

## Author

- **Oussama Missaoui**  
  - [GitHub](https://github.com/OussamaMi01)  
  - [LinkedIn](https://www.linkedin.com/in/oussama-missaoui-a48589246/)

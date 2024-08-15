using System;
using System.Collections.Generic;

namespace DesktopInformationSystem2
{
    // An user class will be the main source class to pass down properties for later ones
    class User
    {
        // Starting with encapsulations
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        // First with setting variables relating to encapsulated attributes
        public User(string name, string telephone, string email, string role)
        {
            Name = name;
            Telephone = telephone;
            Email = email;
            Role = role;
        }
        // An overriden line on console that always appear when viewing/adding or editing a specific registered User.
        public override string ToString()
        {
            return $"Name: {Name}, Telephone: {Telephone}, Email: {Email}, Role: {Role}";
        }
    }
    // Teacher is an inherited sub-class for later dividing roles   
    class Teacher : User
    {
        public decimal Salary { get; set; }
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }

        public Teacher(string name, string telephone, string email, string role, decimal salary, string subject1, string subject2) : base(name, telephone, email, role)
        {
            Salary = salary;
            Subject1 = subject1;
            Subject2 = subject2;
        }
        // Seperated overriden line for Teacher when checking in Teacher group
        public override string ToString()
        {
            return base.ToString() + $", Salary: {Salary}, Subject 1: {Subject1}, Subject 2: {Subject2}";
        }
    }
    // Secondly, is a adminstrator
    class Administration : User
    {
        public decimal Salary { get; set; }
        public string FullTime { get; set; }
        public int WorkingHours { get; set; }

        public Administration(string name, string telephone, string email, string role, decimal salary, string fullTime, int workingHours) : base(name, telephone, email, role)
        {
            Salary = salary;
            FullTime = fullTime;
            WorkingHours = workingHours;
        }

        public override string ToString()
        {
            return base.ToString() + $", Salary: {Salary}, Full-time/part-time: {FullTime}, Working hours: {WorkingHours}";
        }
    }
    // Third is for Student
    class Student : User
    {
        public string CurrentSubject1 { get; set; }
        public string CurrentSubject2 { get; set; }
        public string PrevSubject1 { get; set; }
        public string PrevSubject2 { get; set; }

        public Student(string name, string telephone, string email, string role, string currentSubject1, string currentSubject2, string prevSubject1, string prevSubject2) : base(name, telephone, email, role)
        {
            CurrentSubject1 = currentSubject1;
            CurrentSubject2 = currentSubject2;
            PrevSubject1 = prevSubject1;
            PrevSubject2 = prevSubject2;
        }

        public override string ToString()
        {
            return base.ToString() + $", Current Subject 1: {CurrentSubject1}, Current Subject 2: {CurrentSubject2}, Previously Studied Subject 1: {PrevSubject1}, Previously Studied Subject 2: {PrevSubject2}";
        }
    }
    // Following up is the main program to run a console windowed interface
    internal class Program
    {
        // A List is created from the beneath classes, it can be viewed as a so-called simulated array of a library
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            // A boolean to ensure if performance is on or not
            bool exit = false;
            // Such command line that appropriates for repetitive task to display lines will be for the job of 'while' command line
            while (!exit)
            {
                // All initials line when run the program
                Console.WriteLine("Desktop Information System");
                Console.WriteLine("1. Add new data");
                Console.WriteLine("2. View all existing data");
                Console.WriteLine("3. View existing data by user group");
                Console.WriteLine("4. Edit existing data");
                Console.WriteLine("5. Delete existing data");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                // Cases for choice
                if (choice == "1")
                {
                    AddNewData();
                    PressToContinue();
                }
                else if (choice == "2")
                {
                    ViewAllData();
                    PressToContinue();
                }
                else if (choice == "3")
                {
                    ViewDataByGroup();
                    PressToContinue();
                }
                else if (choice == "4")
                {
                    EditData();
                    PressToContinue();
                }
                else if (choice == "5")
                {
                    DeleteData();
                    PressToContinue();
                }
                // now the boolean is true, so as the program immidiately exits
                else if (choice == "6")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    PressToContinue();
                }
            }
        }
        // Adding data
        static void AddNewData()
        {
            // first with the User class
            Console.WriteLine("Enter user details:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Telephone: ");
            string telephone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Role (teacher/admin/student)?: ");
            string role = Console.ReadLine();
            // Then dividing roles when the role is picked, such cases will be shown in their own
            if (role == "teacher")
            {
                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                Console.Write("Subject 1: ");
                string subject1 = Console.ReadLine();

                Console.Write("Subject 2: ");
                string subject2 = Console.ReadLine();

                users.Add(new Teacher(name, telephone, email, role, salary, subject1, subject2));
            }
            else if (role == "admin")
            {
                Console.Write("Salary: ");
                decimal adminSalary = decimal.Parse(Console.ReadLine());

                Console.Write("Full-time/part-time: ");
                string fullTime = Console.ReadLine();

                Console.Write("Working hours: ");
                int workingHours = int.Parse(Console.ReadLine());

                users.Add(new Administration(name, telephone, email, role, adminSalary, fullTime, workingHours));
            }
            else if (role == "student")
            {
                Console.Write("Subject 1: ");
                string currentSubject1 = Console.ReadLine();

                Console.Write("Subject 2: ");
                string currentSubject2 = Console.ReadLine();

                Console.Write("Previously studied subject 1: ");
                string prevSubject1 = Console.ReadLine();

                Console.Write("Previously studied subject 2: ");
                string prevSubject2 = Console.ReadLine();

                users.Add(new Student(name, telephone, email, role, currentSubject1, currentSubject2, prevSubject1, prevSubject2));
            }
            else
            {
                Console.WriteLine("Invalid role. Please try again.");
            }

            Console.WriteLine("User data added successfully.");
        }
        // A Summary view function to show all data
        static void ViewAllData()
        {
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
        // This will be a special viewing function that only show by the role
        static void ViewDataByGroup()
        {
            Console.WriteLine("Enter user group (teacher/admin/student): ");
            string group = Console.ReadLine();

            foreach (var user in users)
            {
                if (user.Role == group)
                {
                    Console.WriteLine(user);
                }
            }
        }
        // Modification will be required to fix stuffs
        static void EditData()
        {
            Console.WriteLine("Enter the name of the user to edit: ");
            string name = Console.ReadLine();

            bool found = false;

            foreach (var user in users)
            {
                if (user.Name == name)
                {
                    Console.WriteLine("Enter the new details:");

                    Console.Write("Telephone: ");
                    string telephone = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    user.Telephone = telephone;
                    user.Email = email;

                    found = true;
                    break;
                }
            }
            // When the user typed down not match, exceptions will notify
            if (!found)
            {
                Console.WriteLine("User not found.");
            }
            else
            {
                Console.WriteLine("User data updated successfully.");
            }
        }
        // Of couurse, removal an absolute function exist for erasing uncessary datas
        static void DeleteData()
        {
            Console.WriteLine("Enter the name of the user to delete: ");
            string name = Console.ReadLine();

            bool removed = false;

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == name)
                {
                    users.RemoveAt(i);
                    removed = true;
                    break;
                }
            }

            if (!removed)
            {
                Console.WriteLine("User not found.");
            }
            else
            {
                Console.WriteLine("User data deleted successfully.");
            }
        }
        // A big must for not letting line on console window hard-looking or messy
        static void PressToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
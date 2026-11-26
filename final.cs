using System;
using System.Collections.Generic;
class Student
{
    public string StudentNum { get; set; }
    public string Surname { get; set; }
    public string FirstName { get; set; }
    public string Occupation { get; set; }
    public char Gender { get; set; }
    public string CountryCode { get; set; }
    public string AreaCode { get; set; }
    public string Number { get; set; }
    public Student(string studentnum, string surname, string firstName, string occupation, char gender, string countryCode, string areaCode, string number)
    {
        StudentNum = studentnum;
        Surname = surname;
        FirstName = firstName;
        Occupation = occupation;
        Gender = gender;
        CountryCode = countryCode;
        AreaCode = areaCode;
        Number = number;
    }
    private string pronoun()
    {
        if (Gender == 'F')
            return "Her";
        else
            return "Him";
    }
    private string fullnum()
    {
        return CountryCode + "-" + AreaCode + "-" + Number;
    }
    public string edit()
    {
        return $"{FirstName} {Surname} is a/an {Occupation}. {pronoun()} number is {fullnum()}";
    }
    public string search()
    {
        return $"{Surname}, {FirstName} with student number {StudentNum} , is a {Occupation}. {pronoun()} phone number is {fullnum()}";
    }
}
class Phonebook
{
    private List<Student> students = new List<Student>();

    public void Add(Student s)
    {
        students.Add(s);
    }
    public Student Find(string studentnum)
    {
        foreach (Student s in students)
        {
            if (s.StudentNum == studentnum)
                return s;
        }
        return null;
    }
}
class Program
{
    static Phonebook book = new Phonebook();

    static string[] countryNames = { "Philippines", "Thailand", "Singapore", "Indonesia", "Malaysia" };
    static string[] countryCodes = { "63", "66", "65", "62", "60" };
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("[1] Store to ASEAN phonebook");
            Console.WriteLine("[2] Edit entry in ASEAN phonebook");
            Console.WriteLine("[3] Search ASEAN phonebook by country");
            Console.WriteLine("[4] Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1") storeEntry();
            else if (choice == "2") editEntry();
            else if (choice == "3") searchbyCountry();
            else if (choice == "4") running = false;
        }
    }
    static char askGender()
    {
        while (true)
        {
            Console.Write("Enter gender (M for male, F for female): ");
            string g = Console.ReadLine().ToUpper();
            if (g == "M" || g == "F")
                return g[0];
        }
    }
    static string askCountryCode(string message)
    {
        while (true)
        {
            Console.Write(message);
            string code = Console.ReadLine();
            if (Array.IndexOf(countryCodes, code) >= 0)
                return code;
            Console.WriteLine("Invalid country code. Use 60, 62, 63, 65 or 66.");
        }
    }
    static void storeEntry()
    {
        string again = "Y";
        while (again == "Y")
        {
            Console.WriteLine();
            Console.Write("Enter student number: ");
            string number = Console.ReadLine();
            while (book.Find(number) != null)
            {
                Console.WriteLine("Error: that student number already exists.");
                Console.Write("Enter student number: ");
                number = Console.ReadLine();
            }

            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter occupation: ");
            string occupation = Console.ReadLine();
            char gender = askGender();
            string countryCode = askCountryCode("Enter country code: ");
            Console.Write("Enter area code: ");
            string areaCode = Console.ReadLine();
            Console.Write("Enter number: ");
            string phone = Console.ReadLine();

            book.Add(new Student(number, surname, firstName, occupation, gender, countryCode, areaCode, phone));
            again = "";
            while (again != "Y" && again != "N")
            {
                Console.Write("Do you want to enter another entry [Y/N]? ");
                again = Console.ReadLine().ToUpper();
            }
        }
    }
    static void editEntry()
    {
        Console.WriteLine();
        Console.Write("Enter student number: ");
        string number = Console.ReadLine();

        Student s = book.Find(number);
        if (s == null)
        {
            Console.WriteLine("Error: student number does not exist.");
            return;
        }

        string choice = "";
        while (choice != "8")
        {
            Console.WriteLine("Here is the existing information about " + s.StudentNum + ":");
            Console.WriteLine(s.edit());
            Console.WriteLine();
            Console.WriteLine("Which of the following information do you wish to change?");
            Console.WriteLine("[1] Student number [2] Surname [3] Gender [4] Occupation");
            Console.WriteLine("[5] Country code [6] Area code [7] Phone number");
            Console.WriteLine("[8] None - Go back to main menu");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter new student number: ");
                string newNumber = Console.ReadLine();
                Student other = book.Find(newNumber);
                if (other != null && other != s)
                    Console.WriteLine("Error: that student number already exists.");
                else
                    s.StudentNum = newNumber;
            }
            else if (choice == "2")
            {
                Console.Write("Enter new surname: ");
                s.Surname = Console.ReadLine();
            }
            else if (choice == "3")
            {
                s.Gender = askGender();
            }
            else if (choice == "4")
            {
                Console.Write("Enter new occupation: ");
                s.Occupation = Console.ReadLine();
            }
            else if (choice == "5")
            {
                s.CountryCode = askCountryCode("Enter new country code: ");
            }
            else if (choice == "6")
            {
                Console.Write("Enter new area code: ");
                s.AreaCode = Console.ReadLine();
            }
            else if (choice == "7")
            {
                Console.Write("Enter new phone number: ");
                s.Number = Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
    static void searchbyCountry()
    {
    }
}

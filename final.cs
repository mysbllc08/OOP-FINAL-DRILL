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
    static void storeEntry()
    {
    }
    static void editEntry()
    {
    }
    static void searchbyCountry()
    {
    }
}

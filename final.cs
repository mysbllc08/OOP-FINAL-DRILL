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
}
class Program
{
    static void Main()
    {
        // asean phonebook stuff
    }
}

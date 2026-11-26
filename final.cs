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
class Program
{
    static void Main()
    {
        // asean phonebook stuff
    }
}

using System;

public class Student : HSMitglied
{
    public Student(string firstName, string lastName, DateTime birthDay)
        : base(firstName, lastName, birthDay)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDay = birthDay;
    }

    public override void Print()
    {
        int age = DateTime.Now.Year - BirthDay.Year;

        //falls man in diesem Jahr nicht Geburtstag hatte
        if (DateTime.Now.Month < BirthDay.Month ||

            (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day))
        { age -= 1; }


        Console.WriteLine("Student: " + FirstName + " " + LastName + ", " + "Alter: " + age + " UID: " + UsrId);
    }
}
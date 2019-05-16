using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* abstrakte klassen koennen nicht instantiiert werden 
 * Bereitstellung einer allgemeinen Definition einer Basisklasse, die 
 * fuer mehrere Klassen freigegeben wird
 */

public abstract class Person
{

    protected DateTime birthDay;
    protected string firstName;
    protected string lastName;

    public string LastName { get; set; }
    public string FirstName { get; set; }

    public DateTime BirthDay
    {
        get { return birthDay; }

        set
        {


            //while (value.Year < 1900)
            //{

            //    Console.WriteLine("Geburtsjahr von {FirstName} {LastName} < 1900, bitte erneut eingeben: ");
            //    BirthDate = new DateTime(Convert.ToInt32(Console.ReadLine()), value.Month, value.Day);
            //    break;
            //}

            birthDay = value;


            if (value.Year <= 1900)
            {
                Console.WriteLine("Geburtsjahr von " + FirstName + " " + LastName + "< 1900, bitte erneut eingeben: ");
                BirthDay = new DateTime(Convert.ToInt32(Console.ReadLine()), value.Month, value.Day);
            }
        }
    }


    protected Person(string firstName, string lastName, DateTime birthDay)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDay = birthDay;
    }



    public int getAge()
    {
        int age = DateTime.Now.Year - BirthDay.Year;

        //falls man in diesem Jahr nicht Geburtstag hatte
        if (DateTime.Now.Month < BirthDay.Month ||
            (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day))
        {
            age -= 1;
        }


        // Console.WriteLine("Person: " + this.FirstName + " " + this.LastName + ", " + "Alter: " + age);

        return age;
    }

    public virtual void Print()
    {
        int age = DateTime.Now.Year - BirthDay.Year;
       

        //falls man in diesem Jahr nicht Geburtstag hatte
        if (DateTime.Now.Month < BirthDay.Month ||

            (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day))
        { age -= 1; }


        Console.WriteLine("Person: " + FirstName + " " + LastName + ", " + "Alter: " + age);
    }
}


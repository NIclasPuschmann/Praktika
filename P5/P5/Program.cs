using System;

namespace P5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person[] persons = new Person[4];

            persons[0] = new Student("Max", "Mustermann", new DateTime(1981, 8, 13));
            persons[1] = new Student("Mia", "Musterfrau", new DateTime(1993, 3, 22));
            persons[2] = new Mitarbeiter("Jane", "Doe", new DateTime(1995, 1, 15));
            persons[3] = new Mitarbeiter("Jack", "Doe", new DateTime(1995, 12, 15));

            for (int i = 0; i < persons.Length; i++) persons[i].Print();
        }
    }
}

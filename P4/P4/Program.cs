using System;

namespace P4_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person[] persons = 
            {
                new Person("Max", "Mustermann", new DateTime(1981, 8, 13)),
                new Person("Peter", "Pan", new DateTime(1982, 2, 3)),
                new Person("Captain", "Hook", new DateTime(1881, 8, 13))
            };

            foreach (Person p in persons) p.Print();
        }
    }
}

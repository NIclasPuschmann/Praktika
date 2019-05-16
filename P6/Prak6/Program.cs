using System;
using System.Collections.Generic;

namespace Prak6
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //List<Bruch> br = new List<Bruch>();
            

            //br.Add(new Bruch(1, 2));
            //br.Add(new Bruch(1, 3));
            //br.Add(new Bruch(3, 5));
            //br.Add(new Bruch(4, 5));
            //br.Add(new Bruch(5, 3));
            //br.Add(new Bruch(4, 5));
            //br.Add(new Bruch(5, 3));
            //br.Add(new Bruch(7, 6));


            //foreach (Bruch bruch in br)
            //{
            //    Console.WriteLine("{0} < {1} = {2}", br.Bruch, b2, b1 < b2);
            //    Console.WriteLine("{0} > {1} = {2}", b1, b2, b1 > b2);
            //}


            Bruch b1 = new Bruch(1, 2);
            Bruch b2 = new Bruch(1, 3);
            Bruch b3 = new Bruch(3, 5);
            Bruch b4 = new Bruch(4, 5);
            Bruch b5 = new Bruch(5, 3);
            Bruch b6 = new Bruch(4, 5);
            Bruch b7 = new Bruch(5, 3);
            Bruch b8 = new Bruch(7, 6);

            Console.WriteLine("{0} < {1} = {2}", b1, b2, b1 < b2);
            Console.WriteLine("{0} > {1} = {2}", b1, b2, b1 > b2);
            Console.WriteLine("{0} < {1} = {2}", b3, b4, b3 < b4);
            Console.WriteLine("{0} > {1} = {2}", b3, b4, b3 > b4);
            Console.WriteLine("{0} < {1} = {2}", b5, b6, b5 < b6);
            Console.WriteLine("{0} > {1} = {2}", b5, b6, b5 > b6);
            Console.WriteLine("{0} < {1} = {2}", b7, b8, b7 < b8);
            Console.WriteLine("{0} > {1} = {2}", b7, b8, b7 > b8);
        }
    }
}



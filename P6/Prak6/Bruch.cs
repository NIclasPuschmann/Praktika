using System;

namespace Prak6
{
    public class Bruch : IComparable<Bruch>
    {
        //private static Bruch[] br;
        private readonly int nenner;
        private readonly int zaehler;
        //public int zaehler;
        //public int nenner;

        public int Zaehler { get; set; }
        public int Nenner
        {
            get { return nenner; }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Im Nenner darf keine '0' stehen!");
                    //Nenner = Convert.ToInt32(Console.ReadLine());
                }
            }
        }



        // Konstruktor
        public Bruch(int zaehl, int nen) 
        {
            zaehler = zaehl;
            nenner = nen;
        }

        public override string ToString()
        {
            //string strZaehl = Zaehler.ToString();
            return zaehler + @"/" + nenner;
        }


        public int CompareTo(Bruch other)
        {

            if (nenner == other.nenner)
            {
                // B1 > B2
                if (zaehler > other.zaehler)
                    return 1;
                else
                    return -1;
            }
            else if (zaehler == other.zaehler)
            {
                // B1 < B2
                if (nenner > other.nenner)
                    return -1;
                else
                    return 1;
            }
            // B1(1,...) > B2(0,...)
            else if (zaehler > nenner && other.zaehler <= other.nenner)
                return 1;

            // B1(0,...) < B2(1,...)
            else if (zaehler <= nenner && other.zaehler > other.nenner)
                return -1;

            //Kreuzregel
            // B1.Zaehler * B2.Nenner < B2.Nenner * B1.Zaehler 
            //B1 < B2
            else if (zaehler * other.nenner < nenner * other.zaehler)
                return -1;
            else if (zaehler * other.nenner > nenner * other.zaehler)
                return 1;

            return 99;
        }

        public static bool operator <(Bruch b1, Bruch b2)
        {
            return b1.CompareTo(b2) < 0;
        }

        public static bool operator >(Bruch b1, Bruch b2)
        {
            return b1.CompareTo(b2) > 0;
        }

       
    }
}
using System;

namespace CsPrakt1
{
    class MainClass
    {
        static int startKap;
        static int laufzeit;
        static double zinssatz;
        static double endKap;
        static string y = "Jahr ";
        static string str;

        public static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Startkapital in $ eingeben: \n");
            startKap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lauzeit in Jahren eingeben: \n");
            laufzeit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zinssatz eingeben: \n");
            zinssatz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Startkapital: " + startKap);
            Console.WriteLine("Laufzeit: " + laufzeit);
            Console.WriteLine("Zinssatz: " + zinssatz);


            for(int n=1; n<= laufzeit; n++)
            {
                endKap = startKap * (Math.Pow(1 + zinssatz, n));
                str = y + n +":" + " ";
                Console.WriteLine(str + "{0:c2}", endKap);
            }

            Console.WriteLine("Das Endkapital betraegt {0:c2} ", endKap);
            Console.WriteLine("bei einem Zinssatz von {0:P2}", zinssatz);




        }
    }
}




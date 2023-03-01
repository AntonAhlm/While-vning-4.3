using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välj ett av följande alternativ: \n" +
                "1. Omvandla meter till kilometer \n" +
                "2. Omvandla kilometer till meter \n" +
                "3. Avsluta programmet");
            string val = Console.ReadLine();

            switch(val)
            {
                case "1":
                    {
                        Console.Write("Ange antal meter : ");
                        int meter = Convert.ToInt32(Console.ReadLine());
                        int kilometer = meter / 1000;
                        Console.WriteLine("Det blir " + kilometer + " kilometer.");
                        break;
                    }

                case "2":
                    {
                        Console.Write("Ange antal kilometer : ");
                        int kilometer = Convert.ToInt32(Console.ReadLine());
                        int meter = kilometer * 1000;
                        Console.WriteLine("Det blir " + meter + " meter.");
                        break;
                    }

                case "3":
                    break;


            }

        }
    }
}

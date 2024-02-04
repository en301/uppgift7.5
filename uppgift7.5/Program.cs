using System;
using System.Collections.Generic;

namespace uppgift_7_5
{
    class program
    {
        static void Main(string[] args)
        {
            int månadslön = 0;
            List<int> lön = new List<int>();
            Console.WriteLine("Skriv in dina månadslöner och sedan 0 när du vill sluta skriva in dem");
            do
            {
                månadslön = int.Parse(Console.ReadLine());

                if (månadslön != 0)
                {
                    lön.Add(månadslön);
                }
            } while (månadslön != 0);

            medel(lön);
            median(lön);
            Console.ReadKey();
        }

        static void medel(List<int> lön)
        {
            int sum = 0;
            for (int i = 0; i < lön.Count; i++)
            {
                sum += lön[i];
            }
            int medelvärde = sum / lön.Count;
            Console.WriteLine("Medelvärdet av dina löner är "+ medelvärde + "kr");
        }

        static void median(List <int> lön)
        {
            double medianvärde = 0;
            lön.Sort();

            if (lön.Count % 2 == 0)
            {
                int middleindex = lön.Count / 2;
                medianvärde = (lön[middleindex - 1] + lön[middleindex]) / 2;
            }
            else
            {
                int middleindex = lön.Count / 2;
                medianvärde = lön[middleindex];
            }
            Console.WriteLine("Medianen av dina löner är " + medianvärde + "kr");
        }
    }
}
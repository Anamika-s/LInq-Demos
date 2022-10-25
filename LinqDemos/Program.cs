using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //foreach(int x in num)
            //    Console.WriteLine(x);

            var output = (from temp in num
                          select temp);
            foreach (int x in output)
                Console.WriteLine(x);

            var sum = (from temp in num
                       select temp).Sum();
            Console.WriteLine("Sum is " + sum);
            var avg = (from temp in num
                       select temp).Average();
            Console.WriteLine("Average is " + avg);

            var listmorethan2 = (from temp in num
                                 where temp > 2
                                 select temp);
            Console.WriteLine("Nos more than 2");
            foreach (int x in listmorethan2)
                Console.WriteLine(x);

            var evenNumbers = (from temp in num
                               where temp % 2 == 0
                               select temp);
            Console.WriteLine("Even numbers");
            foreach (int x in evenNumbers)
                Console.WriteLine(x);

            List<string> list = new List<string>()
           {
               "Deepak", "Lalit", "Leena" , "Om", "Parul","Jagdish"
           };

            var listOfNames = (from temp in list
                               select temp);

            foreach (var temp in listOfNames)
                Console.WriteLine(temp);

            var listOfNamesLenEqTo5 = (from temp in list
                                       where temp.Length == 5
                                       select temp);
            Console.WriteLine("NAmes with length eq to 5");
            foreach (var temp in listOfNamesLenEqTo5)
                Console.WriteLine(temp);

            var listOfNamesContainsA = (from temp in list
                                        where temp.Contains('a')
                                        select temp);
            Console.WriteLine("NAmes which Contains A");
            foreach (var temp in listOfNamesLenEqTo5)
                Console.WriteLine(temp);

        }
    }
}
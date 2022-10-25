using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemos
{
    class MethodSyntax
    {
        static void Main()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var output = num.ToList();
            foreach (int x in output)
                Console.WriteLine(x);

            var evenNumbers = num.Where(x => x % 2 == 0).ToList();

            Console.WriteLine("Even numbers");
            foreach (int x in evenNumbers)
                Console.WriteLine(x);

            var oddNumbers = num.Where(x => x % 2 != 0).ToList();

            Console.WriteLine("Odd numbers");
            foreach (int x in oddNumbers)
                Console.WriteLine(x);

            var listmorethan2 = num.Where(x => x > 2).ToList();

            Console.WriteLine("Nos more than 2");
            foreach (int x in listmorethan2)
                Console.WriteLine(x);

            List<string> list = new List<string>()
           {
               "Deepak", "Lalit", "Leena" , "Om", "Parul","Jagdish"
           };

            var listOfNames = list.ToList();

            foreach (var temp in listOfNames)
                Console.WriteLine(temp);

            var listOfNamesContainsA = list.Where(x => x.Contains('a')).ToList();

            foreach (var temp in listOfNamesContainsA)
                Console.WriteLine(temp);




        }

    }
}

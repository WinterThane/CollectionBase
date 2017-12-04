using System;
using System.Diagnostics;

namespace CollectionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new MyCollection
            {
                "Marko",
                "Ana",
                "Tadej",
                "Mojca"
            };

            foreach (Object name in names)
            {
                Console.WriteLine(name);               
            }
            Console.WriteLine("Number of names: " + names.Count());
            names.Remove("Marko");
            Console.WriteLine("Number of names: " + names.Count());
            names.Clear();
            Console.WriteLine("Number of names: " + names.Count());

            Console.WriteLine();

            int arrayLength = 99999;
            int[] numbers = new int[arrayLength];
            numbers = UtilFunctions.BuildArray(arrayLength);
            Timing timer = new Timing();

            timer.StartTimer();
            UtilFunctions.DisplayNums(numbers);
            timer.StopTime();

            Console.WriteLine("Duration: {0} in milliseconds.", timer.Result().TotalMilliseconds);

            Console.ReadLine();
        }
    }
}

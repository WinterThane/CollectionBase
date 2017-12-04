using System;

namespace CollectionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new MyCollection();
            names.Add("Marko");
            names.Add("Ana");
            names.Add("Tadej");
            names.Add("Mojca");

            foreach (Object name in names)
            {
                Console.WriteLine(name);
                
            }
            Console.WriteLine("Number of names: " + names.Count());

            names.Remove("Marko");
            Console.WriteLine("Number of names: " + names.Count());

            names.Clear();
            Console.WriteLine("Number of names: " + names.Count());

            Console.ReadLine();
        }
    }
}

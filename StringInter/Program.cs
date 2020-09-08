using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What's Your First Name?");
            string FirstName;
            string LastName;
            FirstName = Console.ReadLine();
            Console.WriteLine("What Is Your Last Name?");
            LastName = Console.ReadLine();
            Console.WriteLine("Hello," + FirstName + " " + LastName);
            Console.WriteLine($"Hello, {FirstName} {LastName}");
          
        }
    }
}

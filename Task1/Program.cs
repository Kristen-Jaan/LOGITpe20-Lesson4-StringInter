using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What's Your First Name?");
            string FirstName;
           FirstName = Console.ReadLine();
            Console.WriteLine("What Is Your Last Name?");
            string LastName;
            LastName = Console.ReadLine();
            Console.WriteLine("What Is Your Year Of Birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            //parsing string to interger (number)
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine($"Hello, {FirstName} {LastName} And You Are {Age}   Years Old"); 
                 
            
            
            
            

        }
    }
}

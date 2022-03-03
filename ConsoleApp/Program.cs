using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name ? : ");
            string name = Console.ReadLine();   
            Console.WriteLine($"Hello,{name}!");

            string n = "";
            string s = "absdefghijklmnbopqestuvg";
            foreach ( char i in s)
            {
                n += i;
            }
            throw new AccessViolationException();
        }
    }
}

using System;

namespace Open_Lab_04._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            StringTools stringtools = new StringTools();
            Console.WriteLine();
            Console.WriteLine("This is result:" + " " + stringtools.GetLongestCommonSequence(str1, str2));
        }
    }
}

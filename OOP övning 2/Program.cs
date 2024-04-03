using System;

namespace OOP_övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 p1 = new Class1();
            p1.metod1 = "Dijar";
            p1.metod2 = "Zejnullahi";

            Console.WriteLine(p1.metod1 + " " + p1.metod2);
        }
    }
}
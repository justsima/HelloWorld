using System;
namespace FinalLab
{
    class Delegate
    {
        delegate void Callback();
        static void Main(string[] args)
        {
            Callback call = DisplayCall;
            call();
        }
        public static void DisplayCall()
        {
            Console.WriteLine("Hello World");
        }
        public static void DisplayCall2()
        {
            Console.WriteLine("Hello Universe!");
        }
    } 
    
}


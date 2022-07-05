using System;
namespace loop
{
    class program
    {
        static void Main(string[] args)
        {
            char ans;
            do
            {
                Console.WriteLine("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {

                    Console.WriteLine("Number is positive!");
                }
                else
                    Console.WriteLine("Number is False!");

                Console.WriteLine("Do you want to repeat?");
                ans = Char.Parse(Console.ReadLine());

            } while (ans == 'y');
            Console.WriteLine("Thank you. Bye");
            Console.Read();


        }
    }
}




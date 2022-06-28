/*using System;

namespace ConsoleApp1
{
    class Student {
        public int Id;
        public string Name;
     }

    class program
    {
        static void Main(string[] args)
        {
            Student st = new ();
            st.Id = 10;
            int num1, num2;
            num1 = 21;
            num2 = 22;
            string str = "Simon";

            Console.WriteLine("Num1 = " + num1 + "\nNum2 = " + num2);
            int sum = num1 + num2;
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine();
            Console.WriteLine("Hello " + str);
            Console.WriteLine("From GitHub web! ");
            Console.WriteLine("From PC in the BEST laptop");
            Console.WriteLine("this is anoither trail ");
            Console.Read();

        }

    }
}
*/
using System;
namespace ConSoleApp1
{
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; };
    }
    
    class program : student
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.Id = 20;
            st.Email = "simon123@gmail.com";
            st.Name = "Simon";
            Console.WriteLine("Name is " + st.Name);
            Console.WriteLine("Age is "+ st.Id);
            Console.WriteLine("Email is "+ st.Email);
            
        }
    }
}

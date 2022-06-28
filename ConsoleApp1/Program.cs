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
        private int _id;
        private string _name;
        public int Id
        {
            get => _id; 
            set => _id = value; 
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }

    }
    
    class program
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.Id = 20;
            st.Name = "Simon";
            Console.WriteLine("Name is " + st.Name);
            Console.WriteLine("Age is "+ st.Id);
            
        }
    }
}

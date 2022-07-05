using System;
namespace ConSoleApp1
{
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
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

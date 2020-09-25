using System;

namespace Full_Course_Csharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Student student1 = new Student("Kane", "Software Engineer", 2.5);
            Student student2 = new Student("Cris", "Business", 3.8);

            Console.WriteLine(student1.hasHonors());
            Console.WriteLine(student2.hasHonors());

            Console.ReadLine();
        }

        
    }
}

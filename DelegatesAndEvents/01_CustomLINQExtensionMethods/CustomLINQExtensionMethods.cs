using System;
using System.Collections.Generic;

namespace _01_CustomLINQExtensionMethods
{
    class CustomLinqExtensionMethods
    {
        static void Main()
        {
            List<int> nums = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var notEvens = nums.WhereNot(n => n%2 == 0);

            Console.WriteLine(string.Join(", ", notEvens));

            var students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Gosho", 4),
                new Student("Mariika", 6)
            };

            Console.WriteLine(students.Max(student => student.Grade));
        }
    }
}

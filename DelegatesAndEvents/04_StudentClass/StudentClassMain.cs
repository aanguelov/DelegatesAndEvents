using System;

namespace _04_StudentClass
{
    class StudentClassMain
    {
        public static void Main()
        {
            Student student = new Student("Peter", 23);
            student.PropertyChanged += Student_PropertyChanged;

            student.Name = "Maria";
            student.Age = 18;

        }

        private static void Student_PropertyChanged(object sender, PropertyChangedEventArgs eventArgs)
        {
            Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
        }
    }
}

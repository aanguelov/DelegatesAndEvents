using System;

namespace _04_StudentClass
{
    class Student
    {
        private string name;
        private int age;

        public event PropertyChangedEventHandler PropertyChanged;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }
                PropertyChangedEventArgs args = new PropertyChangedEventArgs("Name", this.Name, value);
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, args);
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("The person isn`t born yet or he is an alien.");
                }
                PropertyChangedEventArgs args = new PropertyChangedEventArgs("Age", this.Age.ToString(), value.ToString());
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, args);
                }
                this.age = value;
            }
        }

        //protected void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        //{
        //    if (this.PropertyChanged != null)
        //    {
        //        this.PropertyChanged(this, args);
        //    }
        //}

        //public void Change()
        //{
        //    this.OnPropertyChanged();
        //}
    }
}

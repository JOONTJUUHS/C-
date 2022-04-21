using System;

namespace getters_en_setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetAge(30);
            Console.WriteLine("person age is " + person.Age);
        }


    }

    internal class Person
    {
        internal int Age;

        internal void SetAge(int age)
        {
            Age = age;
        }


    }
}
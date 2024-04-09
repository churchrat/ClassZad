﻿using System.Reflection;

namespace ClassPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person pesho = new Person();
            pesho.name = "Pesho";
            pesho.age = 20;
            pesho.Eat();
            Person gosho = new Person();
            gosho.name = "Gosho";
            gosho.age = 18;
            gosho.Eat();
            Person stamat = new Person();
            stamat.name = "Stamata";
            stamat.age = 43;
            stamat.Eat();
        }
    }
}

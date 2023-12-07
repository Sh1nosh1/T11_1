using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T11_1
{
    internal class Person
    {
        /// <summary>
        /// Name
        /// </summary>
        public string name;
        /// <summary>
        /// Surname
        /// </summary>
        public string surname;
        /// <summary>
        /// Age
        /// </summary>
        public int age;

        /// <summary>
        /// Output
        /// </summary>
        public void Info()
        {
            WriteLine($"Name: {name}\tSurname: {surname}\tAge: {age}\n");
        }
        public override string ToString()
        {
            return $"Name: {name}\tSurname: {surname}\tAge: {age}\n";
        }
    }
}

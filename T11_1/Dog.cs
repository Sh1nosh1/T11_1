using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T11_1
{
    internal class Dog
    {
        /// <summary>
        /// Breed
        /// </summary>
        public string breed;
        /// <summary>
        /// Size
        /// </summary>
        public string size;
        /// <summary>
        /// Age
        /// </summary>
        public int age;
        /// <summary>
        /// Color
        /// </summary>
        public string color;
        /// <summary>
        /// Output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Breed: {breed}\tSize {size}\tAge: {age}\tColor: {color}\n";
        }
        
    }
}

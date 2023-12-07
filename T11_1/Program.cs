using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1

                /*Person person = new Person();
                person.name = "Darya";
                person.surname = "Ovcharuk";
                person.age = 18;
                person.Info();

                Person person1 = new Person();
                person1.name = "Artem";
                person1.surname = "Botnar'";
                person1.age = 17;
                WriteLine($"{person1.ToString()}");*/

                //Task 2

                /*Address addess = new Address();
                addess.index = 3300;
                addess.country = "Transnistria";
                addess.city = "Tiraspol";
                addess.street = "The 28th of June";
                addess.house = 125;
                addess.apartament = 77;
                WriteLine($"{addess.ToString()}");*/

                //Task 3

                Dog dog = new Dog();
                dog.breed = "Shiba Inu";
                dog.size = "Middle";
                dog.age = 3;
                dog.color = "Sesame";

                WriteLine($"{dog.ToString()}");
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}

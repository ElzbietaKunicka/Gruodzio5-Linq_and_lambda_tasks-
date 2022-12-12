using System;
using Microsoft.VisualBasic;

namespace Gruodzio5
{
    public class Program
    {
        //public delegate bool Filter(Person person);
        public static void Main(string[] args)
        {
            var jonas = new Person("Jonas", 66);
            var kazys = new Person("Kazys", 16);
            var petras = new Person("Petras", 66);
            var juozukas = new Person("Juozukas", 46);
            var justinas = new Person("justinas", 19);

            var persons = new List<Person>() { jonas, kazys, petras, juozukas, justinas };
            //var arVaikas = (Person person) => person Age < 18;
            //var arSuauges = (Person person) => person Age >= 18 && person.Age < 65;
            //var arSenjoras = (Person person) => person.Age >= 65;
            DisplayPeople("Children:", persons, (person) => person.Age < 18);
            DisplayPeople("Grown up:", persons, (person) => person.Age >= 18 && person.Age < 65);
            DisplayPeople("senior:", persons, (person) => person.Age >= 65);
        }
            public static void DisplayPeople(string title, List<Person>persons, Func<Person, bool> filter)
            {
                Console.WriteLine(title);

                foreach(var person in persons)
                {
                    var result = filter(person);
                    if (result)
                    {
                       Console.WriteLine(person.Name);
                    }
                }
            }
        }
    }

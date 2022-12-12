using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<string, string> selector = (str) => str.ToUpper();

            string[] words =
            {
                "orange", "apple", "article", "elephant"
            };
            words.Where(str => str == "morka");
            //words.OrderBy//
            var singleElement = words.Single(str => str == "apple"); // parodo ar nera pasikartojanciu
            var singleEleme = words.First(str => str == "apple"); // suranda pirma

            var wordsCapitalized = words.Select(str => str.ToUpper());
                  //1task                                              
            // Sukurkite sąrašą su skaičiais. Sukurkite naują sąrašą ir
            // jo reikšmei priskirkite pirmojo sąrašo Select grąžintą sąrašą.
            // Select metodas turi pakelti kiekvieną pirmojo sąrašo skaičių kvadratu.

            List<int> list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7
            };
            var resultList = list.Select(x => x * x).ToList();
            // resultList.ForEach((item) => Console.WriteLine (item);
            resultList.ForEach(Console.WriteLine);

            //IEnumerable<int> resultList = list.Select(x => x * x);
            //foreach (var item in resultList)
            //{
            //    Console.WriteLine(item);
            //}

            // 2task
            //Sukurkite sąraša teigiamų ir neigiamų elementų,
            //sukurkite naują sąrašą iš jo su LINQ grąžinant tik teigiamus skaičius.

            List<int> list1 = new List<int>()
            {
                -1, 2, 3, 4, 5, 6, 7, -5, -9
            };
            var resultList1 = list1.Where(num => num >= 0).ToList();
            resultList1.ForEach(Console.WriteLine);

            // 3 task
            //Sukurkite sąraša teigiamų ir neigiamų elementų, sukurkite naują sąrašą
            //iš jo su LINQ grąžinant tik teigiamus skaičius kurie ne didesni už 10.

            List<int> listfor3task = new List<int>()
            {
                -1, 2, 5 , 4 , 6 , 7 , 8 , 11,  15,  -2
            };
            var resultListfor3task = listfor3task.Where(number => number >= 0 && number <= 10).ToList();
            resultListfor3task.ForEach(Console.WriteLine);

            // 4 task
            //Sukurkite skaičių sąrašą ir su LINQ surūšiuokite jį didėjančia tvarka.
            List<int> listfor4task = new List<int>()
            {
                -1, 15, 12, 5, 4 , 6, 7, 18, 11,  15, -2, 1
            };
            var resultFor4task = listfor4task.OrderBy(numbers=> numbers).ToList();
            resultFor4task.ForEach(Console.WriteLine);

            //5 task
            // Sukurkite skaičių sąrašą ir su LINQ surūšiuokite jį mažėjančia tvarka.
            List<int> listfor5task = new List<int>()
            {
                -1, 15, 12, 5, 4 , 6, 7, 18, 11, 15, -2, 1, 0, 25, 55
            };
            var resultListfor5task = listfor5task.OrderByDescending(numbers=> numbers).ToList();
            resultListfor5task.ForEach(Console.WriteLine);

            // 6task
            //Suraskite iš skaičių sąrašo didžiausią elementą naudodami LINQ.
            var biggestNumber = resultListfor5task.Max(number => number);
            Console.WriteLine(biggestNumber);

            //7task
            //Sukurkite klasę Person su parametrais Name ir Age, sukurkite sąrašą iš šių objektų.
            
            var person0 = new Person("petras", 8);
            var person1 = new Person("tomas", 18);
            var person2 = new Person("kestas", 81);
            var person3 = new Person("ana", 61);
            var person4 = new Person("anastasija", 40);

            var persons = new List<Person>()
            {
                person0, person1, person2, person3, person4
            };
            ////  7.1Sukurkite naują sąrašą su LINQ paimdami tik žmonių vardus, kitą sąrašą tik iš amžiaus.
            var personsNameList = persons.Select(person => person.Name).ToList();
            personsNameList.ForEach(Console.WriteLine);
            var personsAgeList = persons.Select(person => person.Age).ToList();
            personsAgeList.ForEach(Console.WriteLine);

            //  7.2Surūšiuokite sąrašą pagal amžių mažėjančia tvarka.
            var newListAgeDescending = personsAgeList.OrderByDescending(age => age).ToList();
            newListAgeDescending.ForEach(Console.WriteLine);

            //  7.3Sukurkite naują sąrašą iš žmonių, kurių vardai prasideda iš A raidės.
            var namesThatStartWithA = personsNameList.Where(name => name[0] == 'a' || name[0] == 'A').ToList();
            namesThatStartWithA.ForEach(Console.WriteLine);

            //  7.4Sukurkite naują sąrašą iš žmonių, kurių amžius yra virš 40 ir surūšiuokit pagal vardą.
            var personWhoAreOlderThan40 = persons.Where(person => person.Age >= 40).OrderBy(person => person.Name).ToList();
            personWhoAreOlderThan40.ForEach(Console.WriteLine);
            //var persons2 = persons.Select(person => person.Name).Where(person => person[0] == 'a' || person[0] == 'A').ToList();
            //var persons3 = persons.Select(person => person.Age).OrderByDescending(x => x).ToList();
            //var persons4 = persons.Where(x=> x.Age >= 40).OrderBy(x=> x.Name).ToList();

            // pet task
            //Su LINQ Select ir SelectMany sukurkite sąrašą kurį sudarys visi gyvūnai iš sąrašo.
            var person5 = new PersonWithPet("kati", new List<Pet> { new Pet("Ate", 5), new Pet("suni", 6) });
            var person6 = new PersonWithPet("kate", new List<Pet> { new Pet("karve", 7), new Pet("ozka", 4) });
            var person7 = new PersonWithPet("Jura", new List<Pet> { new Pet("Avoras", 4), new Pet("suni", 10) });
            var person8 = new PersonWithPet("mantas", new List<Pet> { new Pet("kate", 12), new Pet("suni", 1) });

            PersonWithPet[] personList = {person5, person6, person7, person8};
            // pettask.1 Kitas sąrašas, kurį sudarys tik gyvūnai, kurių vardai prasideda iš A raidės.
            var petWhoNameStartWithA = personList.SelectMany(x => x.Animals).Where(x => x.Name[0] == 'A').ToList();

            petWhoNameStartWithA.ForEach((item) =>
            {
                Console.WriteLine(item.Name);
            });

            //Pridėkite prie Pet klasės amžių int Age, sudarykite kitą sąrašą iš gyvūnų,
            //kurių vardai prasideda iš A raidės ir jų amžius yra virš 5 metų.
            var petWhoNameStartWithAandIsOldThan5 = personList.SelectMany(x => x.Animals).Where(x => x.Name[0] == 'A').Where(x => x.Age >= 5).ToList();
            petWhoNameStartWithAandIsOldThan5.ForEach((item) => 
            { 
                Console.WriteLine(item.Name); 
            });

            //Parašykite metodą, kuris priima vieną string parametrą. Parašykite LINQ funkcionalumą,
            //kad grąžintų žodžius kurie yra vien iš didžiųjų raidžių.

            var sentence = "Loren ipsum USE to get the capital";
            var result = sentence.Split(" ").Where(word => word.All(c => char.IsUpper(c)));

        }
    }
}